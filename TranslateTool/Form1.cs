using LUATranslateTool;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;

namespace TranslateTool
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void WebView21_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            navigationCompletedTask.TrySetResult(true);
            RemoveElement();
            ScrollToElement();
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
            stopMacroStripMenuItem.Enabled = false;
            menuStrip1.Renderer = new menuStripRenderer();
            fastColoredTextBox1.Selection = new FastColoredTextBoxNS.Range(fastColoredTextBox1);
            fastColoredTextBox1.SelectionChangedDelayed += fastColoredTextBox_SelectionChanged;
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            fastColoredTextBox1.TextChanged += fastColoredTextBox_TextChanged_1;
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
            navigationCompletedTask = new TaskCompletionSource<bool>();
            Directory.CreateDirectory(tempPath);
            textBox1.Text = language;
            label2.Text = "";

            toolTip1.SetToolTip(button2, "Click here to translate selected text.");
            toolTip1.SetToolTip(button3, "Click here to copy the selected text.");
            toolTip1.SetToolTip(button5, "Click here to copy all text.");
            toolTip1.SetToolTip(button6, "Click here to replace selected text.");
            toolTip1.SetToolTip(button7, "Click here to hide Google Translate.");
            toolTip1.SetToolTip(button8, "Click here to select the previous text for translation.");
            toolTip1.SetToolTip(button9, "Click here to select the next text for translation.");
            toolTip1.SetToolTip(button11, "Click here to show Google Translate.");
            toolTip1.SetToolTip(button13, "Click here to refresh the translation page.");
            toolTip1.SetToolTip(button14, "Click here to copy the translated text.");
            toolTip1.SetToolTip(textBox1, "Enter the target language to be translated (e.g., \"es\" for Spanish).");

            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;

            if (webViewControlsToolStripMenuItem.Checked)
            {
                button13.Visible = true;
                button11.Visible = true;
                button7.Visible = true;
            }
            else
            {
                button13.Visible = false;
                button11.Visible = false;
                button7.Visible = false;
            }
        }
        private void ToggleWebView21(bool value)
        {
            if (webView21.Visible != value)
            {
                webView21.Visible = value;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ToggleWebView21(true);
            string targetLang = textBox1.Text;
            string url = $"https://translate.google.com.br/?sl=auto&tl={targetLang}&text={WebUtility.UrlEncode(fastColoredTextBox1.SelectedText)}&op=translate";
            webView21.Source = new Uri(url);
            button7.Enabled = true;
            button14.Enabled = true;
        }
        async void ScrollToElement()
        {
            string cssSelector = "body#yDmH0d>c-wiz>div>div:nth-of-type(2)>c-wiz>div:nth-of-type(2)>c-wiz>div>div:nth-of-type(2)>div:nth-of-type(3)>c-wiz:nth-of-type(2)>div";
            string script = $@"(function() {{
                let element = document.querySelector('{cssSelector}');
                if (element) {{
                    element.scrollIntoView({{ behavior: 'smooth', block: 'center' }});
                }}
            }})();";
            await webView21.ExecuteScriptAsync(script);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectedText.Length > 0)
            {
                Clipboard.SetText(fastColoredTextBox1.SelectedText);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = language;
            }
        }

        private void fastColoredTextBox_SelectionChanged(object? sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectionLength > 0)
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
        private async void button6_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectionLength > 0)
            {
                string clipboardText = Clipboard.GetText();

                fastColoredTextBox1.SelectedText = clipboardText;
                await Task.Delay(100);
                ScrollToElement();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.TextLength > 0)
            {
                Clipboard.SetText(fastColoredTextBox1.Text);
                MessageBox.Show("Text copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void fastColoredTextBox_TextChanged_1(object? sender, EventArgs e)
        {
            if (fastColoredTextBox1.TextLength > 0)
            {
                button5.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                newProjectToolStripMenuItem.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                findToolStripMenuItem.Enabled = true;
                findNextToolStripMenuItem.Enabled = true;
                findPreviousToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = true;
                goToToolStripMenuItem.Enabled = true;
                autoTranslateToolStripMenuItem.Enabled = true;

                string fileName = $"backup_{DateTime.Now.ToString("HH_mm_dd_MM_yyyy")}.lua";
                File.WriteAllText(Path.Combine(tempPath, fileName), fastColoredTextBox1.Text);

                if ((DateTime.Now - lastBackupTime).TotalMinutes > 2)
                {
                    lastBackupTime = DateTime.Now;
                    File.WriteAllText(Path.Combine(tempPath, fileName), fastColoredTextBox1.Text);
                }
            }
            else
            {
                button5.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                newProjectToolStripMenuItem.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                findToolStripMenuItem.Enabled = false;
                findNextToolStripMenuItem.Enabled = false;
                findPreviousToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                goToToolStripMenuItem.Enabled = false;
                autoTranslateToolStripMenuItem.Enabled = false;

            }

            fastColoredTextBox1.UndoRedoStateChanged += (sender, e) =>
            {
                if (fastColoredTextBox1.RedoEnabled)
                {
                    redoToolStripMenuItem.Enabled = true;
                }
                else
                {
                    redoToolStripMenuItem.Enabled = false;
                }

                if (fastColoredTextBox1.UndoEnabled)
                {
                    undoToolStripMenuItem.Enabled = true;
                }
                else
                {
                    undoToolStripMenuItem.Enabled = false;
                }
            };
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ToggleWebView21(false);
            button7.Enabled = false;
            button11.Enabled = true;
            button13.Enabled = false;
            button14.Enabled = false;
        }

        string pattern = @"(?<=\=\s*[\'""])(?:[^\'""\\]|\\.)+(?=[\'""])";
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int searchStart = fastColoredTextBox1.SelectionStart;
                MatchCollection matches = Regex.Matches(fastColoredTextBox1.Text.Substring(0, searchStart), pattern);
                if (matches.Count > 0)
                {
                    Match match = matches[matches.Count - 1];
                    int index = match.Index;
                    string value = match.Value;
                    fastColoredTextBox1.Selection.Start = fastColoredTextBox1.PositionToPlace(index);
                    fastColoredTextBox1.Selection.End = fastColoredTextBox1.PositionToPlace(index + value.Length);
                    fastColoredTextBox1.DoCaretVisible();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Out of range error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int searchStart = fastColoredTextBox1.SelectionStart;
            Match match = Regex.Match(fastColoredTextBox1.Text.Substring(searchStart), pattern);
            if (match.Success)
            {
                int index = searchStart + match.Index;
                string value = match.Value;
                fastColoredTextBox1.Selection.Start = fastColoredTextBox1.PositionToPlace(index);
                fastColoredTextBox1.Selection.End = fastColoredTextBox1.PositionToPlace(index + value.Length);
                fastColoredTextBox1.DoCaretVisible();
            }
        }
        private async void RemoveElement()
        {
            await webView21.ExecuteScriptAsync("var element = document.querySelector('header#gb>div:nth-of-type(2)');" + "if (element) {element.remove();}");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            ToggleWebView21(true);
            button7.Enabled = true;
            button11.Enabled = false;
            button13.Enabled = true;
            button14.Enabled = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (!webView21.IsDisposed)
            {
                webView21.Reload();
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            string xpath = "(//button[@jslog='171549; track:JIbuQc;']//div)[3]";
            webView21.ExecuteScriptAsync($"document.evaluate(\"{xpath}\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.click();");
        }
        private void newProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to start a new project?", "New Project", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    fastColoredTextBox1.Text = "";
                    openFileDialog1.FileName = "";
                    undoToolStripMenuItem.Enabled = false;
                    redoToolStripMenuItem.Enabled = false;
                    fastColoredTextBox1.ClearUndo();
                }
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 helpForm = new Form3();
            helpForm.Owner = this;
            helpForm.Show();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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
                    sw.Write(fastColoredTextBox1.Text);
                }
                MessageBox.Show("File successfully saved!");
                openFileDialog1.FileName = saveFileDialog1.FileName;
                string argument = "/select, \"" + saveFileDialog1.FileName + "\"";
                Process.Start("explorer.exe", argument);
            }
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Lua File|*.lua";
            openFileDialog1.Title = "Select Lua file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = "";
                string[] luaTextLines = File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in luaTextLines)
                {
                    fastColoredTextBox1.AppendText(line + "\n");
                }
                fastColoredTextBox1.ClearUndo();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.UndoEnabled)
                fastColoredTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.RedoEnabled)
                fastColoredTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = fontDialog.Font;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ClearSelected();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = fastColoredTextBox1.SelectedText;
            if (!string.IsNullOrEmpty(selectedText))
            {
                string regexPattern = Regex.Escape(selectedText);
                bool backward = false;
                RegexOptions options = RegexOptions.IgnoreCase;
                bool found = fastColoredTextBox1.SelectNext(regexPattern, backward, options);

                if (found)
                {
                    fastColoredTextBox1.DoCaretVisible();
                }
            }
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrlOnBrowser("https://github.com/0wn1/LuaTranslateTool/#lua-translate-tool");
        }
        public void openUrlOnBrowser(string url)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No network connection available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
        private void recordMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fastColoredTextBox1.MacrosManager.IsRecording)
            {
                fastColoredTextBox1.MacrosManager.ClearMacros();
                fastColoredTextBox1.MacrosManager.IsRecording = true;
                recordMacroToolStripMenuItem.Enabled = false;
                stopMacroStripMenuItem.Enabled = true;
            }
        }
        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!expandToolStripMenuItem.Checked)
            {
                fastColoredTextBox1.Dock = DockStyle.Fill;
                expandToolStripMenuItem.Checked = true;
                label2.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                fastColoredTextBox1.Location = new Point(11, 66);
                fastColoredTextBox1.Size = new Size(876, 184);
                fastColoredTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                fastColoredTextBox1.Dock = DockStyle.None;
                expandToolStripMenuItem.Checked = false;
                label2.Visible = true;
            }
        }
        private void runMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new RunMacroForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (form.RunOption == RunOption.Run)
                    {
                        int timesToRun = form.TimesToRun;
                        for (int i = 0; i < timesToRun; i++)
                        {
                            fastColoredTextBox1.MacrosManager.ExecuteMacros();
                        }
                    }
                    else if (form.RunOption == RunOption.RunUntilEndOfFile)
                    {
                        int totalLines = fastColoredTextBox1.Lines.Count;
                        for (int i = 0; i < totalLines; i++)
                        {
                            fastColoredTextBox1.MacrosManager.ExecuteMacros();
                            if (fastColoredTextBox1.Selection.Start.iLine == totalLines - 1)
                                break;
                        }
                    }
                }
            }
        }
        private void findPreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = fastColoredTextBox1.SelectedText;
            if (!string.IsNullOrEmpty(selectedText))
            {
                string regexPattern = Regex.Escape(selectedText);
                bool backward = true;
                RegexOptions options = RegexOptions.IgnoreCase;
                bool found = fastColoredTextBox1.SelectNext(regexPattern, backward, options);
                if (found)
                {
                    fastColoredTextBox1.DoCaretVisible();
                }
            }
        }

        private void stopMacroStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.MacrosManager.IsRecording)
            {
                fastColoredTextBox1.MacrosManager.IsRecording = false;
                stopMacroStripMenuItem.Enabled = false;
                recordMacroToolStripMenuItem.Enabled = true;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                fastColoredTextBox1.Paste();
            }
        }

        private async void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                File.WriteAllText(openFileDialog1.FileName, fastColoredTextBox1.Text);
                label2.Text = "Status: Document saved.";
                await Task.Delay(5000);
                label2.Text = "";
            }
        }

        private void autoTranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private async void updateStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No network connection available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var client = new System.Net.Http.HttpClient())
            {
                label2.Text = "Status: Checking for updates...";
                client.DefaultRequestHeaders.Add("User-Agent", "request");
                var json = await client.GetStringAsync("https://api.github.com/repos/0wn1/LuaTranslateTool/releases/latest");
                dynamic? release = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                string latestVersion = release?.tag_name ?? string.Empty;
                var currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? string.Empty;

                if (currentVersion.CompareTo(latestVersion.Substring(1)) < 0)
                {
                    if (MessageBox.Show("Current version: " + currentVersion + "\nLatest version : " + latestVersion.Substring(1) + "\n\nWould you like to go to the releases page?", "New Release Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        openUrlOnBrowser("https://github.com/0wn1/LuaTranslateTool/releases");
                    }
                }
                else
                {
                    MessageBox.Show("Version: " + currentVersion + "\n\nCurrent version is up to date!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                label2.Text = "";
            }
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!alwaysOnTopToolStripMenuItem.Checked)
            {
                alwaysOnTopToolStripMenuItem.Checked = true;
            }
            else
            {
                alwaysOnTopToolStripMenuItem.Checked = false;
            }
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        private void webViewControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!webViewControlsToolStripMenuItem.Checked)
            {
                button13.Visible = true;
                button11.Visible = true;
                button7.Visible = true;
                webViewControlsToolStripMenuItem.Checked = true;
            }
            else
            {
                button13.Visible = false;
                button11.Visible = false;
                button7.Visible = false;
                webViewControlsToolStripMenuItem.Checked = false;
            }
        }

        private void fastColoredTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!recordMacroToolStripMenuItem.Enabled)
            {
                recordMacroToolStripMenuItem.Enabled = true;
                stopMacroStripMenuItem.Enabled = false;
                fastColoredTextBox1.MacrosManager.ClearMacros();
                fastColoredTextBox1.MacrosManager.IsRecording = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(fastColoredTextBox1, new Point(e.X, e.Y));
            }
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectAllToolStripMenuItem_Click(sender, e);
        }

        private void uPPERCASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectedText.Length > 0)
            {
                fastColoredTextBox1.SelectedText = fastColoredTextBox1.SelectedText.ToUpper();
            }
        }

        private void lowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectedText.Length > 0)
            {
                fastColoredTextBox1.SelectedText = fastColoredTextBox1.SelectedText.ToLower();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectedText.Length > 0)
            {
                fastColoredTextBox1.SelectedText = fastColoredTextBox1.SelectedText.ToSentenceCase();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectedText.Length > 0)
            {
                fastColoredTextBox1.SelectedText = fastColoredTextBox1.SelectedText.ToTitleCase();
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.SelectedText.Length > 0)
            {
                string searchText = fastColoredTextBox1.SelectedText.Replace(" ", "+");
                openUrlOnBrowser("https://www.google.com/search?q=" + searchText);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Application.OpenForms["Form1"].BackColor = colorDialog.Color;
                menuStrip1.BackColor = colorDialog.Color;
            }
        }
    }
}