﻿
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
            this.tbSeuilStock = new System.Windows.Forms.TextBox();
            this.lbSeuilStock = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.lbPrixVente = new System.Windows.Forms.Label();
            this.tbTVA = new System.Windows.Forms.TextBox();
            this.lbPrixAchat = new System.Windows.Forms.Label();
            this.tbPrixAchat = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.tbPrixVente = new System.Windows.Forms.TextBox();
            this.lbTVA = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvAjoutArticles = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjoutArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tbSeuilStock);
            this.panel.Controls.Add(this.lbSeuilStock);
            this.panel.Controls.Add(this.tbID);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.lbID);
            this.panel.Controls.Add(this.lbNom);
            this.panel.Controls.Add(this.tbStock);
            this.panel.Controls.Add(this.lbPrixVente);
            this.panel.Controls.Add(this.tbTVA);
            this.panel.Controls.Add(this.lbPrixAchat);
            this.panel.Controls.Add(this.tbPrixAchat);
            this.panel.Controls.Add(this.lbStock);
            this.panel.Controls.Add(this.tbPrixVente);
            this.panel.Controls.Add(this.lbTVA);
            this.panel.Controls.Add(this.tbNom);
            this.panel.Location = new System.Drawing.Point(296, 345);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(331, 213);
            this.panel.TabIndex = 23;
            // 
            // tbSeuilStock
            // 
            this.tbSeuilStock.Location = new System.Drawing.Point(144, 159);
            this.tbSeuilStock.Name = "tbSeuilStock";
            this.tbSeuilStock.Size = new System.Drawing.Size(184, 20);
            this.tbSeuilStock.TabIndex = 6;
            // 
            // lbSeuilStock
            // 
            this.lbSeuilStock.AutoSize = true;
            this.lbSeuilStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeuilStock.Location = new System.Drawing.Point(30, 159);
            this.lbSeuilStock.Name = "lbSeuilStock";
            this.lbSeuilStock.Size = new System.Drawing.Size(108, 20);
            this.lbSeuilStock.TabIndex = 18;
            this.lbSeuilStock.Text = "Seuil de stock";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(144, 3);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(184, 20);
            this.tbID.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(215, 190);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(52, 190);
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
            this.lbID.Location = new System.Drawing.Point(112, 3);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 20);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(22, 29);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(116, 20);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nom de l\'article";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(144, 133);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(184, 20);
            this.tbStock.TabIndex = 5;
            // 
            // lbPrixVente
            // 
            this.lbPrixVente.AutoSize = true;
            this.lbPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixVente.Location = new System.Drawing.Point(39, 55);
            this.lbPrixVente.Name = "lbPrixVente";
            this.lbPrixVente.Size = new System.Drawing.Size(99, 20);
            this.lbPrixVente.TabIndex = 6;
            this.lbPrixVente.Text = "Prix de vente";
            // 
            // tbTVA
            // 
            this.tbTVA.Location = new System.Drawing.Point(144, 107);
            this.tbTVA.Name = "tbTVA";
            this.tbTVA.Size = new System.Drawing.Size(184, 20);
            this.tbTVA.TabIndex = 4;
            // 
            // lbPrixAchat
            // 
            this.lbPrixAchat.AutoSize = true;
            this.lbPrixAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixAchat.Location = new System.Drawing.Point(48, 81);
            this.lbPrixAchat.Name = "lbPrixAchat";
            this.lbPrixAchat.Size = new System.Drawing.Size(90, 20);
            this.lbPrixAchat.TabIndex = 7;
            this.lbPrixAchat.Text = "Prix d\'achat";
            // 
            // tbPrixAchat
            // 
            this.tbPrixAchat.Location = new System.Drawing.Point(144, 81);
            this.tbPrixAchat.Name = "tbPrixAchat";
            this.tbPrixAchat.Size = new System.Drawing.Size(184, 20);
            this.tbPrixAchat.TabIndex = 3;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(4, 133);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(134, 20);
            this.lbStock.TabIndex = 8;
            this.lbStock.Text = "Quantité en stock";
            // 
            // tbPrixVente
            // 
            this.tbPrixVente.Location = new System.Drawing.Point(144, 55);
            this.tbPrixVente.Name = "tbPrixVente";
            this.tbPrixVente.Size = new System.Drawing.Size(184, 20);
            this.tbPrixVente.TabIndex = 2;
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVA.Location = new System.Drawing.Point(70, 107);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(68, 20);
            this.lbTVA.TabIndex = 9;
            this.lbTVA.Text = "TVA (%)";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(144, 29);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(184, 20);
            this.tbNom.TabIndex = 1;
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
            // dgvAjoutArticles
            // 
            this.dgvAjoutArticles.AllowUserToAddRows = false;
            this.dgvAjoutArticles.AllowUserToDeleteRows = false;
            this.dgvAjoutArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjoutArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNom,
            this.cPrixAchat,
            this.prixVente,
            this.cTVA,
            this.cQteStock,
            this.Quantite});
            this.dgvAjoutArticles.Location = new System.Drawing.Point(5, 8);
            this.dgvAjoutArticles.Name = "dgvAjoutArticles";
            this.dgvAjoutArticles.ReadOnly = true;
            this.dgvAjoutArticles.RowHeadersVisible = false;
            this.dgvAjoutArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAjoutArticles.Size = new System.Drawing.Size(622, 328);
            this.dgvAjoutArticles.TabIndex = 19;
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
            // AjouterAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvAjoutArticles);
            this.Name = "AjouterAchat";
            this.Text = "AjouterAchat";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjoutArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tbSeuilStock;
        private System.Windows.Forms.Label lbSeuilStock;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label lbPrixVente;
        private System.Windows.Forms.TextBox tbTVA;
        private System.Windows.Forms.Label lbPrixAchat;
        private System.Windows.Forms.TextBox tbPrixAchat;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox tbPrixVente;
        private System.Windows.Forms.Label lbTVA;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvAjoutArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
    }
}