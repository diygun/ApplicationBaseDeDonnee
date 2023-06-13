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
    public partial class CommandesFournisseur : Form
    {
        String sConnexion;
        private DataTable dtCmdFrn; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsCmdFrn;
        int lastID = 1;
        int idDuFRNselectionnnee = -1;

        public CommandesFournisseur(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }
        private void Activer(bool lPrincipale)
        {

            dgvCmdFrn.Enabled = true;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panelCmdFrn.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
            //panelFrn.Enabled = true;
        }

        private void CommandesFournisseur_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvCmdFrn.Rows.Count > 0)
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
            dtCmdFrn = new DataTable();
            dtCmdFrn.Columns.Add(new DataColumn("cID", System.Type.GetType("System.Int32")));
            dtCmdFrn.Columns.Add(new DataColumn("IDFournisseur"));
            dtCmdFrn.Columns.Add(new DataColumn("dateCommande"));

            List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("ID_frn");
            foreach (C_t_commande_frn p in listeTemporaire)
            {
                dtCmdFrn.Rows.Add((int)p.ID_commande_frn, p.ID_frn, p.Date_commande.ToString("dddd dd-MM-yyyy"));
                
            }
            
            bsCmdFrn = new BindingSource();
            bsCmdFrn.DataSource = dtCmdFrn;
            dgvCmdFrn.DataSource = bsCmdFrn;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbIDCmdFrn.Text = "";
            cbIDFRn.SelectedItem = "";
            dtpCmd.Value = DateTime.Today;
            Activer(false);
            tbNom.Focus();
            RemplirDGV();
            Activer(false);

            cbIDFRn.Items.Clear();
            List<C_t_frn> listeTemporaire = new G_t_frn(sConnexion).Lire("Nom");
            foreach (C_t_frn p in listeTemporaire)
            {
                cbIDFRn.Items.Add(p.Nom);
            }
            tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text = tbNmCompte.Text = "";

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // ---------------------------
            tbIDCmdFrn.Text = "";
            cbIDFRn.SelectedItem = "";
            tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text = tbNmCompte.Text = "";
            dtpCmd.Value = DateTime.Today;
            // ---------------------------
            Activer(true);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvCmdFrn.SelectedRows.Count > 0)
            {
                tbIDCmdFrn.Text = dgvCmdFrn.SelectedRows[0].Cells["cID"].Value.ToString();
                C_t_commande_frn pImp = new G_t_commande_frn(sConnexion).Lire_ID(int.Parse(tbIDCmdFrn.Text));
                cbIDFRn.Items.Clear();
                List<C_t_frn> listeTemporaire = new G_t_frn(sConnexion).Lire("Nom");
                foreach (C_t_frn p in listeTemporaire)
                {
                    cbIDFRn.Items.Add(p.Nom);
                }
                    cbIDFRn.SelectedIndex = 1;

                dtpCmd.Value = pImp.Date_commande == null ? DateTime.Today : (DateTime)pImp.Date_commande;
                Activer(false);
            }
            else
            {
                MessageBox.Show("Sélectionnez l'enregistrement à éditer");
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
                if (string.IsNullOrEmpty(tbIDCmdFrn.Text)) // Ajout si id est vide
                {
                    if (tbNom.Text != "") // verifier s'il y a un nom suffit car sans frn pas de lien
                    {
                        //int idincre = lastID++;
                        DateTime dateAtransmettre = dtpCmd.Value;
                        new G_t_commande_frn(sConnexion).Ajouter(0, idDuFRNselectionnnee, dtpCmd.Value);
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
                    if (cbIDFRn.SelectedItem != null)
                    {
                        //new G_t_commande_frn(sConnexion).Modifier(int.Parse(tbIDCmdFrn.Text), tbNom.Text.ToString(), prixVente, prixAchat, stock, tva, seuilStock);
                        RemplirDGV(); // ! mettre a true 
                        Activer(true);
                        new G_t_commande_frn(sConnexion).Modifier(int.Parse(tbIDCmdFrn.Text), idDuFRNselectionnnee, dtpCmd.Value);
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

        private void cbIDFRn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"lastID = {lastID}");

            List<C_t_frn> listeTemporaire = new G_t_frn(sConnexion).Lire("Nom");
            foreach (C_t_frn p in listeTemporaire)
            {
                if (p.Nom == cbIDFRn.SelectedItem.ToString())
                {
                    idDuFRNselectionnnee = p.ID_frn;
                }
            }

            C_t_frn pImp = new G_t_frn(sConnexion).Lire_ID(idDuFRNselectionnnee);
            tbNom.Text = pImp.Nom;
            tbAdresse.Text = pImp.Adresse;
            tbEmail.Text = pImp.Email;
            tbGSM.Text = pImp.GSM;
            tbNmCompte.Text = pImp.N_compte;
            //tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text =  tbNmCompte.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvCmdFrn.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement ?", "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvCmdFrn.SelectedRows[0].Cells["cID"].Value;
                    new G_t_commande_frn(sConnexion).Supprimer(iID);
                    bsCmdFrn.RemoveCurrent();
                }
            }
        }

        /*
        Charger la listes des cmds
        Btn d'ajout suppressiosn de cmd.
        Pour l'id frn proposer une liste pas une tb
        Et a chaque click de la commande, afficher le frn + plus tard le detail de la commande

        Pour le btn date, proposer un date picker

         */

    }
}
