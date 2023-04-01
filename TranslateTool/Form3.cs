using TranslateTool;

namespace LUATranslateTool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? string.Empty;
            label2.Text = "Version " + currentVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            form1.openUrlOnBrowser("https://github.com/0wn1/LuaTranslateTool/#lua-translate-tool");
            this.Close();
        }
    }
}