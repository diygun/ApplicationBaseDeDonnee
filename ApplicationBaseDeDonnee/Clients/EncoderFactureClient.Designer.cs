
namespace ApplicationBaseDeDonnee.Clients
{
    partial class EncoderFactureClient
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFacturer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCmdFrn = new System.Windows.Forms.Panel();
            this.btnAjouterCommande = new System.Windows.Forms.Button();
            this.tbNomclient = new System.Windows.Forms.TextBox();
            this.lnNomFrn = new System.Windows.Forms.Label();
            this.btnAjouterUnClient = new System.Windows.Forms.Button();
            this.tbIDCmdClient = new System.Windows.Forms.TextBox();
            this.lbIDCmdFrn = new System.Windows.Forms.Label();
            this.tbIDClient = new System.Windows.Forms.TextBox();
            this.lnIDfrn = new System.Windows.Forms.Label();
            this.dgvCmdClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.cbIDproduit = new System.Windows.Forms.ComboBox();
            this.lbEncoderArticle = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.tbQtee = new System.Windows.Forms.TextBox();
            this.lbQte = new System.Windows.Forms.Label();
            this.lbIDclient = new System.Windows.Forms.Label();
            this.tbTVA = new System.Windows.Forms.TextBox();
            this.lbPrixVente = new System.Windows.Forms.Label();
            this.tbPrixVente = new System.Windows.Forms.TextBox();
            this.lbTVA = new System.Windows.Forms.Label();
            this.btnCalculeCaHebdo = new System.Windows.Forms.Button();
            this.lbCA = new System.Windows.Forms.Label();
            this.btnEtatStockHTML = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.panelCmdFrn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdClient)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Emettre une facture au client";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFacturer);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.dgvArticles);
            this.panel1.Location = new System.Drawing.Point(574, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 775);
            this.panel1.TabIndex = 35;
            // 
            // btnFacturer
            // 
            this.btnFacturer.Location = new System.Drawing.Point(448, 739);
            this.btnFacturer.Name = "btnFacturer";
            this.btnFacturer.Size = new System.Drawing.Size(140, 29);
            this.btnFacturer.TabIndex = 24;
            this.btnFacturer.Text = "Emettre la facture";
            this.btnFacturer.UseVisualStyleBackColor = true;
            this.btnFacturer.Click += new System.EventHandler(this.btnFacturer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(302, 739);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(140, 29);
            this.btnSupprimer.TabIndex = 23;
            this.btnSupprimer.Text = "Supprimer l\'article";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(156, 739);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 29);
            this.btnModifier.TabIndex = 22;
            this.btnModifier.Text = "Modifier l\'article";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(10, 739);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(140, 29);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter un article";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNom,
            this.prixVente,
            this.cTVA,
            this.cQteStock});
            this.dgvArticles.Location = new System.Drawing.Point(3, 7);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(612, 726);
            this.dgvArticles.TabIndex = 20;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "N°";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cNom
            // 
            this.cNom.DataPropertyName = "Nom";
            this.cNom.HeaderText = "Nom";
            this.cNom.Name = "cNom";
            this.cNom.ReadOnly = true;
            this.cNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNom.Width = 225;
            // 
            // prixVente
            // 
            this.prixVente.DataPropertyName = "prixVente";
            this.prixVente.HeaderText = "Prix de vente";
            this.prixVente.Name = "prixVente";
            this.prixVente.ReadOnly = true;
            this.prixVente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prixVente.Width = 175;
            // 
            // cTVA
            // 
            this.cTVA.DataPropertyName = "TVA";
            this.cTVA.HeaderText = "T.V.A.";
            this.cTVA.Name = "cTVA";
            this.cTVA.ReadOnly = true;
            this.cTVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cTVA.Width = 50;
            // 
            // cQteStock
            // 
            this.cQteStock.DataPropertyName = "qte";
            this.cQteStock.HeaderText = "Quantite";
            this.cQteStock.Name = "cQteStock";
            this.cQteStock.ReadOnly = true;
            this.cQteStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cQteStock.Width = 50;
            // 
            // panelCmdFrn
            // 
            this.panelCmdFrn.Controls.Add(this.btnEtatStockHTML);
            this.panelCmdFrn.Controls.Add(this.btnAjouterCommande);
            this.panelCmdFrn.Controls.Add(this.tbNomclient);
            this.panelCmdFrn.Controls.Add(this.lnNomFrn);
            this.panelCmdFrn.Controls.Add(this.btnAjouterUnClient);
            this.panelCmdFrn.Controls.Add(this.tbIDCmdClient);
            this.panelCmdFrn.Controls.Add(this.lbIDCmdFrn);
            this.panelCmdFrn.Controls.Add(this.tbIDClient);
            this.panelCmdFrn.Controls.Add(this.lnIDfrn);
            this.panelCmdFrn.Location = new System.Drawing.Point(12, 453);
            this.panelCmdFrn.Name = "panelCmdFrn";
            this.panelCmdFrn.Size = new System.Drawing.Size(439, 172);
            this.panelCmdFrn.TabIndex = 34;
            // 
            // btnAjouterCommande
            // 
            this.btnAjouterCommande.Location = new System.Drawing.Point(150, 88);
            this.btnAjouterCommande.Name = "btnAjouterCommande";
            this.btnAjouterCommande.Size = new System.Drawing.Size(140, 29);
            this.btnAjouterCommande.TabIndex = 34;
            this.btnAjouterCommande.Text = "Ajouter une commande";
            this.btnAjouterCommande.UseVisualStyleBackColor = true;
            this.btnAjouterCommande.Click += new System.EventHandler(this.btnAjouterCommande_Click);
            // 
            // tbNomclient
            // 
            this.tbNomclient.Location = new System.Drawing.Point(244, 55);
            this.tbNomclient.Name = "tbNomclient";
            this.tbNomclient.ReadOnly = true;
            this.tbNomclient.Size = new System.Drawing.Size(181, 20);
            this.tbNomclient.TabIndex = 32;
            // 
            // lnNomFrn
            // 
            this.lnNomFrn.AutoSize = true;
            this.lnNomFrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnNomFrn.Location = new System.Drawing.Point(91, 55);
            this.lnNomFrn.Name = "lnNomFrn";
            this.lnNomFrn.Size = new System.Drawing.Size(147, 20);
            this.lnNomFrn.TabIndex = 31;
            this.lnNomFrn.Text = "Nom du fournisseur";
            // 
            // btnAjouterUnClient
            // 
            this.btnAjouterUnClient.Location = new System.Drawing.Point(4, 88);
            this.btnAjouterUnClient.Name = "btnAjouterUnClient";
            this.btnAjouterUnClient.Size = new System.Drawing.Size(140, 29);
            this.btnAjouterUnClient.TabIndex = 32;
            this.btnAjouterUnClient.Text = "Ajouter un client";
            this.btnAjouterUnClient.UseVisualStyleBackColor = true;
            this.btnAjouterUnClient.Click += new System.EventHandler(this.btnAjouterUnClient_Click);
            // 
            // tbIDCmdClient
            // 
            this.tbIDCmdClient.Location = new System.Drawing.Point(244, 3);
            this.tbIDCmdClient.Name = "tbIDCmdClient";
            this.tbIDCmdClient.ReadOnly = true;
            this.tbIDCmdClient.Size = new System.Drawing.Size(181, 20);
            this.tbIDCmdClient.TabIndex = 29;
            // 
            // lbIDCmdFrn
            // 
            this.lbIDCmdFrn.AutoSize = true;
            this.lbIDCmdFrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCmdFrn.Location = new System.Drawing.Point(0, 3);
            this.lbIDCmdFrn.Name = "lbIDCmdFrn";
            this.lbIDCmdFrn.Size = new System.Drawing.Size(194, 20);
            this.lbIDCmdFrn.TabIndex = 4;
            this.lbIDCmdFrn.Text = "ID de la Commande Client";
            // 
            // tbIDClient
            // 
            this.tbIDClient.Location = new System.Drawing.Point(244, 29);
            this.tbIDClient.Name = "tbIDClient";
            this.tbIDClient.ReadOnly = true;
            this.tbIDClient.Size = new System.Drawing.Size(181, 20);
            this.tbIDClient.TabIndex = 30;
            // 
            // lnIDfrn
            // 
            this.lnIDfrn.AutoSize = true;
            this.lnIDfrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnIDfrn.Location = new System.Drawing.Point(124, 27);
            this.lnIDfrn.Name = "lnIDfrn";
            this.lnIDfrn.Size = new System.Drawing.Size(70, 20);
            this.lnIDfrn.TabIndex = 4;
            this.lnIDfrn.Text = "ID Client";
            // 
            // dgvCmdClient
            // 
            this.dgvCmdClient.AllowUserToAddRows = false;
            this.dgvCmdClient.AllowUserToDeleteRows = false;
            this.dgvCmdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cIDClient,
            this.Nom,
            this.cDateCommande,
            this.dateVente});
            this.dgvCmdClient.Location = new System.Drawing.Point(3, 62);
            this.dgvCmdClient.Name = "dgvCmdClient";
            this.dgvCmdClient.ReadOnly = true;
            this.dgvCmdClient.RowHeadersVisible = false;
            this.dgvCmdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdClient.Size = new System.Drawing.Size(573, 373);
            this.dgvCmdClient.TabIndex = 37;
            this.dgvCmdClient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCmdClient_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cID";
            this.dataGridViewTextBoxColumn1.HeaderText = "N° commande";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 85;
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
            // dateVente
            // 
            this.dateVente.DataPropertyName = "dateVente";
            this.dateVente.HeaderText = "Date de la vente";
            this.dateVente.Name = "dateVente";
            this.dateVente.ReadOnly = true;
            this.dateVente.Width = 150;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbNom);
            this.panel.Controls.Add(this.tbNom);
            this.panel.Controls.Add(this.cbIDproduit);
            this.panel.Controls.Add(this.lbEncoderArticle);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.tbQtee);
            this.panel.Controls.Add(this.lbQte);
            this.panel.Controls.Add(this.lbIDclient);
            this.panel.Controls.Add(this.tbTVA);
            this.panel.Controls.Add(this.lbPrixVente);
            this.panel.Controls.Add(this.tbPrixVente);
            this.panel.Controls.Add(this.lbTVA);
            this.panel.Location = new System.Drawing.Point(1190, 574);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(354, 259);
            this.panel.TabIndex = 38;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(26, 70);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(116, 20);
            this.lbNom.TabIndex = 37;
            this.lbNom.Text = "Nom de l\'article";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(148, 70);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(184, 20);
            this.tbNom.TabIndex = 36;
            // 
            // cbIDproduit
            // 
            this.cbIDproduit.FormattingEnabled = true;
            this.cbIDproduit.Location = new System.Drawing.Point(148, 43);
            this.cbIDproduit.Name = "cbIDproduit";
            this.cbIDproduit.Size = new System.Drawing.Size(184, 21);
            this.cbIDproduit.TabIndex = 35;
            this.cbIDproduit.SelectedIndexChanged += new System.EventHandler(this.cbIDproduit_SelectedIndexChanged);
            // 
            // lbEncoderArticle
            // 
            this.lbEncoderArticle.AutoSize = true;
            this.lbEncoderArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncoderArticle.Location = new System.Drawing.Point(86, 15);
            this.lbEncoderArticle.Name = "lbEncoderArticle";
            this.lbEncoderArticle.Size = new System.Drawing.Size(186, 25);
            this.lbEncoderArticle.TabIndex = 33;
            this.lbEncoderArticle.Text = "Encoder un article";
            this.lbEncoderArticle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(219, 197);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 20);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(63, 197);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(113, 20);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // tbQtee
            // 
            this.tbQtee.Location = new System.Drawing.Point(148, 96);
            this.tbQtee.Name = "tbQtee";
            this.tbQtee.Size = new System.Drawing.Size(184, 20);
            this.tbQtee.TabIndex = 5;
            // 
            // lbQte
            // 
            this.lbQte.AutoSize = true;
            this.lbQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQte.Location = new System.Drawing.Point(67, 96);
            this.lbQte.Name = "lbQte";
            this.lbQte.Size = new System.Drawing.Size(70, 20);
            this.lbQte.TabIndex = 8;
            this.lbQte.Text = "Quantité";
            // 
            // lbIDclient
            // 
            this.lbIDclient.AutoSize = true;
            this.lbIDclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDclient.Location = new System.Drawing.Point(59, 44);
            this.lbIDclient.Name = "lbIDclient";
            this.lbIDclient.Size = new System.Drawing.Size(79, 20);
            this.lbIDclient.TabIndex = 6;
            this.lbIDclient.Text = "ID produit";
            // 
            // tbTVA
            // 
            this.tbTVA.Location = new System.Drawing.Point(148, 148);
            this.tbTVA.Name = "tbTVA";
            this.tbTVA.Size = new System.Drawing.Size(184, 20);
            this.tbTVA.TabIndex = 4;
            // 
            // lbPrixVente
            // 
            this.lbPrixVente.AutoSize = true;
            this.lbPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixVente.Location = new System.Drawing.Point(38, 122);
            this.lbPrixVente.Name = "lbPrixVente";
            this.lbPrixVente.Size = new System.Drawing.Size(99, 20);
            this.lbPrixVente.TabIndex = 7;
            this.lbPrixVente.Text = "Prix de vente";
            // 
            // tbPrixVente
            // 
            this.tbPrixVente.Location = new System.Drawing.Point(148, 122);
            this.tbPrixVente.Name = "tbPrixVente";
            this.tbPrixVente.Size = new System.Drawing.Size(184, 20);
            this.tbPrixVente.TabIndex = 3;
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVA.Location = new System.Drawing.Point(69, 148);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(68, 20);
            this.lbTVA.TabIndex = 9;
            this.lbTVA.Text = "TVA (%)";
            // 
            // btnCalculeCaHebdo
            // 
            this.btnCalculeCaHebdo.Location = new System.Drawing.Point(16, 644);
            this.btnCalculeCaHebdo.Name = "btnCalculeCaHebdo";
            this.btnCalculeCaHebdo.Size = new System.Drawing.Size(224, 29);
            this.btnCalculeCaHebdo.TabIndex = 35;
            this.btnCalculeCaHebdo.Text = "Chiffre d\'affaire hebdomadaire";
            this.btnCalculeCaHebdo.UseVisualStyleBackColor = true;
            this.btnCalculeCaHebdo.Click += new System.EventHandler(this.btnCalculeCaHebdo_Click);
            // 
            // lbCA
            // 
            this.lbCA.AutoSize = true;
            this.lbCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCA.Location = new System.Drawing.Point(12, 676);
            this.lbCA.Name = "lbCA";
            this.lbCA.Size = new System.Drawing.Size(39, 20);
            this.lbCA.TabIndex = 39;
            this.lbCA.Text = "CA :";
            // 
            // btnEtatStockHTML
            // 
            this.btnEtatStockHTML.Location = new System.Drawing.Point(4, 123);
            this.btnEtatStockHTML.Name = "btnEtatStockHTML";
            this.btnEtatStockHTML.Size = new System.Drawing.Size(286, 29);
            this.btnEtatStockHTML.TabIndex = 40;
            this.btnEtatStockHTML.Text = "Voir l\'etat du stock (HTML)";
            this.btnEtatStockHTML.UseVisualStyleBackColor = true;
            this.btnEtatStockHTML.Click += new System.EventHandler(this.btnEtatStockHTML_Click);
            // 
            // EncoderFactureClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 845);
            this.Controls.Add(this.lbCA);
            this.Controls.Add(this.btnCalculeCaHebdo);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgvCmdClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCmdFrn);
            this.Name = "EncoderFactureClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emettre facture au client";
            this.Load += new System.EventHandler(this.EncoderFactureClient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.panelCmdFrn.ResumeLayout(false);
            this.panelCmdFrn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdClient)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Panel panelCmdFrn;
        private System.Windows.Forms.Button btnAjouterCommande;
        private System.Windows.Forms.TextBox tbNomclient;
        private System.Windows.Forms.Label lnNomFrn;
        private System.Windows.Forms.Button btnAjouterUnClient;
        private System.Windows.Forms.TextBox tbIDCmdClient;
        private System.Windows.Forms.Label lbIDCmdFrn;
        private System.Windows.Forms.TextBox tbIDClient;
        private System.Windows.Forms.Label lnIDfrn;
        private System.Windows.Forms.DataGridView dgvCmdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVente;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbIDproduit;
        private System.Windows.Forms.Label lbEncoderArticle;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox tbQtee;
        private System.Windows.Forms.Label lbQte;
        private System.Windows.Forms.Label lbIDclient;
        private System.Windows.Forms.TextBox tbTVA;
        private System.Windows.Forms.Label lbPrixVente;
        private System.Windows.Forms.TextBox tbPrixVente;
        private System.Windows.Forms.Label lbTVA;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnFacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQteStock;
        private System.Windows.Forms.Button btnCalculeCaHebdo;
        private System.Windows.Forms.Label lbCA;
        private System.Windows.Forms.Button btnEtatStockHTML;
    }
}