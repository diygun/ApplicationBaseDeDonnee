using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ApplicationBaseDeDonnee.Fournisseurs;
using ApplicationBaseDeDonnee.Clients;
using Projet_DB_ManagmentAPP;
using DB_ManagmentAPP_Acces;
using Projet_DB_ManagmentAPP_Gestion;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_DB_ManagmentAPP.Classes;
using Projet_DB_ManagmentAPP.Gestion;


namespace ApplicationBaseDeDonnee
{
    public partial class PageAcueille : Form
    {
        String sConnexion;
        int IDproduit = -1;
        private DataTable dtArticles;
        private BindingSource bsArticles;
        private DataTable dtClient;
        private BindingSource bsClient;

        public PageAcueille()
        {
            InitializeComponent();
        }

        private void PageAcueille_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["ApplicationBaseDeDonnee.Properties.Settings.BD_Chaine_de_connexion_couches"].ConnectionString;
            RemplirDGV();
            RemplirDGVClient();


            cbIDproduit.Items.Clear();
            List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listProduit)
            {
                cbIDproduit.Items.Add(p.ID_produit);
            }

        }

        private void msArticles_Click(object sender, EventArgs e)
        {
            var listesArticles = new ListesArticles(sConnexion);
            listesArticles.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };
            listesArticles.Show();
            listesArticles.Activate();
        }



        #region Gestion fournisseur

        private void msFournisseur_Click(object sender, EventArgs e)
        {
            var listesFournisseur = new ListesFournisseur(sConnexion);
            listesFournisseur.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            listesFournisseur.Show();
            listesFournisseur.Activate();
        }
        private void msCommandesFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cmdFournisseur = new CommandesFournisseur(sConnexion);
            cmdFournisseur.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            cmdFournisseur.Show();
            cmdFournisseur.Activate();
        }
        private void ajouterDetailAchat_Click(object sender, EventArgs e)
        {
            var ajouterDetailAchat = new EncoderFactureFrn2(sConnexion);
            ajouterDetailAchat.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterDetailAchat.Show();
            ajouterDetailAchat.Activate();
        }

        #endregion

        #region Gestion client
        private void msAjouterClient_Click(object sender, EventArgs e)
        {
            var ajouterClient = new ListesClient(sConnexion);
            ajouterClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterClient.Show();
            ajouterClient.Activate();
        }
        private void msAjouterCmdClient_Click(object sender, EventArgs e)
        {
            var ajouterCommandeClient = new CommandeClient(sConnexion);
            ajouterCommandeClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterCommandeClient.Show();
            ajouterCommandeClient.Activate();
        }
        private void msAjouterDetailVente_Click(object sender, EventArgs e)
        {
            var ajouterDetailVente = new EncoderFactureClient2(sConnexion);
            ajouterDetailVente.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterDetailVente.Show();
            ajouterDetailVente.Activate();
        }

        #endregion

        #region encodages

        private void managmentEncoderFactureFrn_Click(object sender, EventArgs e)
        {
            var encoderFactureFrn = new EncoderFactureFrn(sConnexion);
            encoderFactureFrn.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };
            encoderFactureFrn.Show();
            encoderFactureFrn.Activate();
        }
        private void emettreUneFactureAuClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var encoderFactureClient = new EncoderFactureClient(sConnexion);
            encoderFactureClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };
            encoderFactureClient.Show();
            encoderFactureClient.Activate();
        }



        #endregion

        #region DashBoard

        private void RemplirDGV()
        {
            dtArticles = new DataTable();
            dtArticles.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtArticles.Columns.Add(new DataColumn("Nom"));
            dtArticles.Columns.Add(new DataColumn("prixVente"));
            dtArticles.Columns.Add(new DataColumn("TVA"));
            dtArticles.Columns.Add(new DataColumn("qte"));
            dtArticles.Columns.Add(new DataColumn("DateSortie"));

            List<C_t_produit> produit = new G_t_produit(sConnexion).Lire("Nom");
            List<C_t_detail_vente> detailAchat = new G_t_detail_vente(sConnexion).Lire("ID_commande_client");
            List<C_t_commande_client> CommandeClient = new G_t_commande_client(sConnexion).Lire("ID_client");
            foreach (C_t_produit p in produit)
            {
                {
                    dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_vente, p.TVA, p.Quantite_stock, p.DateSortie);
                }
            }

            bsArticles = new BindingSource();
            bsArticles.DataSource = dtArticles;
            dgvArticles.DataSource = bsArticles;
        }

        private void RemplirDGVClient()
        {
            dtClient = new DataTable();
            dtClient.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtClient.Columns.Add(new DataColumn("Nom"));
            dtClient.Columns.Add(new DataColumn("adresse"));
            dtClient.Columns.Add(new DataColumn("Email"));
            dtClient.Columns.Add(new DataColumn("GSM"));

            List<C_t_client> listeTemporaire = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client p in listeTemporaire)
            {
                dtClient.Rows.Add(p.ID_client, p.Nom, p.Adresse, p.Email, p.GSM);
            }
            bsClient = new BindingSource();
            bsClient.DataSource = dtClient;
            dgvClient.DataSource = bsClient;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (
                cbIDproduit.SelectedItem != null &&
                tbQtee.Text == "" &&
                tbPrixVente.Text == "" &&
                tbTVA.Text == ""
                )
            {
                MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbIDproduit.SelectedItem != null)
                {
                    if (decimal.TryParse(tbPrixVente.Text.Replace('.', ','), out decimal prixVente)
                        && int.TryParse(tbQtee.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        )
                    {
                        C_t_produit pImp = new G_t_produit(sConnexion).Lire_ID(IDproduit);

                        if (pImp.Quantite_stock <= pImp.Seuil_stock)
                        {
                            MessageBox.Show($"Le stock de l'article {pImp.Nom} référence : {pImp.ID_produit} est faible.", "Stock faible", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        if (int.Parse(tbQtee.Text) > pImp.Quantite_stock)
                        {
                            MessageBox.Show("Il n'y a pas assez d'articles en stock.", "Stock insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            new G_t_produit(sConnexion).Modifier(IDproduit, pImp.Nom, pImp.Prix_vente, pImp.Prix_achat, (pImp.Quantite_stock - int.Parse(tbQtee.Text)), pImp.TVA, pImp.Seuil_stock, pImp.DateSortie ?? DateTime.Now);

                        }

                        RemplirDGV();
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
            cbIDproduit.SelectedIndex = 0;
            tbNom.Text = "";
            tbQtee.Text = "";
            tbPrixVente.Text = "";
            tbTVA.Text = "";
        }

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

        #endregion

        private void btnAfficherStock_Click(object sender, EventArgs e)
        {
            var nav = new visionneurStockHtml();
            nav.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            nav.Show();
            nav.Activate();
        }
    }
}
