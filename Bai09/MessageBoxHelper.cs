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
        public static DialogResult ShowConfirmation(string message, MessageBoxButtons mode = MessageBoxButtons.OKCancel)
        {
            return MessageBox.Show(message, "Confirmation", mode, MessageBoxIcon.Asterisk);
        }
    }
}
