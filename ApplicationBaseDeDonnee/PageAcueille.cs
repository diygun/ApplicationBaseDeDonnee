using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ApplicationBaseDeDonnee.Fournisseurs;
using Projet_DB_ManagmentAPP;
using DB_ManagmentAPP_Acces;
using Projet_DB_ManagmentAPP_Gestion;
using System.Data.SqlClient;

namespace ApplicationBaseDeDonnee
{
    public partial class PageAcueille : Form
    {
        String sConnexion;
        //private DataTable dtCommerce; // joue un peu le role de dataset, on stock les donnee dedans
        //private BindingSource bsCommerce;
        public PageAcueille()
        {
            InitializeComponent();
        }

        private void PageAcueille_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["ApplicationBaseDeDonnee.Properties.Settings.BD_Chaine_de_connexion_couches"].ConnectionString;
        }

        private void managmentEncoderFactureFrn_Click(object sender, EventArgs e)
        {
            var encoderFactureFrn = new EncoderFactureFrn(sConnexion);
            encoderFactureFrn.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            encoderFactureFrn.Show();
            encoderFactureFrn.Activate();
        }

        private void msArticles_Click(object sender, EventArgs e)
        {
            var listesArticles = new ListesArticles(sConnexion);
            listesArticles.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            listesArticles.Show();
            listesArticles.Activate();
        }
        private void msFournisseur_Click(object sender, EventArgs e)
        {
            var listesFournisseur = new ListesFournisseur(sConnexion);
            listesFournisseur.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            listesFournisseur.Show();
            listesFournisseur.Activate();
        }
        private void commandesFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cmdFournisseur = new CommandesFournisseur(sConnexion);
            cmdFournisseur.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            cmdFournisseur.Show();
            cmdFournisseur.Activate();
        }
        private void ajouterUnAchatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dtail achat
            var ajouterAchat = new AjouterAchat(sConnexion);
            ajouterAchat.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterAchat.Show();
            ajouterAchat.Activate();
        }
        private void msAjouterClient_Click(object sender, EventArgs e)
        {
            var ajouterClient = new ListesClient(sConnexion);
            ajouterClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterClient.Show();
            ajouterClient.Activate();
        }
        private void msAjouterCmdClient_Click(object sender, EventArgs e)
        {
            var ajouterCommandeClient = new CommandeClient(sConnexion);
            ajouterCommandeClient.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterCommandeClient.Show();
            ajouterCommandeClient.Activate();
        }

        private void ajouterDetailAchat_Click(object sender, EventArgs e)
        {
            var ajouterDetailAchat = new EncoderFactureFrn2(sConnexion);
            ajouterDetailAchat.Closed += delegate (object s, EventArgs args)
            {
                this.Show();
            };

            ajouterDetailAchat.Show();
            ajouterDetailAchat.Activate();
        }
    }
}
