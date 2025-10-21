namespace Bai03
{
    public partial class FormBai3 : Form
    {
        Random _rand = new Random();
        public FormBai3()
        {
            InitializeComponent();
        }

        private void changeColorBtn_Click(object sender, EventArgs e)
        {
            var r = _rand.Next(256);
            var g = _rand.Next(256);
            var b = _rand.Next(256);

            var randColor = Color.FromArgb(255, r, g, b);
            BackColor = randColor;

        }
    }
}
