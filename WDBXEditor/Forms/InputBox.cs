﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDBXEditor.Forms
{
    public static class InputBox
    {
        /// <summary>
        /// Generates the VB equivalent input box with label, field and buttons as a dialog
        /// </summary>
        /// <param name="Prompt"></param>
        /// <param name="Title"></param>
        /// <param name="Default"></param>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static DialogResult ShowInputDialog(string Prompt, string Title, string Default, ref string Result)
        {
            System.Drawing.Size size = new System.Drawing.Size(420, 270); // 放大窗口
            Form inputBox = new Form();

            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = Title;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.ShowIcon = false;
            inputBox.Font = new Font("Microsoft Sans Serif", 12F); // 放大字体！

            Label prompt = new Label();
            prompt.Size = new System.Drawing.Size(size.Width - 20, 30); // 加宽加高
            prompt.Location = new System.Drawing.Point(10, 10);
            prompt.Text = Prompt;
            inputBox.Controls.Add(prompt);

            TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 20, 35); // 高度也增加
            textBox.Location = new System.Drawing.Point(10, 50);
            textBox.Text = Default;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(100, 35); // 按钮变大
            okButton.Text = "&确定";
            okButton.Location = new System.Drawing.Point(size.Width / 2 - 110, 110);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(100, 35);
            cancelButton.Text = "&取消";
            cancelButton.Location = new System.Drawing.Point(size.Width / 2 + 10, 110);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            Result = textBox.Text;
            return result;
        }



        public static DialogResult ShowOverwriteDialog(string Prompt, string Title)
        {
            System.Drawing.Size size = new System.Drawing.Size(280, 105);
            Form inputBox = new Form();

            inputBox.StartPosition = FormStartPosition.CenterParent;
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = Title;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.MaximumSize = inputBox.Size;
            inputBox.MinimumSize = inputBox.Size;
            inputBox.ShowIcon = false;

            Panel panel = new Panel();
            panel.Size = new System.Drawing.Size(size.Width, inputBox.Size.Height - 85);
            panel.Location = new System.Drawing.Point(0, 0);
            panel.BackColor = System.Drawing.Color.White;
            inputBox.Controls.Add(panel);

            Label prompt = new Label();
            prompt.Size = new System.Drawing.Size(size.Width - 10, 30);
            prompt.Location = new System.Drawing.Point(15, (panel.Size.Height / 2) - 20);
            prompt.Text = Prompt;
            prompt.Font = new System.Drawing.Font("Segoe UI", 9);
            panel.Controls.Add(prompt);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "yesButton";
            okButton.Size = new System.Drawing.Size(75, 26);
            okButton.Text = "Append";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80 - 80, 69);
            okButton.Tag = DialogResult.Yes;
            inputBox.Controls.Add(okButton);

            Button overrideButton = new Button();
            overrideButton.DialogResult = DialogResult.Cancel;
            overrideButton.Name = "overButton";
            overrideButton.Size = new System.Drawing.Size(75, 26);
            overrideButton.Text = "Overwrite";
            overrideButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 69);
            overrideButton.Tag = DialogResult.No;
            inputBox.Controls.Add(overrideButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 26);
            cancelButton.Text = "Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 69);
            cancelButton.Tag = DialogResult.Cancel;
            inputBox.Controls.Add(cancelButton);

            cancelButton.Click += new EventHandler(Button_Click);
            overrideButton.Click += new EventHandler(Button_Click);
            okButton.Click += new EventHandler(Button_Click);

            return inputBox.ShowDialog();
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = (DialogResult)(((Button)sender).Tag); //Set the result

            //Find the parent form
            Control cntrl = (Control)sender;
            while (cntrl.GetType() != typeof(Form) && cntrl.Parent != null)
                cntrl = cntrl.Parent;

            if (cntrl.GetType() != typeof(Form)) return; //No parent form found

            //Set the result and close
            ((Form)cntrl).DialogResult = dialogResult;
            ((Form)cntrl).Close();
        }
    }
}
