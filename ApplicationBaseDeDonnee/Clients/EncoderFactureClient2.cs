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
    public partial class EncoderFactureClient2 : Form
    {
        String sConnexion;
        private DataTable dtEncoderFacture; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsEncoderFacture;

        int IDcommandeClientSelectionnee = -1;
        int IDproduit = -1;



        public EncoderFactureClient2(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }
        private void Activer(bool lPrincipale)
        {
            dgvArticles.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panel.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }
        private void EncoderFactureClient_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvArticles.Rows.Count > 0)
            {
                Activer(true);
            }
            else
            {
                Activer(false);
            }
        }

        private void RemplirDGV()
        {
            dtEncoderFacture = new DataTable();
            dtEncoderFacture.Columns.Add(new DataColumn("ID_detail_articles", System.Type.GetType("System.Int32")));
            dtEncoderFacture.Columns.Add(new DataColumn("ID_commandes_client"));
            dtEncoderFacture.Columns.Add(new DataColumn("ID_produit"));
            dtEncoderFacture.Columns.Add(new DataColumn("NomProduit"));
            dtEncoderFacture.Columns.Add(new DataColumn("Quantite"));
            dtEncoderFacture.Columns.Add(new DataColumn("PrixUnitaire"));
            dtEncoderFacture.Columns.Add(new DataColumn("TVA"));

            List<C_t_produit> produit = new G_t_produit(sConnexion).Lire("Nom");
            List<C_t_detail_vente> detailAchat = new G_t_detail_vente(sConnexion).Lire("ID_commande_client");
            List<C_t_commande_client> CommandeClient = new G_t_commande_client(sConnexion).Lire("ID_client");

            foreach (C_t_commande_client c in CommandeClient)
            {
                foreach (C_t_detail_vente a in detailAchat)
                {
                    if (a.ID_commande_client == c.ID_commande_client)
                        foreach (C_t_produit p in produit)
                        {
                            if (a.ID_commande_client == c.ID_commande_client && a.ID_produit == p.ID_produit)
                            {
                                dtEncoderFacture.Rows.Add(a.ID_detail_vente, a.ID_commande_client, a.ID_produit, p.Nom, a.Quantite, a.Prix_vente, a.TVA);
                            }
                        }
                }
            }

            bsEncoderFacture = new BindingSource();
            bsEncoderFacture.DataSource = dtEncoderFacture;
            dgvArticles.DataSource = bsEncoderFacture;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbID.Text = cbIDCommandeClient.Text = tbPrixVente.Text = tbQte.Text = ""; // = tbPrixVente.Text= tbSeuilStock.Text
            tbTVA.Text = "21";
            Activer(false);
            cbIDCommandeClient.Focus();
            RemplirDGV();


            cbIDCommandeClient.Items.Clear();
            List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client"); // !!!!!!!! mettre id client sinon ca n'affiche rien 
            foreach (C_t_commande_client p in listeTemporaire)
            {
                cbIDCommandeClient.Items.Add(p.ID_commande_client);
            }

            cbIDproduit.Items.Clear();
            List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listProduit)
            {
                //dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_vente, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
                cbIDproduit.Items.Add(p.ID_produit);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count > 0)
            {
                tbID.Text = dgvArticles.SelectedRows[0].Cells["ID_detail_articles"].Value.ToString();
                C_t_detail_vente pImp = new G_t_detail_vente(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbID.Text = pImp.ID_detail_vente.ToString();
                cbIDCommandeClient.Text = pImp.ID_commande_client.ToString();
                cbIDproduit.Text = pImp.ID_produit.ToString();
                tbQte.Text = pImp.Quantite.ToString();
                tbPrixVente.Text = Math.Round((double)pImp.Prix_vente, 2).ToString();
                tbTVA.Text = pImp.TVA.ToString();

                Activer(false);
                tbTVA.Text = "21";
                Activer(false);
                cbIDCommandeClient.Focus();
                RemplirDGV();


                cbIDCommandeClient.Items.Clear();
                List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client"); // !!!!!!!! mettre id client sinon ca n'affiche rien 
                foreach (C_t_commande_client p in listeTemporaire)
                {
                    cbIDCommandeClient.Items.Add(p.ID_commande_client);
                }

                cbIDproduit.Items.Clear();
                List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
                foreach (C_t_produit p in listProduit)
                {
                    cbIDproduit.Items.Add(p.ID_produit);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez l'enregistrement à éditer");
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (
                cbIDCommandeClient.SelectedItem == null ||
                cbIDproduit.SelectedItem == null ||
                tbQte.Text == "" ||
                tbPrixVente.Text == "" ||
                tbTVA.Text == ""
                )
            {
                MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbID.Text)) // Ajout si id est vide
                {
                    // il faut parse / convertir chaque element des tb avant de les envoyer. Afficher une pop up warning + text a chaque key down ?
                    if (decimal.TryParse(tbPrixVente.Text.Replace('.', ','), out decimal prixVente)
                        && int.TryParse(tbQte.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        )
                    {

                        /*
                                    tbNom.Text = pImp.Nom;
                                    tbPrixVente.Text = Math.Round(pImp.Prix_vente, 2).ToString();
                                    tbPrixAchat.Text = Math.Round(pImp.Prix_achat, 2).ToString();
                                    tbTVA.Text = pImp.TVA.ToString();
                                    tbStock.Text = pImp.Quantite_stock.ToString();
                                    tbSeuilStock.Text = pImp.Seuil_stock.ToString();
                        */
                        C_t_produit pImp = new G_t_produit(sConnexion).Lire_ID(IDproduit);

                        if (pImp.Quantite_stock <= pImp.Seuil_stock)
                        {
                            MessageBox.Show($"Le stock de l'article {pImp.Nom} référence : {pImp.ID_produit} est faible.", "Stock faible", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        if (int.Parse(tbQte.Text) > pImp.Quantite_stock)
                        {
                            MessageBox.Show("Il n'y a pas assez d'articles en stock.", "Stock insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            new G_t_detail_vente(sConnexion).Ajouter(IDcommandeClientSelectionnee, IDproduit, stock, prixVente, tva);
                            new G_t_produit(sConnexion).Modifier(IDproduit, pImp.Nom, pImp.Prix_vente, pImp.Prix_achat, (pImp.Quantite_stock - int.Parse(tbQte.Text)) , pImp.TVA, pImp.Seuil_stock, pImp.DateSortie ?? DateTime.Now);

                            // emmettre un ticket de vente ??
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
                    && int.TryParse(tbQte.Text, out int stock)
                    && int.TryParse(tbTVA.Text, out int tva)
                    )
                    {
                        new G_t_detail_vente(sConnexion).Modifier(int.Parse(tbID.Text), IDcommandeClientSelectionnee, IDproduit, stock, prixVente, tva);
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
            Activer(true);
        }

        private void tbIDCommandeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client"); // !!!!! id client sinon ca n'affiche pas
            foreach (C_t_commande_client p in listeTemporaire)
            {
                if (p.ID_commande_client.ToString() == cbIDCommandeClient.SelectedItem.ToString())
                {
                    IDcommandeClientSelectionnee = p.ID_commande_client;
                }
            }
        }

        private void cbIDproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listProduit)
            {
                if (p.ID_produit.ToString() == cbIDproduit.SelectedItem.ToString())
                {
                    IDproduit = p.ID_produit;
                    tbPrixVente.Text = p.Prix_vente.ToString();
                    tbTVA.Text = p.TVA.ToString();
                }
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
                    bsEncoderFacture.RemoveCurrent();
                }
            }
        }
    }
}
