using WDBXEditor.Common;

namespace WDBXEditor
{
    partial class LoadMPQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadMPQ));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLocales = new System.Windows.Forms.ComboBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lstFiles = new WDBXEditor.Common.BufferedListBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new WDBXEditor.Common.AutoProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLocales);
            this.panel1.Controls.Add(this.btnParse);
            this.panel1.Controls.Add(this.lstFiles);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 526);
            this.panel1.TabIndex = 14;
            // 
            // cbLocales
            // 
            this.cbLocales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocales.FormattingEnabled = true;
            this.cbLocales.Items.AddRange(new object[] {
            "DeDE",
            "EnCN",
            "EnGB",
            "EnTW",
            "EnUS",
            "EsES",
            "EsMX",
            "FrFR",
            "ItIT",
            "KoKR",
            "PtBR",
            "PtPT",
            "RuRU",
            "ZhCN",
            "ZhTW"});
            this.cbLocales.Location = new System.Drawing.Point(514, 13);
            this.cbLocales.Margin = new System.Windows.Forms.Padding(6);
            this.cbLocales.Name = "cbLocales";
            this.cbLocales.Size = new System.Drawing.Size(106, 32);
            this.cbLocales.Sorted = true;
            this.cbLocales.TabIndex = 19;
            // 
            // btnParse
            // 
            this.btnParse.Enabled = false;
            this.btnParse.Location = new System.Drawing.Point(630, 11);
            this.btnParse.Margin = new System.Windows.Forms.Padding(6);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(118, 42);
            this.btnParse.TabIndex = 9;
            this.btnParse.Text = "Load";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 24;
            this.lstFiles.Location = new System.Drawing.Point(16, 72);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(6);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFiles.Size = new System.Drawing.Size(728, 436);
            this.lstFiles.Sorted = true;
            this.lstFiles.TabIndex = 8;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(74, 13);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(294, 35);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(384, 11);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 42);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "File:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MPQ files (*.mpq)|*.mpq";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(480, 559);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 42);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Open";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(642, 558);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 42);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(40, 561);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(428, 39);
            this.progressBar.TabIndex = 17;
            // 
            // LoadMPQ
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 629);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(812, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(812, 700);
            this.Name = "LoadMPQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load From MPQ";
            this.Load += new System.EventHandler(this.LoadMPQ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BufferedListBox lstFiles;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private Common.AutoProgressBar progressBar;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button btnParse;
		private System.Windows.Forms.ComboBox cbLocales;
	}
}