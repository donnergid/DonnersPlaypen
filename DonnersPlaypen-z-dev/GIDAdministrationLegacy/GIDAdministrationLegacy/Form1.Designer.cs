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
            this.btnHideTestInterface = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnReCreateFile = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnShowTestInterface = new System.Windows.Forms.Button();
            this.pnlAddNewMember = new System.Windows.Forms.Panel();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblCharRace = new System.Windows.Forms.Label();
            this.lblCharClass = new System.Windows.Forms.Label();
            this.cmbbxCharRace = new System.Windows.Forms.ComboBox();
            this.cmbbxCharClass = new System.Windows.Forms.ComboBox();
            this.lblCharSpec = new System.Windows.Forms.Label();
            this.cmbbxCharSpec = new System.Windows.Forms.ComboBox();
            this.txbxCharName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.btnAddMemberApply = new System.Windows.Forms.Button();
            this.lblErrorStatus = new System.Windows.Forms.Label();
            this.pnlTestInterface.SuspendLayout();
            this.pnlAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTestInterface
            // 
            this.pnlTestInterface.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTestInterface.Controls.Add(this.lblErrorStatus);
            this.pnlTestInterface.Controls.Add(this.btnHideTestInterface);
            this.pnlTestInterface.Controls.Add(this.lblDisplay);
            this.pnlTestInterface.Controls.Add(this.btnReCreateFile);
            this.pnlTestInterface.Controls.Add(this.btnAddText);
            this.pnlTestInterface.Controls.Add(this.btnDeleteFile);
            this.pnlTestInterface.Controls.Add(this.btnCreateFile);
            this.pnlTestInterface.Location = new System.Drawing.Point(1, 973);
            this.pnlTestInterface.Name = "pnlTestInterface";
            this.pnlTestInterface.Size = new System.Drawing.Size(1383, 316);
            this.pnlTestInterface.TabIndex = 0;
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
            this.btnShowTestInterface.Location = new System.Drawing.Point(1198, 12);
            this.btnShowTestInterface.Name = "btnShowTestInterface";
            this.btnShowTestInterface.Size = new System.Drawing.Size(180, 92);
            this.btnShowTestInterface.TabIndex = 5;
            this.btnShowTestInterface.Text = "Admin";
            this.btnShowTestInterface.UseVisualStyleBackColor = true;
            this.btnShowTestInterface.Click += new System.EventHandler(this.btnShowTestInterface_Click);
            // 
            // pnlAddNewMember
            // 
            this.pnlAddNewMember.BackColor = System.Drawing.Color.Firebrick;
            this.pnlAddNewMember.Controls.Add(this.btnAddMemberApply);
            this.pnlAddNewMember.Controls.Add(this.label2);
            this.pnlAddNewMember.Controls.Add(this.comboBox1);
            this.pnlAddNewMember.Controls.Add(this.label1);
            this.pnlAddNewMember.Controls.Add(this.txbxCharName);
            this.pnlAddNewMember.Controls.Add(this.cmbbxCharSpec);
            this.pnlAddNewMember.Controls.Add(this.lblCharSpec);
            this.pnlAddNewMember.Controls.Add(this.cmbbxCharClass);
            this.pnlAddNewMember.Controls.Add(this.cmbbxCharRace);
            this.pnlAddNewMember.Controls.Add(this.lblCharClass);
            this.pnlAddNewMember.Controls.Add(this.lblCharRace);
            this.pnlAddNewMember.Controls.Add(this.lblCharName);
            this.pnlAddNewMember.Location = new System.Drawing.Point(-9, 0);
            this.pnlAddNewMember.Name = "pnlAddNewMember";
            this.pnlAddNewMember.Size = new System.Drawing.Size(510, 401);
            this.pnlAddNewMember.TabIndex = 6;
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharName.Location = new System.Drawing.Point(25, 94);
            this.lblCharName.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(220, 35);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Character Name: ";
            // 
            // lblCharRace
            // 
            this.lblCharRace.AutoSize = true;
            this.lblCharRace.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharRace.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharRace.Location = new System.Drawing.Point(25, 142);
            this.lblCharRace.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharRace.Name = "lblCharRace";
            this.lblCharRace.Size = new System.Drawing.Size(220, 35);
            this.lblCharRace.TabIndex = 1;
            this.lblCharRace.Text = "Character Race:";
            // 
            // lblCharClass
            // 
            this.lblCharClass.AutoSize = true;
            this.lblCharClass.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharClass.Location = new System.Drawing.Point(25, 191);
            this.lblCharClass.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharClass.Name = "lblCharClass";
            this.lblCharClass.Size = new System.Drawing.Size(220, 35);
            this.lblCharClass.TabIndex = 2;
            this.lblCharClass.Text = "Character Class: ";
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
            this.cmbbxCharRace.Location = new System.Drawing.Point(268, 142);
            this.cmbbxCharRace.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxCharRace.Name = "cmbbxCharRace";
            this.cmbbxCharRace.Size = new System.Drawing.Size(230, 40);
            this.cmbbxCharRace.TabIndex = 3;
            this.cmbbxCharRace.Text = "<Choose Race>";
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
            this.cmbbxCharClass.Location = new System.Drawing.Point(268, 191);
            this.cmbbxCharClass.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxCharClass.Name = "cmbbxCharClass";
            this.cmbbxCharClass.Size = new System.Drawing.Size(230, 40);
            this.cmbbxCharClass.TabIndex = 4;
            this.cmbbxCharClass.Text = "<Choose Class>";
            // 
            // lblCharSpec
            // 
            this.lblCharSpec.AutoSize = true;
            this.lblCharSpec.BackColor = System.Drawing.Color.IndianRed;
            this.lblCharSpec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharSpec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCharSpec.Location = new System.Drawing.Point(25, 239);
            this.lblCharSpec.MinimumSize = new System.Drawing.Size(220, 35);
            this.lblCharSpec.Name = "lblCharSpec";
            this.lblCharSpec.Size = new System.Drawing.Size(220, 35);
            this.lblCharSpec.TabIndex = 5;
            this.lblCharSpec.Text = "Character Spec: ";
            // 
            // cmbbxCharSpec
            // 
            this.cmbbxCharSpec.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbbxCharSpec.FormattingEnabled = true;
            this.cmbbxCharSpec.Location = new System.Drawing.Point(268, 239);
            this.cmbbxCharSpec.MinimumSize = new System.Drawing.Size(220, 0);
            this.cmbbxCharSpec.Name = "cmbbxCharSpec";
            this.cmbbxCharSpec.Size = new System.Drawing.Size(230, 40);
            this.cmbbxCharSpec.TabIndex = 6;
            this.cmbbxCharSpec.Text = "<Choose Spec>";
            // 
            // txbxCharName
            // 
            this.txbxCharName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbxCharName.Location = new System.Drawing.Point(268, 94);
            this.txbxCharName.Name = "txbxCharName";
            this.txbxCharName.Size = new System.Drawing.Size(230, 39);
            this.txbxCharName.TabIndex = 7;
            this.txbxCharName.Text = "<Enter Name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(25, 285);
            this.label1.MinimumSize = new System.Drawing.Size(220, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Locale: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AEST",
            "BRT",
            "CDT",
            "EDT",
            "MDT",
            "PDT"});
            this.comboBox1.Location = new System.Drawing.Point(268, 285);
            this.comboBox1.MinimumSize = new System.Drawing.Size(220, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 40);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "<Choose Locale>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.MinimumSize = new System.Drawing.Size(220, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 62);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Member Creation";
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddNewMember.Location = new System.Drawing.Point(1003, 12);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(180, 92);
            this.btnAddNewMember.TabIndex = 7;
            this.btnAddNewMember.Text = "New Member";
            this.btnAddNewMember.UseVisualStyleBackColor = true;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // btnAddMemberApply
            // 
            this.btnAddMemberApply.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddMemberApply.Location = new System.Drawing.Point(408, 343);
            this.btnAddMemberApply.Name = "btnAddMemberApply";
            this.btnAddMemberApply.Size = new System.Drawing.Size(90, 46);
            this.btnAddMemberApply.TabIndex = 8;
            this.btnAddMemberApply.Text = "Apply";
            this.btnAddMemberApply.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1390, 1289);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.Button btnAddMemberApply;
        private System.Windows.Forms.Label lblErrorStatus;
    }
}

