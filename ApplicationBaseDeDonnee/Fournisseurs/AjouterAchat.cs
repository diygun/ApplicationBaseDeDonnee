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
    public partial class AjouterAchat : Form
    {
        String sConnexion;
        private DataTable dtFrn; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsFrn;

        public AjouterAchat(string sConnexion)
        {
            InitializeComponent();
            this.sConnexion = sConnexion;
        }
        private void Activer(bool lPrincipale)
        {

            dgvAjoutAchat.Enabled = lPrincipale;
            btnAjouter.Enabled = btnModifier.Enabled = btnSupprimer.Enabled = lPrincipale;
            panel.Enabled = !lPrincipale;
            btnConfirmer.Enabled = btnAnnuler.Enabled = !lPrincipale;
        }
        private void RemplirDGV()
        {
            dtFrn = new DataTable();
            dtFrn.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtFrn.Columns.Add(new DataColumn("Nom")); // .MaxLength ? 
            dtFrn.Columns.Add(new DataColumn("prixAchat"));
            dtFrn.Columns.Add(new DataColumn("prixVente"));
            dtFrn.Columns.Add(new DataColumn("TVA"));
            dtFrn.Columns.Add(new DataColumn("qteStock"));
            dtFrn.Columns.Add(new DataColumn("seuilStock"));

            // !!!!! SI ERRUEUR ICI, CA VEUT DIRE QUE LE SERVEUR SQL N'EST PAS OUVERT 
            List<C_t_produit> listeTemporaire = new G_t_produit(sConnexion).Lire("Nom");
            foreach (C_t_produit p in listeTemporaire)
            {
                dtFrn.Rows.Add(p.ID_produit, p.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
            }
            bsFrn = new BindingSource();
            bsFrn.DataSource = dtFrn;
            dgvAjoutAchat.DataSource = bsFrn;
        }

    }
}
