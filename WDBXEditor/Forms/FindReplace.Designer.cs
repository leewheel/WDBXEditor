﻿namespace WDBXEditor
{
    partial class FindReplace
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.chkExact = new System.Windows.Forms.CheckBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoFlag = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(180, 22);
            this.txtFind.Margin = new System.Windows.Forms.Padding(6);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(404, 35);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "查找:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "替换为:";
            // 
            // txtReplace
            // 
            this.txtReplace.Enabled = false;
            this.txtReplace.Location = new System.Drawing.Point(180, 70);
            this.txtReplace.Margin = new System.Windows.Forms.Padding(6);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(404, 35);
            this.txtReplace.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(638, 19);
            this.btnFind.Margin = new System.Windows.Forms.Padding(6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 42);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查找下一个";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(638, 73);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(6);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(150, 42);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "替换";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Enabled = false;
            this.btnReplaceAll.Location = new System.Drawing.Point(638, 127);
            this.btnReplaceAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(150, 42);
            this.btnReplaceAll.TabIndex = 4;
            this.btnReplaceAll.Text = "全部替换";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(638, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 210);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 24);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "....";
            this.lblResult.Visible = false;
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(274, 118);
            this.chkCase.Margin = new System.Windows.Forms.Padding(6);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(162, 28);
            this.chkCase.TabIndex = 7;
            this.chkCase.Text = "Match Case";
            this.chkCase.UseVisualStyleBackColor = true;
            this.chkCase.CheckedChanged += new System.EventHandler(this.chkCase_CheckedChanged);
            // 
            // chkExact
            // 
            this.chkExact.AutoSize = true;
            this.chkExact.Location = new System.Drawing.Point(274, 161);
            this.chkExact.Margin = new System.Windows.Forms.Padding(6);
            this.chkExact.Name = "chkExact";
            this.chkExact.Size = new System.Drawing.Size(354, 28);
            this.chkExact.TabIndex = 8;
            this.chkExact.Text = "Match Entire Cell Contents";
            this.chkExact.UseVisualStyleBackColor = true;
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Checked = true;
            this.rdoText.Location = new System.Drawing.Point(274, 203);
            this.rdoText.Margin = new System.Windows.Forms.Padding(6);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(149, 28);
            this.rdoText.TabIndex = 10;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text Mode";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoFlag
            // 
            this.rdoFlag.AutoSize = true;
            this.rdoFlag.Location = new System.Drawing.Point(438, 203);
            this.rdoFlag.Margin = new System.Windows.Forms.Padding(6);
            this.rdoFlag.Name = "rdoFlag";
            this.rdoFlag.Size = new System.Drawing.Size(149, 28);
            this.rdoFlag.TabIndex = 11;
            this.rdoFlag.Text = "Flag Mode";
            this.rdoFlag.UseVisualStyleBackColor = true;
            // 
            // FindReplace
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 276);
            this.Controls.Add(this.rdoText);
            this.Controls.Add(this.rdoFlag);
            this.Controls.Add(this.chkExact);
            this.Controls.Add(this.chkCase);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 250);
            this.Name = "FindReplace";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Activated += new System.EventHandler(this.FindReplace_Activated);
            this.Deactivate += new System.EventHandler(this.FindReplace_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindReplace_FormClosing);
            this.Load += new System.EventHandler(this.FindReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.CheckBox chkExact;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoFlag;
    }
}