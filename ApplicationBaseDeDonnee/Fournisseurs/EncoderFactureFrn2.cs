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

namespace ApplicationBaseDeDonnee.Fournisseurs
{
    public partial class EncoderFactureFrn2 : Form
    {
        String sConnexion;
        private DataTable dtEncoderFacture; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsEncoderFacture;

        int IDcommandeFrnSelectionnee = -1;
        int IDproduit = -1;



        public EncoderFactureFrn2(string sConnexion)
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
        private void EncoderFactureFrn_Load(object sender, EventArgs e)
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
            dtEncoderFacture.Columns.Add(new DataColumn("ID_commandes_frn"));
            dtEncoderFacture.Columns.Add(new DataColumn("ID_produit"));
            dtEncoderFacture.Columns.Add(new DataColumn("NomProduit"));
            dtEncoderFacture.Columns.Add(new DataColumn("Quantite"));
            dtEncoderFacture.Columns.Add(new DataColumn("PrixUnitaire"));
            dtEncoderFacture.Columns.Add(new DataColumn("TVA"));

            Console.WriteLine("init");
            List<C_t_produit> produit = new G_t_produit(sConnexion).Lire("Nom");
            List<C_t_detail_achat> detailAchat = new G_t_detail_achat(sConnexion).Lire("ID_commande_frn");
            List<C_t_commande_frn> CommandeFrn = new G_t_commande_frn(sConnexion).Lire("ID_frn");

            foreach (C_t_commande_frn c in CommandeFrn)
            {
                foreach (C_t_detail_achat a in detailAchat)
                {
                    if (a.ID_commande_frn == c.ID_commande_frn)
                        foreach (C_t_produit p in produit)
                        {
                            if (a.ID_commande_frn == c.ID_commande_frn && a.ID_produit == p.ID_produit)
                            {
                                dtEncoderFacture.Rows.Add(a.ID_detail_achat, a.ID_commande_frn, a.ID_produit, p.Nom, a.Quantite, a.Prix_unitaire, a.TVA);
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
            tbID.Text = cbIDCommandeFrn.Text = tbPrixAchat.Text = tbStock.Text = ""; // = tbPrixVente.Text= tbSeuilStock.Text
            tbTVA.Text = "21";
            Activer(false);
            cbIDCommandeFrn.Focus();
            RemplirDGV();


            cbIDCommandeFrn.Items.Clear();
            List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("ID_frn"); // !!!!!!!! mettre id frn sinon ca n'affiche rien 
            foreach (C_t_commande_frn p in listeTemporaire)
            {
                cbIDCommandeFrn.Items.Add(p.ID_commande_frn);
            }

            cbIDproduit.Items.Clear();
            List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listProduit)
            {
                //dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
                cbIDproduit.Items.Add(p.ID_produit);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count > 0)
            {
                tbID.Text = dgvArticles.SelectedRows[0].Cells["ID_detail_articles"].Value.ToString();

                C_t_detail_achat pImp = new G_t_detail_achat(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbID.Text = pImp.ID_detail_achat.ToString();
                cbIDCommandeFrn.Text = pImp.ID_commande_frn.ToString();
                cbIDproduit.Text = pImp.ID_produit.ToString();
                tbStock.Text = pImp.Quantite.ToString();
                tbPrixAchat.Text = Math.Round(pImp.Prix_unitaire, 2).ToString();
                tbTVA.Text = pImp.TVA.ToString();

                Activer(false);
                tbTVA.Text = "21";
                Activer(false);
                cbIDCommandeFrn.Focus();
                RemplirDGV();


                cbIDCommandeFrn.Items.Clear();
                List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("ID_frn"); // !!!!!!!! mettre id frn sinon ca n'affiche rien 
                foreach (C_t_commande_frn p in listeTemporaire)
                {
                    cbIDCommandeFrn.Items.Add(p.ID_commande_frn);
                }

                cbIDproduit.Items.Clear();
                List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
                foreach (C_t_produit p in listProduit)
                {
                    //dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
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
                cbIDCommandeFrn.SelectedItem == null ||
                cbIDproduit.SelectedItem == null ||
                tbStock.Text == "" ||
                tbPrixAchat.Text == "" ||
                tbTVA.Text == ""
                )
            {
                MessageBox.Show(" AAAA Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbID.Text)) // Ajout si id est vide
                {
                    // il faut parse / convertir chaque element des tb avant de les envoyer. Afficher une pop up warning + text a chaque key down ?
                    if (decimal.TryParse(tbPrixAchat.Text.Replace('.', ','), out decimal prixAchat)
                        && int.TryParse(tbStock.Text, out int stock)
                        && int.TryParse(tbTVA.Text, out int tva)
                        )
                    {

                        new G_t_detail_achat(sConnexion).Ajouter(IDcommandeFrnSelectionnee, IDproduit, stock, prixAchat, tva);
                        RemplirDGV();
                        Activer(true);
                    }
                    else
                    {
                        MessageBox.Show(" 111 Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Modification si id est remplie
                {
                    if (decimal.TryParse(tbPrixAchat.Text.Replace('.', ','), out decimal prixAchat)
                    && int.TryParse(tbStock.Text, out int stock)
                    && int.TryParse(tbTVA.Text, out int tva)
                    )
                    {
                        new G_t_detail_achat(sConnexion).Modifier(int.Parse(tbID.Text), IDcommandeFrnSelectionnee, IDproduit, stock, prixAchat, tva);
                        RemplirDGV();
                        Activer(true);
                    }
                    else
                    {
                        MessageBox.Show(" SSSSS Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);

        }

        private void tbIDCommandeFrn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine($"lastID = {lastID}");

            List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("ID_frn"); // !!!!! id frn sinon ca n'affiche pas
            foreach (C_t_commande_frn p in listeTemporaire)
            {
                if (p.ID_commande_frn.ToString() == cbIDCommandeFrn.SelectedItem.ToString())
                {
                    IDcommandeFrnSelectionnee = p.ID_commande_frn;
                }
            }

            Console.WriteLine("IDcommandeFrnSelectionnee = " + IDcommandeFrnSelectionnee);
            //C_t_commande_frn pImp = new G_t_commande_frn(sConnexion).Lire_ID(IDcommandeFrnSelectionnee);
            //tbNom.Text = pImp.Nom;
            //tbAdresse.Text = pImp.Adresse;
            //tbEmail.Text = pImp.Email;
            //tbGSM.Text = pImp.GSM;
            //tbNmCompte.Text = pImp.N_compte;
            ////tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text =  tbNmCompte.Text = "";
        }

        private void cbIDproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<C_t_produit> listProduit = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listProduit)
            {
                if (p.ID_produit.ToString() == cbIDproduit.SelectedItem.ToString())
                {
                    IDproduit = p.ID_produit;
                }
                Console.WriteLine("IDproduit = " + IDproduit);

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




        /*
                    private void RemplirDGV()
                {
                    dtEncoderFacture = new DataTable();
                    dtEncoderFacture.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
                    dtEncoderFacture.Columns.Add(new DataColumn("Nom"));
                    dtEncoderFacture.Columns.Add(new DataColumn("ID_commande_frn")); // id de la table commande frn (nomé !n de commande )
                    dtEncoderFacture.Columns.Add(new DataColumn("Nom_frn"));// + nom depuis la table table frn ( nomé nom du fournisseur)

                    dtEncoderFacture.Columns.Add(new DataColumn("ID_produit")); // id depuis table produit, nulero du prioduit, et nom du produit
                    dtEncoderFacture.Columns.Add(new DataColumn("Nom_produit")); // id depuis table produit, nulero du prioduit, et nom du produit

                    dtEncoderFacture.Columns.Add(new DataColumn("prixAchat"));
                    dtEncoderFacture.Columns.Add(new DataColumn("prixVente"));
                    dtEncoderFacture.Columns.Add(new DataColumn("TVA"));
                    dtEncoderFacture.Columns.Add(new DataColumn("qteStock"));
                    dtEncoderFacture.Columns.Add(new DataColumn("seuilStock"));

                    List<C_t_produit> listeProduit = new G_t_produit(sConnexion).Lire("Nom");
                    List<C_t_frn> l2 = new G_t_frn(sConnexion).Lire("Nom");
                    foreach (C_t_frn f in l2)
                    {
                        //foreach (C_t_frn p in l2)
                        {
                            foreach (C_t_produit p in listeProduit)
                            {
                                dtEncoderFacture.Rows.Add(p.ID_produit, p.Nom, f.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
                            }
                        }
                    }

                    bsEncoderFacture = new BindingSource();
                    bsEncoderFacture.DataSource = dtEncoderFacture;
                    dgvArticles.DataSource = bsEncoderFacture;
                }

         */
    }
}
