﻿namespace WDBXEditor.Forms
{
    partial class ColourConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourConverter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.betSet = new System.Windows.Forms.Button();
            this.picColour = new System.Windows.Forms.PictureBox();
            this.txtWoWVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colourWheel = new WDBXEditor.Common.ColourWheel();
            ((System.ComponentModel.ISupportInitialize)(this.picColour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "G";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(486, 22);
            this.txtRed.Margin = new System.Windows.Forms.Padding(6);
            this.txtRed.MaxLength = 3;
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(120, 35);
            this.txtRed.TabIndex = 3;
            this.txtRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColourKeyPress);
            this.txtRed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtColourKeyUp);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(486, 70);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(6);
            this.txtGreen.MaxLength = 3;
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(120, 35);
            this.txtGreen.TabIndex = 4;
            this.txtGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColourKeyPress);
            this.txtGreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtColourKeyUp);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(486, 118);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(6);
            this.txtBlue.MaxLength = 3;
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(120, 35);
            this.txtBlue.TabIndex = 6;
            this.txtBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColourKeyPress);
            this.txtBlue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtColourKeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(298, 351);
            this.btnGet.Margin = new System.Windows.Forms.Padding(6);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(150, 42);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "获取颜色";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // betSet
            // 
            this.betSet.Location = new System.Drawing.Point(460, 351);
            this.betSet.Margin = new System.Windows.Forms.Padding(6);
            this.betSet.Name = "betSet";
            this.betSet.Size = new System.Drawing.Size(150, 42);
            this.betSet.TabIndex = 8;
            this.betSet.Text = "设置颜色";
            this.betSet.UseVisualStyleBackColor = true;
            this.betSet.Click += new System.EventHandler(this.betSet_Click);
            // 
            // picColour
            // 
            this.picColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColour.Location = new System.Drawing.Point(486, 166);
            this.picColour.Margin = new System.Windows.Forms.Padding(6);
            this.picColour.Name = "picColour";
            this.picColour.Size = new System.Drawing.Size(122, 50);
            this.picColour.TabIndex = 9;
            this.picColour.TabStop = false;
            // 
            // txtWoWVal
            // 
            this.txtWoWVal.Location = new System.Drawing.Point(486, 292);
            this.txtWoWVal.Margin = new System.Windows.Forms.Padding(6);
            this.txtWoWVal.MaxLength = 10;
            this.txtWoWVal.Name = "txtWoWVal";
            this.txtWoWVal.Size = new System.Drawing.Size(120, 35);
            this.txtWoWVal.TabIndex = 11;
            this.txtWoWVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWoWVal_KeyPress);
            this.txtWoWVal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWoWVal_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "WoW数值";
            // 
            // colourWheel
            // 
            this.colourWheel.CurrentColour = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colourWheel.Hue = ((byte)(0));
            this.colourWheel.Lightness = ((byte)(0));
            this.colourWheel.Location = new System.Drawing.Point(18, 18);
            this.colourWheel.Margin = new System.Windows.Forms.Padding(6);
            this.colourWheel.Name = "colourWheel";
            this.colourWheel.Saturation = ((byte)(0));
            this.colourWheel.SecondaryHues = null;
            this.colourWheel.Size = new System.Drawing.Size(374, 342);
            this.colourWheel.TabIndex = 0;
            this.colourWheel.HueChanged += new System.EventHandler(this.colourWheelChanged);
            this.colourWheel.SLChanged += new System.EventHandler(this.colourWheelChanged);
            // 
            // ColourConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.colourWheel);
            this.Controls.Add(this.txtWoWVal);
            this.Controls.Add(this.picColour);
            this.Controls.Add(this.betSet);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "ColourConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "颜色拾取器";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.ColourConverter_Activated);
            this.Deactivate += new System.EventHandler(this.ColourConverter_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColourConverter_FormClosing);
            this.Load += new System.EventHandler(this.ColourConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picColour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.ColourWheel colourWheel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button betSet;
        private System.Windows.Forms.PictureBox picColour;
        private System.Windows.Forms.TextBox txtWoWVal;
        private System.Windows.Forms.Label label4;
    }
}