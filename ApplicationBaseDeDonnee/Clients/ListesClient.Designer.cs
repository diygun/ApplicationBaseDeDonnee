
namespace ApplicationBaseDeDonnee
{
    partial class ListesClient
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
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tbGSM = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lbGSM = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNom,
            this.cAdresse,
            this.email,
            this.GSM});
            this.dgvClient.Location = new System.Drawing.Point(5, 3);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(661, 328);
            this.dgvClient.TabIndex = 11;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 375);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 29);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier le client";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 410);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 29);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer le client";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 337);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 29);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter un client";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tbGSM);
            this.panel.Controls.Add(this.tbID);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.lbID);
            this.panel.Controls.Add(this.lbNom);
            this.panel.Controls.Add(this.lbAdresse);
            this.panel.Controls.Add(this.lbEmail);
            this.panel.Controls.Add(this.tbEmail);
            this.panel.Controls.Add(this.tbAdresse);
            this.panel.Controls.Add(this.lbGSM);
            this.panel.Controls.Add(this.tbNom);
            this.panel.Location = new System.Drawing.Point(218, 337);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(338, 213);
            this.panel.TabIndex = 26;
            // 
            // tbGSM
            // 
            this.tbGSM.Location = new System.Drawing.Point(149, 107);
            this.tbGSM.Name = "tbGSM";
            this.tbGSM.Size = new System.Drawing.Size(184, 20);
            this.tbGSM.TabIndex = 4;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(149, 3);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(184, 20);
            this.tbID.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(220, 150);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(57, 150);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(113, 20);
            this.btnConfirmer.TabIndex = 5;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
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
            this.lbNom.Location = new System.Drawing.Point(33, 29);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(105, 20);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nom du client";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(7, 55);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(131, 20);
            this.lbAdresse.TabIndex = 6;
            this.lbAdresse.Text = "Adresse du client";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(87, 81);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "e-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(149, 81);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(184, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(149, 55);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(184, 20);
            this.tbAdresse.TabIndex = 2;
            // 
            // lbGSM
            // 
            this.lbGSM.AutoSize = true;
            this.lbGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGSM.Location = new System.Drawing.Point(92, 107);
            this.lbGSM.Name = "lbGSM";
            this.lbGSM.Size = new System.Drawing.Size(46, 20);
            this.lbGSM.TabIndex = 9;
            this.lbGSM.Text = "GSM";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(149, 29);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(184, 20);
            this.tbNom.TabIndex = 1;
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
            this.cNom.Width = 125;
            // 
            // cAdresse
            // 
            this.cAdresse.DataPropertyName = "adresse";
            this.cAdresse.HeaderText = "Adresse";
            this.cAdresse.Name = "cAdresse";
            this.cAdresse.ReadOnly = true;
            this.cAdresse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cAdresse.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.email.Width = 155;
            // 
            // GSM
            // 
            this.GSM.DataPropertyName = "GSM";
            this.GSM.HeaderText = "GSM";
            this.GSM.Name = "GSM";
            this.GSM.ReadOnly = true;
            this.GSM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GSM.Width = 115;
            // 
            // ListesClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvClient);
            this.Name = "ListesClient";
            this.Text = "Listes des clients";
            this.Load += new System.EventHandler(this.ListesClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSM;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tbGSM;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label lbGSM;
        private System.Windows.Forms.TextBox tbNom;
    }
}