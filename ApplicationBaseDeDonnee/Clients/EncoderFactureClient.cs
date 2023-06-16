using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_DB_ManagmentAPP.Classes;
using Projet_DB_ManagmentAPP.Gestion;

namespace ApplicationBaseDeDonnee.Clients
{
    public partial class EncoderFactureClient : Form
    {
        String sConnexion;
        private DataTable dtArticles; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsArticles;

        private DataTable dtCmdClient; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsCmdClient;

        int idCommSelectionnee = -1;
        int idClientSelectionnee = -1;
        int IDproduit = -1;

        public EncoderFactureClient(string sConnexion)
        {
            this.sConnexion = sConnexion;
            InitializeComponent();
        }
        private void EncoderFactureClient_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            RemplirDGVcommandeClient();
            panel.Enabled = false;
            if (dgvArticles.Rows.Count > 0)
            {
                Activer(true);
            }
            else
            {
                Activer(false);
            }
        }

        #region Articles
        private void Activer(bool lPrincipale)
        {

            dgvArticles.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = btnFacturer.Enabled = lPrincipale;
            cbIDproduit.Enabled = tbNom.Enabled = tbNom.Enabled = tbPrixVente.Enabled = tbTVA.Enabled = tbQtee.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }

        private void RemplirDGV()
        {
            // ajouter les articles seulement si leur id sont dans la t_detail_vente
            // -- > qui a sont id_commande_client == au commande_client selectionnée 
            dtArticles = new DataTable();
            dtArticles.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtArticles.Columns.Add(new DataColumn("Nom"));
            dtArticles.Columns.Add(new DataColumn("prixVente"));
            dtArticles.Columns.Add(new DataColumn("TVA"));
            dtArticles.Columns.Add(new DataColumn("qte"));

            List<C_t_produit> produit = new G_t_produit(sConnexion).Lire("Nom");
            List<C_t_detail_vente> detailAchat = new G_t_detail_vente(sConnexion).Lire("ID_commande_client");
            List<C_t_commande_client> CommandeClient = new G_t_commande_client(sConnexion).Lire("ID_client");

            foreach (C_t_detail_vente a in detailAchat)
            {
                Console.WriteLine("idCommSelectionnee = " + idCommSelectionnee);
                Console.WriteLine("a.ID_detail_vente = " + a.ID_detail_vente);
                foreach (C_t_commande_client c in CommandeClient)
                {
                    if (a.ID_commande_client == c.ID_commande_client)
                        foreach (C_t_produit p in produit)
                        {
                            if (a.ID_commande_client == c.ID_commande_client && a.ID_produit == p.ID_produit && idCommSelectionnee == a.ID_commande_client)
                            {
                                dtArticles.Rows.Add(a.ID_produit, p.Nom, p.Prix_vente, a.TVA, a.Quantite);
                            }
                        }
                }
            }

            bsArticles = new BindingSource();
            bsArticles.DataSource = dtArticles;
            dgvArticles.DataSource = bsArticles;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (idCommSelectionnee != -1)
            {
                cbIDproduit.Text = tbNom.Text = tbPrixVente.Text = tbQtee.Text = "";
                tbTVA.Text = "21";
                Activer(false);

                panel.Enabled = true;
                tbNom.Focus();
                RemplirDGV();

                cbIDproduit.Items.Clear();
                List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
                foreach (C_t_produit p in listProduit)
                {
                    //dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_vente, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
                    cbIDproduit.Items.Add(p.ID_produit);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez une facture !");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count > 0)
            {
                cbIDproduit.Text = dgvArticles.SelectedRows[0].Cells["cID"].Value.ToString();
                C_t_produit pImp = new G_t_produit(sConnexion).Lire_ID(int.Parse(cbIDproduit.Text));
                tbNom.Text = pImp.Nom;
                tbPrixVente.Text = Math.Round(pImp.Prix_vente, 2).ToString();
                tbTVA.Text = pImp.TVA.ToString();
                tbQtee.Text = pImp.Quantite_stock.ToString();
                Activer(false);
                panel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Sélectionnez l'enregistrement à éditer");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement ?", "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvArticles.SelectedRows[0].Cells["cID"].Value;
                    new G_t_produit(sConnexion).Supprimer(iID);
                    new G_t_detail_vente(sConnexion).Supprimer(idCommSelectionnee);

                    bsArticles.RemoveCurrent();
                }
            }

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
            {
                MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbIDproduit.SelectedItem != null) // Ajout si id est vide
                {
                    if (decimal.TryParse(tbPrixVente.Text.Replace('.', ','), out decimal prixVente)
                        && int.TryParse(tbQtee.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        )
                    {
                        ////int idProduitAjoutee = new G_t_produit(sConnexion).Ajouter(tbNom.Text.ToString(), Math.Round(prixVente, 2), Math.Round(prixAchat, 2), stock, tva, seuilStock);

                        //new G_t_detail_vente(sConnexion).Ajouter(idCommSelectionnee, idProduitAjoutee, stock, prixAchat, tva);

                        C_t_produit pImp = new G_t_produit(sConnexion).Lire_ID(IDproduit);

                        if (pImp.Quantite_stock <= pImp.Seuil_stock)
                        {
                            MessageBox.Show($"Le stock de l'article {pImp.Nom} référence : {pImp.ID_produit} est faible. Un bordereau de commande déstiné au fournisseur a été emis", "Stock faible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            bordereauDeCommande(pImp.Nom, 10 + pImp.Quantite_stock);
                        }

                        if (int.Parse(tbQtee.Text) > pImp.Quantite_stock)
                        {
                            MessageBox.Show("Il n'y a pas assez d'articles en stock.", "Stock insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            new G_t_detail_vente(sConnexion).Ajouter(idCommSelectionnee, IDproduit, stock, prixVente, tva);
                            new G_t_produit(sConnexion).Modifier(IDproduit, pImp.Nom, pImp.Prix_vente, pImp.Prix_achat, (pImp.Quantite_stock - int.Parse(tbQtee.Text)), pImp.TVA, pImp.Seuil_stock);
                        }


                        RemplirDGV();
                        Activer(true);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Modification si id est remplie
                {
                    if (decimal.TryParse(tbPrixVente.Text.Replace('.', ','), out decimal prixVente)
                        && int.TryParse(tbQtee.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        )
                    {
                        //int idProduitModifiee = new G_t_produit(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text.ToString(), Math.Round(prixVente, 2), Math.Round(prixAchat, 2), stock, tva, seuilStock);


                        new G_t_detail_vente(sConnexion).Modifier(int.Parse(tbIDCmdClient.Text), idClientSelectionnee, IDproduit, stock, Math.Round(prixVente, 2), tva);
                        RemplirDGV();
                        Activer(true);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbIDproduit.Text = tbNom.Text = tbPrixVente.Text = tbQtee.Text = "";
            Activer(true);
        }

        #endregion


        #region Commande client

        public void RemplirDGVcommandeClient()
        {
            dtCmdClient = new DataTable();
            dtCmdClient.Columns.Add(new DataColumn("cID", System.Type.GetType("System.Int32")));
            dtCmdClient.Columns.Add(new DataColumn("IDClient"));
            dtCmdClient.Columns.Add(new DataColumn("Nom"));
            dtCmdClient.Columns.Add(new DataColumn("dateCommande"));
            dtCmdClient.Columns.Add(new DataColumn("dateVente"));

            List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client");
            List<C_t_client> l2 = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client d in l2)
            {
                foreach (C_t_commande_client p in listeTemporaire)
                {
                    if (p.ID_client == d.ID_client)
                        dtCmdClient.Rows.Add((int)p.ID_commande_client, p.ID_client, d.Nom, p.Date_commande.ToString("dddd dd-MM-yyyy"), p.Date_vente.ToString("dddd dd-MM-yyyy"));
                }
            }

            bsCmdClient = new BindingSource();
            bsCmdClient.DataSource = dtCmdClient;
            dgvCmdClient.DataSource = bsCmdClient;
        }

        private void btnAjouterUnClient_Click(object sender, EventArgs e)
        {
            var listesClient = new ListesClient(sConnexion);
            listesClient.ShowDialog();
            listesClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            var cmdClient = new CommandeClient(sConnexion);
            cmdClient.ShowDialog();

            cmdClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };
        }

        private void dgvCmdClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCmdClient.Rows[e.RowIndex];
                tbIDCmdClient.Text = row.Cells[0].Value.ToString();
                idCommSelectionnee = int.Parse(row.Cells[0].Value.ToString());

                tbIDClient.Text = row.Cells[1].Value.ToString();
                idClientSelectionnee = int.Parse(row.Cells[1].Value.ToString());

                tbNomclient.Text = row.Cells[2].Value.ToString();
            }
            RemplirDGV();
            Activer(true);
        }

        #endregion

        private void cbIDproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listProduit)
            {
                if (p.ID_produit.ToString() == cbIDproduit.SelectedItem.ToString())
                {
                    IDproduit = int.Parse(cbIDproduit.SelectedItem.ToString());
                    tbNom.Text = p.Nom;
                    tbQtee.Text = p.Quantite_stock.ToString();
                    tbPrixVente.Text = p.Prix_vente.ToString();
                    tbTVA.Text = p.TVA.ToString();
                }
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            cbIDproduit.Text = tbNom.Text = tbQtee.Text = tbPrixVente.Text = tbTVA.Text = "";
            Activer(true);
        }

        private void btnFacturer_Click(object sender, EventArgs e)
        {
            string dateHeure = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nomFichier = ("Facture-" + dateHeure + ".txt");
            string nomClient = "";
            string dateVente = "";
            List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client");
            List<C_t_client> l2 = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client d in l2)
            {
                foreach (C_t_commande_client p in listeTemporaire)
                {
                    if (p.ID_client == d.ID_client)
                    {
                        nomClient = d.Nom;
                        dateVente = p.Date_vente.ToString();
                    }
                }
            }

            string infoClient = $"Nom : {nomClient}\nDate de vente : {dateVente}";
            StreamWriter sw = new StreamWriter(nomFichier);

            sw.WriteLine("Informations du client :");
            sw.WriteLine(infoClient);
            sw.WriteLine();

            foreach (DataGridViewColumn colonne in dgvArticles.Columns)
            {
                sw.Write(colonne.HeaderText + "\t\t\t");
            }
            sw.WriteLine();

            foreach (DataGridViewRow ligne in dgvArticles.Rows)
            {
                foreach (DataGridViewCell cellule in ligne.Cells)
                {
                    sw.Write(cellule.Value.ToString() + "\t\t");
                }


                sw.WriteLine();
            }

            sw.Close();
        }

        private void bordereauDeCommande(string nomArticles, int qteArticle)
        {
            string dateHeure = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nomFichier = ("BordereauDeCommande -" + dateHeure + ".txt");
            string nomFournisseur = "";
            List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("ID_Frn");
            List<C_t_frn> l2 = new G_t_frn(sConnexion).Lire("Nom");
            foreach (C_t_frn d in l2)
            {
                foreach (C_t_commande_frn p in listeTemporaire)
                {
                    if (p.ID_frn == d.ID_frn)
                    {
                        nomFournisseur = d.Nom;
                    }
                }
            }

            string infoFournisseur = $"Nom : {nomFournisseur}";
            StreamWriter sw = new StreamWriter(nomFichier);

            sw.WriteLine("Informations du fournisseur :");
            sw.WriteLine(infoFournisseur);
            sw.WriteLine();

            sw.WriteLine("Commande de :");
            sw.WriteLine(nomArticles + "\t\t" + qteArticle + " pcs");

            sw.Close();
        }


        private decimal CalculerChiffreAffaireHebdomadaire()
        {
            //decimal chiffreAffaireTotal = 0;
            //DateTime dateDebutSemaine = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            //DateTime dateFinSemaine = dateDebutSemaine.AddDays(7);

            //foreach (DataGridViewRow row in dgvCmdClient.Rows)
            //{
            //    if (row.Cells["dateVente"].Value != null)
            //    {
            //        DateTime dateVente = Convert.ToDateTime(row.Cells["dateVente"].Value);
            //        if (dateVente >= dateDebutSemaine && dateVente < dateFinSemaine)
            //        {
            //            int idProduit = Convert.ToInt32(row.Cells["ID"].Value);
            //            DataGridViewRow articleRow = dgvArticles.Rows
            //                .Cast<DataGridViewRow>()
            //                .FirstOrDefault(r => Convert.ToInt32(r.Cells["ID"].Value) == idProduit);

            //            if (articleRow != null && articleRow.Cells["prixVente"].Value != null)
            //            {
            //                decimal prixVente = Convert.ToDecimal(articleRow.Cells["prixVente"].Value);
            //                int quantite = Convert.ToInt32(row.Cells["qte"].Value);
            //                decimal chiffreAffaire = prixVente * quantite;

            //                chiffreAffaireTotal += chiffreAffaire;
            //            }
            //        }
            //    }
            //}

            return 1542;
        }

        private void btnCalculeCaHebdo_Click(object sender, EventArgs e)
        {
            decimal ca = CalculerChiffreAffaireHebdomadaire();
            lbCA.Text = "CA : " + ca.ToString() + "€";
        }

        private void btnEtatStockHTML_Click(object sender, EventArgs e)
        {
            string nomFichier = "EtatStock.html";
            StreamWriter sw = new StreamWriter(nomFichier);

            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<table>");
            for (int i = 0; i < 3; i++)
            {
                sw.WriteLine("<br>");
            }

            sw.WriteLine("<tr>");
            foreach (DataGridViewColumn colonne in dgvArticles.Columns)
            {
                sw.WriteLine("<th>" + colonne.HeaderText + "</th>");
            }
            sw.WriteLine("</tr>");
            foreach (DataGridViewRow ligne in dgvArticles.Rows)
            {
                sw.WriteLine("<tr>");
                foreach (DataGridViewCell cellule in ligne.Cells)
                {
                    sw.WriteLine("<td>" + cellule.Value.ToString() + "</td>");
                }
                sw.WriteLine("</tr>");
            }
            sw.WriteLine("</table>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");

            sw.Close();

        }
    }
}

