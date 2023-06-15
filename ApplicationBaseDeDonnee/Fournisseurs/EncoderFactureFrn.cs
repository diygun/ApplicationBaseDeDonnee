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

namespace ApplicationBaseDeDonnee
{
    public partial class EncoderFactureFrn : Form
    {
        String sConnexion;
        private DataTable dtArticles; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsArticles;

        private DataTable dtCmdFrn; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsCmdFrn;

        int idCommSelectionnee = -1;
        int idFrnSelectionnee = -1;
        public EncoderFactureFrn(string sConnexion)
        {
            this.sConnexion = sConnexion;
            InitializeComponent();
        }
        private void EncoderFactureFrn_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            RemplirDGVcommandeFrn();
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
            // ajouter les articles seulement si leur id sont dans la t_detail_achat
            // -- > qui a sont id_commande_frn == au commande_frn selectionnée 
            dtArticles = new DataTable();
            dtArticles.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtArticles.Columns.Add(new DataColumn("Nom"));
            dtArticles.Columns.Add(new DataColumn("prixAchat"));
            dtArticles.Columns.Add(new DataColumn("prixVente"));
            dtArticles.Columns.Add(new DataColumn("TVA"));
            dtArticles.Columns.Add(new DataColumn("qteStock"));
            dtArticles.Columns.Add(new DataColumn("seuilStock"));



            // ------------------------

            //DataGridViewRow row = dgvCmdFrn.Rows[e.RowIndex];
            //tbIDCmdFrn.Text = row.Cells[0].Value.ToString();
            //tbIDFRn.Text = row.Cells[1].Value.ToString();
            //tbNomfrn.Text = row.Cells[2].Value.ToString();


            // ------------------------
            List<C_t_produit> produit = new G_t_produit(sConnexion).Lire("Nom");
            List<C_t_detail_achat> detailAchat = new G_t_detail_achat(sConnexion).Lire("ID_commande_frn");
            List<C_t_commande_frn> CommandeFrn = new G_t_commande_frn(sConnexion).Lire("ID_frn");

            foreach (C_t_detail_achat a in detailAchat)
            {
                Console.WriteLine("idCommSelectionnee = " + idCommSelectionnee);
                Console.WriteLine("a.ID_detail_achat = " + a.ID_detail_achat);
                foreach (C_t_commande_frn c in CommandeFrn)
                {
                    if (a.ID_commande_frn == c.ID_commande_frn)
                        foreach (C_t_produit p in produit)
                        {
                            if (a.ID_commande_frn == c.ID_commande_frn && a.ID_produit == p.ID_produit && idCommSelectionnee == a.ID_commande_frn)
                            {
                                dtArticles.Rows.Add(/*a.ID_detail_achat, a.ID_commande_frn,*/ a.ID_produit, p.Nom, p.Prix_achat, p.Prix_vente, a.TVA, p.Quantite_stock, p.Seuil_stock);
                            }
                        }
                }
            }

            //List<C_t_produit> listeTemporaire = new G_t_produit(sConnexion).Lire("Nom");
            //foreach (C_t_produit p in listeTemporaire)
            //{

            //    dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
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
                tbPrixAchat.Text = Math.Round(pImp.Prix_achat, 2).ToString();
                tbTVA.Text = pImp.TVA.ToString();
                tbStock.Text = pImp.Quantite_stock.ToString();
                tbSeuilStock.Text = pImp.Seuil_stock.ToString();
                Activer(false);
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
                    new G_t_detail_achat(sConnexion).Supprimer(idCommSelectionnee);

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

                        new G_t_detail_achat(sConnexion).Ajouter(idCommSelectionnee, idProduitAjoutee, stock, prixAchat, tva);


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
                        new G_t_detail_achat(sConnexion).Modifier(int.Parse(tbIDCmdFrn.Text), idFrnSelectionnee, idProduitModifiee, stock, Math.Round(prixAchat, 2), tva);
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


        #region Commande frn

        public void RemplirDGVcommandeFrn()
        {
            dtCmdFrn = new DataTable();
            dtCmdFrn.Columns.Add(new DataColumn("cID", System.Type.GetType("System.Int32")));
            dtCmdFrn.Columns.Add(new DataColumn("IDFournisseur"));
            dtCmdFrn.Columns.Add(new DataColumn("Nom"));
            dtCmdFrn.Columns.Add(new DataColumn("dateCommande"));

            List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("ID_frn");
            List<C_t_frn> l2 = new G_t_frn(sConnexion).Lire("Nom");
            foreach (C_t_frn d in l2)
            {
                foreach (C_t_commande_frn p in listeTemporaire)
                {
                    if (p.ID_frn == d.ID_frn)
                        dtCmdFrn.Rows.Add((int)p.ID_commande_frn, p.ID_frn, d.Nom, p.Date_commande.ToString("dddd dd-MM-yyyy"));
                }
            }

            bsCmdFrn = new BindingSource();
            bsCmdFrn.DataSource = dtCmdFrn;
            dgvCmdFrn.DataSource = bsCmdFrn;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            new G_t_produit(sConnexion).Ajouter("Generic prod", 100, 50, 10, 21, 1);
        }

        private void btnAjouterUnFournisseur_Click(object sender, EventArgs e)
        {
            var listesFournisseur = new ListesFournisseur(sConnexion);
            listesFournisseur.ShowDialog();
            listesFournisseur.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            //listesFournisseur.Show();
            //listesFournisseur.Activate();
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            var cmdFournisseur = new CommandesFournisseur(sConnexion);
            cmdFournisseur.ShowDialog();

            cmdFournisseur.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };


        }

        private void dgvCmdFrn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCmdFrn.Rows[e.RowIndex];
                tbIDCmdFrn.Text = row.Cells[0].Value.ToString();
                idCommSelectionnee = int.Parse(row.Cells[0].Value.ToString());
                tbIDFRn.Text = row.Cells[1].Value.ToString();
                idFrnSelectionnee = int.Parse(row.Cells[1].Value.ToString());
                tbNomfrn.Text = row.Cells[2].Value.ToString();
            }
            RemplirDGV();
            Activer(true);
        }

        #endregion

    }
}