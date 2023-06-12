
namespace ApplicationBaseDeDonnee
{
    partial class AjouterAchat
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
            this.panel = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNumCommandeFrn = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvAjoutAchat = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNumCommandeFrn = new System.Windows.Forms.ComboBox();
            this.cbNomProduit = new System.Windows.Forms.ComboBox();
            this.lbProduit = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbTVA = new System.Windows.Forms.TextBox();
            this.lbPrixAchat = new System.Windows.Forms.Label();
            this.tbPrixAchat = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbTVA = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjoutAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tbStock);
            this.panel.Controls.Add(this.lbProduit);
            this.panel.Controls.Add(this.tbTVA);
            this.panel.Controls.Add(this.cbNomProduit);
            this.panel.Controls.Add(this.lbPrixAchat);
            this.panel.Controls.Add(this.tbPrixAchat);
            this.panel.Controls.Add(this.cbNumCommandeFrn);
            this.panel.Controls.Add(this.lbStock);
            this.panel.Controls.Add(this.lbTVA);
            this.panel.Controls.Add(this.tbID);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.lbID);
            this.panel.Controls.Add(this.lbNumCommandeFrn);
            this.panel.Location = new System.Drawing.Point(178, 345);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(449, 213);
            this.panel.TabIndex = 23;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(253, 6);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(184, 20);
            this.tbID.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(324, 184);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(161, 184);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(113, 20);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(221, 6);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 20);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID";
            // 
            // lbNumCommandeFrn
            // 
            this.lbNumCommandeFrn.AutoSize = true;
            this.lbNumCommandeFrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumCommandeFrn.Location = new System.Drawing.Point(57, 33);
            this.lbNumCommandeFrn.Name = "lbNumCommandeFrn";
            this.lbNumCommandeFrn.Size = new System.Drawing.Size(190, 20);
            this.lbNumCommandeFrn.TabIndex = 5;
            this.lbNumCommandeFrn.Text = "Numéro de la commande ";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 415);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 29);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.Text = "Supprimer l\'article";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 380);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(113, 29);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "Modifier l\'article";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 345);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 29);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter un article";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // dgvAjoutAchat
            // 
            this.dgvAjoutAchat.AllowUserToAddRows = false;
            this.dgvAjoutAchat.AllowUserToDeleteRows = false;
            this.dgvAjoutAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjoutAchat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNom,
            this.cPrixAchat,
            this.prixVente,
            this.cTVA,
            this.cQteStock,
            this.Quantite});
            this.dgvAjoutAchat.Location = new System.Drawing.Point(5, 8);
            this.dgvAjoutAchat.Name = "dgvAjoutAchat";
            this.dgvAjoutAchat.ReadOnly = true;
            this.dgvAjoutAchat.RowHeadersVisible = false;
            this.dgvAjoutAchat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAjoutAchat.Size = new System.Drawing.Size(622, 328);
            this.dgvAjoutAchat.TabIndex = 19;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cID.Width = 30;
            // 
            // cNom
            // 
            this.cNom.DataPropertyName = "Nom";
            this.cNom.HeaderText = "Nom";
            this.cNom.Name = "cNom";
            this.cNom.ReadOnly = true;
            this.cNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cPrixAchat
            // 
            this.cPrixAchat.DataPropertyName = "prixAchat";
            this.cPrixAchat.HeaderText = "Prix d\'achat";
            this.cPrixAchat.Name = "cPrixAchat";
            this.cPrixAchat.ReadOnly = true;
            this.cPrixAchat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prixVente
            // 
            this.prixVente.DataPropertyName = "prixVente";
            this.prixVente.HeaderText = "Prix de vente";
            this.prixVente.Name = "prixVente";
            this.prixVente.ReadOnly = true;
            this.prixVente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cTVA
            // 
            this.cTVA.DataPropertyName = "TVA";
            this.cTVA.HeaderText = "T.V.A.";
            this.cTVA.Name = "cTVA";
            this.cTVA.ReadOnly = true;
            this.cTVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTVA.Width = 45;
            // 
            // cQteStock
            // 
            this.cQteStock.DataPropertyName = "qteStock";
            this.cQteStock.HeaderText = "Quantite en stock";
            this.cQteStock.Name = "cQteStock";
            this.cQteStock.ReadOnly = true;
            this.cQteStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "seuilStock";
            this.Quantite.HeaderText = "Seuil de stock";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            this.Quantite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbNumCommandeFrn
            // 
            this.cbNumCommandeFrn.FormattingEnabled = true;
            this.cbNumCommandeFrn.Location = new System.Drawing.Point(253, 32);
            this.cbNumCommandeFrn.Name = "cbNumCommandeFrn";
            this.cbNumCommandeFrn.Size = new System.Drawing.Size(184, 21);
            this.cbNumCommandeFrn.TabIndex = 24;
            // 
            // cbNomProduit
            // 
            this.cbNomProduit.FormattingEnabled = true;
            this.cbNomProduit.Location = new System.Drawing.Point(253, 59);
            this.cbNomProduit.Name = "cbNomProduit";
            this.cbNomProduit.Size = new System.Drawing.Size(184, 21);
            this.cbNomProduit.TabIndex = 25;
            // 
            // lbProduit
            // 
            this.lbProduit.AutoSize = true;
            this.lbProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduit.Location = new System.Drawing.Point(131, 60);
            this.lbProduit.Name = "lbProduit";
            this.lbProduit.Size = new System.Drawing.Size(116, 20);
            this.lbProduit.TabIndex = 26;
            this.lbProduit.Text = "Nom de l\'article";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(253, 86);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(184, 20);
            this.tbStock.TabIndex = 26;
            // 
            // tbTVA
            // 
            this.tbTVA.Location = new System.Drawing.Point(253, 138);
            this.tbTVA.Name = "tbTVA";
            this.tbTVA.Size = new System.Drawing.Size(184, 20);
            this.tbTVA.TabIndex = 25;
            // 
            // lbPrixAchat
            // 
            this.lbPrixAchat.AutoSize = true;
            this.lbPrixAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixAchat.Location = new System.Drawing.Point(157, 112);
            this.lbPrixAchat.Name = "lbPrixAchat";
            this.lbPrixAchat.Size = new System.Drawing.Size(90, 20);
            this.lbPrixAchat.TabIndex = 27;
            this.lbPrixAchat.Text = "Prix d\'achat";
            // 
            // tbPrixAchat
            // 
            this.tbPrixAchat.Location = new System.Drawing.Point(253, 112);
            this.tbPrixAchat.Name = "tbPrixAchat";
            this.tbPrixAchat.Size = new System.Drawing.Size(184, 20);
            this.tbPrixAchat.TabIndex = 24;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(113, 86);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(134, 20);
            this.lbStock.TabIndex = 28;
            this.lbStock.Text = "Quantité en stock";
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVA.Location = new System.Drawing.Point(179, 138);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(68, 20);
            this.lbTVA.TabIndex = 29;
            this.lbTVA.Text = "TVA (%)";
            // 
            // AjouterAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvAjoutAchat);
            this.Name = "AjouterAchat";
            this.Text = "AjouterAchat";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjoutAchat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNumCommandeFrn;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvAjoutAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.ComboBox cbNumCommandeFrn;
        private System.Windows.Forms.Label lbProduit;
        private System.Windows.Forms.ComboBox cbNomProduit;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbTVA;
        private System.Windows.Forms.Label lbPrixAchat;
        private System.Windows.Forms.TextBox tbPrixAchat;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbTVA;
    }
}