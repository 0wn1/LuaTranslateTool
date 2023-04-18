using FastColoredTextBoxNS;
using System.ComponentModel;
using System.Globalization;

namespace TranslateTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            button11 = new Button();
            button13 = new Button();
            button14 = new Button();
            fastColoredTextBox1 = new FastColoredTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newProjectToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            findNextToolStripMenuItem = new ToolStripMenuItem();
            findPreviousToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            expandToolStripMenuItem = new ToolStripMenuItem();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            webViewControlsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            macroToolStripMenuItem = new ToolStripMenuItem();
            autoTranslateToolStripMenuItem = new ToolStripMenuItem();
            recordMacroToolStripMenuItem = new ToolStripMenuItem();
            stopMacroStripMenuItem = new ToolStripMenuItem();
            runMacroToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            updateStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            selectAllToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            uPPERCASEToolStripMenuItem = new ToolStripMenuItem();
            lowercaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            ((ISupportInitialize)webView21).BeginInit();
            ((ISupportInitialize)fastColoredTextBox1).BeginInit();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(668, 284);
            button2.Name = "button2";
            button2.Size = new Size(63, 25);
            button2.TabIndex = 2;
            button2.Text = "Translate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.BackColor = Color.Gray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(12, 35);
            button3.Name = "button3";
            button3.Size = new Size(94, 25);
            button3.TabIndex = 3;
            button3.Text = "Copy Selected";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = Color.Gray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.LightGray;
            textBox1.Location = new Point(91, 294);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 16);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = Color.Gray;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.LightGray;
            button5.Location = new Point(112, 35);
            button5.Name = "button5";
            button5.Size = new Size(69, 25);
            button5.TabIndex = 6;
            button5.Text = "Copy All";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button6.BackColor = Color.Gray;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.LightGray;
            button6.Location = new Point(811, 284);
            button6.Name = "button6";
            button6.Size = new Size(73, 25);
            button6.TabIndex = 7;
            button6.Text = "Replace";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.BackColor = SystemColors.ControlDarkDark;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 315);
            webView21.Name = "webView21";
            webView21.Size = new Size(876, 182);
            webView21.Source = new Uri("https://translate.google.com/", UriKind.Absolute);
            webView21.TabIndex = 9;
            webView21.ZoomFactor = 1D;
            webView21.NavigationCompleted += WebView21_NavigationCompleted;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = Color.Gray;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.LightGray;
            button7.Location = new Point(825, 503);
            button7.Name = "button7";
            button7.Size = new Size(63, 25);
            button7.TabIndex = 10;
            button7.Text = "Hide";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button8.BackColor = Color.Gray;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.LightGray;
            button8.Location = new Point(520, 284);
            button8.Name = "button8";
            button8.Size = new Size(68, 25);
            button8.TabIndex = 11;
            button8.Text = "Prev";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button9.BackColor = Color.Gray;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.LightGray;
            button9.Location = new Point(594, 284);
            button9.Name = "button9";
            button9.Size = new Size(68, 25);
            button9.TabIndex = 12;
            button9.Text = "Next";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(12, 295);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = "Translate to :";
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button11.BackColor = Color.Gray;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = Color.LightGray;
            button11.Location = new Point(756, 503);
            button11.Name = "button11";
            button11.Size = new Size(63, 25);
            button11.TabIndex = 16;
            button11.Text = "Show";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button13.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button13.BackColor = Color.Gray;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ForeColor = Color.LightGray;
            button13.Location = new Point(684, 503);
            button13.Name = "button13";
            button13.Size = new Size(66, 25);
            button13.TabIndex = 19;
            button13.Text = "Refresh";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button14.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button14.BackColor = Color.Gray;
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ForeColor = Color.LightGray;
            button14.Location = new Point(737, 284);
            button14.Name = "button14";
            button14.Size = new Size(68, 25);
            button14.TabIndex = 20;
            button14.Text = "Copy";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // fastColoredTextBox1
            // 
            fastColoredTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fastColoredTextBox1.AutoCompleteBrackets = true;
            fastColoredTextBox1.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            fastColoredTextBox1.AutoIndent = false;
            fastColoredTextBox1.AutoIndentChars = false;
            fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            fastColoredTextBox1.AutoIndentExistingLines = false;
            fastColoredTextBox1.AutoScrollMinSize = new Size(25, 15);
            fastColoredTextBox1.AutoSize = true;
            fastColoredTextBox1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            fastColoredTextBox1.BackBrush = null;
            fastColoredTextBox1.BackColor = SystemColors.ControlDark;
            fastColoredTextBox1.BorderStyle = BorderStyle.Fixed3D;
            fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
            fastColoredTextBox1.CharHeight = 15;
            fastColoredTextBox1.CharWidth = 7;
            fastColoredTextBox1.CommentPrefix = "--";
            fastColoredTextBox1.CurrentLineColor = Color.OliveDrab;
            fastColoredTextBox1.Cursor = Cursors.IBeam;
            fastColoredTextBox1.DefaultMarkerSize = 8;
            fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            fastColoredTextBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fastColoredTextBox1.HighlightFoldingIndicator = false;
            fastColoredTextBox1.HighlightingRangeType = HighlightingRangeType.AllTextRange;
            fastColoredTextBox1.Hotkeys = resources.GetString("fastColoredTextBox1.Hotkeys");
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(64, 64, 64);
            fastColoredTextBox1.IsReplaceMode = false;
            fastColoredTextBox1.Language = Language.Lua;
            fastColoredTextBox1.LeftBracket = '(';
            fastColoredTextBox1.LeftBracket2 = '{';
            fastColoredTextBox1.Location = new Point(11, 66);
            fastColoredTextBox1.Name = "fastColoredTextBox1";
            fastColoredTextBox1.Paddings = new Padding(0);
            fastColoredTextBox1.RightBracket = ')';
            fastColoredTextBox1.RightBracket2 = '}';
            fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            fastColoredTextBox1.ServiceColors = (ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
            fastColoredTextBox1.ShowFoldingLines = true;
            fastColoredTextBox1.Size = new Size(876, 200);
            fastColoredTextBox1.TabIndex = 27;
            fastColoredTextBox1.Zoom = 100;
            fastColoredTextBox1.TextChanged += fastColoredTextBox_TextChanged_1;
            fastColoredTextBox1.SelectionChangedDelayed += fastColoredTextBox_SelectionChanged;
            fastColoredTextBox1.MouseClick += fastColoredTextBox1_MouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, searchToolStripMenuItem, viewToolStripMenuItem, settingsToolStripMenuItem, macroToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Transparent;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newProjectToolStripMenuItem, openToolStripMenuItem, toolStripMenuItem2, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.LightGray;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            newProjectToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            newProjectToolStripMenuItem.ForeColor = Color.LightGray;
            newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            newProjectToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newProjectToolStripMenuItem.Size = new Size(195, 22);
            newProjectToolStripMenuItem.Text = "New";
            newProjectToolStripMenuItem.Click += newProjectToolStripMenuItem_Click_1;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            openToolStripMenuItem.ForeColor = Color.LightGray;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(195, 22);
            openToolStripMenuItem.Text = "Open..";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.FromArgb(64, 64, 64);
            toolStripMenuItem2.ForeColor = Color.LightGray;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem2.Size = new Size(195, 22);
            toolStripMenuItem2.Text = "Save";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            saveAsToolStripMenuItem.ForeColor = Color.LightGray;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(195, 22);
            saveAsToolStripMenuItem.Text = "Save As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            exitToolStripMenuItem.ForeColor = Color.LightGray;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(195, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.Transparent;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.LightGray;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.ForeColor = Color.LightGray;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            undoToolStripMenuItem.Size = new Size(164, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.ForeColor = Color.LightGray;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
            redoToolStripMenuItem.Size = new Size(164, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            cutToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.ForeColor = Color.LightGray;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            cutToolStripMenuItem.Size = new Size(164, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            copyToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.ForeColor = Color.LightGray;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            copyToolStripMenuItem.Size = new Size(164, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            pasteToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem.ForeColor = Color.LightGray;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            pasteToolStripMenuItem.Size = new Size(164, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            deleteToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.ForeColor = Color.LightGray;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            deleteToolStripMenuItem.Size = new Size(164, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            selectAllToolStripMenuItem.Enabled = false;
            selectAllToolStripMenuItem.ForeColor = Color.LightGray;
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.BackColor = Color.Transparent;
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, findNextToolStripMenuItem, findPreviousToolStripMenuItem, toolStripMenuItem1, goToToolStripMenuItem });
            searchToolStripMenuItem.ForeColor = Color.LightGray;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(54, 20);
            searchToolStripMenuItem.Text = "Search";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            findToolStripMenuItem.Enabled = false;
            findToolStripMenuItem.ForeColor = Color.LightGray;
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            findToolStripMenuItem.Size = new Size(196, 22);
            findToolStripMenuItem.Text = "Find...";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            findNextToolStripMenuItem.Enabled = false;
            findNextToolStripMenuItem.ForeColor = Color.LightGray;
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            findNextToolStripMenuItem.ShortcutKeys = Keys.F3;
            findNextToolStripMenuItem.Size = new Size(196, 22);
            findNextToolStripMenuItem.Text = "Find Next";
            findNextToolStripMenuItem.Click += findNextToolStripMenuItem_Click;
            // 
            // findPreviousToolStripMenuItem
            // 
            findPreviousToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            findPreviousToolStripMenuItem.Enabled = false;
            findPreviousToolStripMenuItem.ForeColor = Color.LightGray;
            findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
            findPreviousToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            findPreviousToolStripMenuItem.Size = new Size(196, 22);
            findPreviousToolStripMenuItem.Text = "Find Previous";
            findPreviousToolStripMenuItem.Click += findPreviousToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(64, 64, 64);
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.ForeColor = Color.LightGray;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+H";
            toolStripMenuItem1.Size = new Size(196, 22);
            toolStripMenuItem1.Text = "Replace...";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            goToToolStripMenuItem.Enabled = false;
            goToToolStripMenuItem.ForeColor = Color.LightGray;
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
            goToToolStripMenuItem.Size = new Size(196, 22);
            goToToolStripMenuItem.Text = "Go To";
            goToToolStripMenuItem.Click += goToToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.BackColor = Color.Transparent;
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { expandToolStripMenuItem, alwaysOnTopToolStripMenuItem, webViewControlsToolStripMenuItem });
            viewToolStripMenuItem.ForeColor = Color.LightGray;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // expandToolStripMenuItem
            // 
            expandToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            expandToolStripMenuItem.ForeColor = Color.LightGray;
            expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            expandToolStripMenuItem.ShortcutKeyDisplayString = "";
            expandToolStripMenuItem.ShortcutKeys = Keys.F11;
            expandToolStripMenuItem.Size = new Size(174, 22);
            expandToolStripMenuItem.Text = "Expand";
            expandToolStripMenuItem.Click += expandToolStripMenuItem_Click;
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            alwaysOnTopToolStripMenuItem.ForeColor = Color.LightGray;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(174, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always on Top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // webViewControlsToolStripMenuItem
            // 
            webViewControlsToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            webViewControlsToolStripMenuItem.ForeColor = Color.LightGray;
            webViewControlsToolStripMenuItem.Name = "webViewControlsToolStripMenuItem";
            webViewControlsToolStripMenuItem.Size = new Size(174, 22);
            webViewControlsToolStripMenuItem.Text = "Web View Controls";
            webViewControlsToolStripMenuItem.Click += webViewControlsToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.BackColor = Color.Transparent;
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            settingsToolStripMenuItem.ForeColor = Color.LightGray;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            fontToolStripMenuItem.ForeColor = Color.LightGray;
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(120, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            colorToolStripMenuItem.ForeColor = Color.LightGray;
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(120, 22);
            colorToolStripMenuItem.Text = "Interface";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // macroToolStripMenuItem
            // 
            macroToolStripMenuItem.BackColor = Color.Transparent;
            macroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoTranslateToolStripMenuItem, recordMacroToolStripMenuItem, stopMacroStripMenuItem, runMacroToolStripMenuItem });
            macroToolStripMenuItem.ForeColor = Color.LightGray;
            macroToolStripMenuItem.Name = "macroToolStripMenuItem";
            macroToolStripMenuItem.Size = new Size(53, 20);
            macroToolStripMenuItem.Text = "Macro";
            // 
            // autoTranslateToolStripMenuItem
            // 
            autoTranslateToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            autoTranslateToolStripMenuItem.Enabled = false;
            autoTranslateToolStripMenuItem.ForeColor = Color.LightGray;
            autoTranslateToolStripMenuItem.Name = "autoTranslateToolStripMenuItem";
            autoTranslateToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            autoTranslateToolStripMenuItem.ShortcutKeys = Keys.F5;
            autoTranslateToolStripMenuItem.Size = new Size(174, 22);
            autoTranslateToolStripMenuItem.Text = "Auto Translate";
            autoTranslateToolStripMenuItem.Click += autoTranslateToolStripMenuItem_Click;
            // 
            // recordMacroToolStripMenuItem
            // 
            recordMacroToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            recordMacroToolStripMenuItem.ForeColor = Color.LightGray;
            recordMacroToolStripMenuItem.Name = "recordMacroToolStripMenuItem";
            recordMacroToolStripMenuItem.ShortcutKeyDisplayString = "F6";
            recordMacroToolStripMenuItem.ShortcutKeys = Keys.F6;
            recordMacroToolStripMenuItem.Size = new Size(174, 22);
            recordMacroToolStripMenuItem.Text = "Record Macro";
            recordMacroToolStripMenuItem.Click += recordMacroToolStripMenuItem_Click;
            // 
            // stopMacroStripMenuItem
            // 
            stopMacroStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            stopMacroStripMenuItem.ForeColor = Color.LightGray;
            stopMacroStripMenuItem.Name = "stopMacroStripMenuItem";
            stopMacroStripMenuItem.ShortcutKeyDisplayString = "F7";
            stopMacroStripMenuItem.ShortcutKeys = Keys.F7;
            stopMacroStripMenuItem.Size = new Size(174, 22);
            stopMacroStripMenuItem.Text = "Stop Recording";
            stopMacroStripMenuItem.Click += stopMacroStripMenuItem_Click;
            // 
            // runMacroToolStripMenuItem
            // 
            runMacroToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            runMacroToolStripMenuItem.ForeColor = Color.LightGray;
            runMacroToolStripMenuItem.Name = "runMacroToolStripMenuItem";
            runMacroToolStripMenuItem.ShortcutKeyDisplayString = "F8";
            runMacroToolStripMenuItem.ShortcutKeys = Keys.F8;
            runMacroToolStripMenuItem.Size = new Size(174, 22);
            runMacroToolStripMenuItem.Text = "Run Macro";
            runMacroToolStripMenuItem.Click += runMacroToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.BackColor = Color.Transparent;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, updateStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.LightGray;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            homeToolStripMenuItem.ForeColor = Color.LightGray;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(179, 22);
            homeToolStripMenuItem.Text = "Project Page";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // updateStripMenuItem
            // 
            updateStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            updateStripMenuItem.ForeColor = Color.LightGray;
            updateStripMenuItem.Name = "updateStripMenuItem";
            updateStripMenuItem.Size = new Size(179, 22);
            updateStripMenuItem.Text = "Check for updates...";
            updateStripMenuItem.Click += updateStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            aboutToolStripMenuItem.ForeColor = Color.LightGray;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.F1;
            aboutToolStripMenuItem.Size = new Size(179, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoEllipsis = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 503);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(650, 25);
            label2.TabIndex = 34;
            label2.Text = "Status";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem1, selectAllToolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem7, toolStripMenuItem5, uPPERCASEToolStripMenuItem, lowercaseToolStripMenuItem, toolStripMenuItem4, openFileToolStripMenuItem, searchToolStripMenuItem1 });
            contextMenuStrip1.Margin = new Padding(5, 0, 5, 0);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.ShowCheckMargin = true;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(199, 236);
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            cutToolStripMenuItem1.ForeColor = SystemColors.Control;
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.Size = new Size(198, 22);
            cutToolStripMenuItem1.Text = "Cut                                   ";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            pasteToolStripMenuItem1.ForeColor = SystemColors.Control;
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new Size(198, 22);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            deleteToolStripMenuItem1.ForeColor = SystemColors.Control;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(198, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // selectAllToolStripMenuItem1
            // 
            selectAllToolStripMenuItem1.BackColor = SystemColors.ControlDark;
            selectAllToolStripMenuItem1.ForeColor = SystemColors.Control;
            selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            selectAllToolStripMenuItem1.Size = new Size(198, 22);
            selectAllToolStripMenuItem1.Text = "Select All";
            selectAllToolStripMenuItem1.Click += selectAllToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(195, 6);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.ForeColor = SystemColors.Control;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(198, 22);
            toolStripMenuItem7.Text = "Sentence case";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.ForeColor = SystemColors.Control;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(198, 22);
            toolStripMenuItem5.Text = "Title Case";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // uPPERCASEToolStripMenuItem
            // 
            uPPERCASEToolStripMenuItem.ForeColor = SystemColors.Control;
            uPPERCASEToolStripMenuItem.Name = "uPPERCASEToolStripMenuItem";
            uPPERCASEToolStripMenuItem.Size = new Size(198, 22);
            uPPERCASEToolStripMenuItem.Text = "UPPERCASE";
            uPPERCASEToolStripMenuItem.Click += uPPERCASEToolStripMenuItem_Click;
            // 
            // lowercaseToolStripMenuItem
            // 
            lowercaseToolStripMenuItem.ForeColor = SystemColors.Control;
            lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            lowercaseToolStripMenuItem.Size = new Size(198, 22);
            lowercaseToolStripMenuItem.Text = "lowercase";
            lowercaseToolStripMenuItem.Click += lowercaseToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(195, 6);
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.ForeColor = SystemColors.Control;
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(198, 22);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.ForeColor = SystemColors.Control;
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(198, 22);
            searchToolStripMenuItem1.Text = "Search on Internet";
            searchToolStripMenuItem1.Click += searchToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(900, 532);
            Controls.Add(label2);
            Controls.Add(fastColoredTextBox1);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(webView21);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            ForeColor = Color.FromArgb(64, 64, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUA Translate Tool";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((ISupportInitialize)webView21).EndInit();
            ((ISupportInitialize)fastColoredTextBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button button2;
        public Button button3;
        private TextBox textBox1;
        public Button button5;
        public Button button6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        public Button button7;
        public Button button8;
        public Button button9;
        private Label label1;
        public Button button11;
        public Button button13;
        public Button button14;
        private string language = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        private string tempPath = Path.Combine(Path.GetTempPath(), "LuaTranslateTool");
        public TaskCompletionSource<bool> navigationCompletedTask;
        private DateTime lastBackupTime = DateTime.Now;
        public FastColoredTextBox fastColoredTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newProjectToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem macroToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem findNextToolStripMenuItem;
        private ToolStripMenuItem findPreviousToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem recordMacroToolStripMenuItem;
        private ToolStripMenuItem runMacroToolStripMenuItem;
        private ToolStripMenuItem stopMacroStripMenuItem;
        private ToolStripMenuItem expandToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem autoTranslateToolStripMenuItem;
        private ToolStripMenuItem updateStripMenuItem;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem webViewControlsToolStripMenuItem;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem selectAllToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem uPPERCASEToolStripMenuItem;
        private ToolStripMenuItem lowercaseToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem colorToolStripMenuItem;
    }
}