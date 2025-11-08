using System.Text;

namespace Bai01
{
    public partial class FormBai1 : Form
    {
        Form? exampleForm;

        int logCount = 0;

        public FormBai1()
        {
            InitializeComponent();


            AddLog("This is the event log");
            showExampleBtn.Click += (_, _) =>
            {
                AddLog("Show example clicked");
                exampleForm = new FormShowcase();

                exampleForm.Load += ExampleForm_Load;
                exampleForm.Activated += ExampleForm_Activate;
                exampleForm.Shown += ExampleForm_Shown;
                exampleForm.Deactivate += ExampleForm_Deactivate;

                exampleForm.FormClosing += ExampleForm_FormClosing;
                exampleForm.FormClosed += ExampleForm_FormClosed;


                exampleForm.Show();
            };

            clearLog.Click += (_, _) =>
            {
                logTextBox.Text = string.Empty;
            };

           
        }

        void AddLog(string log)
        {
            logTextBox.AppendText($"{logCount} - {log}");
            logTextBox.AppendText(Environment.NewLine);
            logCount++;
        }

        private void ExampleForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            AddLog("Example form closed 🔒");
        }

        private void ExampleForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            AddLog("Example form closing ⏳");

            if (e.Cancel)
            {
                AddLog("Example form closing CANCELED");
            }
        }

        private void ExampleForm_Deactivate(object? sender, EventArgs e)
        {
            AddLog("Example form deactivated ❌");

        }

        private void ExampleForm_Shown(object? sender, EventArgs e)
        {
            AddLog("Example form showned 👋");
        }

        private void ExampleForm_Activate(object? sender, EventArgs e)
        {
            AddLog("Example form activated 🦾");
        }

        private void ExampleForm_Load(object? sender, EventArgs e)
        {
            AddLog("Example form loaded 🚀");
        }

    }
}
