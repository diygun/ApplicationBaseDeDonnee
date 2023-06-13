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
    public partial class ListesClient : Form
    {
        String sConnexion;
        private DataTable dtClient; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsClient;

        public ListesClient(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }

        private void Activer(bool lPrincipale)
        {
            dgvClient.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panel.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }

        private void RemplirDGV()
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

        private void ListesClient_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvClient.Rows.Count > 0)
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
            tbID.Text = tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text = "";
            Activer(false);
            tbNom.Focus();
            RemplirDGV();
            Activer(false);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvClient.SelectedRows.Count > 0)
            {
                tbID.Text = dgvClient.SelectedRows[0].Cells["cID"].Value.ToString();
                C_t_client pImp = new G_t_client(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbNom.Text = pImp.Nom;
                tbAdresse.Text = pImp.Adresse;
                tbEmail.Text = pImp.Email;
                tbGSM.Text = pImp.GSM;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionnez l'enregistrement à éditer");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvClient.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement ?", "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvClient.SelectedRows[0].Cells["cID"].Value;
                    new G_t_client(sConnexion).Supprimer(iID);
                    bsClient.RemoveCurrent();
                }
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "" && tbAdresse.Text.ToString() == "" && tbEmail.Text.ToString() == "" && tbGSM.Text.ToString() == "")
            {
                MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbID.Text)) // Ajout si id est vide
                {
                    new G_t_client(sConnexion).Ajouter(tbNom.Text.ToString(), tbAdresse.Text.ToString(), tbEmail.Text.ToString(), tbGSM.Text.ToString());
                    RemplirDGV();
                    Activer(true);
                }
                else // Modification si id est remplie
                {
                    if (tbNom.Text.Trim() != "" && tbAdresse.Text.ToString() != "" && tbEmail.Text.ToString() != "" && tbGSM.Text.ToString() != "")
                    {
                        new G_t_client(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text.ToString(), tbAdresse.Text.ToString(), tbEmail.Text.ToString(), tbGSM.Text.ToString());
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
    }
}
