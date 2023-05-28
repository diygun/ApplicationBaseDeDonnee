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
    public partial class ListesArticles : Form
    {
        String sConnexion;
        private DataTable dtArticles; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsArticles;

        public ListesArticles(string sConnexion)
        {
            this.sConnexion = sConnexion;
            InitializeComponent();
        }
        private void Activer(bool lPrincipale)
        {

            dgvArticles.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            tbID.Enabled = tbNom.Enabled = tbNom.Enabled = tbPrixVente.Enabled = tbPrixAchat.Enabled = tbTVA.Enabled = tbStock.Enabled = tbSeuilStock.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }

        private void RemplirDGV()
        {
            dtArticles = new DataTable();
            dtArticles.Columns.Add(new DataColumn("cID", System.Type.GetType("System.Int32")));
            dtArticles.Columns.Add(new DataColumn("Nom"));
            dtArticles.Columns.Add(new DataColumn("prixAchat"));
            dtArticles.Columns.Add(new DataColumn("prixVente"));
            dtArticles.Columns.Add(new DataColumn("TVA"));
            dtArticles.Columns.Add(new DataColumn("qteStock"));
            dtArticles.Columns.Add(new DataColumn("seuilStock"));

            // !!!!! SI ERRUEUR ICI, CA VEUT DIRE QUE LE SERVEUR SQL N'EST PAS OUVERT 
            List<C_t_produit> listeTemporaire = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listeTemporaire)
            {
                dtArticles.Rows.Add(p.ID_produit, p.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
            }
            bsArticles = new BindingSource();
            bsArticles.DataSource = dtArticles;
            dgvArticles.DataSource = bsArticles;
        }

        private void ListesArticles_Load(object sender, EventArgs e)
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbID.Text = tbNom.Text = tbPrixVente.Text = tbPrixAchat.Text = tbStock.Text = tbSeuilStock.Text = "";
            tbTVA.Text = "21";
            Activer(false);
            tbNom.Focus();
            RemplirDGV();
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
                        new G_t_produit(sConnexion).Ajouter(tbNom.Text.ToString(), Math.Round(prixVente, 2), Math.Round(prixAchat, 2), stock, tva, seuilStock);
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
                        new G_t_produit(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text.ToString(), prixVente, prixAchat, stock, tva, seuilStock);
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
        
        private void btnTest_Click(object sender, EventArgs e)
        {
            new G_t_produit(sConnexion).Ajouter("Carte mere", 100, 50, 10, 21, 1);
        }
    }
}
