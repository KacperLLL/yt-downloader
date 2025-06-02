using System.Drawing.Drawing2D;

namespace Youtube_Desktop_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 30, 30, 180, 90); // Lewy górny róg
            path.AddArc(textBox1.Width - 30, 0, 30, 30, 270, 90); // Prawy górny
            path.AddArc(textBox1.Width - 30, textBox1.Height - 30, 30, 30, 0, 90); // Prawy dolny
            path.AddArc(0, textBox1.Height - 30, 30, 30, 90, 90); // Lewy dolny
            path.CloseAllFigures();
            textBox1.Region = new Region(path);
        }
    }
}
