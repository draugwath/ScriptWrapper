using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ScriptWrapper
{
    public partial class Wrapper : Form
    {
        private CheckBox checkBoxNoLogin;
        private CheckBox checkBoxSaveOutputToFile;

        public Wrapper()
        {
            InitializeComponent();

            buttonRunTest.Click += ButtonRunTest_Click;
            checkBoxNoLogin.CheckedChanged += CheckBoxNoLogin_CheckedChanged;
        }

        private void CheckBoxNoLogin_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUsername.Enabled = !checkBoxNoLogin.Checked;
            textBoxPassword.Enabled = !checkBoxNoLogin.Checked;
        }

        private void ButtonRunTest_Click(object sender, EventArgs e)
        {
            List<string> outputLines = new List<string>();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) && !checkBoxNoLogin.Checked)
            {
                MessageBox.Show("Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(password) && !checkBoxNoLogin.Checked)
            {
                MessageBox.Show("Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "account_control_test.exe");
            if (checkBoxNoLogin.Checked)
            {
                process.StartInfo.Arguments = $"/connectivity_test /no_login";
            }
            else
            {
                process.StartInfo.Arguments = $"/connectivity_test /account:{username} /password:{password}";
            }
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.EnableRaisingEvents = true;
            string outputFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "acronis_connectivity_check.txt");
            process.OutputDataReceived += (s, data) =>
            {
                if (!string.IsNullOrEmpty(data.Data))
                {
                    outputLines.Add(data.Data);
                }

                // Update the RichTextBox with the output data
                this.Invoke((MethodInvoker)delegate
                {
                    string[] parts = data.Data.Split(new string[] { "SUCCESS", "FAILED" }, StringSplitOptions.None);
                    FontStyle originalFontStyle = richTextBoxOutput.Font.Style;
                    for (int i = 0; i < parts.Length; i++)
                    {
                        richTextBoxOutput.SelectionColor = richTextBoxOutput.ForeColor;
                        richTextBoxOutput.SelectionFont = new Font(richTextBoxOutput.Font, originalFontStyle);
                        richTextBoxOutput.AppendText(parts[i]);

                        if (i < parts.Length - 1)
                        {
                            string nextWord = data.Data.Contains("SUCCESS") ? "SUCCESS" : "FAILED";
                            richTextBoxOutput.SelectionColor = nextWord == "SUCCESS" ? Color.Green : Color.Red;
                            richTextBoxOutput.SelectionFont = new Font(richTextBoxOutput.Font, FontStyle.Bold);
                            richTextBoxOutput.AppendText(nextWord);
                        }
                    }
                    richTextBoxOutput.AppendText(Environment.NewLine);
                });
            };

            process.ErrorDataReceived += (s, data) =>
            {
                if (!string.IsNullOrEmpty(data.Data))
                {
                    // Handle error messages here, such as showing a MessageBox
                    MessageBox.Show("Error: " + data.Data);
                }
            };

            process.Exited += (s, args) =>
            {
                if (checkBoxSaveOutputToFile.Checked)
                {
                    File.WriteAllLines(outputFilePath, outputLines);
                }
                MessageBox.Show("Process completed.");
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }


        private void checkBoxSaveOutputToFile_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
