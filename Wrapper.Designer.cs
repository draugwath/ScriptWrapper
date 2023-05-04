using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace ScriptWrapper
{
    partial class Wrapper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// Add control declarations
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonRunTest;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;


        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            buttonRunTest = new Button();
            richTextBoxOutput = new RichTextBox();
            checkBoxNoLogin = new CheckBox();
            checkBoxSaveOutputToFile = new CheckBox();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(173, 19);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(346, 39);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(668, 22);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(346, 39);
            textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.Location = new Point(21, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(146, 40);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.Location = new Point(540, 22);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(152, 58);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // buttonRunTest
            // 
            buttonRunTest.Location = new Point(1102, 12);
            buttonRunTest.Name = "buttonRunTest";
            buttonRunTest.Size = new Size(135, 61);
            buttonRunTest.TabIndex = 4;
            buttonRunTest.Text = "Test";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxOutput.Location = new Point(21, 83);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxOutput.Size = new Size(993, 368);
            richTextBoxOutput.TabIndex = 5;
            richTextBoxOutput.Text = "";
            // 
            // checkBoxNoLogin
            // 
            checkBoxNoLogin.Location = new Point(1038, 83);
            checkBoxNoLogin.Name = "checkBoxNoLogin";
            checkBoxNoLogin.Size = new Size(219, 89);
            checkBoxNoLogin.TabIndex = 6;
            checkBoxNoLogin.Text = "No Login mode";
            // 
            // checkBoxSaveOutputToFile
            // 
            checkBoxSaveOutputToFile.AutoSize = true;
            checkBoxSaveOutputToFile.Location = new Point(1038, 178);
            checkBoxSaveOutputToFile.Name = "checkBoxSaveOutputToFile";
            checkBoxSaveOutputToFile.Size = new Size(169, 36);
            checkBoxSaveOutputToFile.TabIndex = 7;
            checkBoxSaveOutputToFile.Text = "Save to File";
            checkBoxSaveOutputToFile.CheckedChanged += checkBoxSaveOutputToFile_CheckedChanged;
            // 
            // Wrapper
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 463);
            Controls.Add(checkBoxSaveOutputToFile);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(buttonRunTest);
            Controls.Add(richTextBoxOutput);
            Controls.Add(checkBoxNoLogin);
            MaximumSize = new Size(1294, 2147483591);
            MinimumSize = new Size(1294, 71);
            Name = "Wrapper";
            Text = "Connection Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


    }
}