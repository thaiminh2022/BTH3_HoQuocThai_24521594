using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class FormShowcase : Form
    {
        public FormShowcase()
        {
            InitializeComponent();


            FormClosing += FormShowcase_FormClosing;
        }

        private void FormShowcase_FormClosing(object? sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to close the form?", "Confirm Close", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK) {
                e.Cancel = true;
            }
        }
    }
}
