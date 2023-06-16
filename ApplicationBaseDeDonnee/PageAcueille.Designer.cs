
namespace ApplicationBaseDeDonnee
{
    partial class PageAcueille
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPageAcueille = new System.Windows.Forms.MenuStrip();
            this.msManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentEncoderFactureFrn = new System.Windows.Forms.ToolStripMenuItem();
            this.emettreUneFactureAuClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msArticles = new System.Windows.Forms.ToolStripMenuItem();
            this.msGestionClient = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterClient = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterCmdClient = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterDetailVente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msGestionFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterCmdFournisseur = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterDetailAchat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbAvertissement = new System.Windows.Forms.Label();
            this.msPageAcueille.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPageAcueille
            // 
            this.msPageAcueille.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msManagment,
            this.msArticles,
            this.msGestionClient,
            this.msGestionFournisseur});
            this.msPageAcueille.Location = new System.Drawing.Point(0, 0);
            this.msPageAcueille.Name = "msPageAcueille";
            this.msPageAcueille.Size = new System.Drawing.Size(1213, 24);
            this.msPageAcueille.TabIndex = 0;
            this.msPageAcueille.Text = "menuStrip1";
            // 
            // msManagment
            // 
            this.msManagment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managmentEncoderFactureFrn,
            this.emettreUneFactureAuClientToolStripMenuItem});
            this.msManagment.Name = "msManagment";
            this.msManagment.Size = new System.Drawing.Size(84, 20);
            this.msManagment.Text = "Managment";
            // 
            // managmentEncoderFactureFrn
            // 
            this.managmentEncoderFactureFrn.Name = "managmentEncoderFactureFrn";
            this.managmentEncoderFactureFrn.Size = new System.Drawing.Size(242, 22);
            this.managmentEncoderFactureFrn.Text = "Encoder une facture fournisseur";
            this.managmentEncoderFactureFrn.Click += new System.EventHandler(this.managmentEncoderFactureFrn_Click);
            // 
            // emettreUneFactureAuClientToolStripMenuItem
            // 
            this.emettreUneFactureAuClientToolStripMenuItem.Name = "emettreUneFactureAuClientToolStripMenuItem";
            this.emettreUneFactureAuClientToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.emettreUneFactureAuClientToolStripMenuItem.Text = "Emettre une facture au client";
            this.emettreUneFactureAuClientToolStripMenuItem.Click += new System.EventHandler(this.emettreUneFactureAuClientToolStripMenuItem_Click);
            // 
            // msArticles
            // 
            this.msArticles.Name = "msArticles";
            this.msArticles.Size = new System.Drawing.Size(58, 20);
            this.msArticles.Text = "Articles";
            this.msArticles.Click += new System.EventHandler(this.msArticles_Click);
            // 
            // msGestionClient
            // 
            this.msGestionClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouterClient,
            this.msAjouterCmdClient,
            this.msAjouterDetailVente,
            this.toolStripSeparator1});
            this.msGestionClient.Name = "msGestionClient";
            this.msGestionClient.Size = new System.Drawing.Size(101, 20);
            this.msGestionClient.Text = "Gestions clients";
            // 
            // msAjouterClient
            // 
            this.msAjouterClient.Name = "msAjouterClient";
            this.msAjouterClient.Size = new System.Drawing.Size(258, 22);
            this.msAjouterClient.Text = "Ajouter un client";
            this.msAjouterClient.Click += new System.EventHandler(this.msAjouterClient_Click);
            // 
            // msAjouterCmdClient
            // 
            this.msAjouterCmdClient.Name = "msAjouterCmdClient";
            this.msAjouterCmdClient.Size = new System.Drawing.Size(258, 22);
            this.msAjouterCmdClient.Text = "Ajouter une commande client";
            this.msAjouterCmdClient.Click += new System.EventHandler(this.msAjouterCmdClient_Click);
            // 
            // msAjouterDetailVente
            // 
            this.msAjouterDetailVente.Name = "msAjouterDetailVente";
            this.msAjouterDetailVente.Size = new System.Drawing.Size(258, 22);
            this.msAjouterDetailVente.Text = "Ajouter un detail de vente au client";
            this.msAjouterDetailVente.Click += new System.EventHandler(this.msAjouterDetailVente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
            // 
            // msGestionFournisseur
            // 
            this.msGestionFournisseur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouterFournisseur,
            this.msAjouterCmdFournisseur,
            this.msAjouterDetailAchat,
            this.toolStripSeparator2});
            this.msGestionFournisseur.Name = "msGestionFournisseur";
            this.msGestionFournisseur.Size = new System.Drawing.Size(121, 20);
            this.msGestionFournisseur.Text = "Gestion fournisseur";
            // 
            // msAjouterFournisseur
            // 
            this.msAjouterFournisseur.Name = "msAjouterFournisseur";
            this.msAjouterFournisseur.Size = new System.Drawing.Size(282, 22);
            this.msAjouterFournisseur.Text = "Ajouter un fournisseur";
            this.msAjouterFournisseur.Click += new System.EventHandler(this.msFournisseur_Click);
            // 
            // msAjouterCmdFournisseur
            // 
            this.msAjouterCmdFournisseur.Name = "msAjouterCmdFournisseur";
            this.msAjouterCmdFournisseur.Size = new System.Drawing.Size(282, 22);
            this.msAjouterCmdFournisseur.Text = "Ajouter une commande au fournisseur";
            this.msAjouterCmdFournisseur.Click += new System.EventHandler(this.msCommandesFournisseurToolStripMenuItem_Click);
            // 
            // msAjouterDetailAchat
            // 
            this.msAjouterDetailAchat.Name = "msAjouterDetailAchat";
            this.msAjouterDetailAchat.Size = new System.Drawing.Size(282, 22);
            this.msAjouterDetailAchat.Text = "Ajouter un detail d\'achat au fournisseur";
            this.msAjouterDetailAchat.Click += new System.EventHandler(this.ajouterDetailAchat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // lbAvertissement
            // 
            this.lbAvertissement.AutoSize = true;
            this.lbAvertissement.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvertissement.ForeColor = System.Drawing.Color.Red;
            this.lbAvertissement.Location = new System.Drawing.Point(12, 407);
            this.lbAvertissement.Name = "lbAvertissement";
            this.lbAvertissement.Size = new System.Drawing.Size(383, 34);
            this.lbAvertissement.TabIndex = 1;
            this.lbAvertissement.Text = "Serveur SQL ouvert ?";
            // 
            // PageAcueille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 548);
            this.Controls.Add(this.lbAvertissement);
            this.Controls.Add(this.msPageAcueille);
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.msPageAcueille;
            this.Name = "PageAcueille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "E-Commerce Managment";
            this.Load += new System.EventHandler(this.PageAcueille_Load);
            this.msPageAcueille.ResumeLayout(false);
            this.msPageAcueille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPageAcueille;
        private System.Windows.Forms.ToolStripMenuItem msManagment;
        private System.Windows.Forms.Label lbAvertissement;
        private System.Windows.Forms.ToolStripMenuItem msArticles;
        private System.Windows.Forms.ToolStripMenuItem msGestionClient;
        private System.Windows.Forms.ToolStripMenuItem msAjouterClient;
        private System.Windows.Forms.ToolStripMenuItem msAjouterCmdClient;
        private System.Windows.Forms.ToolStripMenuItem msAjouterDetailVente;
        private System.Windows.Forms.ToolStripMenuItem managmentEncoderFactureFrn;
        private System.Windows.Forms.ToolStripMenuItem emettreUneFactureAuClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msGestionFournisseur;
        private System.Windows.Forms.ToolStripMenuItem msAjouterFournisseur;
        private System.Windows.Forms.ToolStripMenuItem msAjouterCmdFournisseur;
        private System.Windows.Forms.ToolStripMenuItem msAjouterDetailAchat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

