
namespace ApplicationBaseDeDonnee
{
    partial class EncoderFactureClient2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lbDetailVente = new System.Windows.Forms.Label();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.ID_detail_articles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_commandes_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.cbIDproduit = new System.Windows.Forms.ComboBox();
            this.cbIDCommandeClient = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbEncoderArticle = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbIDdetailVente = new System.Windows.Forms.Label();
            this.tbQte = new System.Windows.Forms.TextBox();
            this.lbQte = new System.Windows.Forms.Label();
            this.lbIDcmdClient = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.tbTVA = new System.Windows.Forms.TextBox();
            this.lbPrixVente = new System.Windows.Forms.Label();
            this.tbPrixVente = new System.Windows.Forms.TextBox();
            this.lbTVA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 462);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 29);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer l\'article";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 427);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(113, 29);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier l\'article";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 392);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 29);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "Ajouter un article";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lbDetailVente
            // 
            this.lbDetailVente.AutoSize = true;
            this.lbDetailVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetailVente.Location = new System.Drawing.Point(12, 9);
            this.lbDetailVente.Name = "lbDetailVente";
            this.lbDetailVente.Size = new System.Drawing.Size(269, 25);
            this.lbDetailVente.TabIndex = 30;
            this.lbDetailVente.Text = "Encoder un detail de vente";
            this.lbDetailVente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detail_articles,
            this.ID_commandes_client,
            this.ID_produit,
            this.NomProduit,
            this.Quantite,
            this.PrixUnitaire,
            this.TVA});
            this.dgvArticles.Location = new System.Drawing.Point(2, 37);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(714, 349);
            this.dgvArticles.TabIndex = 31;
            // 
            // ID_detail_articles
            // 
            this.ID_detail_articles.DataPropertyName = "ID_detail_articles";
            this.ID_detail_articles.HeaderText = "ID_detail_articles";
            this.ID_detail_articles.Name = "ID_detail_articles";
            this.ID_detail_articles.ReadOnly = true;
            // 
            // ID_commandes_client
            // 
            this.ID_commandes_client.DataPropertyName = "ID_commandes_client";
            this.ID_commandes_client.HeaderText = "ID_commandes_client";
            this.ID_commandes_client.Name = "ID_commandes_client";
            this.ID_commandes_client.ReadOnly = true;
            this.ID_commandes_client.Width = 130;
            // 
            // ID_produit
            // 
            this.ID_produit.DataPropertyName = "ID_produit";
            this.ID_produit.HeaderText = "ID_produit";
            this.ID_produit.Name = "ID_produit";
            this.ID_produit.ReadOnly = true;
            // 
            // NomProduit
            // 
            this.NomProduit.DataPropertyName = "NomProduit";
            this.NomProduit.HeaderText = "NomProduit";
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "Quantite";
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // PrixUnitaire
            // 
            this.PrixUnitaire.DataPropertyName = "PrixUnitaire";
            this.PrixUnitaire.HeaderText = "PrixUnitaire";
            this.PrixUnitaire.Name = "PrixUnitaire";
            this.PrixUnitaire.ReadOnly = true;
            // 
            // TVA
            // 
            this.TVA.DataPropertyName = "TVA";
            this.TVA.HeaderText = "TVA";
            this.TVA.Name = "TVA";
            this.TVA.ReadOnly = true;
            this.TVA.Width = 75;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbIDproduit);
            this.panel.Controls.Add(this.cbIDCommandeClient);
            this.panel.Controls.Add(this.tbID);
            this.panel.Controls.Add(this.lbEncoderArticle);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.lbIDdetailVente);
            this.panel.Controls.Add(this.tbQte);
            this.panel.Controls.Add(this.lbQte);
            this.panel.Controls.Add(this.lbIDcmdClient);
            this.panel.Controls.Add(this.lbClient);
            this.panel.Controls.Add(this.tbTVA);
            this.panel.Controls.Add(this.lbPrixVente);
            this.panel.Controls.Add(this.tbPrixVente);
            this.panel.Controls.Add(this.lbTVA);
            this.panel.Location = new System.Drawing.Point(131, 392);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(460, 245);
            this.panel.TabIndex = 32;
            // 
            // cbIDproduit
            // 
            this.cbIDproduit.FormattingEnabled = true;
            this.cbIDproduit.Location = new System.Drawing.Point(232, 86);
            this.cbIDproduit.Name = "cbIDproduit";
            this.cbIDproduit.Size = new System.Drawing.Size(184, 21);
            this.cbIDproduit.TabIndex = 35;
            this.cbIDproduit.SelectedIndexChanged += new System.EventHandler(this.cbIDproduit_SelectedIndexChanged);
            // 
            // cbIDCommandeClient
            // 
            this.cbIDCommandeClient.FormattingEnabled = true;
            this.cbIDCommandeClient.Location = new System.Drawing.Point(232, 61);
            this.cbIDCommandeClient.Name = "cbIDCommandeClient";
            this.cbIDCommandeClient.Size = new System.Drawing.Size(184, 21);
            this.cbIDCommandeClient.TabIndex = 34;
            this.cbIDCommandeClient.SelectedIndexChanged += new System.EventHandler(this.tbIDCommandeClient_SelectedIndexChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(232, 35);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(184, 20);
            this.tbID.TabIndex = 34;
            // 
            // lbEncoderArticle
            // 
            this.lbEncoderArticle.AutoSize = true;
            this.lbEncoderArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncoderArticle.Location = new System.Drawing.Point(170, 7);
            this.lbEncoderArticle.Name = "lbEncoderArticle";
            this.lbEncoderArticle.Size = new System.Drawing.Size(186, 25);
            this.lbEncoderArticle.TabIndex = 33;
            this.lbEncoderArticle.Text = "Encoder un article";
            this.lbEncoderArticle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(303, 222);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(140, 222);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(113, 20);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lbIDdetailVente
            // 
            this.lbIDdetailVente.AutoSize = true;
            this.lbIDdetailVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDdetailVente.Location = new System.Drawing.Point(110, 33);
            this.lbIDdetailVente.Name = "lbIDdetailVente";
            this.lbIDdetailVente.Size = new System.Drawing.Size(111, 20);
            this.lbIDdetailVente.TabIndex = 4;
            this.lbIDdetailVente.Text = "ID detail vente";
            // 
            // tbQte
            // 
            this.tbQte.Location = new System.Drawing.Point(232, 113);
            this.tbQte.Name = "tbQte";
            this.tbQte.Size = new System.Drawing.Size(184, 20);
            this.tbQte.TabIndex = 5;
            // 
            // lbQte
            // 
            this.lbQte.AutoSize = true;
            this.lbQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQte.Location = new System.Drawing.Point(151, 113);
            this.lbQte.Name = "lbQte";
            this.lbQte.Size = new System.Drawing.Size(70, 20);
            this.lbQte.TabIndex = 8;
            this.lbQte.Text = "Quantité";
            // 
            // lbIDcmdClient
            // 
            this.lbIDcmdClient.AutoSize = true;
            this.lbIDcmdClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDcmdClient.Location = new System.Drawing.Point(90, 61);
            this.lbIDcmdClient.Name = "lbIDcmdClient";
            this.lbIDcmdClient.Size = new System.Drawing.Size(132, 20);
            this.lbIDcmdClient.TabIndex = 5;
            this.lbIDcmdClient.Text = "ID commande frn";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.Location = new System.Drawing.Point(143, 87);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(79, 20);
            this.lbClient.TabIndex = 6;
            this.lbClient.Text = "ID produit";
            // 
            // tbTVA
            // 
            this.tbTVA.Location = new System.Drawing.Point(232, 165);
            this.tbTVA.Name = "tbTVA";
            this.tbTVA.Size = new System.Drawing.Size(184, 20);
            this.tbTVA.TabIndex = 4;
            // 
            // lbPrixVente
            // 
            this.lbPrixVente.AutoSize = true;
            this.lbPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixVente.Location = new System.Drawing.Point(122, 139);
            this.lbPrixVente.Name = "lbPrixVente";
            this.lbPrixVente.Size = new System.Drawing.Size(99, 20);
            this.lbPrixVente.TabIndex = 7;
            this.lbPrixVente.Text = "Prix de vente";
            // 
            // tbPrixVente
            // 
            this.tbPrixVente.Location = new System.Drawing.Point(232, 139);
            this.tbPrixVente.Name = "tbPrixVente";
            this.tbPrixVente.Size = new System.Drawing.Size(184, 20);
            this.tbPrixVente.TabIndex = 3;
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVA.Location = new System.Drawing.Point(153, 165);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(68, 20);
            this.lbTVA.TabIndex = 9;
            this.lbTVA.Text = "TVA (%)";
            // 
            // EncoderFactureClient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 722);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.lbDetailVente);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "EncoderFactureClient2";
            this.Text = "Enocoder une fcature client";
            this.Load += new System.EventHandler(this.EncoderFactureClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lbDetailVente;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbEncoderArticle;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbIDdetailVente;
        private System.Windows.Forms.Label lbIDcmdClient;
        private System.Windows.Forms.TextBox tbQte;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.TextBox tbTVA;
        private System.Windows.Forms.Label lbPrixVente;
        private System.Windows.Forms.TextBox tbPrixVente;
        private System.Windows.Forms.Label lbQte;
        private System.Windows.Forms.Label lbTVA;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbIDCommandeClient;
        private System.Windows.Forms.ComboBox cbIDproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_detail_articles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_commandes_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
    }
}