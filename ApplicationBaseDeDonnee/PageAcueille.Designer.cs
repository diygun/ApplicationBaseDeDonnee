
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
            this.lbProduits = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.cbIDproduit = new System.Windows.Forms.ComboBox();
            this.lbEncoderArticle = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.tbQtee = new System.Windows.Forms.TextBox();
            this.lbQte = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.tbTVA = new System.Windows.Forms.TextBox();
            this.lbPrixVente = new System.Windows.Forms.Label();
            this.tbPrixVente = new System.Windows.Forms.TextBox();
            this.lbTVA = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListClient = new System.Windows.Forms.Label();
            this.btnGererClients = new System.Windows.Forms.Button();
            this.btnAfficherStock = new System.Windows.Forms.Button();
            this.msPageAcueille.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
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
            this.msPageAcueille.Size = new System.Drawing.Size(1268, 24);
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
            // lbProduits
            // 
            this.lbProduits.AutoSize = true;
            this.lbProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduits.Location = new System.Drawing.Point(14, 47);
            this.lbProduits.Name = "lbProduits";
            this.lbProduits.Size = new System.Drawing.Size(180, 20);
            this.lbProduits.TabIndex = 5;
            this.lbProduits.Text = "Les articles disponibles :";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbNom);
            this.panel.Controls.Add(this.cbIDproduit);
            this.panel.Controls.Add(this.tbNom);
            this.panel.Controls.Add(this.lbEncoderArticle);
            this.panel.Controls.Add(this.btnAnnuler);
            this.panel.Controls.Add(this.btnConfirmer);
            this.panel.Controls.Add(this.tbQtee);
            this.panel.Controls.Add(this.lbQte);
            this.panel.Controls.Add(this.lbClient);
            this.panel.Controls.Add(this.tbTVA);
            this.panel.Controls.Add(this.lbPrixVente);
            this.panel.Controls.Add(this.tbPrixVente);
            this.panel.Controls.Add(this.lbTVA);
            this.panel.Location = new System.Drawing.Point(18, 485);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(581, 245);
            this.panel.TabIndex = 33;
            // 
            // cbIDproduit
            // 
            this.cbIDproduit.FormattingEnabled = true;
            this.cbIDproduit.Location = new System.Drawing.Point(232, 62);
            this.cbIDproduit.Name = "cbIDproduit";
            this.cbIDproduit.Size = new System.Drawing.Size(184, 21);
            this.cbIDproduit.TabIndex = 35;
            this.cbIDproduit.SelectedIndexChanged += new System.EventHandler(this.cbIDproduit_SelectedIndexChanged);
            // 
            // lbEncoderArticle
            // 
            this.lbEncoderArticle.AutoSize = true;
            this.lbEncoderArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncoderArticle.Location = new System.Drawing.Point(181, 34);
            this.lbEncoderArticle.Name = "lbEncoderArticle";
            this.lbEncoderArticle.Size = new System.Drawing.Size(193, 25);
            this.lbEncoderArticle.TabIndex = 33;
            this.lbEncoderArticle.Text = "Encoder une vente";
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
            // tbQtee
            // 
            this.tbQtee.Location = new System.Drawing.Point(232, 115);
            this.tbQtee.Name = "tbQtee";
            this.tbQtee.Size = new System.Drawing.Size(184, 20);
            this.tbQtee.TabIndex = 5;
            // 
            // lbQte
            // 
            this.lbQte.AutoSize = true;
            this.lbQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQte.Location = new System.Drawing.Point(151, 115);
            this.lbQte.Name = "lbQte";
            this.lbQte.Size = new System.Drawing.Size(70, 20);
            this.lbQte.TabIndex = 8;
            this.lbQte.Text = "Quantité";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClient.Location = new System.Drawing.Point(143, 63);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(79, 20);
            this.lbClient.TabIndex = 6;
            this.lbClient.Text = "ID produit";
            // 
            // tbTVA
            // 
            this.tbTVA.Location = new System.Drawing.Point(232, 167);
            this.tbTVA.Name = "tbTVA";
            this.tbTVA.Size = new System.Drawing.Size(184, 20);
            this.tbTVA.TabIndex = 4;
            // 
            // lbPrixVente
            // 
            this.lbPrixVente.AutoSize = true;
            this.lbPrixVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrixVente.Location = new System.Drawing.Point(122, 141);
            this.lbPrixVente.Name = "lbPrixVente";
            this.lbPrixVente.Size = new System.Drawing.Size(99, 20);
            this.lbPrixVente.TabIndex = 7;
            this.lbPrixVente.Text = "Prix de vente";
            // 
            // tbPrixVente
            // 
            this.tbPrixVente.Location = new System.Drawing.Point(232, 141);
            this.tbPrixVente.Name = "tbPrixVente";
            this.tbPrixVente.Size = new System.Drawing.Size(184, 20);
            this.tbPrixVente.TabIndex = 3;
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTVA.Location = new System.Drawing.Point(153, 167);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(68, 20);
            this.lbTVA.TabIndex = 9;
            this.lbTVA.Text = "TVA (%)";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(110, 89);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(116, 20);
            this.lbNom.TabIndex = 39;
            this.lbNom.Text = "Nom de l\'article";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(232, 89);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(184, 20);
            this.tbNom.TabIndex = 38;
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
            this.dgvArticles.Location = new System.Drawing.Point(18, 82);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersVisible = false;
            this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticles.Size = new System.Drawing.Size(581, 397);
            this.dgvArticles.TabIndex = 34;
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
            this.cNom.Width = 200;
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
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cAdresse,
            this.email,
            this.GSM});
            this.dgvClient.Location = new System.Drawing.Point(618, 82);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(638, 397);
            this.dgvClient.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 125;
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
            // lbListClient
            // 
            this.lbListClient.AutoSize = true;
            this.lbListClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListClient.Location = new System.Drawing.Point(614, 47);
            this.lbListClient.Name = "lbListClient";
            this.lbListClient.Size = new System.Drawing.Size(165, 20);
            this.lbListClient.TabIndex = 36;
            this.lbListClient.Text = "Appercue des clients :";
            // 
            // btnGererClients
            // 
            this.btnGererClients.Location = new System.Drawing.Point(618, 505);
            this.btnGererClients.Name = "btnGererClients";
            this.btnGererClients.Size = new System.Drawing.Size(184, 27);
            this.btnGererClients.TabIndex = 37;
            this.btnGererClients.Text = "Gerer les clients";
            this.btnGererClients.UseVisualStyleBackColor = true;
            this.btnGererClients.Click += new System.EventHandler(this.msAjouterClient_Click);
            // 
            // btnAfficherStock
            // 
            this.btnAfficherStock.Location = new System.Drawing.Point(618, 546);
            this.btnAfficherStock.Name = "btnAfficherStock";
            this.btnAfficherStock.Size = new System.Drawing.Size(184, 27);
            this.btnAfficherStock.TabIndex = 38;
            this.btnAfficherStock.Text = "Consulter l\'etats des stocks";
            this.btnAfficherStock.UseVisualStyleBackColor = true;
            this.btnAfficherStock.Click += new System.EventHandler(this.btnAfficherStock_Click);
            // 
            // PageAcueille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 742);
            this.Controls.Add(this.btnAfficherStock);
            this.Controls.Add(this.btnGererClients);
            this.Controls.Add(this.lbListClient);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbProduits);
            this.Controls.Add(this.msPageAcueille);
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.msPageAcueille;
            this.Name = "PageAcueille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "E-Commerce Managment";
            this.Load += new System.EventHandler(this.PageAcueille_Load);
            this.msPageAcueille.ResumeLayout(false);
            this.msPageAcueille.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPageAcueille;
        private System.Windows.Forms.ToolStripMenuItem msManagment;
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
        private System.Windows.Forms.Label lbProduits;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbIDproduit;
        private System.Windows.Forms.Label lbEncoderArticle;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox tbQtee;
        private System.Windows.Forms.Label lbQte;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.TextBox tbTVA;
        private System.Windows.Forms.Label lbPrixVente;
        private System.Windows.Forms.TextBox tbPrixVente;
        private System.Windows.Forms.Label lbTVA;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQteStock;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSM;
        private System.Windows.Forms.Label lbListClient;
        private System.Windows.Forms.Button btnGererClients;
        private System.Windows.Forms.Button btnAfficherStock;
    }
}

