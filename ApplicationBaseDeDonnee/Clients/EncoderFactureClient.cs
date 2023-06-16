using System;
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
        public EncoderFactureClient(string sConnexion)
        {
            this.sConnexion = sConnexion;
            InitializeComponent();
        }
        private void EncoderFactureClient_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            RemplirDGVcommandeClient();
            panelArticle.Enabled = false;
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
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            tbID.Enabled = tbNom.Enabled = tbNom.Enabled = tbPrixVente.Enabled = tbPrixAchat.Enabled = tbTVA.Enabled = tbStock.Enabled = tbSeuilStock.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }

        private void RemplirDGV()
        {
            // ajouter les articles seulement si leur id sont dans la t_detail_vente
            // -- > qui a sont id_commande_client == au commande_client selectionnée 
            dtArticles = new DataTable();
            dtArticles.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtArticles.Columns.Add(new DataColumn("Nom"));
            dtArticles.Columns.Add(new DataColumn("prixAchat"));
            dtArticles.Columns.Add(new DataColumn("prixVente"));
            dtArticles.Columns.Add(new DataColumn("TVA"));
            dtArticles.Columns.Add(new DataColumn("qteStock"));
            dtArticles.Columns.Add(new DataColumn("seuilStock"));



            // ------------------------

            //DataGridViewRow row = dgvCmdClient.Rows[e.RowIndex];
            //tbIDCmdClient.Text = row.Cells[0].Value.ToString();
            //tbIDFRn.Text = row.Cells[1].Value.ToString();
            //tbNomclient.Text = row.Cells[2].Value.ToString();


            // ------------------------
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
                                dtArticles.Rows.Add(/*a.ID_detail_vente, a.ID_commande_client,*/ a.ID_produit, p.Nom, p.Prix_vente, p.Prix_vente, a.TVA, p.Quantite_stock, p.Seuil_stock);
                            }
                        }
                }
            }

            //List<C_t_produit> listeTemporaire = new G_t_produit(sConnexion).Lire("Nom");
            //foreach (C_t_produit p in listeTemporaire)
            //{

            //    dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_vente, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
            //}

            bsArticles = new BindingSource();
            bsArticles.DataSource = dtArticles;
            dgvArticles.DataSource = bsArticles;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (idCommSelectionnee != -1)
            {
                tbID.Text = tbNom.Text = tbPrixVente.Text = tbPrixAchat.Text = tbStock.Text = tbSeuilStock.Text = "";
                tbTVA.Text = "21";
                Activer(false);

                panelArticle.Enabled = true;
                tbNom.Focus();
                RemplirDGV();
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
                tbID.Text = dgvArticles.SelectedRows[0].Cells["cID"].Value.ToString();
                C_t_produit pImp = new G_t_produit(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbNom.Text = pImp.Nom;
                tbPrixVente.Text = Math.Round(pImp.Prix_vente, 2).ToString();
                tbPrixAchat.Text = Math.Round(pImp.Prix_vente, 2).ToString();
                tbTVA.Text = pImp.TVA.ToString();
                tbStock.Text = pImp.Quantite_stock.ToString();
                tbSeuilStock.Text = pImp.Seuil_stock.ToString();
                Activer(false);
                panelArticle.Enabled = true;
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
                if (string.IsNullOrEmpty(tbID.Text)) // Ajout si id est vide
                {
                    // il faut parse / convertir chaque element des tb avant de les envoyer. Afficher une pop up warning + text a chaque key down ?
                    if (decimal.TryParse(tbPrixVente.Text.Replace('.', ','), out decimal prixVente)
                        && decimal.TryParse(tbPrixAchat.Text.Replace('.', ','), out decimal prixAchat)
                        && int.TryParse(tbStock.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        && int.TryParse(tbSeuilStock.Text, out int seuilStock)
                        )
                    {
                        Console.WriteLine(prixVente);
                        int idProduitAjoutee = new G_t_produit(sConnexion).Ajouter(tbNom.Text.ToString(), Math.Round(prixVente, 2), Math.Round(prixAchat, 2), stock, tva, seuilStock);

                        new G_t_detail_vente(sConnexion).Ajouter(idCommSelectionnee, idProduitAjoutee, stock, prixAchat, tva);


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
                        && decimal.TryParse(tbPrixAchat.Text.Replace('.', ','), out decimal prixAchat)
                        && int.TryParse(tbStock.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        && int.TryParse(tbSeuilStock.Text, out int seuilStock)
                        )
                    {
                        int idProduitModifiee = new G_t_produit(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text.ToString(), Math.Round(prixVente, 2), Math.Round(prixAchat, 2), stock, tva, seuilStock);
                        new G_t_detail_vente(sConnexion).Modifier(int.Parse(tbIDCmdClient.Text), idClientSelectionnee, idProduitModifiee, stock, Math.Round(prixAchat, 2), tva);
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
            tbID.Text = tbNom.Text = tbPrixVente.Text = tbPrixAchat.Text = tbStock.Text = tbSeuilStock.Text = "";
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

            List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client");
            List<C_t_client> l2 = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client d in l2)
            {
                foreach (C_t_commande_client p in listeTemporaire)
                {
                    if (p.ID_client == d.ID_client)
                        dtCmdClient.Rows.Add((int)p.ID_commande_client, p.ID_client, d.Nom, p.Date_commande.ToString("dddd dd-MM-yyyy"));
                }
            }

            bsCmdClient = new BindingSource();
            bsCmdClient.DataSource = dtCmdClient;
            dgvCmdClient.DataSource = bsCmdClient;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            new G_t_produit(sConnexion).Ajouter("Generic prod", 100, 50, 10, 21, 1);
        }

        private void btnAjouterUnClient_Click(object sender, EventArgs e)
        {
            var listesClient = new ListesClient(sConnexion);
            listesClient.ShowDialog();
            listesClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            //listesClient.Show();
            //listesClient.Activate();
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

    }
}
