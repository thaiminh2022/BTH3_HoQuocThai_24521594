namespace Bai08
{
    partial class FormBai8
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
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            soTienInput = new TextBox();
            label4 = new Label();
            diaChiInput = new TextBox();
            label3 = new Label();
            tenKHInput = new TextBox();
            label2 = new Label();
            stkInput = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            quitBtn = new Button();
            deleteBtn = new Button();
            addUpdateBtn = new Button();
            accountListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            sumLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(accountListView, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(881, 746);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(875, 74);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2283459F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.77165F));
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(soTienInput, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(diaChiInput, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(tenKHInput, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(stkInput, 1, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 4);
            tableLayoutPanel2.Location = new Point(59, 78);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(762, 215);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.ImageAlign = ContentAlignment.TopRight;
            label5.Location = new Point(3, 129);
            label5.Name = "label5";
            label5.Size = new Size(171, 43);
            label5.TabIndex = 6;
            label5.Text = "Số tiền trong tài khoản";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // soTienInput
            // 
            soTienInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            soTienInput.Location = new Point(180, 132);
            soTienInput.Name = "soTienInput";
            soTienInput.Size = new Size(579, 27);
            soTienInput.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(3, 86);
            label4.Name = "label4";
            label4.Size = new Size(171, 43);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ khách hàng";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // diaChiInput
            // 
            diaChiInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            diaChiInput.Location = new Point(180, 89);
            diaChiInput.Name = "diaChiInput";
            diaChiInput.Size = new Size(579, 27);
            diaChiInput.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(3, 43);
            label3.Name = "label3";
            label3.Size = new Size(171, 43);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tenKHInput
            // 
            tenKHInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tenKHInput.Location = new Point(180, 46);
            tenKHInput.Name = "tenKHInput";
            tenKHInput.Size = new Size(579, 27);
            tenKHInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 43);
            label2.TabIndex = 0;
            label2.Text = "Số tài khoản";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // stkInput
            // 
            stkInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stkInput.Location = new Point(180, 3);
            stkInput.Name = "stkInput";
            stkInput.Size = new Size(579, 27);
            stkInput.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel2.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(quitBtn);
            flowLayoutPanel1.Controls.Add(deleteBtn);
            flowLayoutPanel1.Controls.Add(addUpdateBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 175);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(756, 37);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // quitBtn
            // 
            quitBtn.Location = new Point(659, 3);
            quitBtn.Margin = new Padding(50, 3, 3, 3);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(94, 29);
            quitBtn.TabIndex = 0;
            quitBtn.Text = "Thoát";
            quitBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom;
            deleteBtn.Location = new Point(512, 3);
            deleteBtn.Margin = new Padding(50, 3, 3, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // addUpdateBtn
            // 
            addUpdateBtn.Anchor = AnchorStyles.Bottom;
            addUpdateBtn.Location = new Point(326, 3);
            addUpdateBtn.Margin = new Padding(50, 3, 3, 3);
            addUpdateBtn.Name = "addUpdateBtn";
            addUpdateBtn.Size = new Size(133, 29);
            addUpdateBtn.TabIndex = 2;
            addUpdateBtn.Text = "Thêm/Cập Nhật";
            addUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // accountListView
            // 
            accountListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            accountListView.Dock = DockStyle.Fill;
            accountListView.FullRowSelect = true;
            accountListView.Location = new Point(20, 300);
            accountListView.Margin = new Padding(20, 3, 20, 3);
            accountListView.MultiSelect = false;
            accountListView.Name = "accountListView";
            accountListView.Size = new Size(841, 404);
            accountListView.TabIndex = 2;
            accountListView.UseCompatibleStateImageBehavior = false;
            accountListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã tài khoản";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên khách hàng";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa chỉ";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Số tiền";
            columnHeader5.Width = 275;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.63393F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.36607F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(sumLabel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(413, 710);
            tableLayoutPanel3.Margin = new Padding(3, 3, 20, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(448, 33);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(185, 33);
            label6.TabIndex = 0;
            label6.Text = "Tổng Tiền:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.BorderStyle = BorderStyle.FixedSingle;
            sumLabel.Dock = DockStyle.Fill;
            sumLabel.Location = new Point(194, 0);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(251, 33);
            sumLabel.TabIndex = 1;
            sumLabel.Text = "10000";
            sumLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormBai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 746);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBai8";
            Text = "Quản Lý Tài Khoản";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TextBox soTienInput;
        private Label label4;
        private TextBox diaChiInput;
        private Label label3;
        private TextBox tenKHInput;
        private Label label2;
        private TextBox stkInput;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button quitBtn;
        private Button deleteBtn;
        private Button addUpdateBtn;
        private ListView accountListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private Label sumLabel;
    }
}
