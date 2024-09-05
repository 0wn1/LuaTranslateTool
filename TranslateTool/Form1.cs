using LUATranslateTool;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace TranslateTool
{
    public partial class Form1 : Form
    {
        private HttpClient _httpClient;
        System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        string regex = @"(?<=[:=]\s*(['""]))((?:\\.|\1\1|(?!\1).)*?)(?=\1)";
        public Form1()
        {
            InitializeComponent();
            string targetLang = textBox1.Text;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://translate.googleapis.com/");
        }
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            stopMacroStripMenuItem.Enabled = false;
            menuStrip1.Renderer = new menuStripRenderer();
            fastColoredTextBox1.Selection = new FastColoredTextBoxNS.Range(fastColoredTextBox1);
            fastColoredTextBox1.SelectionChangedDelayed += fastColoredTextBox_SelectionChanged;
            fastColoredTextBox1.TextChanged += fastColoredTextBox_TextChanged_1;
            navigationCompletedTask = new TaskCompletionSource<bool>();
            Directory.CreateDirectory(tempPath);
            textBox1.Text = language;
            label2.Text = "";

            toolTip1.SetToolTip(button2, "Click here to translate selected text.");
            toolTip1.SetToolTip(button3, "Click here to copy the selected text.");
            toolTip1.SetToolTip(button5, "Click here to copy all text.");
            toolTip1.SetToolTip(button6, "Click here to replace selected text.");
            toolTip1.SetToolTip(button8, "Click here to select the previous text for translation.");
            toolTip1.SetToolTip(button9, "Click here to select the next text for translation.");
            toolTip1.SetToolTip(textBox1, "Enter the target language to be translated (e.g., \"es\" for Spanish).");

            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private async Task<string> Translate(string text, string sourceLanguageCode, string targetLanguageCode)
        {
            string jsonResultString;
            try
            {
                var url = $"translate_a/single?client=gtx&sl={sourceLanguageCode}&tl={targetLanguageCode}&dt=t&q={Uri.EscapeDataString(text)}";
                var result = await _httpClient.GetAsync(url);
                var bytes = await result.Content.ReadAsByteArrayAsync();
                jsonResultString = Encoding.UTF8.GetString(bytes).Trim();
                if (!result.IsSuccessStatusCode)
                {
                    return $"Error: {jsonResultString}";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            var resultList = ConvertJsonObjectToStringLines(jsonResultString);
            return string.Join(Environment.NewLine, resultList);
        }

        private List<string> ConvertJsonObjectToStringLines(string jsonString)
        {
            var result = new List<string>();
            try
            {
                var jsonArray = JsonConvert.DeserializeObject<dynamic>(jsonString);
                if (jsonArray != null && jsonArray?.Count > 0)
                {
                    var translations = jsonArray?[0];
                    if (translations != null) {
                        foreach (var item in translations)
                        {
                            if (item.Count > 0 && item[0].Type == JTokenType.String)
                            {
                                result.Add(item[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
                result.Add($"Error parsing JSON: {jsonString}");
            }
            return result;
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            string targetLang = textBox1.Text;
            string sourceText = fastColoredTextBox1.SelectedText;

            if (string.IsNullOrWhiteSpace(sourceText))
            {
                richTextBox1.Text = "No text selected for translation.";
                return;
            }
            string result = await Translate(sourceText, "auto", targetLang);

            if (!string.IsNullOrWhiteSpace(result))
            {
                richTextBox1.Text = result;
            }
            else
            {
                richTextBox1.Text = "Translation failed or returned empty result.";
            }
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
                int maxAttempts = 10;
                int attempts = 0;
                while (string.IsNullOrWhiteSpace(richTextBox1.Text) && attempts < maxAttempts)
                {
                    await Task.Delay(1000);
                    attempts++;
                }

                if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    MessageBox.Show("Timeout: Response time has exceeded the limit.");
                    return;
                }

                string richTextBoxContent = richTextBox1.Text;
                richTextBoxContent = string.Join(" ", richTextBoxContent
                    .Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None)
                    .Select(line => line.Trim())
                    .Where(line => !string.IsNullOrWhiteSpace(line)));

                fastColoredTextBox1.SelectedText = richTextBoxContent;
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
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int searchStart = fastColoredTextBox1.SelectionStart;
                MatchCollection matches = Regex.Matches(fastColoredTextBox1.Text.Substring(0, searchStart), regex);
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
            Match match = Regex.Match(fastColoredTextBox1.Text.Substring(searchStart), regex);
            if (match.Success)
            {
                int index = searchStart + match.Index;
                string value = match.Value;
                fastColoredTextBox1.Selection.Start = fastColoredTextBox1.PositionToPlace(index);
                fastColoredTextBox1.Selection.End = fastColoredTextBox1.PositionToPlace(index + value.Length);
                fastColoredTextBox1.DoCaretVisible();
            }
        }
        private void newProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to start a new project?", "New Project", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    fastColoredTextBox1.Text = "";
                    richTextBox1.Text = "";
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
                Filter = "Lua and JSON Files|*.lua;*.json|All Files|*.*",
                Title = "Save File",
                DefaultExt = "lua",
                AddExtension = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                string extension = Path.GetExtension(fileName).ToLower();

                if (string.IsNullOrEmpty(extension))
                {
                    fileName += ".lua";
                }
                else if (extension != ".lua" && extension != ".json")
                {
                    MessageBox.Show("Invalid file extension. Please use .lua or .json", "Invalid Extension", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }

                MessageBox.Show("File successfully saved!");
                openFileDialog1.FileName = fileName;
                string argument = "/select, \"" + fileName + "\"";
                Process.Start("explorer.exe", argument);
            }
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Lua and JSON Files|*.lua;*.json|Lua Files|*.lua|JSON Files|*.json";
            openFileDialog1.Title = "Select Lua or JSON file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                fastColoredTextBox1.ClearUndo();
                richTextBox1.Text = "";
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
                richTextBox1.Visible = false;
                expandToolStripMenuItem.Checked = true;
                label2.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

                fastColoredTextBox1.Location = new Point(11, 66);
                fastColoredTextBox1.Size = new Size(876, 260);
                fastColoredTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                fastColoredTextBox1.Dock = DockStyle.None;

                richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                richTextBox1.Location = new Point(12, 375);
                richTextBox1.Size = new Size(876, 125);
                richTextBox1.Dock = DockStyle.None;
                richTextBox1.Visible = true;

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