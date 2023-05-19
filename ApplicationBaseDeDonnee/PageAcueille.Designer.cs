
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
            this.msManagmentListesArticles = new System.Windows.Forms.ToolStripMenuItem();
            this.gererLesArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPageAcueille.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPageAcueille
            // 
            this.msPageAcueille.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msManagment,
            this.gererLesArticlesToolStripMenuItem});
            this.msPageAcueille.Location = new System.Drawing.Point(0, 0);
            this.msPageAcueille.Name = "msPageAcueille";
            this.msPageAcueille.Size = new System.Drawing.Size(800, 24);
            this.msPageAcueille.TabIndex = 0;
            this.msPageAcueille.Text = "menuStrip1";
            // 
            // msManagment
            // 
            this.msManagment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msManagmentListesArticles});
            this.msManagment.Name = "msManagment";
            this.msManagment.Size = new System.Drawing.Size(84, 20);
            this.msManagment.Text = "Managment";
            // 
            // msManagmentListesArticles
            // 
            this.msManagmentListesArticles.Name = "msManagmentListesArticles";
            this.msManagmentListesArticles.Size = new System.Drawing.Size(164, 22);
            this.msManagmentListesArticles.Text = "Listes des articles";
            this.msManagmentListesArticles.Click += new System.EventHandler(this.msManagmentListesArticles_Click);
            // 
            // gererLesArticlesToolStripMenuItem
            // 
            this.gererLesArticlesToolStripMenuItem.Name = "gererLesArticlesToolStripMenuItem";
            this.gererLesArticlesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gererLesArticlesToolStripMenuItem.Text = "Gerer les articles";
            this.gererLesArticlesToolStripMenuItem.Click += new System.EventHandler(this.gererLesArticlesToolStripMenuItem_Click);
            // 
            // PageAcueille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msPageAcueille);
            this.MainMenuStrip = this.msPageAcueille;
            this.Name = "PageAcueille";
            this.Text = "E-COM MANAGER";
            this.Load += new System.EventHandler(this.PageAcueille_Load);
            this.msPageAcueille.ResumeLayout(false);
            this.msPageAcueille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPageAcueille;
        private System.Windows.Forms.ToolStripMenuItem msManagment;
        private System.Windows.Forms.ToolStripMenuItem msManagmentListesArticles;
        private System.Windows.Forms.ToolStripMenuItem gererLesArticlesToolStripMenuItem;
    }
}

