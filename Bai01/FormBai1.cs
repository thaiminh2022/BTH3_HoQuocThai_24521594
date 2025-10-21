namespace Bai01
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();

            Construct();

            Load += Form1_Load;
            Activated += Form1_Activated;
            Shown += Form1_Shown;
            Deactivate += Form1_Deactivate;

            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
        }

        private void Form1_Deactivate(object? sender, EventArgs e)
        {
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
        }

        private void Form1_Activated(object? sender, EventArgs e)
        {
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
        }

        void Construct() { }
    }
}
