namespace WDBXEditor
{
    partial class LoadSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadSQL));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlDatabases = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlTable = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radNewOnly = new System.Windows.Forms.RadioButton();
            this.radOverride = new System.Windows.Forms.RadioButton();
            this.radUpdate = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(134, 20);
            this.txtHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(546, 35);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(134, 68);
            this.txtPort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(546, 35);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "3308";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(134, 116);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(546, 35);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "acore";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(134, 164);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(546, 35);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "acore";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database:";
            // 
            // ddlDatabases
            // 
            this.ddlDatabases.Enabled = false;
            this.ddlDatabases.FormattingEnabled = true;
            this.ddlDatabases.Location = new System.Drawing.Point(134, 212);
            this.ddlDatabases.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ddlDatabases.Name = "ddlDatabases";
            this.ddlDatabases.Size = new System.Drawing.Size(400, 32);
            this.ddlDatabases.TabIndex = 6;
            this.ddlDatabases.SelectedIndexChanged += new System.EventHandler(this.ddlDatabases_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(550, 212);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 39);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Connect";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlTable);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.radNewOnly);
            this.panel1.Controls.Add(this.radOverride);
            this.panel1.Controls.Add(this.radUpdate);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlDatabases);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 474);
            this.panel1.TabIndex = 11;
            // 
            // ddlTable
            // 
            this.ddlTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTable.FormattingEnabled = true;
            this.ddlTable.Location = new System.Drawing.Point(132, 262);
            this.ddlTable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ddlTable.Name = "ddlTable";
            this.ddlTable.Size = new System.Drawing.Size(402, 32);
            this.ddlTable.TabIndex = 7;
            this.ddlTable.SelectedIndexChanged += new System.EventHandler(this.ddlTable_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Table:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.MaximumSize = new System.Drawing.Size(740, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(382, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Override All: Replaces all data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.MaximumSize = new System.Drawing.Size(700, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(646, 48);
            this.label7.TabIndex = 24;
            this.label7.Text = "Update Existing: Imports new records and updates any existing ones that are diffe" +
    "rent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 349);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.MaximumSize = new System.Drawing.Size(400, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 48);
            this.label8.TabIndex = 23;
            this.label8.Text = "Import New: Imports new records only";
            // 
            // radNewOnly
            // 
            this.radNewOnly.AutoSize = true;
            this.radNewOnly.Checked = true;
            this.radNewOnly.Location = new System.Drawing.Point(93, 312);
            this.radNewOnly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radNewOnly.Name = "radNewOnly";
            this.radNewOnly.Size = new System.Drawing.Size(161, 28);
            this.radNewOnly.TabIndex = 8;
            this.radNewOnly.TabStop = true;
            this.radNewOnly.Text = "Import New";
            this.radNewOnly.UseVisualStyleBackColor = true;
            // 
            // radOverride
            // 
            this.radOverride.AutoSize = true;
            this.radOverride.Location = new System.Drawing.Point(512, 312);
            this.radOverride.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radOverride.Name = "radOverride";
            this.radOverride.Size = new System.Drawing.Size(185, 28);
            this.radOverride.TabIndex = 10;
            this.radOverride.Text = "Override All";
            this.radOverride.UseVisualStyleBackColor = true;
            // 
            // radUpdate
            // 
            this.radUpdate.AutoSize = true;
            this.radUpdate.Location = new System.Drawing.Point(266, 312);
            this.radUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radUpdate.Name = "radUpdate";
            this.radUpdate.Size = new System.Drawing.Size(221, 28);
            this.radUpdate.TabIndex = 9;
            this.radUpdate.Text = "Update Existing";
            this.radUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(424, 508);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 42);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(586, 508);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 42);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoadSQL
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(740, 557);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 628);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 628);
            this.Name = "LoadSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SQL Settings";
            this.Load += new System.EventHandler(this.LoadSQL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlDatabases;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radNewOnly;
        private System.Windows.Forms.RadioButton radOverride;
        private System.Windows.Forms.RadioButton radUpdate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox ddlTable;
        private System.Windows.Forms.Label label9;
    }
}