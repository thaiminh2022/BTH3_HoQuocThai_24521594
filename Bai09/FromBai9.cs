namespace Bai09
{
    public partial class FromBai9 : Form
    {
        public FromBai9()
        {
            InitializeComponent();

            maleCheckbox.CheckedChanged += CheckBoxChanged;
            femaleCheckbox.CheckedChanged += CheckBoxChanged;
        }

        private void CheckBoxChanged(object? sender, EventArgs e)
        {
            // Weird ass pattern, idc
            maleCheckbox.CheckedChanged -= CheckBoxChanged;
            femaleCheckbox.CheckedChanged -= CheckBoxChanged;

            maleCheckbox.Checked = false;
            femaleCheckbox.Checked = false;

            if (sender is CheckBox chx)
            {
                chx.Checked = true;
            }

            maleCheckbox.CheckedChanged += CheckBoxChanged;
            femaleCheckbox.CheckedChanged += CheckBoxChanged;
        }
    }
}
