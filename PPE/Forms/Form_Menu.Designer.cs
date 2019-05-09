namespace PPE
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jouerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entraînementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirMonProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.texteMenu = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jouerToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.fenêtreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jouerToolStripMenuItem
            // 
            this.jouerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuNormalToolStripMenuItem,
            this.entraînementToolStripMenuItem});
            this.jouerToolStripMenuItem.Name = "jouerToolStripMenuItem";
            this.jouerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.jouerToolStripMenuItem.Text = "Jouer";
            // 
            // jeuNormalToolStripMenuItem
            // 
            this.jeuNormalToolStripMenuItem.Name = "jeuNormalToolStripMenuItem";
            this.jeuNormalToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.jeuNormalToolStripMenuItem.Text = "Jeu normal";
            // 
            // entraînementToolStripMenuItem
            // 
            this.entraînementToolStripMenuItem.Name = "entraînementToolStripMenuItem";
            this.entraînementToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.entraînementToolStripMenuItem.Text = "Entraînement";
            this.entraînementToolStripMenuItem.Click += new System.EventHandler(this.entraînementToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirMonProfilToolStripMenuItem,
            this.classementToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.profilToolStripMenuItem.Text = "Communauté";
            // 
            // voirMonProfilToolStripMenuItem
            // 
            this.voirMonProfilToolStripMenuItem.Name = "voirMonProfilToolStripMenuItem";
            this.voirMonProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirMonProfilToolStripMenuItem.Text = "Profil";
            this.voirMonProfilToolStripMenuItem.Click += new System.EventHandler(this.voirMonProfilToolStripMenuItem_Click);
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classementToolStripMenuItem.Text = "Classement";
            this.classementToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMotToolStripMenuItem1});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fenêtreToolStripMenuItem.Text = "Administration";
            // 
            // ajouterMotToolStripMenuItem1
            // 
            this.ajouterMotToolStripMenuItem1.Name = "ajouterMotToolStripMenuItem1";
            this.ajouterMotToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.ajouterMotToolStripMenuItem1.Text = "Gestion des données";
            this.ajouterMotToolStripMenuItem1.Click += new System.EventHandler(this.ajouterMotToolStripMenuItem1_Click);
            // 
            // texteMenu
            // 
            this.texteMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texteMenu.Location = new System.Drawing.Point(13, 28);
            this.texteMenu.Name = "texteMenu";
            this.texteMenu.ReadOnly = true;
            this.texteMenu.Size = new System.Drawing.Size(452, 108);
            this.texteMenu.TabIndex = 4;
            this.texteMenu.TabStop = false;
            this.texteMenu.Text = "Bienvenue !\n\nUtilisez le menu ci-dessus pour jouer ou ajouter de nouveaux mots.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 148);
            this.Controls.Add(this.texteMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jouerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entraînementToolStripMenuItem;
        private System.Windows.Forms.RichTextBox texteMenu;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirMonProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
    }
}

