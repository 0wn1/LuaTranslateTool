namespace TranslateTool
{
    partial class RunMacroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunMacroForm));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.ForeColor = Color.LightGray;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.ForeColor = Color.LightGray;
            radioButton2.Name = "radioButton2";
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.Gray;
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.ForeColor = Color.LightGray;
            resources.ApplyResources(numericUpDown1, "numericUpDown1");
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.LightGray;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.LightGray;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // RunMacroForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(64, 64, 64);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "RunMacroForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
    }
}