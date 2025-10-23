using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal static class MessageBoxHelper
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message.ToString(), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
