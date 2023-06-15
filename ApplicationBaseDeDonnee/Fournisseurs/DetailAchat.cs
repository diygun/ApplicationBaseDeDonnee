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
        private DataTable dtAchat; // joue un peu le role de dataset, on stock les donnee dedans
        private BindingSource bsAchat;

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
            dtAchat = new DataTable();
            dtAchat.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtAchat.Columns.Add(new DataColumn("Nom"));
            dtAchat.Columns.Add(new DataColumn("ID_commande_frn")); // id de la table commande frn (nomé !n de commande )
            dtAchat.Columns.Add(new DataColumn("Nom_frn"));// + nom depuis la table table frn ( nomé nom du fournisseur)

            dtAchat.Columns.Add(new DataColumn("ID_produit")); // id depuis table produit, nulero du prioduit, et nom du produit
            dtAchat.Columns.Add(new DataColumn("Nom_produit")); // id depuis table produit, nulero du prioduit, et nom du produit

            dtAchat.Columns.Add(new DataColumn("prixAchat"));
            dtAchat.Columns.Add(new DataColumn("prixVente"));
            dtAchat.Columns.Add(new DataColumn("TVA"));
            dtAchat.Columns.Add(new DataColumn("qteStock"));
            dtAchat.Columns.Add(new DataColumn("seuilStock"));

            List<C_t_produit> listeProduit = new G_t_produit(sConnexion).Lire("Nom");
            List<C_t_frn> l2 = new G_t_frn(sConnexion).Lire("Nom");
            foreach (C_t_frn f in l2)
            {
                //foreach (C_t_frn p in l2)
                {
                    foreach (C_t_produit p in listeProduit)
                    {
                        dtAchat.Rows.Add(p.ID_produit, p.Nom, f.Nom, p.Prix_achat, p.Prix_vente, p.TVA, p.Quantite_stock, p.Seuil_stock);
                    }
                }
            }

            bsAchat = new BindingSource();
            bsAchat.DataSource = dtAchat;
            dgvAjoutAchat.DataSource = bsAchat;
        }
        private void AjouterAchat_Load(object sender, EventArgs e)
        {
            RemplirDGV();
            if (dgvAjoutAchat.Rows.Count > 0)
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

        }



    }
}
