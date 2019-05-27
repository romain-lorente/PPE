namespace PPE
{
    partial class Form_Classement
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
            this.titreClassement = new System.Windows.Forms.Label();
            this.listeJoueurs = new System.Windows.Forms.ListView();
            this.pseudo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // titreClassement
            // 
            this.titreClassement.AutoSize = true;
            this.titreClassement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreClassement.Location = new System.Drawing.Point(12, 9);
            this.titreClassement.Name = "titreClassement";
            this.titreClassement.Size = new System.Drawing.Size(323, 24);
            this.titreClassement.TabIndex = 1;
            this.titreClassement.Text = "Classement des dix meilleurs joueurs";
            // 
            // listeJoueurs
            // 
            this.listeJoueurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pseudo,
            this.score});
            this.listeJoueurs.Location = new System.Drawing.Point(13, 59);
            this.listeJoueurs.Name = "listeJoueurs";
            this.listeJoueurs.Size = new System.Drawing.Size(322, 368);
            this.listeJoueurs.TabIndex = 2;
            this.listeJoueurs.UseCompatibleStateImageBehavior = false;
            this.listeJoueurs.View = System.Windows.Forms.View.Details;
            // 
            // pseudo
            // 
            this.pseudo.Text = "Nom d\'utilisateur";
            this.pseudo.Width = 235;
            // 
            // score
            // 
            this.score.Text = "Score";
            this.score.Width = 80;
            // 
            // Form_Classement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 439);
            this.Controls.Add(this.listeJoueurs);
            this.Controls.Add(this.titreClassement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Classement";
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.Form_Classement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreClassement;
        private System.Windows.Forms.ListView listeJoueurs;
        private System.Windows.Forms.ColumnHeader pseudo;
        private System.Windows.Forms.ColumnHeader score;
    }
}