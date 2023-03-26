using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace TranslateTool
{
    public partial class Form1 : Form
    {
        private string[] luaTextLines;
        private bool isRunning = false;
        private BackgroundWorker worker = new BackgroundWorker();
        private string language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        private string tempPath = Path.Combine(Path.GetTempPath(), "LuaTranslateTool");
        private TaskCompletionSource<bool> navigationCompletedTask;
        private DateTime lastBackupTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
            worker.WorkerSupportsCancellation = true;
            navigationCompletedTask = new TaskCompletionSource<bool>();
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
            Directory.CreateDirectory(tempPath);

            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            luaTextLines = new string[0];

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = language;
            }
        }
        private void WebView21_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            navigationCompletedTask.TrySetResult(true);
            RemoveElement();
            ScrollToElement();
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
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button1, "Click here to open Lua file.");
            toolTip1.SetToolTip(button2, "Click here to translate selected text.");
            toolTip1.SetToolTip(button3, "Click here to copy the selected text.");
            toolTip1.SetToolTip(button4, "Click here to save Lua file.");
            toolTip1.SetToolTip(button5, "Click here to copy all text.");
            toolTip1.SetToolTip(button6, "Click here to replace selected text.");
            toolTip1.SetToolTip(button7, "Click here to hide Google Translate.");
            toolTip1.SetToolTip(button8, "Click here to select the previous text for translation.");
            toolTip1.SetToolTip(button9, "Click here to select the next text for translation.");
            toolTip1.SetToolTip(button11, "Click here to show Google Translate.");
            toolTip1.SetToolTip(button10, "Click here to add Lua syntax highlighting.");
            toolTip1.SetToolTip(button12, "Click here to remove the highlighted text.");
            toolTip1.SetToolTip(button13, "Click here to refresh the translation page.");
            toolTip1.SetToolTip(button14, "Click here to copy the translated text.");
            toolTip1.SetToolTip(button15, "Click here to start or stop macro tasks.");
            toolTip1.SetToolTip(textBox1, "Enter the target language to be translated (e.g., \"es\" for Spanish).");
            toolTip1.SetToolTip(numericUpDown1, "Enter how many times the macro should repeat tasks.");
            toolTip1.SetToolTip(numericUpDown2, "Adjust the interval time in seconds (min. 2, max. 10) to prevent the macro from skipping translations.");
            toolTip1.SetToolTip(checkBox1, "Place this window on top of all other Windows applications.");
            toolTip1.SetToolTip(linkLabel1, "LUA Translate Tool Version 1.1.1");

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button15.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "Lua File|*.lua";
            openFileDialog1.Title = "Select Lua file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = "";
                luaTextLines = File.ReadAllLines(openFileDialog1.FileName);
                richTextBox1.Lines = luaTextLines;
            }
        }
        private void ToggleWebView21(bool value)
        {
            if (webView21.Visible != value)
            {
                webView21.Visible = value;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            ToggleWebView21(true);
            string targetLang = textBox1.Text;
            string url = $"https://translate.google.com.br/?sl=auto&tl={targetLang}&text={WebUtility.UrlEncode(richTextBox1.SelectedText)}&op=translate";
            webView21.Source = new Uri(url);
            button7.Enabled = true;
            button14.Enabled = true;

            await Task.Delay(2000);
            RemoveElement();
            ScrollToElement();
        }
        private async void ScrollToElement()
        {
            await Task.Delay(1000);
            string cssSelectorToScroll = ".FqSPb, .xsPT1b";
            string cssSelectorToRemove = ".gb_Fa .gb_Td.gb_Zd.gb_0d";

            WebView2? webView = this.Controls.OfType<WebView2>().FirstOrDefault();
            if (webView != null)
            {
                string script = @"
            let elementToScrollTo = document.querySelector('" + cssSelectorToScroll + @"');
            if (elementToScrollTo != null) {
                elementToScrollTo.scrollIntoView(true);
            }
            let elementsToRemove = document.querySelectorAll('" + cssSelectorToRemove + @"');
            for (let i = 0; i < elementsToRemove.length; i++) {
                let elementToRemove = elementsToRemove[i];
                elementToRemove.parentNode.removeChild(elementToRemove);
                elementToRemove.style.display = 'none';
            }
        ";
                await webView.ExecuteScriptAsync(script);
            }
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
            System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog
            {
                Filter = "Lua File|*.lua",
                Title = "Save Lua File"
            };
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

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (isRunning)
            {
                worker.CancelAsync();
                isRunning = false;
                button15.Text = "Start Macro";
                MessageBox.Show("Macro stopped.");
                return;
            }

            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Please enter how many times the macro should repeat the task.");
                return;
            }

            isRunning = true;
            button15.Text = "Stop Macro";
            int repeat = Convert.ToInt32(numericUpDown1.Value);
            worker.RunWorkerAsync(repeat);
        }
        private async void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            int repeat = e.Argument is int value ? value : 0;
            for (int i = 0; i < repeat; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                this.Invoke(new Action(() => button9.PerformClick()));
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                this.Invoke(new Action(() => button2.PerformClick()));
                int macroDelay = Convert.ToInt32(numericUpDown2.Value);
                Thread.Sleep(macroDelay * 1000);
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                await navigationCompletedTask.Task;
                this.Invoke(new Action(() => button14.PerformClick()));
                Thread.Sleep(200);
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                this.Invoke(new Action(() => button6.PerformClick()));
                Thread.Sleep(200);

                int selectedLine = 0;
                this.Invoke(new Action(() => selectedLine = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart)));
                int lineCount = 0;
                this.Invoke(new Action(() => lineCount = richTextBox1.Lines.Length));
                if (selectedLine == lineCount - 1)
                {
                    break;
                }
            }
            if (isRunning)
            {
                isRunning = false;
                MessageBox.Show("Macro stopped.");
                this.Invoke(new Action(() => button15.Text = "Start Macro"));
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
                string fileName = $"backup_{DateTime.Now.ToString("HH_mm_dd_MM_yyyy")}.lua";
                File.WriteAllText(Path.Combine(tempPath, fileName), richTextBox1.Text);

                if ((DateTime.Now - lastBackupTime).TotalMinutes > 2)
                {
                    lastBackupTime = DateTime.Now;
                    File.WriteAllText(Path.Combine(tempPath, fileName), richTextBox1.Text);
                }

                button4.Enabled = true;
                button5.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button12.Enabled = false;
                button15.Enabled = false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ToggleWebView21(false);
            button7.Enabled = false;
            button11.Enabled = true;
            button13.Enabled = false;
            button14.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int searchStart = richTextBox1.SelectionStart;

                string pattern = @"(?<=\=\s*[\'""])(?:[^\'""\\]|\\.)+(?=[\'""])";
                MatchCollection matches = Regex.Matches(richTextBox1.Text.Substring(0, searchStart), pattern);
                if (matches.Count > 0)
                {
                    Match match = matches[matches.Count - 1];
                    int index = match.Index;
                    string value = match.Value;
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionBackColor = richTextBox1.BackColor;
                    richTextBox1.DeselectAll();
                    richTextBox1.Select(index, value.Length);
                    richTextBox1.SelectionBackColor = Color.Yellow;

                    richTextBox1.ScrollToCaret();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Out of range error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int searchStart = richTextBox1.SelectionStart;

            string pattern = @"(?<=\=\s*[\'""])(?:[^\'""\\]|\\.)+(?=[\'""])";
            Match match = Regex.Match(richTextBox1.Text.Substring(searchStart), pattern);
            if (match.Success)
            {
                int index = searchStart + match.Index;
                string value = match.Value;
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = richTextBox1.BackColor;
                richTextBox1.DeselectAll();
                richTextBox1.Select(index, value.Length);
                richTextBox1.SelectionBackColor = Color.Yellow;
                richTextBox1.ScrollToCaret();
            }
        }
        private async void RemoveElement()
        {
            await webView21.ExecuteScriptAsync("var element = document.querySelector('div[style=\"overflow: hidden; position: absolute; top: 0px; width: 370px; z-index: 991; height: 235px; margin-top: 70px; right: 0px; margin-right: 11px;\"]');" + "if (element) {element.remove();}");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            ToggleWebView21(true);
            button7.Enabled = true;
            button11.Enabled = false;
            button13.Enabled = true;
            button14.Enabled = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            richTextBox1.DeselectAll();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (!webView21.IsDisposed)
            {
                webView21.Reload();
            }
        }
        private async void button14_Click(object sender, EventArgs e)
        {
            await navigationCompletedTask.Task;
            if (!isRunning)
            {
                await Task.Delay(200);
            }
            await webView21.CoreWebView2.ExecuteScriptAsync(@"document.querySelector('body#yDmH0d>c-wiz>div>div:nth-of-type(2)>c-wiz>div:nth-of-type(2)>c-wiz>div>div:nth-of-type(2)>div:nth-of-type(3)>c-wiz:nth-of-type(2)>div>div:nth-of-type(8)>div>div:nth-of-type(4)>div:nth-of-type(2)>span:nth-of-type(2)>button>div:nth-of-type(3)').click();");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalLines = richTextBox1.Lines.Length;
            int currentLineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            int remainingLines = totalLines - currentLineIndex;

            if (numericUpDown1.Value >= remainingLines)
            {
                numericUpDown1.Value = remainingLines;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/0wn1/LuaTranslateTool/#lua-translate-tool";
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch
            {
                try
                {
                    string edgePath = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%\\Microsoft\\Edge\\Application\\msedge.exe");
                    System.Diagnostics.Process.Start(edgePath, url);
                }
                catch
                {
                    try
                    {
                        string edgePath = Environment.ExpandEnvironmentVariables("%ProgramFiles%\\Microsoft\\Edge\\Application\\msedge.exe");
                        System.Diagnostics.Process.Start(edgePath, url);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to open the URL.");
                    }
                }
            }
        }
        private void HighlightLuaSyntax()
        {
            string keywordsPattern = @"\b(and|break|do|else|elseif|end|false|for|function|if|in|local|nil|not|or|repeat|return|then|true|until|while)\b";
            string operatorsPattern = @"[+\-*/%^#=<>~]";
            string commentsPattern = @"--.*?\n";
            string stringsPattern = @"""[^""\\]*(?:\\.[^""\\]*)*""|'[^'\\]*(?:\\.[^'\\]*)*'";
            Color keywordsColor = Color.Blue;
            Color operatorsColor = Color.Gray;
            Color commentsColor = Color.Green;
            Color stringsColor = Color.Red;
            int selectionStart = richTextBox1.SelectionStart;
            int selectionLength = richTextBox1.SelectionLength;
            HighlightLuaSyntaxElement(keywordsPattern, keywordsColor);
            HighlightLuaSyntaxElement(operatorsPattern, operatorsColor);
            HighlightLuaSyntaxElement(commentsPattern, commentsColor);
            HighlightLuaSyntaxElement(stringsPattern, stringsColor);
            richTextBox1.SelectionStart = selectionStart;
            richTextBox1.SelectionLength = selectionLength;
        }
        private void HighlightLuaSyntaxElement(string pattern, Color color)
        {
            MatchCollection matches = Regex.Matches(richTextBox1.Text, pattern);
            foreach (Match match in matches)
            {
                richTextBox1.SelectionStart = match.Index;
                richTextBox1.SelectionLength = match.Length;
                richTextBox1.SelectionColor = color;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HighlightLuaSyntax();
            richTextBox1.ClearUndo();
        }
    }
}