namespace WDBXEditor.Forms
{
    partial class LegionParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegionParser));
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuild = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoCASC = new System.Windows.Forms.RadioButton();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.autoProgressBar1 = new WDBXEditor.Common.AutoProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parsed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(524, 2);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 42);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Files";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Build Number: ";
            // 
            // txtBuild
            // 
            this.txtBuild.Location = new System.Drawing.Point(170, 6);
            this.txtBuild.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(338, 35);
            this.txtBuild.TabIndex = 2;
            // 
            // btnParse
            // 
            this.btnParse.Enabled = false;
            this.btnParse.Location = new System.Drawing.Point(686, 2);
            this.btnParse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(150, 42);
            this.btnParse.TabIndex = 3;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(734, 650);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(572, 650);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdoCASC
            // 
            this.rdoCASC.AutoSize = true;
            this.rdoCASC.Checked = true;
            this.rdoCASC.Location = new System.Drawing.Point(170, 54);
            this.rdoCASC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoCASC.Name = "rdoCASC";
            this.rdoCASC.Size = new System.Drawing.Size(149, 28);
            this.rdoCASC.TabIndex = 8;
            this.rdoCASC.TabStop = true;
            this.rdoCASC.Text = "From CASC";
            this.rdoCASC.UseVisualStyleBackColor = true;
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(340, 54);
            this.rdoFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(149, 28);
            this.rdoFile.TabIndex = 9;
            this.rdoFile.Text = "From File";
            this.rdoFile.UseVisualStyleBackColor = true;
            // 
            // autoProgressBar1
            // 
            this.autoProgressBar1.Location = new System.Drawing.Point(30, 650);
            this.autoProgressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.autoProgressBar1.Name = "autoProgressBar1";
            this.autoProgressBar1.Size = new System.Drawing.Size(530, 42);
            this.autoProgressBar1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuild);
            this.panel1.Controls.Add(this.rdoFile);
            this.panel1.Controls.Add(this.btnParse);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.rdoCASC);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 90);
            this.panel1.TabIndex = 10;
            // 
            // dgFiles
            // 
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToResizeColumns = false;
            this.dgFiles.AllowUserToResizeRows = false;
            this.dgFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File,
            this.Parsed});
            this.dgFiles.Location = new System.Drawing.Point(22, 124);
            this.dgFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.ReadOnly = true;
            this.dgFiles.RowHeadersWidth = 82;
            this.dgFiles.Size = new System.Drawing.Size(862, 515);
            this.dgFiles.TabIndex = 11;
            // 
            // File
            // 
            this.File.FillWeight = 250F;
            this.File.HeaderText = "DB File";
            this.File.MinimumWidth = 10;
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // Parsed
            // 
            this.Parsed.HeaderText = "Parsed";
            this.Parsed.MinimumWidth = 10;
            this.Parsed.Name = "Parsed";
            this.Parsed.ReadOnly = true;
            // 
            // LegionParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(888, 655);
            this.Controls.Add(this.dgFiles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.autoProgressBar1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(914, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(914, 726);
            this.Name = "LegionParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Legion Parser (WDB5, WDB6)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuild;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private Common.AutoProgressBar autoProgressBar1;
        private System.Windows.Forms.RadioButton rdoCASC;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Parsed;
    }
}