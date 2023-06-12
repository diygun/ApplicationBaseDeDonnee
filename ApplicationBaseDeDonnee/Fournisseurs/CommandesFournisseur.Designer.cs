
namespace ApplicationBaseDeDonnee
{
    partial class CommandesFournisseur
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
            this.dgvCmdFrn = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDFrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panelFrn = new System.Windows.Forms.Panel();
            this.tbNmCompte = new System.Windows.Forms.TextBox();
            this.tbGSM = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNmCompte = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.lbGSM = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.panelCmdFrn = new System.Windows.Forms.Panel();
            this.cbIDFRn = new System.Windows.Forms.ComboBox();
            this.dtpCmd = new System.Windows.Forms.DateTimePicker();
            this.tbIDCmdFrn = new System.Windows.Forms.TextBox();
            this.lbIDCmdFrn = new System.Windows.Forms.Label();
            this.lbDateCmd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdFrn)).BeginInit();
            this.panelFrn.SuspendLayout();
            this.panelCmdFrn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCmdFrn
            // 
            this.dgvCmdFrn.AllowUserToAddRows = false;
            this.dgvCmdFrn.AllowUserToDeleteRows = false;
            this.dgvCmdFrn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdFrn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cIDFrn,
            this.cDateCommande});
            this.dgvCmdFrn.Location = new System.Drawing.Point(5, 12);
            this.dgvCmdFrn.Name = "dgvCmdFrn";
            this.dgvCmdFrn.ReadOnly = true;
            this.dgvCmdFrn.RowHeadersVisible = false;
            this.dgvCmdFrn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdFrn.Size = new System.Drawing.Size(371, 328);
            this.dgvCmdFrn.TabIndex = 1;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "ID Commande";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIDFrn
            // 
            this.cIDFrn.DataPropertyName = "IDFournisseur";
            this.cIDFrn.HeaderText = "ID Fournisseur";
            this.cIDFrn.Name = "cIDFrn";
            this.cIDFrn.ReadOnly = true;
            this.cIDFrn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cDateCommande
            // 
            this.cDateCommande.DataPropertyName = "dateCommande";
            this.cDateCommande.HeaderText = "Date de la commande";
            this.cDateCommande.Name = "cDateCommande";
            this.cDateCommande.ReadOnly = true;
            this.cDateCommande.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDateCommande.Width = 150;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 390);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 29);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier la commande fournisseur";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 425);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 29);
            this.btnSupprimer.TabIndex = 24;
            this.btnSupprimer.Text = "Supprimer la commande fourniseur";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 352);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 29);
            this.btnAjouter.TabIndex = 23;
            this.btnAjouter.Text = "Ajouter une commande fournisseur";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panelFrn
            // 
            this.panelFrn.Controls.Add(this.tbNmCompte);
            this.panelFrn.Controls.Add(this.tbGSM);
            this.panelFrn.Controls.Add(this.lbNom);
            this.panelFrn.Controls.Add(this.lbAdresse);
            this.panelFrn.Controls.Add(this.lbEmail);
            this.panelFrn.Controls.Add(this.tbEmail);
            this.panelFrn.Controls.Add(this.lbNmCompte);
            this.panelFrn.Controls.Add(this.tbAdresse);
            this.panelFrn.Controls.Add(this.lbGSM);
            this.panelFrn.Controls.Add(this.tbNom);
            this.panelFrn.Location = new System.Drawing.Point(382, 35);
            this.panelFrn.Name = "panelFrn";
            this.panelFrn.Size = new System.Drawing.Size(411, 134);
            this.panelFrn.TabIndex = 27;
            // 
            // tbNmCompte
            // 
            this.tbNmCompte.Location = new System.Drawing.Point(224, 107);
            this.tbNmCompte.Name = "tbNmCompte";
            this.tbNmCompte.ReadOnly = true;
            this.tbNmCompte.Size = new System.Drawing.Size(184, 20);
            this.tbNmCompte.TabIndex = 11;
            // 
            // tbGSM
            // 
            this.tbGSM.Location = new System.Drawing.Point(224, 81);
            this.tbGSM.Name = "tbGSM";
            this.tbGSM.ReadOnly = true;
            this.tbGSM.Size = new System.Drawing.Size(184, 20);
            this.tbGSM.TabIndex = 10;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(66, 3);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(147, 20);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nom du fournisseur";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(40, 29);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(173, 20);
            this.lbAdresse.TabIndex = 6;
            this.lbAdresse.Text = "Adresse du fournisseur";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(162, 55);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "e-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(224, 55);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(184, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // lbNmCompte
            // 
            this.lbNmCompte.AutoSize = true;
            this.lbNmCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNmCompte.Location = new System.Drawing.Point(69, 107);
            this.lbNmCompte.Name = "lbNmCompte";
            this.lbNmCompte.Size = new System.Drawing.Size(144, 20);
            this.lbNmCompte.TabIndex = 8;
            this.lbNmCompte.Text = "Numéro de compte";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(224, 29);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.ReadOnly = true;
            this.tbAdresse.Size = new System.Drawing.Size(184, 20);
            this.tbAdresse.TabIndex = 2;
            // 
            // lbGSM
            // 
            this.lbGSM.AutoSize = true;
            this.lbGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGSM.Location = new System.Drawing.Point(167, 81);
            this.lbGSM.Name = "lbGSM";
            this.lbGSM.Size = new System.Drawing.Size(46, 20);
            this.lbGSM.TabIndex = 9;
            this.lbGSM.Text = "GSM";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(224, 3);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(184, 20);
            this.tbNom.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(344, 103);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(181, 103);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(113, 20);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(148, 60);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(114, 20);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID Fournisseur";
            // 
            // panelCmdFrn
            // 
            this.panelCmdFrn.Controls.Add(this.cbIDFRn);
            this.panelCmdFrn.Controls.Add(this.dtpCmd);
            this.panelCmdFrn.Controls.Add(this.tbIDCmdFrn);
            this.panelCmdFrn.Controls.Add(this.lbIDCmdFrn);
            this.panelCmdFrn.Controls.Add(this.btnAnnuler);
            this.panelCmdFrn.Controls.Add(this.btnConfirmer);
            this.panelCmdFrn.Controls.Add(this.lbDateCmd);
            this.panelCmdFrn.Controls.Add(this.lbID);
            this.panelCmdFrn.Location = new System.Drawing.Point(333, 390);
            this.panelCmdFrn.Name = "panelCmdFrn";
            this.panelCmdFrn.Size = new System.Drawing.Size(460, 136);
            this.panelCmdFrn.TabIndex = 28;
            // 
            // cbIDFRn
            // 
            this.cbIDFRn.FormattingEnabled = true;
            this.cbIDFRn.Location = new System.Drawing.Point(273, 59);
            this.cbIDFRn.Name = "cbIDFRn";
            this.cbIDFRn.Size = new System.Drawing.Size(184, 21);
            this.cbIDFRn.TabIndex = 30;
            this.cbIDFRn.SelectedIndexChanged += new System.EventHandler(this.cbIDFRn_SelectedIndexChanged);
            // 
            // dtpCmd
            // 
            this.dtpCmd.Location = new System.Drawing.Point(273, 30);
            this.dtpCmd.Name = "dtpCmd";
            this.dtpCmd.Size = new System.Drawing.Size(184, 20);
            this.dtpCmd.TabIndex = 29;
            // 
            // tbIDCmdFrn
            // 
            this.tbIDCmdFrn.Location = new System.Drawing.Point(273, 5);
            this.tbIDCmdFrn.Name = "tbIDCmdFrn";
            this.tbIDCmdFrn.ReadOnly = true;
            this.tbIDCmdFrn.Size = new System.Drawing.Size(184, 20);
            this.tbIDCmdFrn.TabIndex = 0;
            // 
            // lbIDCmdFrn
            // 
            this.lbIDCmdFrn.AutoSize = true;
            this.lbIDCmdFrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCmdFrn.Location = new System.Drawing.Point(24, 5);
            this.lbIDCmdFrn.Name = "lbIDCmdFrn";
            this.lbIDCmdFrn.Size = new System.Drawing.Size(238, 20);
            this.lbIDCmdFrn.TabIndex = 4;
            this.lbIDCmdFrn.Text = "ID de la Commande Fournisseur";
            // 
            // lbDateCmd
            // 
            this.lbDateCmd.AutoSize = true;
            this.lbDateCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateCmd.Location = new System.Drawing.Point(97, 30);
            this.lbDateCmd.Name = "lbDateCmd";
            this.lbDateCmd.Size = new System.Drawing.Size(165, 20);
            this.lbDateCmd.TabIndex = 5;
            this.lbDateCmd.Text = "Date de la commande";
            // 
            // CommandesFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 561);
            this.Controls.Add(this.panelCmdFrn);
            this.Controls.Add(this.panelFrn);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvCmdFrn);
            this.Controls.Add(this.btnAjouter);
            this.Name = "CommandesFournisseur";
            this.Text = "Commandes Fournisseur";
            this.Load += new System.EventHandler(this.CommandesFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdFrn)).EndInit();
            this.panelFrn.ResumeLayout(false);
            this.panelFrn.PerformLayout();
            this.panelCmdFrn.ResumeLayout(false);
            this.panelCmdFrn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCmdFrn;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDFrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateCommande;
        private System.Windows.Forms.Panel panelFrn;
        private System.Windows.Forms.TextBox tbNmCompte;
        private System.Windows.Forms.TextBox tbGSM;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNmCompte;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label lbGSM;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Panel panelCmdFrn;
        private System.Windows.Forms.TextBox tbIDCmdFrn;
        private System.Windows.Forms.Label lbIDCmdFrn;
        private System.Windows.Forms.Label lbDateCmd;
        private System.Windows.Forms.DateTimePicker dtpCmd;
        private System.Windows.Forms.ComboBox cbIDFRn;
    }
}