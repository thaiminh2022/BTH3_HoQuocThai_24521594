using System.Drawing.Text;

namespace Bai02
{
    public partial class FormBai2 : Form
    {
        Random rand;

        public FormBai2()
        {
            rand = new();
            InitializeComponent();
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            var font = new Font(new FontFamily(GenericFontFamilies.SansSerif), 10);

            var randX = (float)rand.NextDouble() * Size.Width;
            var randY = (float)rand.NextDouble() * Size.Height;


            e.Graphics.DrawString("Paint Event", font, new SolidBrush(Color.Black), randX, randY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
