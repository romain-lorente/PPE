namespace PPE
{
    partial class Form_Jeu
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
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonAucun = new System.Windows.Forms.Button();
            this.panelResult.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPhrase
            // 
            this.panelPhrase.BackColor = System.Drawing.SystemColors.Control;
            this.panelPhrase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPhrase.Location = new System.Drawing.Point(12, 157);
            this.panelPhrase.Name = "panelPhrase";
            this.panelPhrase.Size = new System.Drawing.Size(776, 116);
            this.panelPhrase.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Regenerer une phrase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.Control;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResult.Controls.Add(this.labelScore);
            this.panelResult.Location = new System.Drawing.Point(12, 395);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(776, 43);
            this.panelResult.TabIndex = 4;
            // 
            // panelQuestion
            // 
            this.panelQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.panelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelQuestion.Controls.Add(this.labelQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(12, 12);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(776, 116);
            this.panelQuestion.TabIndex = 3;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(91, 29);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(341, 5);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(86, 29);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 0";
            // 
            // buttonAucun
            // 
            this.buttonAucun.Location = new System.Drawing.Point(12, 279);
            this.buttonAucun.Name = "buttonAucun";
            this.buttonAucun.Size = new System.Drawing.Size(383, 23);
            this.buttonAucun.TabIndex = 5;
            this.buttonAucun.Text = "Il n\'y en a pas";
            this.buttonAucun.UseVisualStyleBackColor = true;
            this.buttonAucun.Click += new System.EventHandler(this.buttonAucun_Click);
            // 
            // Form_Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAucun);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelPhrase);
            this.Name = "Form_Jeu";
            this.Text = "Entraînement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Jeu_FormClosing);
            this.Load += new System.EventHandler(this.Form_Jeu_Load);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPhrase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonAucun;
    }
}