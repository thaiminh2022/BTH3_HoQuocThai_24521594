namespace Bai07
{
    public partial class FormBai7 : Form
    {
        Color _takenColor = Color.Yellow;
        Color _selectedColor = Color.Blue;

        readonly List<CheckBox> checkBoxes;

        public FormBai7()
        {
            InitializeComponent();
            checkBoxes = [
                checkBox1, 
                checkBox2, 
                checkBox3, 
                checkBox4, 
                checkBox5, 
                checkBox6, 
                checkBox7, 
                checkBox8, 
                checkBox9, 
                checkBox10, 
                checkBox11, 
                checkBox12, 
                checkBox13, 
                checkBox14,
                checkBox15
            ];
            for (int i = 0; i < checkBoxes.Count; i++) {
                CheckBox checkBox = checkBoxes[i];
                checkBox.UseVisualStyleBackColor = true;
                checkBox.FlatAppearance.CheckedBackColor = _selectedColor;

                var idx = i;
                checkBox.Click += (_, _) => CheckSeat(idx);
            }
            selectBtn.Click += SelectBtn_Click;
            removeBtn.Click += RemoveBtn_Click;
            endBtn.Click += EndBtn_Click;
        }

        private void EndBtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveBtn_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                CheckBox checkBox = checkBoxes[i];

                if (checkBox.Checked && checkBox.AutoCheck == true)
                {
                    checkBox.Checked = false;
                }

            }
            totalLabel.Text = "0";
        }

        private void SelectBtn_Click(object? sender, EventArgs e)
        {
            uint totalAmount = 0;
            bool haveSelect = false;
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                CheckBox checkBox = checkBoxes[i];
                
                if (checkBox.Checked && checkBox.AutoCheck == true)
                {
                    haveSelect = true;
                    checkBox.FlatAppearance.CheckedBackColor = _takenColor;
                    checkBox.AutoCheck = false;

                    totalAmount += i switch
                    {
                        >= 0 and < 5 => 5000,
                        >= 5 and < 10 => 6500,
                        >= 10 and < 15 => 8000,
                        _ => 0,
                    };
                }
            }
            if (haveSelect)
                totalLabel.Text = totalAmount.ToString();
        }

        private void CheckSeat(int idx)
        {
            var checkBox = checkBoxes[idx];
            if (!checkBox.AutoCheck) {
                MessageBox.Show("Ví trí đã được đặt", "Lỗi đặt vị trí");
            }
        }
    }
}
