namespace GIDAdministrationLegacy
{
    partial class Form1
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
            this.pnlTestInterface = new System.Windows.Forms.Panel();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.btnHideTestInterface = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnReCreateFile = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnShowTestInterface = new System.Windows.Forms.Button();
            this.pnlAddNewMember = new System.Windows.Forms.Panel();
            this.cmbbxRealm = new System.Windows.Forms.ComboBox();
            this.cmbbxGuildName = new System.Windows.Forms.ComboBox();
            this.lblRealm = new System.Windows.Forms.Label();
            this.lblGuildName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbxLocale = new System.Windows.Forms.ComboBox();
            this.lblAccLocale = new System.Windows.Forms.Label();
            this.txbxCharName = new System.Windows.Forms.TextBox();
            this.cmbbxCharSpec = new System.Windows.Forms.ComboBox();
            this.lblCharSpec = new System.Windows.Forms.Label();
            this.cmbbxCharClass = new System.Windows.Forms.ComboBox();
            this.cmbbxCharRace = new System.Windows.Forms.ComboBox();
            this.lblCharClass = new System.Windows.Forms.Label();
            this.lblCharRace = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.btnShowMembers = new System.Windows.Forms.Button();
            this.pnlViewMembers = new System.Windows.Forms.Panel();
            this.lstvwViewMembers = new System.Windows.Forms.ListView();
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadRace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadSpec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.pnlTestInterface.SuspendLayout();
            this.pnlAddNewMember.SuspendLayout();
            this.pnlViewMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTestInterface
            // 
            this.pnlTestInterface.AutoSize = true;
            this.pnlTestInterface.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTestInterface.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTestInterface.Controls.Add(this.lblErrorStatus);
            this.pnlTestInterface.Controls.Add(this.btnHideTestInterface);
            this.pnlTestInterface.Controls.Add(this.lblDisplay);
            this.pnlTestInterface.Controls.Add(this.btnReCreateFile);
            this.pnlTestInterface.Controls.Add(this.btnAddText);
            this.pnlTestInterface.Controls.Add(this.btnDeleteFile);
            this.pnlTestInterface.Controls.Add(this.btnCreateFile);
            this.pnlTestInterface.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTestInterface.Location = new System.Drawing.Point(0, 764);
            this.pnlTestInterface.Name = "pnlTestInterface";
            this.pnlTestInterface.Size = new System.Drawing.Size(1447, 307);
            this.pnlTestInterface.TabIndex = 0;
            // 
            // lblErrorStatus
            // 
            this.lblErrorStatus.AutoSize = true;
            this.lblErrorStatus.BackColor = System.Drawing.Color.IndianRed;
            this.lblErrorStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorStatus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblErrorStatus.Location = new System.Drawing.Point(839, 37);
            this.lblErrorStatus.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblErrorStatus.Name = "lblErrorStatus";
            this.lblErrorStatus.Size = new System.Drawing.Size(245, 40);
            this.lblErrorStatus.TabIndex = 11;
            this.lblErrorStatus.Text = "Errors show here...";
            // 
            // btnHideTestInterface
            // 
            this.btnHideTestInterface.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHideTestInterface.Location = new System.Drawing.Point(1197, 212);
            this.btnHideTestInterface.Name = "btnHideTestInterface";
            this.btnHideTestInterface.Size = new System.Drawing.Size(180, 92);
            this.btnHideTestInterface.TabIndex = 5;
            this.btnHideTestInterface.Text = "Close";
            this.btnHideTestInterface.UseVisualStyleBackColor = true;
            this.btnHideTestInterface.Click += new System.EventHandler(this.btnHideTestInterface_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(4, 167);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(946, 65);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "This is the text we will add to the JSON file. ";
            // 
            // btnReCreateFile
            // 
            this.btnReCreateFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReCreateFile.Location = new System.Drawing.Point(573, 17);
            this.btnReCreateFile.Name = "btnReCreateFile";
            this.btnReCreateFile.Size = new System.Drawing.Size(180, 92);
            this.btnReCreateFile.TabIndex = 3;
            this.btnReCreateFile.Text = "Recreate File";
            this.btnReCreateFile.UseVisualStyleBackColor = true;
            // 
            // btnAddText
            // 
            this.btnAddText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddText.Location = new System.Drawing.Point(387, 17);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(180, 92);
            this.btnAddText.TabIndex = 2;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteFile.Location = new System.Drawing.Point(201, 17);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(180, 92);
            this.btnDeleteFile.TabIndex = 1;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreateFile.Location = new System.Drawing.Point(15, 17);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(180, 92);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnShowTestInterface
            // 
            this.btnShowTestInterface.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowTestInterface.Location = new System.Drawing.Point(768, 6);
            this.btnShowTestInterface.Name = "btnShowTestInterface";
            this.btnShowTestInterface.Size = new System.Drawing.Size(105, 55);
            this.btnShowTestInterface.TabIndex = 5;
            this.btnShowTestInterface.Text = "Admin";
            this.btnShowTestInterface.UseVisualStyleBackColor = true;
            this.btnShowTestInterface.Click += new System.EventHandler(this.btnShowTestInterface_Click);
            // 
            // pnlAddNewMember
            // 
            this.pnlAddNewMember.BackColor = System.Drawing.Color.Firebrick;
            this.pnlAddNewMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddNewMember.Controls.Add(this.cmbbxRealm);
            this.pnlAddNewMember.Controls.Add(this.cmbbxGuildName);
            this.pnlAddNewMember.Controls.Add(this.lblRealm);
            this.pnlAddNewMember.Controls.Add(this.lblGuildName);
            this.pnlAddNewMember.Controls.Add(this.label2);
            this.pnlAddNewMember.Controls.Add(this.cmbbxLocale);
            this.pnlAddNewMember.Controls.Add(this.lblAccLocale);
            this.pnlAddNewMember.Controls.Add(this.txbxCharName);
            this.pnlAddNewMember.Controls.Add(this.cmbbxCharSpec);
            this.pnlAddNewMember.Controls.Add(this.lblCharSpec);
            this.pnlAddNewMember.Controls.Add(this.cmbbxCharClass);
            this.pnlAddNewMember.Controls.Add(this.cmbbxCharRace);
            this.pnlAddNewMember.Controls.Add(this.lblCharClass);
            this.pnlAddNewMember.Controls.Add(this.lblCharRace);
            this.pnlAddNewMember.Controls.Add(this.lblCharName);
            this.pnlAddNewMember.Location = new System.Drawing.Point(3, 65);
            this.pnlAddNewMember.Name = "pnlAddNewMember";
            this.pnlAddNewMember.Size = new System.Drawing.Size(475, 387);
            this.pnlAddNewMember.TabIndex = 6;
            // 
            // cmbbxRealm
            // 
            this.cmbbxRealm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxRealm.FormattingEnabled = true;
            this.cmbbxRealm.Items.AddRange(new object[] {
            "Antonidas",
            "Killrogg",
            "Shu\'halo"});
            this.cmbbxRealm.Location = new System.Drawing.Point(235, 326);
            this.cmbbxRealm.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxRealm.Name = "cmbbxRealm";
            this.cmbbxRealm.Size = new System.Drawing.Size(230, 40);
            this.cmbbxRealm.TabIndex = 7;
            this.cmbbxRealm.Text = "<Choose Realm>";
            // 
            // cmbbxGuildName
            // 
            this.cmbbxGuildName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxGuildName.FormattingEnabled = true;
            this.cmbbxGuildName.Items.AddRange(new object[] {
            "NONE",
            "Death Vendors",
            "Ghosts in the Darkness",
            "Origin"});
            this.cmbbxGuildName.Location = new System.Drawing.Point(235, 282);
            this.cmbbxGuildName.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxGuildName.Name = "cmbbxGuildName";
            this.cmbbxGuildName.Size = new System.Drawing.Size(230, 40);
            this.cmbbxGuildName.TabIndex = 6;
            this.cmbbxGuildName.Text = "<Choose Guild>";
            // 
            // lblRealm
            // 
            this.lblRealm.AutoSize = true;
            this.lblRealm.BackColor = System.Drawing.Color.IndianRed;
            this.lblRealm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRealm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRealm.Location = new System.Drawing.Point(9, 326);
            this.lblRealm.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblRealm.Name = "lblRealm";
            this.lblRealm.Size = new System.Drawing.Size(220, 35);
            this.lblRealm.TabIndex = 12;
            this.lblRealm.Text = "Realm: ";
            // 
            // lblGuildName
            // 
            this.lblGuildName.AutoSize = true;
            this.lblGuildName.BackColor = System.Drawing.Color.IndianRed;
            this.lblGuildName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGuildName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGuildName.Location = new System.Drawing.Point(9, 282);
            this.lblGuildName.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblGuildName.Name = "lblGuildName";
            this.lblGuildName.Size = new System.Drawing.Size(220, 35);
            this.lblGuildName.TabIndex = 11;
            this.lblGuildName.Text = "Guild Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.MinimumSize = new System.Drawing.Size(220, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 62);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Member Creation";
            // 
            // cmbbxLocale
            // 
            this.cmbbxLocale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxLocale.FormattingEnabled = true;
            this.cmbbxLocale.Items.AddRange(new object[] {
            "AEST",
            "BRT",
            "CDT",
            "EDT",
            "MDT",
            "PDT"});
            this.cmbbxLocale.Location = new System.Drawing.Point(235, 238);
            this.cmbbxLocale.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxLocale.Name = "cmbbxLocale";
            this.cmbbxLocale.Size = new System.Drawing.Size(230, 40);
            this.cmbbxLocale.TabIndex = 5;
            this.cmbbxLocale.Text = "<Choose Time Zone>";
            // 
            // lblAccLocale
            // 
            this.lblAccLocale.AutoSize = true;
            this.lblAccLocale.BackColor = System.Drawing.Color.IndianRed;
            this.lblAccLocale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccLocale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAccLocale.Location = new System.Drawing.Point(9, 238);
            this.lblAccLocale.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblAccLocale.Name = "lblAccLocale";
            this.lblAccLocale.Size = new System.Drawing.Size(238, 35);
            this.lblAccLocale.TabIndex = 8;
            this.lblAccLocale.Text = "Account Time Zone: ";
            // 
            // txbxCharName
            // 
            this.txbxCharName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbxCharName.Location = new System.Drawing.Point(235, 61);
            this.txbxCharName.Name = "txbxCharName";
            this.txbxCharName.Size = new System.Drawing.Size(230, 39);
            this.txbxCharName.TabIndex = 1;
            this.txbxCharName.Text = "<Enter Name>";
            // 
            // cmbbxCharSpec
            // 
            this.cmbbxCharSpec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxCharSpec.FormattingEnabled = true;
            this.cmbbxCharSpec.Location = new System.Drawing.Point(235, 192);
            this.cmbbxCharSpec.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxCharSpec.Name = "cmbbxCharSpec";
            this.cmbbxCharSpec.Size = new System.Drawing.Size(230, 40);
            this.cmbbxCharSpec.TabIndex = 4;
            this.cmbbxCharSpec.Text = "...";
            // 
            // lblCharSpec
            // 
            this.lblCharSpec.AutoSize = true;
            this.lblCharSpec.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharSpec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharSpec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharSpec.Location = new System.Drawing.Point(9, 192);
            this.lblCharSpec.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharSpec.Name = "lblCharSpec";
            this.lblCharSpec.Size = new System.Drawing.Size(220, 35);
            this.lblCharSpec.TabIndex = 5;
            this.lblCharSpec.Text = "Character Spec: ";
            // 
            // cmbbxCharClass
            // 
            this.cmbbxCharClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxCharClass.FormattingEnabled = true;
            this.cmbbxCharClass.Items.AddRange(new object[] {
            "Death Knight",
            "Demon Hunter",
            "Druid",
            "Hunter",
            "Mage",
            "Monk",
            "Paladin",
            "Priest",
            "Rogue",
            "Shaman",
            "Warlock",
            "Warrior"});
            this.cmbbxCharClass.Location = new System.Drawing.Point(235, 147);
            this.cmbbxCharClass.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxCharClass.Name = "cmbbxCharClass";
            this.cmbbxCharClass.Size = new System.Drawing.Size(230, 40);
            this.cmbbxCharClass.TabIndex = 3;
            this.cmbbxCharClass.Text = "<Choose Class>";
            this.cmbbxCharClass.SelectedIndexChanged += new System.EventHandler(this.cmbbxCharClass_SelectedIndexChanged);
            // 
            // cmbbxCharRace
            // 
            this.cmbbxCharRace.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxCharRace.FormattingEnabled = true;
            this.cmbbxCharRace.Items.AddRange(new object[] {
            "Blood Elf",
            "Goblin",
            "Orc",
            "Pandaren",
            "Tauren",
            "Troll",
            "Undead",
            "Draenei",
            "Dwarf",
            "Gnome",
            "Human",
            "Night Elf",
            "Pandaren",
            "Worgen"});
            this.cmbbxCharRace.Location = new System.Drawing.Point(235, 105);
            this.cmbbxCharRace.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxCharRace.Name = "cmbbxCharRace";
            this.cmbbxCharRace.Size = new System.Drawing.Size(230, 40);
            this.cmbbxCharRace.TabIndex = 2;
            this.cmbbxCharRace.Text = "<Choose Race>";
            // 
            // lblCharClass
            // 
            this.lblCharClass.AutoSize = true;
            this.lblCharClass.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharClass.Location = new System.Drawing.Point(9, 147);
            this.lblCharClass.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharClass.Name = "lblCharClass";
            this.lblCharClass.Size = new System.Drawing.Size(220, 35);
            this.lblCharClass.TabIndex = 2;
            this.lblCharClass.Text = "Character Class: ";
            // 
            // lblCharRace
            // 
            this.lblCharRace.AutoSize = true;
            this.lblCharRace.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharRace.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharRace.Location = new System.Drawing.Point(9, 105);
            this.lblCharRace.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharRace.Name = "lblCharRace";
            this.lblCharRace.Size = new System.Drawing.Size(220, 35);
            this.lblCharRace.TabIndex = 1;
            this.lblCharRace.Text = "Character Race:";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharName.Location = new System.Drawing.Point(9, 61);
            this.lblCharName.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(220, 35);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Character Name: ";
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddNewMember.Location = new System.Drawing.Point(527, 6);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(204, 55);
            this.btnAddNewMember.TabIndex = 7;
            this.btnAddNewMember.Text = "New Member";
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // btnShowMembers
            // 
            this.btnShowMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowMembers.Location = new System.Drawing.Point(527, 78);
            this.btnShowMembers.Name = "btnShowMembers";
            this.btnShowMembers.Size = new System.Drawing.Size(204, 55);
            this.btnShowMembers.TabIndex = 9;
            this.btnShowMembers.Text = "Show Members";
            this.btnShowMembers.UseVisualStyleBackColor = true;
            this.btnShowMembers.Click += new System.EventHandler(this.btnShowMembers_Click);
            // 
            // pnlViewMembers
            // 
            this.pnlViewMembers.BackColor = System.Drawing.Color.Firebrick;
            this.pnlViewMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlViewMembers.Controls.Add(this.lstvwViewMembers);
            this.pnlViewMembers.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlViewMembers.Location = new System.Drawing.Point(879, 0);
            this.pnlViewMembers.Name = "pnlViewMembers";
            this.pnlViewMembers.Size = new System.Drawing.Size(568, 764);
            this.pnlViewMembers.TabIndex = 10;
            // 
            // lstvwViewMembers
            // 
            this.lstvwViewMembers.BackColor = System.Drawing.Color.DarkRed;
            this.lstvwViewMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName,
            this.colHeadRace,
            this.colHeadClass,
            this.colHeadSpec});
            this.lstvwViewMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvwViewMembers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstvwViewMembers.FullRowSelect = true;
            this.lstvwViewMembers.GridLines = true;
            this.lstvwViewMembers.Location = new System.Drawing.Point(0, 0);
            this.lstvwViewMembers.Name = "lstvwViewMembers";
            this.lstvwViewMembers.Size = new System.Drawing.Size(564, 760);
            this.lstvwViewMembers.TabIndex = 0;
            this.lstvwViewMembers.UseCompatibleStateImageBehavior = false;
            this.lstvwViewMembers.View = System.Windows.Forms.View.Details;
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Name";
            this.colHeadName.Width = 100;
            // 
            // colHeadRace
            // 
            this.colHeadRace.Text = "Race";
            this.colHeadRace.Width = 100;
            // 
            // colHeadClass
            // 
            this.colHeadClass.Text = "Class";
            this.colHeadClass.Width = 100;
            // 
            // colHeadSpec
            // 
            this.colHeadSpec.Text = "Spec";
            this.colHeadSpec.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "GiD Administration Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveData.Location = new System.Drawing.Point(527, 152);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(204, 55);
            this.btnSaveData.TabIndex = 12;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1447, 1071);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlViewMembers);
            this.Controls.Add(this.btnShowMembers);
            this.Controls.Add(this.btnAddNewMember);
            this.Controls.Add(this.pnlAddNewMember);
            this.Controls.Add(this.btnShowTestInterface);
            this.Controls.Add(this.pnlTestInterface);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form1";
            this.Text = "GID Administration [Legacy]";
            this.pnlTestInterface.ResumeLayout(false);
            this.pnlTestInterface.PerformLayout();
            this.pnlAddNewMember.ResumeLayout(false);
            this.pnlAddNewMember.PerformLayout();
            this.pnlViewMembers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTestInterface;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnReCreateFile;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnShowTestInterface;
        private System.Windows.Forms.Button btnHideTestInterface;
        private System.Windows.Forms.Panel pnlAddNewMember;
        private System.Windows.Forms.TextBox txbxCharName;
        private System.Windows.Forms.ComboBox cmbbxCharSpec;
        private System.Windows.Forms.Label lblCharSpec;
        private System.Windows.Forms.ComboBox cmbbxCharClass;
        private System.Windows.Forms.ComboBox cmbbxCharRace;
        private System.Windows.Forms.Label lblCharClass;
        private System.Windows.Forms.Label lblCharRace;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbxLocale;
        private System.Windows.Forms.Label lblAccLocale;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.Label lblErrorStatus;
        private System.Windows.Forms.Label lblRealm;
        private System.Windows.Forms.Label lblGuildName;
        private System.Windows.Forms.ComboBox cmbbxGuildName;
        private System.Windows.Forms.ComboBox cmbbxRealm;
        private System.Windows.Forms.Button btnShowMembers;
        private System.Windows.Forms.Panel pnlViewMembers;
        private System.Windows.Forms.ListView lstvwViewMembers;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadRace;
        private System.Windows.Forms.ColumnHeader colHeadClass;
        private System.Windows.Forms.ColumnHeader colHeadSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveData;
    }
}

