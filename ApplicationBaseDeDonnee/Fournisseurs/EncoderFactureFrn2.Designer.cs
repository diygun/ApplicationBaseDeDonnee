
namespace ApplicationBaseDeDonnee.Fournisseurs
{
    partial class EncoderFactureFrn2
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
            this.lbDetailAchat = new System.Windows.Forms.Label();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.cbIDproduit = new System.Windows.Forms.ComboBox();
            this.cbIDCommandeFrn = new System.Windows.Forms.ComboBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbEncoderArticle = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbIDdetailAchat = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbIDcmdFrn = new System.Windows.Forms.Label();
            this.lbFrn = new System.Windows.Forms.Label();
            this.tbTVA = new System.Windows.Forms.TextBox();
            this.lbPrixAchat = new System.Windows.Forms.Label();
            this.tbPrixAchat = new System.Windows.Forms.TextBox();
            this.lbTVA = new System.Windows.Forms.Label();
            this.ID_detail_articles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_commandes_frn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // lbDetailAchat
            // 
            this.lbDetailAchat.AutoSize = true;
            this.lbDetailAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetailAchat.Location = new System.Drawing.Point(12, 9);
            this.lbDetailAchat.Name = "lbDetailAchat";
            this.lbDetailAchat.Size = new System.Drawing.Size(255, 25);
            this.lbDetailAchat.TabIndex = 30;
            this.lbDetailAchat.Text = "Encoder un detail d\'achat";
            this.lbDetailAchat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_detail_articles,
            this.ID_commandes_frn,
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
            this.dgvArticles.Size = new System.Drawing.Size(706, 349);
            this.dgvArticles.TabIndex = 31;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbIDproduit);
            this.panel.Controls.Add(this.cbIDCommandeFrn);
            this.panel.Controls.Add(this.tbID);
            this.panel.Controls.Add(this.lbEncoderArticle);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.lbIDdetailAchat);
            this.panel.Controls.Add(this.tbStock);
            this.panel.Controls.Add(this.lbStock);
            this.panel.Controls.Add(this.lbIDcmdFrn);
            this.panel.Controls.Add(this.lbFrn);
            this.panel.Controls.Add(this.tbTVA);
            this.panel.Controls.Add(this.lbPrixAchat);
            this.panel.Controls.Add(this.tbPrixAchat);
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
            // cbIDCommandeFrn
            // 
            this.cbIDCommandeFrn.FormattingEnabled = true;
            this.cbIDCommandeFrn.Location = new System.Drawing.Point(232, 61);
            this.cbIDCommandeFrn.Name = "cbIDCommandeFrn";
            this.cbIDCommandeFrn.Size = new System.Drawing.Size(184, 21);
            this.cbIDCommandeFrn.TabIndex = 34;
            this.cbIDCommandeFrn.SelectedIndexChanged += new System.EventHandler(this.tbIDCommandeFrn_SelectedIndexChanged);
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
            // lbIDdetailAchat
            // 
            this.lbIDdetailAchat.AutoSize = true;
            this.lbIDdetailAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDdetailAchat.Location = new System.Drawing.Point(110, 33);
            this.lbIDdetailAchat.Name = "lbIDdetailAchat";
            this.lbIDdetailAchat.Size = new System.Drawing.Size(112, 20);
            this.lbIDdetailAchat.TabIndex = 4;
            this.lbIDdetailAchat.Text = "ID detail achat";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(232, 113);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(184, 20);
            this.tbStock.TabIndex = 5;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(92, 113);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(134, 20);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Quantité en stock";
            // 
            // lbIDcmdFrn
            // 
            this.lbIDcmdFrn.AutoSize = true;
            this.lbIDcmdFrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDcmdFrn.Location = new System.Drawing.Point(90, 61);
            this.lbIDcmdFrn.Name = "lbIDcmdFrn";
            this.lbIDcmdFrn.Size = new System.Drawing.Size(132, 20);
            this.lbIDcmdFrn.TabIndex = 5;
            this.lbIDcmdFrn.Text = "ID commande frn";
            // 
            // lbFrn
            // 
            this.lbFrn.AutoSize = true;
            this.lbFrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrn.Location = new System.Drawing.Point(143, 87);
            this.lbFrn.Name = "lbFrn";
            this.lbFrn.Size = new System.Drawing.Size(79, 20);
            this.lbFrn.TabIndex = 6;
            this.lbFrn.Text = "ID produit";
            // 
            // tbTVA
            // 
            this.tbTVA.Location = new System.Drawing.Point(232, 165);
            this.tbTVA.Name = "tbTVA";
            this.tbTVA.Size = new System.Drawing.Size(184, 20);
            this.tbTVA.TabIndex = 4;
            // 
            // lbPrixAchat
            // 
            this.lbPrixAchat.AutoSize = true;
            this.lbPrixAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixAchat.Location = new System.Drawing.Point(136, 139);
            this.lbPrixAchat.Name = "lbPrixAchat";
            this.lbPrixAchat.Size = new System.Drawing.Size(90, 20);
            this.lbPrixAchat.TabIndex = 7;
            this.lbPrixAchat.Text = "Prix d\'achat";
            // 
            // tbPrixAchat
            // 
            this.tbPrixAchat.Location = new System.Drawing.Point(232, 139);
            this.tbPrixAchat.Name = "tbPrixAchat";
            this.tbPrixAchat.Size = new System.Drawing.Size(184, 20);
            this.tbPrixAchat.TabIndex = 3;
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVA.Location = new System.Drawing.Point(158, 165);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(68, 20);
            this.lbTVA.TabIndex = 9;
            this.lbTVA.Text = "TVA (%)";
            // 
            // ID_detail_articles
            // 
            this.ID_detail_articles.DataPropertyName = "ID_detail_articles";
            this.ID_detail_articles.HeaderText = "ID_detail_articles";
            this.ID_detail_articles.Name = "ID_detail_articles";
            this.ID_detail_articles.ReadOnly = true;
            // 
            // ID_commandes_frn
            // 
            this.ID_commandes_frn.DataPropertyName = "ID_commandes_frn";
            this.ID_commandes_frn.HeaderText = "ID_commandes_frn";
            this.ID_commandes_frn.Name = "ID_commandes_frn";
            this.ID_commandes_frn.ReadOnly = true;
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
            // 
            // EncoderFactureFrn2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 722);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.lbDetailAchat);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "EncoderFactureFrn2";
            this.Text = "Enocoder une fcature fournisseur";
            this.Load += new System.EventHandler(this.EncoderFactureFrn_Load);
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
        private System.Windows.Forms.Label lbDetailAchat;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbEncoderArticle;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbIDdetailAchat;
        private System.Windows.Forms.Label lbIDcmdFrn;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label lbFrn;
        private System.Windows.Forms.TextBox tbTVA;
        private System.Windows.Forms.Label lbPrixAchat;
        private System.Windows.Forms.TextBox tbPrixAchat;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbTVA;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbIDCommandeFrn;
        private System.Windows.Forms.ComboBox cbIDproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_detail_articles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_commandes_frn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
    }
}