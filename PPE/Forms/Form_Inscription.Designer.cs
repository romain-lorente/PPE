namespace PPE
{
    partial class Form_Inscription
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
            this.inputMDP = new System.Windows.Forms.TextBox();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputConfirmerMDP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.boutonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe";
            // 
            // inputMDP
            // 
            this.inputMDP.Location = new System.Drawing.Point(146, 32);
            this.inputMDP.Name = "inputMDP";
            this.inputMDP.Size = new System.Drawing.Size(191, 20);
            this.inputMDP.TabIndex = 6;
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(146, 6);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(191, 20);
            this.inputLogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmer le mot de passe";
            // 
            // inputConfirmerMDP
            // 
            this.inputConfirmerMDP.Location = new System.Drawing.Point(146, 58);
            this.inputConfirmerMDP.Name = "inputConfirmerMDP";
            this.inputConfirmerMDP.Size = new System.Drawing.Size(191, 20);
            this.inputConfirmerMDP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prénom";
            // 
            // inputPrenom
            // 
            this.inputPrenom.Location = new System.Drawing.Point(146, 137);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(191, 20);
            this.inputPrenom.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nom";
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(146, 111);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(191, 20);
            this.inputNom.TabIndex = 10;
            // 
            // boutonValider
            // 
            this.boutonValider.Location = new System.Drawing.Point(12, 179);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(324, 23);
            this.boutonValider.TabIndex = 14;
            this.boutonValider.Text = "Valider";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.boutonValider_Click);
            // 
            // Form_Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 214);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPrenom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputConfirmerMDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputMDP);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputMDP;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputConfirmerMDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.Button boutonValider;
    }
}