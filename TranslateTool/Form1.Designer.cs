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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            checkBox1 = new CheckBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.AutoWordSelection = true;
            richTextBox1.BackColor = SystemColors.ControlDark;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.WindowText;
            richTextBox1.Location = new Point(12, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(876, 187);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(799, 41);
            button1.Name = "button1";
            button1.Size = new Size(89, 25);
            button1.TabIndex = 1;
            button1.Text = "Open Lua File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = SystemColors.Control;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(671, 289);
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
            button3.BackColor = SystemColors.Control;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(12, 41);
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
            textBox1.BackColor = SystemColors.Control;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(89, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 23);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(704, 41);
            button4.Name = "button4";
            button4.Size = new Size(89, 25);
            button4.TabIndex = 5;
            button4.Text = "Save File";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button5.BackColor = SystemColors.Control;
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(112, 41);
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
            button6.BackColor = SystemColors.Control;
            button6.Cursor = Cursors.Hand;
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(814, 287);
            button6.Name = "button6";
            button6.Size = new Size(73, 25);
            button6.TabIndex = 7;
            button6.Text = "Replace";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(785, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Always on Top";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.BackColor = SystemColors.ControlDarkDark;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 317);
            webView21.Name = "webView21";
            webView21.Size = new Size(876, 180);
            webView21.Source = new Uri("https://translate.google.com/", UriKind.Absolute);
            webView21.TabIndex = 9;
            webView21.ZoomFactor = 1D;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button7.BackColor = SystemColors.Control;
            button7.Cursor = Cursors.Hand;
            button7.ForeColor = SystemColors.ControlText;
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
            button8.BackColor = SystemColors.Control;
            button8.Cursor = Cursors.Hand;
            button8.ForeColor = SystemColors.ControlText;
            button8.Location = new Point(523, 289);
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
            button9.BackColor = SystemColors.Control;
            button9.Cursor = Cursors.Hand;
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(597, 289);
            button9.Name = "button9";
            button9.Size = new Size(68, 25);
            button9.TabIndex = 12;
            button9.Text = "Next";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button10.BackColor = SystemColors.Control;
            button10.Cursor = Cursors.Hand;
            button10.ForeColor = SystemColors.ControlText;
            button10.Location = new Point(612, 503);
            button10.Name = "button10";
            button10.Size = new Size(66, 25);
            button10.TabIndex = 14;
            button10.Text = "Close Ad";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(10, 299);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = "Translate to :";
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button11.BackColor = SystemColors.Control;
            button11.Cursor = Cursors.Hand;
            button11.ForeColor = SystemColors.ControlText;
            button11.Location = new Point(756, 503);
            button11.Name = "button11";
            button11.Size = new Size(63, 25);
            button11.TabIndex = 16;
            button11.Text = "Show";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button12.BackColor = SystemColors.Control;
            button12.Cursor = Cursors.Hand;
            button12.ForeColor = SystemColors.ControlText;
            button12.Location = new Point(187, 41);
            button12.Name = "button12";
            button12.Size = new Size(104, 25);
            button12.TabIndex = 17;
            button12.Text = "Clear Highlight";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button13.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button13.BackColor = SystemColors.Control;
            button13.Cursor = Cursors.Hand;
            button13.ForeColor = SystemColors.ControlText;
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
            button14.BackColor = SystemColors.Control;
            button14.Cursor = Cursors.Hand;
            button14.ForeColor = SystemColors.ControlText;
            button14.Location = new Point(740, 288);
            button14.Name = "button14";
            button14.Size = new Size(68, 25);
            button14.TabIndex = 20;
            button14.Text = "Copy";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Anchor = AnchorStyles.Top;
            button15.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button15.BackColor = SystemColors.Control;
            button15.Cursor = Cursors.Hand;
            button15.ForeColor = SystemColors.ControlText;
            button15.Location = new Point(324, 41);
            button15.Name = "button15";
            button15.Size = new Size(104, 25);
            button15.TabIndex = 21;
            button15.Text = "Start Macro";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top;
            numericUpDown1.Location = new Point(434, 41);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 23);
            numericUpDown1.TabIndex = 23;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(900, 532);
            Controls.Add(numericUpDown1);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(webView21);
            Controls.Add(checkBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUATranslateTool";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private CheckBox checkBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private NumericUpDown numericUpDown1;
    }
}