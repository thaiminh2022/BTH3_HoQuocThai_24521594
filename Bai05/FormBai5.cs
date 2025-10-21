using System.Diagnostics;

namespace Bai05
{
    public partial class FormBai5 : Form
    {


        public FormBai5()
        {
            InitializeComponent();

            plusBtn.Click += (s, e) => Calculate('+');
            minusBtn.Click += (s, e) => Calculate('-');
            multiplyBtn.Click += (s, e) => Calculate('*');
            divideBtn.Click += (s, e) => Calculate('/');
        }

        void Calculate(char operation)
        {
            if (!float.TryParse(number1TxtBox.Text, out float n1))
            {
                MessageBox.Show("Number 1 is not a valid real number");
                return;
            }
            if (!float.TryParse(number2TxtBox.Text, out float n2))
            {
                MessageBox.Show("Number 2 is not a valid real number");
                return;
            }


            if (operation == '/')
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                    return;
                }
                answerTxtBox.Text = $"{n1 / n2}";

                return;
            }

            answerTxtBox.Text = operation switch
            {
                '+' => $"{n1 + n2}",
                '-' => $"{n1 - n2}",
                '*' => $"{n1 * n2}",
                _ => throw new UnreachableException("This option is not reachable")
            };

        }

    }

}
