namespace PPE
{
    partial class Form_Connexion
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputMDP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boutonConnexion = new System.Windows.Forms.Button();
            this.boutonInscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(103, 10);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(191, 20);
            this.inputLogin.TabIndex = 1;
            // 
            // inputMDP
            // 
            this.inputMDP.Location = new System.Drawing.Point(103, 36);
            this.inputMDP.Name = "inputMDP";
            this.inputMDP.Size = new System.Drawing.Size(191, 20);
            this.inputMDP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // boutonConnexion
            // 
            this.boutonConnexion.Location = new System.Drawing.Point(12, 80);
            this.boutonConnexion.Name = "boutonConnexion";
            this.boutonConnexion.Size = new System.Drawing.Size(282, 23);
            this.boutonConnexion.TabIndex = 4;
            this.boutonConnexion.Text = "Se connecter";
            this.boutonConnexion.UseVisualStyleBackColor = true;
            this.boutonConnexion.Click += new System.EventHandler(this.boutonConnexion_Click);
            // 
            // boutonInscription
            // 
            this.boutonInscription.Location = new System.Drawing.Point(12, 109);
            this.boutonInscription.Name = "boutonInscription";
            this.boutonInscription.Size = new System.Drawing.Size(282, 23);
            this.boutonInscription.TabIndex = 5;
            this.boutonInscription.Text = "Inscription";
            this.boutonInscription.UseVisualStyleBackColor = true;
            this.boutonInscription.Click += new System.EventHandler(this.boutonInscription_Click);
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 144);
            this.Controls.Add(this.boutonInscription);
            this.Controls.Add(this.boutonConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMDP);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form_Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputMDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boutonConnexion;
        private System.Windows.Forms.Button boutonInscription;
    }
}