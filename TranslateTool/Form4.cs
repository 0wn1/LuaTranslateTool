using System.ComponentModel;
using TranslateTool;

namespace LUATranslateTool
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_DoWork;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            if (isRunning)
            {
                worker.CancelAsync();
                isRunning = false;
                button2.Enabled = true;
                button1.Text = "Run";
                return;
            }

            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Please enter how many times the macro should repeat the task.");
                return;
            }

            isRunning = true;
            button2.Enabled = false;
            button1.Text = "Stop Macro";
            int repeat = Convert.ToInt32(numericUpDown1.Value);
            worker.RunWorkerAsync(repeat);
        }

        private async void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];

            int repeat = e.Argument is int value ? value : 0;
            for (int i = 0; i < repeat; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                await Task.Delay(50);
                if (isRunning)
                {
                    this.Invoke(new Action(() => form1.button9.PerformClick()));
                }
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                await Task.Delay(100);
                if (isRunning)
                {
                    this.Invoke(new Action(() => form1.button2.PerformClick()));
                }
                int macroDelay = Convert.ToInt32(numericUpDown2.Value);
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                await form1.navigationCompletedTask.Task;
                await Task.Delay(macroDelay * 1000);
                if (isRunning)
                {
                    this.Invoke(new Action(() => form1.button6.PerformClick()));
                }

                int selectedLine = 0;
                if (isRunning)
                {
                    this.Invoke(new Action(() => selectedLine = form1.fastColoredTextBox1.Selection.Start.iLine));

                }
                int lineCount = 0;
                if (isRunning)
                {
                    this.Invoke(new Action(() => lineCount = form1.fastColoredTextBox1.Lines.Count()));
                }
                if (selectedLine == lineCount - 1)
                {
                    break;
                }
            }
            if (isRunning)
            {
                isRunning = false;
                this.Invoke(new Action(() => button2.Enabled = true));
                this.Invoke(new Action(() => button1.Text = "Run"));
            }
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

        private void Form4_FormClosing(object sender, EventArgs e)
        {
            if (isRunning)
            {
                worker.CancelAsync();
                isRunning = false;
                button2.Enabled = true;
                button1.Text = "Run";
            }
        }
    }
}
