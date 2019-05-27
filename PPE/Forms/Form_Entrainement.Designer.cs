namespace PPE
{
    partial class Form_Entrainement
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
            this.panelPhrase = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelWordInfos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPhrase
            // 
            this.panelPhrase.BackColor = System.Drawing.SystemColors.Control;
            this.panelPhrase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPhrase.Location = new System.Drawing.Point(12, 12);
            this.panelPhrase.Name = "panelPhrase";
            this.panelPhrase.Size = new System.Drawing.Size(776, 116);
            this.panelPhrase.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(776, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Regenerer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelWordInfos
            // 
            this.panelWordInfos.BackColor = System.Drawing.SystemColors.Control;
            this.panelWordInfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWordInfos.Location = new System.Drawing.Point(12, 134);
            this.panelWordInfos.Name = "panelWordInfos";
            this.panelWordInfos.Size = new System.Drawing.Size(776, 275);
            this.panelWordInfos.TabIndex = 3;
            // 
            // Form_Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelWordInfos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelPhrase);
            this.Name = "Form_Jeu";
            this.Text = "Entraînement";
            this.Load += new System.EventHandler(this.Form_Jeu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhrase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelWordInfos;
    }
}