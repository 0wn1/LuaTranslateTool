namespace TranslateTool
{
    public partial class RunMacroForm : Form
    {
        public RunOption RunOption { get; set; }
        public int TimesToRun { get; set; }

        public RunMacroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                RunOption = RunOption.Run;
                TimesToRun = (int)numericUpDown1.Value;
            }
            else if (radioButton2.Checked)
            {
                RunOption = RunOption.RunUntilEndOfFile;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            int totalLines = form1.fastColoredTextBox1.LinesCount;
            int currentLineIndex = form1.fastColoredTextBox1.Selection.Start.iLine;
            int remainingLines = totalLines - currentLineIndex;

            if (numericUpDown1.Value >= remainingLines)
            {
                numericUpDown1.Value = remainingLines;
            }
        }
    }

    public enum RunOption
    {
        Run,
        RunUntilEndOfFile
    }
}
