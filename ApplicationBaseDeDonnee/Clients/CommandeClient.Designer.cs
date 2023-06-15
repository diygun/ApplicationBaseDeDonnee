
namespace ApplicationBaseDeDonnee
{
    partial class CommandeClient
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
            this.panelCmdClient = new System.Windows.Forms.Panel();
            this.tbIDCmdClient = new System.Windows.Forms.TextBox();
            this.cbIDClient = new System.Windows.Forms.ComboBox();
            this.dtpCmd = new System.Windows.Forms.DateTimePicker();
            this.lbIDCmdClient = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lbDateCmd = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panelClient = new System.Windows.Forms.Panel();
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvCmdClient = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dtpVente = new System.Windows.Forms.DateTimePicker();
            this.lbDateVente = new System.Windows.Forms.Label();
            this.panelCmdClient.SuspendLayout();
            this.panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCmdClient
            // 
            this.panelCmdClient.Controls.Add(this.dtpVente);
            this.panelCmdClient.Controls.Add(this.lbDateVente);
            this.panelCmdClient.Controls.Add(this.tbIDCmdClient);
            this.panelCmdClient.Controls.Add(this.cbIDClient);
            this.panelCmdClient.Controls.Add(this.dtpCmd);
            this.panelCmdClient.Controls.Add(this.lbIDCmdClient);
            this.panelCmdClient.Controls.Add(this.btnAnnuler);
            this.panelCmdClient.Controls.Add(this.btnConfirmer);
            this.panelCmdClient.Controls.Add(this.lbDateCmd);
            this.panelCmdClient.Controls.Add(this.lbID);
            this.panelCmdClient.Location = new System.Drawing.Point(406, 370);
            this.panelCmdClient.Name = "panelCmdClient";
            this.panelCmdClient.Size = new System.Drawing.Size(460, 179);
            this.panelCmdClient.TabIndex = 34;
            // 
            // tbIDCmdClient
            // 
            this.tbIDCmdClient.Location = new System.Drawing.Point(273, 5);
            this.tbIDCmdClient.Name = "tbIDCmdClient";
            this.tbIDCmdClient.ReadOnly = true;
            this.tbIDCmdClient.Size = new System.Drawing.Size(184, 20);
            this.tbIDCmdClient.TabIndex = 29;
            // 
            // cbIDClient
            // 
            this.cbIDClient.FormattingEnabled = true;
            this.cbIDClient.Location = new System.Drawing.Point(273, 100);
            this.cbIDClient.Name = "cbIDClient";
            this.cbIDClient.Size = new System.Drawing.Size(184, 21);
            this.cbIDClient.TabIndex = 30;
            this.cbIDClient.SelectedIndexChanged += new System.EventHandler(this.cbIDClient_SelectedIndexChanged);
            // 
            // dtpCmd
            // 
            this.dtpCmd.Location = new System.Drawing.Point(273, 30);
            this.dtpCmd.Name = "dtpCmd";
            this.dtpCmd.Size = new System.Drawing.Size(184, 20);
            this.dtpCmd.TabIndex = 29;
            // 
            // lbIDCmdClient
            // 
            this.lbIDCmdClient.AutoSize = true;
            this.lbIDCmdClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCmdClient.Location = new System.Drawing.Point(67, 5);
            this.lbIDCmdClient.Name = "lbIDCmdClient";
            this.lbIDCmdClient.Size = new System.Drawing.Size(194, 20);
            this.lbIDCmdClient.TabIndex = 4;
            this.lbIDCmdClient.Text = "ID de la Commande Client";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(344, 144);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(181, 144);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(113, 20);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
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
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(148, 101);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(70, 20);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "ID Client";
            // 
            // panelClient
            // 
            this.panelClient.Controls.Add(this.tbNmCompte);
            this.panelClient.Controls.Add(this.tbGSM);
            this.panelClient.Controls.Add(this.lbNom);
            this.panelClient.Controls.Add(this.lbAdresse);
            this.panelClient.Controls.Add(this.lbEmail);
            this.panelClient.Controls.Add(this.tbEmail);
            this.panelClient.Controls.Add(this.lbNmCompte);
            this.panelClient.Controls.Add(this.tbAdresse);
            this.panelClient.Controls.Add(this.lbGSM);
            this.panelClient.Controls.Add(this.tbNom);
            this.panelClient.Location = new System.Drawing.Point(492, 29);
            this.panelClient.Name = "panelClient";
            this.panelClient.Size = new System.Drawing.Size(374, 129);
            this.panelClient.TabIndex = 33;
            // 
            // tbNmCompte
            // 
            this.tbNmCompte.Location = new System.Drawing.Point(186, 104);
            this.tbNmCompte.Name = "tbNmCompte";
            this.tbNmCompte.ReadOnly = true;
            this.tbNmCompte.Size = new System.Drawing.Size(184, 20);
            this.tbNmCompte.TabIndex = 11;
            // 
            // tbGSM
            // 
            this.tbGSM.Location = new System.Drawing.Point(186, 78);
            this.tbGSM.Name = "tbGSM";
            this.tbGSM.ReadOnly = true;
            this.tbGSM.Size = new System.Drawing.Size(184, 20);
            this.tbGSM.TabIndex = 10;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(28, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(105, 20);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nom du client";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(2, 26);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(131, 20);
            this.lbAdresse.TabIndex = 6;
            this.lbAdresse.Text = "Adresse du client";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(124, 52);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "e-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(186, 52);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(184, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // lbNmCompte
            // 
            this.lbNmCompte.AutoSize = true;
            this.lbNmCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNmCompte.Location = new System.Drawing.Point(31, 104);
            this.lbNmCompte.Name = "lbNmCompte";
            this.lbNmCompte.Size = new System.Drawing.Size(144, 20);
            this.lbNmCompte.TabIndex = 8;
            this.lbNmCompte.Text = "Numéro de compte";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(186, 26);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.ReadOnly = true;
            this.tbAdresse.Size = new System.Drawing.Size(184, 20);
            this.tbAdresse.TabIndex = 2;
            // 
            // lbGSM
            // 
            this.lbGSM.AutoSize = true;
            this.lbGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGSM.Location = new System.Drawing.Point(129, 78);
            this.lbGSM.Name = "lbGSM";
            this.lbGSM.Size = new System.Drawing.Size(46, 20);
            this.lbGSM.TabIndex = 9;
            this.lbGSM.Text = "GSM";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(186, 0);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(184, 20);
            this.tbNom.TabIndex = 1;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(19, 390);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 29);
            this.btnModifier.TabIndex = 32;
            this.btnModifier.Text = "Modifier la commande client";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(19, 425);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 29);
            this.btnSupprimer.TabIndex = 31;
            this.btnSupprimer.Text = "Supprimer la commande fourniseur";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dgvCmdClient
            // 
            this.dgvCmdClient.AllowUserToAddRows = false;
            this.dgvCmdClient.AllowUserToDeleteRows = false;
            this.dgvCmdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cIDClient,
            this.Nom,
            this.cDateCommande});
            this.dgvCmdClient.Location = new System.Drawing.Point(12, 12);
            this.dgvCmdClient.Name = "dgvCmdClient";
            this.dgvCmdClient.ReadOnly = true;
            this.dgvCmdClient.RowHeadersVisible = false;
            this.dgvCmdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdClient.Size = new System.Drawing.Size(425, 328);
            this.dgvCmdClient.TabIndex = 29;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "cID";
            this.cID.HeaderText = "N° commande";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cID.Width = 85;
            // 
            // cIDClient
            // 
            this.cIDClient.DataPropertyName = "IDClient";
            this.cIDClient.HeaderText = "N° Client";
            this.cIDClient.Name = "cIDClient";
            this.cIDClient.ReadOnly = true;
            this.cIDClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIDClient.Width = 85;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(19, 352);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 29);
            this.btnAjouter.TabIndex = 30;
            this.btnAjouter.Text = "Ajouter une commande client";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dtpVente
            // 
            this.dtpVente.Location = new System.Drawing.Point(273, 58);
            this.dtpVente.Name = "dtpVente";
            this.dtpVente.Size = new System.Drawing.Size(184, 20);
            this.dtpVente.TabIndex = 32;
            // 
            // lbDateVente
            // 
            this.lbDateVente.AutoSize = true;
            this.lbDateVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateVente.Location = new System.Drawing.Point(97, 58);
            this.lbDateVente.Name = "lbDateVente";
            this.lbDateVente.Size = new System.Drawing.Size(165, 20);
            this.lbDateVente.TabIndex = 31;
            this.lbDateVente.Text = "Date de la commande";
            // 
            // CommandeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 561);
            this.Controls.Add(this.panelCmdClient);
            this.Controls.Add(this.panelClient);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dgvCmdClient);
            this.Controls.Add(this.btnAjouter);
            this.Name = "CommandeClient";
            this.Text = "Commandes Client";
            this.panelCmdClient.ResumeLayout(false);
            this.panelCmdClient.PerformLayout();
            this.panelClient.ResumeLayout(false);
            this.panelClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCmdClient;
        private System.Windows.Forms.TextBox tbIDCmdClient;
        private System.Windows.Forms.ComboBox cbIDClient;
        private System.Windows.Forms.DateTimePicker dtpCmd;
        private System.Windows.Forms.Label lbIDCmdClient;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lbDateCmd;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel panelClient;
        private System.Windows.Forms.TextBox tbNmCompte;
        private System.Windows.Forms.TextBox tbGSM;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNmCompte;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label lbGSM;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridView dgvCmdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateCommande;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dtpVente;
        private System.Windows.Forms.Label lbDateVente;
    }
}