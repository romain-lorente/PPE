namespace PPE
{
    partial class Form_Profil
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
            this.titreProfil = new System.Windows.Forms.Label();
            this.ControleProfil = new System.Windows.Forms.TabControl();
            this.consulterProfil = new System.Windows.Forms.TabPage();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.modifierProfil = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.validerMDP = new System.Windows.Forms.Button();
            this.inputMDPold = new System.Windows.Forms.TextBox();
            this.inputMDP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.validerNom = new System.Windows.Forms.Button();
            this.inputPrenom = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.labelModifPrenom = new System.Windows.Forms.Label();
            this.labelModifNom = new System.Windows.Forms.Label();
            this.ControleProfil.SuspendLayout();
            this.consulterProfil.SuspendLayout();
            this.modifierProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // titreProfil
            // 
            this.titreProfil.AutoSize = true;
            this.titreProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreProfil.Location = new System.Drawing.Point(12, 9);
            this.titreProfil.Name = "titreProfil";
            this.titreProfil.Size = new System.Drawing.Size(93, 24);
            this.titreProfil.TabIndex = 0;
            this.titreProfil.Text = "Profil de _";
            // 
            // ControleProfil
            // 
            this.ControleProfil.Controls.Add(this.consulterProfil);
            this.ControleProfil.Controls.Add(this.modifierProfil);
            this.ControleProfil.Location = new System.Drawing.Point(16, 45);
            this.ControleProfil.Name = "ControleProfil";
            this.ControleProfil.SelectedIndex = 0;
            this.ControleProfil.Size = new System.Drawing.Size(365, 274);
            this.ControleProfil.TabIndex = 1;
            // 
            // consulterProfil
            // 
            this.consulterProfil.Controls.Add(this.labelRole);
            this.consulterProfil.Controls.Add(this.labelScore);
            this.consulterProfil.Controls.Add(this.labelNom);
            this.consulterProfil.Location = new System.Drawing.Point(4, 22);
            this.consulterProfil.Name = "consulterProfil";
            this.consulterProfil.Padding = new System.Windows.Forms.Padding(3);
            this.consulterProfil.Size = new System.Drawing.Size(357, 248);
            this.consulterProfil.TabIndex = 0;
            this.consulterProfil.Text = "Consulter";
            this.consulterProfil.UseVisualStyleBackColor = true;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(6, 75);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(86, 18);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Vous êtes _";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(6, 45);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(68, 18);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score : _";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(6, 15);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(98, 18);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom Prénom";
            // 
            // modifierProfil
            // 
            this.modifierProfil.Controls.Add(this.label1);
            this.modifierProfil.Controls.Add(this.validerMDP);
            this.modifierProfil.Controls.Add(this.inputMDPold);
            this.modifierProfil.Controls.Add(this.inputMDP);
            this.modifierProfil.Controls.Add(this.label2);
            this.modifierProfil.Controls.Add(this.validerNom);
            this.modifierProfil.Controls.Add(this.inputPrenom);
            this.modifierProfil.Controls.Add(this.inputNom);
            this.modifierProfil.Controls.Add(this.labelModifPrenom);
            this.modifierProfil.Controls.Add(this.labelModifNom);
            this.modifierProfil.Location = new System.Drawing.Point(4, 22);
            this.modifierProfil.Name = "modifierProfil";
            this.modifierProfil.Padding = new System.Windows.Forms.Padding(3);
            this.modifierProfil.Size = new System.Drawing.Size(357, 248);
            this.modifierProfil.TabIndex = 1;
            this.modifierProfil.Text = "Modifier";
            this.modifierProfil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ancien mot de passe :";
            // 
            // validerMDP
            // 
            this.validerMDP.Location = new System.Drawing.Point(9, 210);
            this.validerMDP.Name = "validerMDP";
            this.validerMDP.Size = new System.Drawing.Size(342, 23);
            this.validerMDP.TabIndex = 12;
            this.validerMDP.Text = "Valider";
            this.validerMDP.UseVisualStyleBackColor = true;
            this.validerMDP.Click += new System.EventHandler(this.validerMDP_Click);
            // 
            // inputMDPold
            // 
            this.inputMDPold.Location = new System.Drawing.Point(135, 136);
            this.inputMDPold.Name = "inputMDPold";
            this.inputMDPold.PasswordChar = '•';
            this.inputMDPold.Size = new System.Drawing.Size(216, 20);
            this.inputMDPold.TabIndex = 11;
            // 
            // inputMDP
            // 
            this.inputMDP.Location = new System.Drawing.Point(135, 166);
            this.inputMDP.Name = "inputMDP";
            this.inputMDP.PasswordChar = '•';
            this.inputMDP.Size = new System.Drawing.Size(216, 20);
            this.inputMDP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nouveau mot de passe :";
            // 
            // validerNom
            // 
            this.validerNom.Location = new System.Drawing.Point(9, 86);
            this.validerNom.Name = "validerNom";
            this.validerNom.Size = new System.Drawing.Size(342, 23);
            this.validerNom.TabIndex = 7;
            this.validerNom.Text = "Valider";
            this.validerNom.UseVisualStyleBackColor = true;
            this.validerNom.Click += new System.EventHandler(this.validerNom_Click);
            // 
            // inputPrenom
            // 
            this.inputPrenom.Location = new System.Drawing.Point(81, 46);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(270, 20);
            this.inputPrenom.TabIndex = 6;
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(81, 16);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(270, 20);
            this.inputNom.TabIndex = 5;
            // 
            // labelModifPrenom
            // 
            this.labelModifPrenom.AutoSize = true;
            this.labelModifPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifPrenom.Location = new System.Drawing.Point(6, 45);
            this.labelModifPrenom.Name = "labelModifPrenom";
            this.labelModifPrenom.Size = new System.Drawing.Size(69, 18);
            this.labelModifPrenom.TabIndex = 4;
            this.labelModifPrenom.Text = "Prénom :";
            // 
            // labelModifNom
            // 
            this.labelModifNom.AutoSize = true;
            this.labelModifNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModifNom.Location = new System.Drawing.Point(26, 15);
            this.labelModifNom.Name = "labelModifNom";
            this.labelModifNom.Size = new System.Drawing.Size(49, 18);
            this.labelModifNom.TabIndex = 3;
            this.labelModifNom.Text = "Nom :";
            // 
            // Form_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 334);
            this.Controls.Add(this.ControleProfil);
            this.Controls.Add(this.titreProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Profil";
            this.Text = "Votre profil";
            this.Load += new System.EventHandler(this.Form_Profil_Load);
            this.ControleProfil.ResumeLayout(false);
            this.consulterProfil.ResumeLayout(false);
            this.consulterProfil.PerformLayout();
            this.modifierProfil.ResumeLayout(false);
            this.modifierProfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titreProfil;
        private System.Windows.Forms.TabControl ControleProfil;
        private System.Windows.Forms.TabPage consulterProfil;
        private System.Windows.Forms.TabPage modifierProfil;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelModifPrenom;
        private System.Windows.Forms.Label labelModifNom;
        private System.Windows.Forms.Button validerMDP;
        private System.Windows.Forms.TextBox inputMDPold;
        private System.Windows.Forms.TextBox inputMDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validerNom;
        private System.Windows.Forms.TextBox inputPrenom;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.Label label1;
    }
}