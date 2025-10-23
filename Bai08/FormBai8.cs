using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace Bai08
{
    public partial class FormBai8 : Form
    {

        List<TaiKhoan> taiKhoans = [];

        public FormBai8()
        {
            InitializeComponent();
            
            addUpdateBtn.Click += AddUpdateBtn_Click;
            deleteBtn.Click += DeleteBtn_Click;

            accountListView.SelectedIndexChanged += AccountListView_SelectedIndexChanged;
        }

        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            if (!CheckValidDelete()) return;

            CleanInput();

            var foundIndex = -1;
            for (int i = 0; i < taiKhoans.Count; i++)
            {
                if (taiKhoans[i].SoTK == stkInput.Text)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex == -1)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
                return;
            }

            var res = MessageBox.Show("Bạn có muốn xóa tài khoản không?", 
                null, MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question
            );

            if (res == DialogResult.Yes) {
                taiKhoans.RemoveAt(foundIndex);
                accountListView.Items.RemoveAt(foundIndex);

                // Update indexes
                for (int i = 0;i < taiKhoans.Count;i++)
                {
                    taiKhoans[i].Index = i;
                    accountListView.Items[i].Text = i.ToString();
                }
            }
        }

        private void AccountListView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count == 0) return;

            var item = accountListView.SelectedItems[0];
            var tk = TaiKhoan.FromListViewItem(item);

            stkInput.Text = tk.SoTK;
            tenKHInput.Text = tk.TenTK;
            diaChiInput.Text = tk.DiaChiKH;
            soTienInput.Text = tk.SoTienTrongTK.ToString();
        }
        bool CheckValidDelete()
        {
            var textCond = !string.IsNullOrWhiteSpace(stkInput.Text);
            if (!textCond)
            {
                MessageBox.Show("Vui lòng nhập số tài khoản");
                return false;
            }
            return true;
        }
        bool CheckValidAddUpdate()
        {
            
            var textCond = !string.IsNullOrWhiteSpace(stkInput.Text) &&
                !string.IsNullOrWhiteSpace(tenKHInput.Text) &&
                !string.IsNullOrWhiteSpace(diaChiInput.Text);

            var numCond = uint.TryParse(soTienInput.Text, out _);


            if (!textCond || !numCond)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void AddUpdateBtn_Click(object? sender, EventArgs e)
        {
            if (!CheckValidAddUpdate()) return;

            CleanInput();

            var tk = new TaiKhoan(
                stkInput.Text, 
                tenKHInput.Text, 
                diaChiInput.Text, 
                uint.Parse(soTienInput.Text)
            );

            var foundIndex = -1;
            for (int i = 0; i < taiKhoans.Count; i++)
            {
                if (taiKhoans[i].SoTK == tk.SoTK)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex == -1)
            {
                // Create new
                tk.Index = taiKhoans.Count;
                taiKhoans.Add(tk);
                accountListView.Items.Add(tk.ToListViewItem());
            }
            else
            {
                // Modify
                tk.Index = foundIndex;
                taiKhoans[foundIndex] = tk;
                accountListView.Items.RemoveAt(tk.Index);
                accountListView.Items.Insert(tk.Index, tk.ToListViewItem()); 
                
            }

            UpdateMoneyLabel();
        }
        private void UpdateMoneyLabel()
        {
            sumLabel.Text = taiKhoans.Sum(x => x.SoTienTrongTK).ToString();
        }
        private void CleanInput()
        {
            stkInput.Text = stkInput.Text.Trim();
            tenKHInput.Text = tenKHInput.Text.Trim();
            diaChiInput.Text = diaChiInput.Text.Trim();
            soTienInput.Text = soTienInput.Text.Trim();
        }
    }
}
