using System.Diagnostics;
using System.Globalization;
using Microsoft.Win32;
using System.Net;

namespace TranslateTool
{
    public partial class Form1 : Form
    {
        private string[] luaTextLines;
        private string language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        public Form1()
        {
            InitializeComponent();
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            luaTextLines = new string[0];
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = language;
            }
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.Locale)
            {
                textBox1.Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button1, "Click here to open Lua file");
            toolTip1.SetToolTip(button2, "Click here to translate selected text");
            toolTip1.SetToolTip(button3, "Click here to copy selected text");
            toolTip1.SetToolTip(button4, "Click here to save Lua file");
            toolTip1.SetToolTip(button5, "Click here to copy all text");
            toolTip1.SetToolTip(button6, "Click here to replace selected text");
            toolTip1.SetToolTip(button7, "Click here to close Google Translate");
            toolTip1.SetToolTip(textBox1, "Enter the target language to be translated (e.g. \"es\" for Spanish)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Lua File|*.lua";
            openFileDialog1.Title = "Select Lua file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = "";
                luaTextLines = File.ReadAllLines(openFileDialog1.FileName);
                richTextBox1.Lines = luaTextLines;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string targetLang = textBox1.Text;
            string url = $"https://translate.google.com.br/?sl=auto&tl={targetLang}&text={WebUtility.UrlEncode(richTextBox1.SelectedText)}&op=translate";
            webView21.Source = new Uri(url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = language;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Lua File|*.lua";
            saveFileDialog1.Title = "Save Lua File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(richTextBox1.Text);
                }
                MessageBox.Show("File successfully saved!");
                string argument = "/select, \"" + saveFileDialog1.FileName + "\"";
                Process.Start("explorer.exe", argument);
            }
        }

        private void richTextBox1_SelectionChanged(Object? sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string clipboardText = Clipboard.GetText();

                richTextBox1.SelectedText = clipboardText;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                Clipboard.SetText(richTextBox1.Text);
                MessageBox.Show("Text copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webView21.Dispose();
        }
    }
}