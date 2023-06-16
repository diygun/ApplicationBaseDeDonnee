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
    public partial class CommandeClient : Form
    {
        String sConnexion;
        private DataTable dtCmdClient; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsCmdClient;
        int lastID = 1;
        int idDuFRNselectionnnee = -1;

        public CommandeClient(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }
        private void Activer(bool lPrincipale)
        {

            dgvCmdClient.Enabled = true;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panelCmdClient.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
            //panelClient.Enabled = true;
        }

        private void CommandeClient_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvCmdClient.Rows.Count > 0)
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
            dtCmdClient = new DataTable();
            dtCmdClient.Columns.Add(new DataColumn("cID", System.Type.GetType("System.Int32")));
            dtCmdClient.Columns.Add(new DataColumn("IDClient"));
            dtCmdClient.Columns.Add(new DataColumn("Nom"));
            dtCmdClient.Columns.Add(new DataColumn("dateCommande"));
            dtCmdClient.Columns.Add(new DataColumn("dateVente"));

            List<C_t_commande_client> listeTemporaire = new G_t_commande_client(sConnexion).Lire("ID_client");
            List<C_t_client> l2 = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client d in l2)
            {
                foreach (C_t_commande_client p in listeTemporaire)
                {
                    if (p.ID_client == d.ID_client)
                        dtCmdClient.Rows.Add((int)p.ID_commande_client, p.ID_client, d.Nom, p.Date_commande.ToString("dddd dd-MM-yyyy"), p.Date_vente.ToString("dddd dd-MM-yyyy"));
                }
            }

            bsCmdClient = new BindingSource();
            bsCmdClient.DataSource = dtCmdClient;
            dgvCmdClient.DataSource = bsCmdClient;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbIDCmdClient.Text = "";
            cbIDClient.SelectedItem = "";
            dtpCmd.Value = DateTime.Today;
            tbNom.Focus();
            RemplirDGV();
            Activer(false);

            cbIDClient.Items.Clear();
            List<C_t_client> listeTemporaire = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client p in listeTemporaire)
            {
                cbIDClient.Items.Add(p.Nom);
            }
            tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbIDCmdClient.Text = "";
            cbIDClient.SelectedItem = "";
            tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text = "";
            dtpCmd.Value = DateTime.Today;
            Activer(true);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvCmdClient.SelectedRows.Count > 0)
            {
                tbIDCmdClient.Text = dgvCmdClient.SelectedRows[0].Cells["cID"].Value.ToString();
                C_t_commande_client pImp = new G_t_commande_client(sConnexion).Lire_ID(int.Parse(tbIDCmdClient.Text));
                cbIDClient.Items.Clear();
                List<C_t_client> listeTemporaire = new G_t_client(sConnexion).Lire("Nom");
                foreach (C_t_client p in listeTemporaire)
                {
                    cbIDClient.Items.Add(p.Nom);
                }
                cbIDClient.SelectedIndex = 1;

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
                if (string.IsNullOrEmpty(tbIDCmdClient.Text)) // Ajout si id est vide
                {
                    if (tbNom.Text != "") // verifier s'il y a un nom suffit car sans client pas de lien
                    {
                        //int idincre = lastID++;
                        DateTime dateAtransmettre = dtpCmd.Value;
                        new G_t_commande_client(sConnexion).Ajouter(idDuFRNselectionnnee, dtpVente.Value, dtpCmd.Value);
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
                    if (cbIDClient.SelectedItem != null)
                    {
                        //new G_t_commande_client(sConnexion).Modifier(int.Parse(tbIDCmdClient.Text), tbNom.Text.ToString(), prixVente, prixAchat, stock, tva, seuilStock);
                        RemplirDGV(); // ! mettre a true 
                        Activer(true);
                        new G_t_commande_client(sConnexion).Modifier(int.Parse(tbIDCmdClient.Text), idDuFRNselectionnnee, dtpVente.Value, dtpCmd.Value);
                        // erruer ???
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

        private void cbIDClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"lastID = {lastID}");

            List<C_t_client> listeTemporaire = new G_t_client(sConnexion).Lire("Nom");
            foreach (C_t_client p in listeTemporaire)
            {
                if (p.Nom == cbIDClient.SelectedItem.ToString())
                {
                    idDuFRNselectionnnee = p.ID_client;
                }
            }

            C_t_client pImp = new G_t_client(sConnexion).Lire_ID(idDuFRNselectionnnee);
            tbNom.Text = pImp.Nom;
            tbAdresse.Text = pImp.Adresse;
            tbEmail.Text = pImp.Email;
            tbGSM.Text = pImp.GSM;
            //tbNom.Text = tbAdresse.Text = tbEmail.Text = tbGSM.Text =  tbNmCompte.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvCmdClient.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement ?", "Confirmer la suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int iID = (int)dgvCmdClient.SelectedRows[0].Cells["cID"].Value;
                    new G_t_commande_client(sConnexion).Supprimer(iID);
                    bsCmdClient.RemoveCurrent();
                }
            }
        }

        private void dtpCmd_ValueChanged(object sender, EventArgs e)
        {
            dtpVente.MinDate = dtpCmd.Value;
            dtpVente.Value = dtpCmd.Value;
        }



        /*
        Charger la listes des cmds
        Btn d'ajout suppressiosn de cmd.
        Pour l'id client proposer une liste pas une tb
        Et a chaque click de la commande, afficher le client + plus tard le detail de la commande

        Pour le btn date, proposer un date picker

         */

    }
}
