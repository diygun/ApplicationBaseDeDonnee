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
    public partial class ListesFournisseur : Form
    {
        String sConnexion;
        private DataTable dtFrn; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsFrn;

        public ListesFournisseur(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }
        private void Activer(bool lPrincipale)
        {

            dgvFrn.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panel.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }

        private void RemplirDGV()
        {
            dtFrn = new DataTable();
            dtFrn.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtFrn.Columns.Add(new DataColumn("Nom"));
            dtFrn.Columns.Add(new DataColumn("adresse"));
            dtFrn.Columns.Add(new DataColumn("Email"));
            dtFrn.Columns.Add(new DataColumn("GSM"));
            dtFrn.Columns.Add(new DataColumn("NmCompte"));

            // !!!!! SI ERRUEUR ICI, CA VEUT DIRE QUE LE SERVEUR SQL N'EST PAS OUVERT 
            List<C_t_frn> listeTemporaire = new G_t_frn(sConnexion).Lire("Nom");
            foreach (C_t_frn p in listeTemporaire)
            {
                dtFrn.Rows.Add(p.ID_frn, p.Nom, p.Adresse, p.Email, p.GSM, p.N_compte);
            }
            bsFrn = new BindingSource();
            bsFrn.DataSource = dtFrn;
            dgvFrn.DataSource = bsFrn;
        }

        private void ListesFournisseur_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvFrn.Rows.Count > 0)
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
            tbNmCompte.Text = "BE";
            Activer(false);
            tbNom.Focus();
            RemplirDGV();
            Activer(false);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvFrn.SelectedRows.Count > 0)
            {
                tbID.Text = dgvFrn.SelectedRows[0].Cells["cID"].Value.ToString();
                C_t_frn pImp = new G_t_frn(sConnexion).Lire_ID(int.Parse(tbID.Text));
                tbNom.Text = pImp.Nom;
                tbAdresse.Text = pImp.Adresse;
                tbEmail.Text = pImp.Email;
                tbGSM.Text = pImp.GSM;
                tbNmCompte.Text = pImp.N_compte;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionnez l'enregistrement à éditer");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvFrn.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement ?", "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvFrn.SelectedRows[0].Cells["cID"].Value;
                    new G_t_frn(sConnexion).Supprimer(iID);
                    bsFrn.RemoveCurrent();
                }
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "" && tbAdresse.Text.ToString() == "" && tbEmail.Text.ToString() == "" && tbGSM.Text.ToString() == "" && tbNmCompte.Text.ToString() == "")
            {
                MessageBox.Show("Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbID.Text)) // Ajout si id est vide
                {
                    new G_t_frn(sConnexion).Ajouter(tbNom.Text.ToString(), tbAdresse.Text.ToString(), tbEmail.Text.ToString(), tbGSM.Text.ToString(), tbNmCompte.Text.ToString());
                    RemplirDGV();
                    Activer(true);
                }
                else // Modification si id est remplie
                {
                    if (tbNom.Text.Trim() != "" && tbAdresse.Text.ToString() != "" && tbEmail.Text.ToString() != "" && tbGSM.Text.ToString() != "" && tbNmCompte.Text.ToString() != "")
                    {
                        new G_t_frn(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text.ToString(), tbAdresse.Text.ToString(), tbEmail.Text.ToString(), tbGSM.Text.ToString(), tbNmCompte.Text.ToString());
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
