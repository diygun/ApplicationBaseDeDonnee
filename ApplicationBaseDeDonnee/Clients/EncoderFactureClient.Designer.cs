
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelArticle = new System.Windows.Forms.Panel();
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
            this.cIDFrn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.panelArticle.SuspendLayout();
            this.panelCmdFrn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Encoder une facture d\'achat du fournisseur";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.dgvArticles);
            this.panel1.Location = new System.Drawing.Point(510, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 775);
            this.panel1.TabIndex = 35;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(449, 739);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 29);
            this.btnTest.TabIndex = 25;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
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
            this.cPrixAchat,
            this.prixVente,
            this.cTVA,
            this.cQteStock,
            this.Quantite});
            this.dgvArticles.Location = new System.Drawing.Point(11, 7);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(587, 726);
            this.dgvArticles.TabIndex = 20;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.HeaderText = "N°";
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
            // panelArticle
            // 
            this.panelArticle.Controls.Add(this.tbSeuilStock);
            this.panelArticle.Controls.Add(this.lbSeuilStock);
            this.panelArticle.Controls.Add(this.tbID);
            this.panelArticle.Controls.Add(this.btnAnnuler);
            this.panelArticle.Controls.Add(this.btnConfirmer);
            this.panelArticle.Controls.Add(this.lbID);
            this.panelArticle.Controls.Add(this.lbNom);
            this.panelArticle.Controls.Add(this.tbStock);
            this.panelArticle.Controls.Add(this.lbPrixVente);
            this.panelArticle.Controls.Add(this.tbTVA);
            this.panelArticle.Controls.Add(this.lbPrixAchat);
            this.panelArticle.Controls.Add(this.tbPrixAchat);
            this.panelArticle.Controls.Add(this.lbStock);
            this.panelArticle.Controls.Add(this.tbPrixVente);
            this.panelArticle.Controls.Add(this.lbTVA);
            this.panelArticle.Controls.Add(this.tbNom);
            this.panelArticle.Location = new System.Drawing.Point(1166, 602);
            this.panelArticle.Name = "panelArticle";
            this.panelArticle.Size = new System.Drawing.Size(330, 228);
            this.panelArticle.TabIndex = 32;
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
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(52, 190);
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
            // panelCmdFrn
            // 
            this.panelCmdFrn.Controls.Add(this.btnAjouterCommande);
            this.panelCmdFrn.Controls.Add(this.tbNomclient);
            this.panelCmdFrn.Controls.Add(this.lnNomFrn);
            this.panelCmdFrn.Controls.Add(this.btnAjouterUnClient);
            this.panelCmdFrn.Controls.Add(this.tbIDCmdClient);
            this.panelCmdFrn.Controls.Add(this.lbIDCmdFrn);
            this.panelCmdFrn.Controls.Add(this.tbIDClient);
            this.panelCmdFrn.Controls.Add(this.lnIDfrn);
            this.panelCmdFrn.Location = new System.Drawing.Point(19, 388);
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
            this.btnAjouterUnClient.Text = "Ajouter un fournisseur";
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
            this.cIDFrn,
            this.Nom,
            this.cDateCommande});
            this.dgvCmdClient.Location = new System.Drawing.Point(19, 55);
            this.dgvCmdClient.Name = "dgvCmdClient";
            this.dgvCmdClient.ReadOnly = true;
            this.dgvCmdClient.RowHeadersVisible = false;
            this.dgvCmdClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdClient.Size = new System.Drawing.Size(425, 327);
            this.dgvCmdClient.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cID";
            this.dataGridViewTextBoxColumn1.HeaderText = "N° commande";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // cIDFrn
            // 
            this.cIDFrn.DataPropertyName = "IDClient";
            this.cIDFrn.HeaderText = "N° Client";
            this.cIDFrn.Name = "cIDFrn";
            this.cIDFrn.ReadOnly = true;
            this.cIDFrn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIDFrn.Width = 85;
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
            // EncoderFactureClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 845);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelArticle);
            this.Controls.Add(this.panelCmdFrn);
            this.Controls.Add(this.dgvCmdClient);
            this.Name = "EncoderFactureClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncoderFactureClient";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.panelArticle.ResumeLayout(false);
            this.panelArticle.PerformLayout();
            this.panelCmdFrn.ResumeLayout(false);
            this.panelCmdFrn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrixAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.Panel panelArticle;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDFrn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDateCommande;
    }
}