namespace PPE
{
    partial class Form_AjoutMot
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
            this.listeMots = new System.Windows.Forms.DataGridView();
            this.Mot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNom = new System.Windows.Forms.TabPage();
            this.ajoutNom = new System.Windows.Forms.Button();
            this.nombreNom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genreNom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.natureNom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texteNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVerbe = new System.Windows.Forms.TabPage();
            this.pers3PVerbe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pers2PVerbe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pers1PVerbe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pers3SVerbe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pers2SVerbe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pers1SVerbe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ajoutVerbe = new System.Windows.Forms.Button();
            this.fonctionVerbe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.infinitifVerbe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabAdjectif = new System.Windows.Forms.TabPage();
            this.ajoutAdjectif = new System.Windows.Forms.Button();
            this.nombreAdjectif = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.genreAdjectif = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.fonctionAdjectif = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.texteAdjectif = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabDivers = new System.Windows.Forms.TabPage();
            this.ajoutMot = new System.Windows.Forms.Button();
            this.nombreMot = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.genreMot = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.typeMot = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.texteMot = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tabSelection = new System.Windows.Forms.TabControl();
            this.tabMot = new System.Windows.Forms.TabPage();
            this.tabPhrase = new System.Windows.Forms.TabPage();
            this.ValiderPhrase = new System.Windows.Forms.Button();
            this.formulaireComplementPhrase = new System.Windows.Forms.Panel();
            this.AnalyserPhrase = new System.Windows.Forms.Button();
            this.inputPhrase = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabListePhrase = new System.Windows.Forms.TabPage();
            this.listePhrases = new System.Windows.Forms.ListView();
            this.texte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.listeMots)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabNom.SuspendLayout();
            this.tabVerbe.SuspendLayout();
            this.tabAdjectif.SuspendLayout();
            this.tabDivers.SuspendLayout();
            this.tabSelection.SuspendLayout();
            this.tabMot.SuspendLayout();
            this.tabPhrase.SuspendLayout();
            this.tabListePhrase.SuspendLayout();
            this.SuspendLayout();
            // 
            // listeMots
            // 
            this.listeMots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeMots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeMots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mot,
            this.Type});
            this.listeMots.Location = new System.Drawing.Point(5, 6);
            this.listeMots.Margin = new System.Windows.Forms.Padding(2);
            this.listeMots.Name = "listeMots";
            this.listeMots.RowTemplate.Height = 24;
            this.listeMots.Size = new System.Drawing.Size(393, 424);
            this.listeMots.TabIndex = 0;
            // 
            // Mot
            // 
            this.Mot.HeaderText = "Mot";
            this.Mot.Name = "Mot";
            this.Mot.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNom);
            this.tabControl1.Controls.Add(this.tabVerbe);
            this.tabControl1.Controls.Add(this.tabAdjectif);
            this.tabControl1.Controls.Add(this.tabDivers);
            this.tabControl1.Location = new System.Drawing.Point(403, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // tabNom
            // 
            this.tabNom.Controls.Add(this.ajoutNom);
            this.tabNom.Controls.Add(this.nombreNom);
            this.tabNom.Controls.Add(this.label4);
            this.tabNom.Controls.Add(this.genreNom);
            this.tabNom.Controls.Add(this.label3);
            this.tabNom.Controls.Add(this.natureNom);
            this.tabNom.Controls.Add(this.label2);
            this.tabNom.Controls.Add(this.texteNom);
            this.tabNom.Controls.Add(this.label1);
            this.tabNom.Location = new System.Drawing.Point(4, 22);
            this.tabNom.Name = "tabNom";
            this.tabNom.Padding = new System.Windows.Forms.Padding(3);
            this.tabNom.Size = new System.Drawing.Size(380, 402);
            this.tabNom.TabIndex = 0;
            this.tabNom.Text = "Nom";
            this.tabNom.UseVisualStyleBackColor = true;
            // 
            // ajoutNom
            // 
            this.ajoutNom.Location = new System.Drawing.Point(7, 348);
            this.ajoutNom.Name = "ajoutNom";
            this.ajoutNom.Size = new System.Drawing.Size(367, 48);
            this.ajoutNom.TabIndex = 8;
            this.ajoutNom.Text = "Ajouter le nom";
            this.ajoutNom.UseVisualStyleBackColor = true;
            this.ajoutNom.Click += new System.EventHandler(this.ajoutNom_Click);
            // 
            // nombreNom
            // 
            this.nombreNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreNom.FormattingEnabled = true;
            this.nombreNom.Items.AddRange(new object[] {
            "Singulier",
            "Pluriel"});
            this.nombreNom.Location = new System.Drawing.Point(7, 146);
            this.nombreNom.Name = "nombreNom";
            this.nombreNom.Size = new System.Drawing.Size(367, 21);
            this.nombreNom.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre :";
            // 
            // genreNom
            // 
            this.genreNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreNom.FormattingEnabled = true;
            this.genreNom.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.genreNom.Location = new System.Drawing.Point(7, 105);
            this.genreNom.Name = "genreNom";
            this.genreNom.Size = new System.Drawing.Size(367, 21);
            this.genreNom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre :";
            // 
            // natureNom
            // 
            this.natureNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.natureNom.FormattingEnabled = true;
            this.natureNom.Items.AddRange(new object[] {
            "Commun",
            "Propre"});
            this.natureNom.Location = new System.Drawing.Point(7, 64);
            this.natureNom.Name = "natureNom";
            this.natureNom.Size = new System.Drawing.Size(367, 21);
            this.natureNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nature :";
            // 
            // texteNom
            // 
            this.texteNom.Location = new System.Drawing.Point(6, 24);
            this.texteNom.Name = "texteNom";
            this.texteNom.Size = new System.Drawing.Size(368, 20);
            this.texteNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrer le nom :";
            // 
            // tabVerbe
            // 
            this.tabVerbe.Controls.Add(this.pers3PVerbe);
            this.tabVerbe.Controls.Add(this.label11);
            this.tabVerbe.Controls.Add(this.pers2PVerbe);
            this.tabVerbe.Controls.Add(this.label12);
            this.tabVerbe.Controls.Add(this.pers1PVerbe);
            this.tabVerbe.Controls.Add(this.label9);
            this.tabVerbe.Controls.Add(this.pers3SVerbe);
            this.tabVerbe.Controls.Add(this.label10);
            this.tabVerbe.Controls.Add(this.pers2SVerbe);
            this.tabVerbe.Controls.Add(this.label6);
            this.tabVerbe.Controls.Add(this.pers1SVerbe);
            this.tabVerbe.Controls.Add(this.label5);
            this.tabVerbe.Controls.Add(this.ajoutVerbe);
            this.tabVerbe.Controls.Add(this.fonctionVerbe);
            this.tabVerbe.Controls.Add(this.label7);
            this.tabVerbe.Controls.Add(this.infinitifVerbe);
            this.tabVerbe.Controls.Add(this.label8);
            this.tabVerbe.Location = new System.Drawing.Point(4, 22);
            this.tabVerbe.Name = "tabVerbe";
            this.tabVerbe.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerbe.Size = new System.Drawing.Size(380, 402);
            this.tabVerbe.TabIndex = 1;
            this.tabVerbe.Text = "Verbe";
            this.tabVerbe.UseVisualStyleBackColor = true;
            // 
            // pers3PVerbe
            // 
            this.pers3PVerbe.Location = new System.Drawing.Point(6, 299);
            this.pers3PVerbe.Name = "pers3PVerbe";
            this.pers3PVerbe.Size = new System.Drawing.Size(368, 20);
            this.pers3PVerbe.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Troisième personne du pluriel :";
            // 
            // pers2PVerbe
            // 
            this.pers2PVerbe.Location = new System.Drawing.Point(6, 260);
            this.pers2PVerbe.Name = "pers2PVerbe";
            this.pers2PVerbe.Size = new System.Drawing.Size(368, 20);
            this.pers2PVerbe.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Deuxième personne du pluriel :";
            // 
            // pers1PVerbe
            // 
            this.pers1PVerbe.Location = new System.Drawing.Point(6, 221);
            this.pers1PVerbe.Name = "pers1PVerbe";
            this.pers1PVerbe.Size = new System.Drawing.Size(368, 20);
            this.pers1PVerbe.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Première personne du pluriel :";
            // 
            // pers3SVerbe
            // 
            this.pers3SVerbe.Location = new System.Drawing.Point(6, 182);
            this.pers3SVerbe.Name = "pers3SVerbe";
            this.pers3SVerbe.Size = new System.Drawing.Size(368, 20);
            this.pers3SVerbe.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Troisième personne du singulier :";
            // 
            // pers2SVerbe
            // 
            this.pers2SVerbe.Location = new System.Drawing.Point(6, 143);
            this.pers2SVerbe.Name = "pers2SVerbe";
            this.pers2SVerbe.Size = new System.Drawing.Size(368, 20);
            this.pers2SVerbe.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Deuxième personne du singulier :";
            // 
            // pers1SVerbe
            // 
            this.pers1SVerbe.Location = new System.Drawing.Point(6, 104);
            this.pers1SVerbe.Name = "pers1SVerbe";
            this.pers1SVerbe.Size = new System.Drawing.Size(368, 20);
            this.pers1SVerbe.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Première personne du singulier :";
            // 
            // ajoutVerbe
            // 
            this.ajoutVerbe.Location = new System.Drawing.Point(7, 348);
            this.ajoutVerbe.Name = "ajoutVerbe";
            this.ajoutVerbe.Size = new System.Drawing.Size(367, 48);
            this.ajoutVerbe.TabIndex = 17;
            this.ajoutVerbe.Text = "Ajouter le verbe";
            this.ajoutVerbe.UseVisualStyleBackColor = true;
            this.ajoutVerbe.Click += new System.EventHandler(this.ajoutVerbe_Click);
            // 
            // fonctionVerbe
            // 
            this.fonctionVerbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fonctionVerbe.FormattingEnabled = true;
            this.fonctionVerbe.Items.AddRange(new object[] {
            "Action",
            "État"});
            this.fonctionVerbe.Location = new System.Drawing.Point(7, 64);
            this.fonctionVerbe.Name = "fonctionVerbe";
            this.fonctionVerbe.Size = new System.Drawing.Size(367, 21);
            this.fonctionVerbe.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fonction :";
            // 
            // infinitifVerbe
            // 
            this.infinitifVerbe.Location = new System.Drawing.Point(6, 24);
            this.infinitifVerbe.Name = "infinitifVerbe";
            this.infinitifVerbe.Size = new System.Drawing.Size(368, 20);
            this.infinitifVerbe.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Entrer l\'infinitif du verbe :";
            // 
            // tabAdjectif
            // 
            this.tabAdjectif.Controls.Add(this.ajoutAdjectif);
            this.tabAdjectif.Controls.Add(this.nombreAdjectif);
            this.tabAdjectif.Controls.Add(this.label13);
            this.tabAdjectif.Controls.Add(this.genreAdjectif);
            this.tabAdjectif.Controls.Add(this.label14);
            this.tabAdjectif.Controls.Add(this.fonctionAdjectif);
            this.tabAdjectif.Controls.Add(this.label15);
            this.tabAdjectif.Controls.Add(this.texteAdjectif);
            this.tabAdjectif.Controls.Add(this.label16);
            this.tabAdjectif.Location = new System.Drawing.Point(4, 22);
            this.tabAdjectif.Name = "tabAdjectif";
            this.tabAdjectif.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdjectif.Size = new System.Drawing.Size(380, 402);
            this.tabAdjectif.TabIndex = 2;
            this.tabAdjectif.Text = "Adjectif";
            this.tabAdjectif.UseVisualStyleBackColor = true;
            // 
            // ajoutAdjectif
            // 
            this.ajoutAdjectif.Location = new System.Drawing.Point(7, 348);
            this.ajoutAdjectif.Name = "ajoutAdjectif";
            this.ajoutAdjectif.Size = new System.Drawing.Size(367, 48);
            this.ajoutAdjectif.TabIndex = 18;
            this.ajoutAdjectif.Text = "Ajouter l\'adjectif";
            this.ajoutAdjectif.UseVisualStyleBackColor = true;
            this.ajoutAdjectif.Click += new System.EventHandler(this.ajoutAdjectif_Click);
            // 
            // nombreAdjectif
            // 
            this.nombreAdjectif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreAdjectif.FormattingEnabled = true;
            this.nombreAdjectif.Items.AddRange(new object[] {
            "Singulier",
            "Pluriel"});
            this.nombreAdjectif.Location = new System.Drawing.Point(7, 146);
            this.nombreAdjectif.Name = "nombreAdjectif";
            this.nombreAdjectif.Size = new System.Drawing.Size(367, 21);
            this.nombreAdjectif.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nombre :";
            // 
            // genreAdjectif
            // 
            this.genreAdjectif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreAdjectif.FormattingEnabled = true;
            this.genreAdjectif.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.genreAdjectif.Location = new System.Drawing.Point(7, 105);
            this.genreAdjectif.Name = "genreAdjectif";
            this.genreAdjectif.Size = new System.Drawing.Size(367, 21);
            this.genreAdjectif.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Genre :";
            // 
            // fonctionAdjectif
            // 
            this.fonctionAdjectif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fonctionAdjectif.FormattingEnabled = true;
            this.fonctionAdjectif.Items.AddRange(new object[] {
            "Qualificatif",
            "Démonstratif",
            "Possessif"});
            this.fonctionAdjectif.Location = new System.Drawing.Point(7, 64);
            this.fonctionAdjectif.Name = "fonctionAdjectif";
            this.fonctionAdjectif.Size = new System.Drawing.Size(367, 21);
            this.fonctionAdjectif.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Fonction :";
            // 
            // texteAdjectif
            // 
            this.texteAdjectif.Location = new System.Drawing.Point(6, 24);
            this.texteAdjectif.Name = "texteAdjectif";
            this.texteAdjectif.Size = new System.Drawing.Size(368, 20);
            this.texteAdjectif.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Entrer l\'adjectif :";
            // 
            // tabDivers
            // 
            this.tabDivers.Controls.Add(this.ajoutMot);
            this.tabDivers.Controls.Add(this.nombreMot);
            this.tabDivers.Controls.Add(this.label18);
            this.tabDivers.Controls.Add(this.genreMot);
            this.tabDivers.Controls.Add(this.label19);
            this.tabDivers.Controls.Add(this.typeMot);
            this.tabDivers.Controls.Add(this.label20);
            this.tabDivers.Controls.Add(this.texteMot);
            this.tabDivers.Controls.Add(this.label21);
            this.tabDivers.Location = new System.Drawing.Point(4, 22);
            this.tabDivers.Name = "tabDivers";
            this.tabDivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabDivers.Size = new System.Drawing.Size(380, 402);
            this.tabDivers.TabIndex = 3;
            this.tabDivers.Text = "Autres types";
            this.tabDivers.UseVisualStyleBackColor = true;
            // 
            // ajoutMot
            // 
            this.ajoutMot.Location = new System.Drawing.Point(7, 348);
            this.ajoutMot.Name = "ajoutMot";
            this.ajoutMot.Size = new System.Drawing.Size(367, 48);
            this.ajoutMot.TabIndex = 18;
            this.ajoutMot.Text = "Ajouter le mot";
            this.ajoutMot.UseVisualStyleBackColor = true;
            this.ajoutMot.Click += new System.EventHandler(this.ajoutMot_Click);
            // 
            // nombreMot
            // 
            this.nombreMot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreMot.FormattingEnabled = true;
            this.nombreMot.Items.AddRange(new object[] {
            "Singulier",
            "Pluriel",
            "Invariable"});
            this.nombreMot.Location = new System.Drawing.Point(7, 146);
            this.nombreMot.Name = "nombreMot";
            this.nombreMot.Size = new System.Drawing.Size(367, 21);
            this.nombreMot.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Nombre :";
            // 
            // genreMot
            // 
            this.genreMot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreMot.FormattingEnabled = true;
            this.genreMot.Items.AddRange(new object[] {
            "Masculin",
            "Féminin",
            "Mixte"});
            this.genreMot.Location = new System.Drawing.Point(7, 105);
            this.genreMot.Name = "genreMot";
            this.genreMot.Size = new System.Drawing.Size(367, 21);
            this.genreMot.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Genre :";
            // 
            // typeMot
            // 
            this.typeMot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeMot.FormattingEnabled = true;
            this.typeMot.Items.AddRange(new object[] {
            "Pronom",
            "Préposition",
            "Adverbe",
            "Autre"});
            this.typeMot.Location = new System.Drawing.Point(7, 64);
            this.typeMot.Name = "typeMot";
            this.typeMot.Size = new System.Drawing.Size(367, 21);
            this.typeMot.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Type de mot :";
            // 
            // texteMot
            // 
            this.texteMot.Location = new System.Drawing.Point(6, 24);
            this.texteMot.Name = "texteMot";
            this.texteMot.Size = new System.Drawing.Size(368, 20);
            this.texteMot.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Entrer le mot :";
            // 
            // tabSelection
            // 
            this.tabSelection.Controls.Add(this.tabMot);
            this.tabSelection.Controls.Add(this.tabPhrase);
            this.tabSelection.Controls.Add(this.tabListePhrase);
            this.tabSelection.Location = new System.Drawing.Point(11, 9);
            this.tabSelection.Name = "tabSelection";
            this.tabSelection.SelectedIndex = 0;
            this.tabSelection.Size = new System.Drawing.Size(796, 466);
            this.tabSelection.TabIndex = 2;
            // 
            // tabMot
            // 
            this.tabMot.Controls.Add(this.listeMots);
            this.tabMot.Controls.Add(this.tabControl1);
            this.tabMot.Location = new System.Drawing.Point(4, 22);
            this.tabMot.Name = "tabMot";
            this.tabMot.Padding = new System.Windows.Forms.Padding(3);
            this.tabMot.Size = new System.Drawing.Size(788, 440);
            this.tabMot.TabIndex = 0;
            this.tabMot.Text = "Mot";
            this.tabMot.UseVisualStyleBackColor = true;
            // 
            // tabPhrase
            // 
            this.tabPhrase.Controls.Add(this.ValiderPhrase);
            this.tabPhrase.Controls.Add(this.formulaireComplementPhrase);
            this.tabPhrase.Controls.Add(this.AnalyserPhrase);
            this.tabPhrase.Controls.Add(this.inputPhrase);
            this.tabPhrase.Controls.Add(this.label17);
            this.tabPhrase.Location = new System.Drawing.Point(4, 22);
            this.tabPhrase.Name = "tabPhrase";
            this.tabPhrase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhrase.Size = new System.Drawing.Size(788, 440);
            this.tabPhrase.TabIndex = 1;
            this.tabPhrase.Text = "Phrase";
            this.tabPhrase.UseVisualStyleBackColor = true;
            // 
            // ValiderPhrase
            // 
            this.ValiderPhrase.Location = new System.Drawing.Point(9, 405);
            this.ValiderPhrase.Name = "ValiderPhrase";
            this.ValiderPhrase.Size = new System.Drawing.Size(773, 29);
            this.ValiderPhrase.TabIndex = 12;
            this.ValiderPhrase.Text = "Valider la phrase";
            this.ValiderPhrase.UseVisualStyleBackColor = true;
            this.ValiderPhrase.Visible = false;
            this.ValiderPhrase.Click += new System.EventHandler(this.ValiderPhrase_Click);
            // 
            // formulaireComplementPhrase
            // 
            this.formulaireComplementPhrase.AutoScroll = true;
            this.formulaireComplementPhrase.Location = new System.Drawing.Point(9, 59);
            this.formulaireComplementPhrase.Name = "formulaireComplementPhrase";
            this.formulaireComplementPhrase.Size = new System.Drawing.Size(773, 340);
            this.formulaireComplementPhrase.TabIndex = 11;
            // 
            // AnalyserPhrase
            // 
            this.AnalyserPhrase.Location = new System.Drawing.Point(666, 33);
            this.AnalyserPhrase.Name = "AnalyserPhrase";
            this.AnalyserPhrase.Size = new System.Drawing.Size(116, 20);
            this.AnalyserPhrase.TabIndex = 9;
            this.AnalyserPhrase.Text = "Analyser";
            this.AnalyserPhrase.UseVisualStyleBackColor = true;
            this.AnalyserPhrase.Click += new System.EventHandler(this.AnalyserPhrase_Click);
            // 
            // inputPhrase
            // 
            this.inputPhrase.Location = new System.Drawing.Point(9, 33);
            this.inputPhrase.Name = "inputPhrase";
            this.inputPhrase.Size = new System.Drawing.Size(651, 20);
            this.inputPhrase.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Entrer une phrase :";
            // 
            // tabListePhrase
            // 
            this.tabListePhrase.Controls.Add(this.listePhrases);
            this.tabListePhrase.Location = new System.Drawing.Point(4, 22);
            this.tabListePhrase.Name = "tabListePhrase";
            this.tabListePhrase.Padding = new System.Windows.Forms.Padding(3);
            this.tabListePhrase.Size = new System.Drawing.Size(788, 440);
            this.tabListePhrase.TabIndex = 2;
            this.tabListePhrase.Text = "Liste des phrases";
            this.tabListePhrase.UseVisualStyleBackColor = true;
            // 
            // listePhrases
            // 
            this.listePhrases.AllowColumnReorder = true;
            this.listePhrases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.texte});
            this.listePhrases.Location = new System.Drawing.Point(7, 7);
            this.listePhrases.Name = "listePhrases";
            this.listePhrases.Size = new System.Drawing.Size(775, 427);
            this.listePhrases.TabIndex = 0;
            this.listePhrases.UseCompatibleStateImageBehavior = false;
            this.listePhrases.View = System.Windows.Forms.View.Details;
            // 
            // texte
            // 
            this.texte.Text = "Texte";
            this.texte.Width = 750;
            // 
            // Form_AjoutMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 483);
            this.Controls.Add(this.tabSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AjoutMot";
            this.Text = "Gestion du contenu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeMots)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabNom.ResumeLayout(false);
            this.tabNom.PerformLayout();
            this.tabVerbe.ResumeLayout(false);
            this.tabVerbe.PerformLayout();
            this.tabAdjectif.ResumeLayout(false);
            this.tabAdjectif.PerformLayout();
            this.tabDivers.ResumeLayout(false);
            this.tabDivers.PerformLayout();
            this.tabSelection.ResumeLayout(false);
            this.tabMot.ResumeLayout(false);
            this.tabPhrase.ResumeLayout(false);
            this.tabPhrase.PerformLayout();
            this.tabListePhrase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listeMots;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNom;
        private System.Windows.Forms.TabPage tabVerbe;
        private System.Windows.Forms.TabPage tabAdjectif;
        private System.Windows.Forms.TextBox texteNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox natureNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nombreNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genreNom;
        private System.Windows.Forms.Button ajoutNom;
        private System.Windows.Forms.Button ajoutVerbe;
        private System.Windows.Forms.ComboBox fonctionVerbe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox infinitifVerbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pers3PVerbe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pers2PVerbe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pers1PVerbe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pers3SVerbe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pers2SVerbe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pers1SVerbe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ajoutAdjectif;
        private System.Windows.Forms.ComboBox nombreAdjectif;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox genreAdjectif;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox fonctionAdjectif;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox texteAdjectif;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabSelection;
        private System.Windows.Forms.TabPage tabMot;
        private System.Windows.Forms.TabPage tabPhrase;
        private System.Windows.Forms.Button AnalyserPhrase;
        private System.Windows.Forms.TextBox inputPhrase;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel formulaireComplementPhrase;
        private System.Windows.Forms.Button ValiderPhrase;
        private System.Windows.Forms.TabPage tabListePhrase;
        private System.Windows.Forms.ListView listePhrases;
        private System.Windows.Forms.ColumnHeader texte;
        private System.Windows.Forms.TabPage tabDivers;
        private System.Windows.Forms.ComboBox nombreMot;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox genreMot;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox typeMot;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox texteMot;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button ajoutMot;
    }
}