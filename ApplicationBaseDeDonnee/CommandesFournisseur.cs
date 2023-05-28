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


        public CommandesFournisseur(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }
        private void Activer(bool lPrincipale)
        {

            dgvCmdFrn.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panelCmdFrn.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
            panelFrn.Enabled = true;
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
            dtCmdFrn.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtCmdFrn.Columns.Add(new DataColumn("IDFournisseur"));
            dtCmdFrn.Columns.Add(new DataColumn("dateCommande"));

            List<C_t_commande_frn> listeTemporaire = new G_t_commande_frn(sConnexion).Lire("Nom");
            foreach (C_t_commande_frn p in listeTemporaire)
            {
                dtCmdFrn.Rows.Add(p.ID_frn, p.ID_commande_frn, p.Date_commande);
            }
            bsCmdFrn = new BindingSource();
            bsCmdFrn.DataSource = dtCmdFrn;
            dgvCmdFrn.DataSource = bsCmdFrn;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbIDCmdFrn.Text = "";
            cbIDFRn.SelectedItem = null;
            dtpCmd.Value = DateTime.Today;
            Activer(false);
            tbNom.Focus();
            RemplirDGV();
            Activer(false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // ---------------------------
            tbIDCmdFrn.Text = "";
            cbIDFRn.SelectedItem = null;
            dtpCmd.Value = DateTime.Today;
            // ---------------------------

            Activer(true);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

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
                    // il faut parse / convertir chaque element des tb avant de les envoyer. Afficher une pop up warning + text a chaque key down ?
                    if ( /*CONDITION AVANT D'AJOUTER*/ false)
                    {
                        int numID = 0;
                        //new G_t_commande_frn(sConnexion).Ajouter(numID, (int)cbIDFRn.SelectedIndex, dtpCmd.Value);
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
                    if ( /*CONDITION AVANT D'AJOUTER*/ false)
                    {
                        //new G_t_commande_frn(sConnexion).Modifier(int.Parse(tbIDCmdFrn.Text), tbNom.Text.ToString(), prixVente, prixAchat, stock, tva, seuilStock);
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

        /*
        Charger la listes des cmds
        Btn d'ajout suppressiosn de cmd.
        Pour l'id frn proposer une liste pas une tb
        Et a chaque click de la commande, afficher le frn + plus tard le detail de la commande

        Pour le btn date, proposer un date picker

         */

    }
}
