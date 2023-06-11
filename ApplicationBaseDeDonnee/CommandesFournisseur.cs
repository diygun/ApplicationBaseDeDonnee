﻿using System;
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
            //panelFrn.Enabled = true;
        }

        private void CommandesFournisseur_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvCmdFrn.Rows.Count > 0)
            {
                Activer(false);
            }
            else
            {
                Activer(true);
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
                if(p.ID_frn >= 0)
                {
                lastID = p.ID_frn;
                }
                else
                {
                    Console.WriteLine("ERRUER du lastID !!");
                    lastID = 0;
                }
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


            // quand je clique sur ajouter
            tbNom.Text = "ACCES NOM";
            // ----
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

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
            {
                MessageBox.Show(" 1111   Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbIDCmdFrn.Text)) // Ajout si id est vide
                {
                    if (tbNom.Text != "") // verifier s'il y a un nom suffit car sans frn pas de lien
                    {
                        Console.WriteLine($"lastID = {lastID}");
                        int idincre = lastID++;
                        new G_t_commande_frn(sConnexion).Ajouter(
                            //lastID,
                            //int.Parse(cbIDFRn.SelectedItem.ToString()),
                            2,2,
                            dtpCmd.Value);
                        RemplirDGV();
                        Activer(true);
                    }
                    else
                    {
                        MessageBox.Show(" 22222 Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Modification si id est remplie
                {
                    if ( /*CONDITION AVANT D'AJOUTER*/ false)
                    {
                        //new G_t_commande_frn(sConnexion).Modifier(int.Parse(tbIDCmdFrn.Text), tbNom.Text.ToString(), prixVente, prixAchat, stock, tva, seuilStock);
                        RemplirDGV(); // ! mettre a true 
                        Activer(true);

                    }
                    else
                    {
                        MessageBox.Show(" 33333  Veuillez renseigner toute les informations correctement.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbIDFRn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"lastID = {lastID}");

            int idDuFRNselectionnnee = -1;
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

        /*
        Charger la listes des cmds
        Btn d'ajout suppressiosn de cmd.
        Pour l'id frn proposer une liste pas une tb
        Et a chaque click de la commande, afficher le frn + plus tard le detail de la commande

        Pour le btn date, proposer un date picker

         */

    }
}
