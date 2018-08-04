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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.btnReCreateFile = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnShowTestInterface = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideTestInterface = new System.Windows.Forms.Button();
            this.pnlTestInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTestInterface
            // 
            this.pnlTestInterface.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTestInterface.Controls.Add(this.btnHideTestInterface);
            this.pnlTestInterface.Controls.Add(this.lblDisplay);
            this.pnlTestInterface.Controls.Add(this.btnReCreateFile);
            this.pnlTestInterface.Controls.Add(this.btnAddText);
            this.pnlTestInterface.Controls.Add(this.btnDeleteFile);
            this.pnlTestInterface.Controls.Add(this.btnCreateFile);
            this.pnlTestInterface.Location = new System.Drawing.Point(1, 973);
            this.pnlTestInterface.Name = "pnlTestInterface";
            this.pnlTestInterface.Size = new System.Drawing.Size(1383, 304);
            this.pnlTestInterface.TabIndex = 0;
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
            // btnShowTestInterface
            // 
            this.btnShowTestInterface.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnShowTestInterface.Location = new System.Drawing.Point(1174, 37);
            this.btnShowTestInterface.Name = "btnShowTestInterface";
            this.btnShowTestInterface.Size = new System.Drawing.Size(180, 92);
            this.btnShowTestInterface.TabIndex = 5;
            this.btnShowTestInterface.Text = "Admin";
            this.btnShowTestInterface.UseVisualStyleBackColor = true;
            this.btnShowTestInterface.Click += new System.EventHandler(this.btnShowTestInterface_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnHideTestInterface
            // 
            this.btnHideTestInterface.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHideTestInterface.Location = new System.Drawing.Point(1173, 178);
            this.btnHideTestInterface.Name = "btnHideTestInterface";
            this.btnHideTestInterface.Size = new System.Drawing.Size(180, 92);
            this.btnHideTestInterface.TabIndex = 5;
            this.btnHideTestInterface.Text = "Close";
            this.btnHideTestInterface.UseVisualStyleBackColor = true;
            this.btnHideTestInterface.Click += new System.EventHandler(this.btnHideTestInterface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 1289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowTestInterface);
            this.Controls.Add(this.pnlTestInterface);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "Form1";
            this.Text = "GID Administration [Legacy]";
            this.pnlTestInterface.ResumeLayout(false);
            this.pnlTestInterface.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHideTestInterface;
    }
}

