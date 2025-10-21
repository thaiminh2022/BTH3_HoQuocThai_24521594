namespace Bai04
{
    public partial class FormBai4 : Form
    {
        Color _currentColor;
        public FormBai4()
        {
            InitializeComponent();
            _currentColor = BackColor;
        }

        private void colorFormatItem_Click(object sender, EventArgs e)
        {
            colorDialog.Color = _currentColor;
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _currentColor = colorDialog.Color;
                _currentColor = Color.FromArgb(255, _currentColor);
                BackColor = _currentColor;
            }
        }
    }
}
