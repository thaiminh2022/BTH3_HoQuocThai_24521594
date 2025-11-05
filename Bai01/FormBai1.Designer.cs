namespace Bai01
{
    partial class FormBai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            logTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            showExampleBtn = new Button();
            clearLog = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(logTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // logTextBox
            // 
            logTextBox.Dock = DockStyle.Fill;
            logTextBox.Location = new Point(3, 48);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(794, 399);
            logTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(showExampleBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(clearLog, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 39);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // showExampleBtn
            // 
            showExampleBtn.Dock = DockStyle.Fill;
            showExampleBtn.Location = new Point(3, 3);
            showExampleBtn.Name = "showExampleBtn";
            showExampleBtn.Size = new Size(391, 33);
            showExampleBtn.TabIndex = 1;
            showExampleBtn.Text = "Show Example";
            showExampleBtn.UseVisualStyleBackColor = true;
            // 
            // clearLog
            // 
            clearLog.Dock = DockStyle.Fill;
            clearLog.Location = new Point(400, 3);
            clearLog.Name = "clearLog";
            clearLog.Size = new Size(391, 33);
            clearLog.TabIndex = 2;
            clearLog.Text = "Clear Log";
            clearLog.UseVisualStyleBackColor = true;
            // 
            // FormBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormBai1";
            Text = "Form Bai 1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox logTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button showExampleBtn;
        private Button clearLog;
    }
}
