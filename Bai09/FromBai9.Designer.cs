namespace Bai09
{
    partial class FromBai9
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
            groupBox1 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addUpdateBtn = new Button();
            deleteBtn = new Button();
            deselectBtn = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            saveAsBtn = new Button();
            saveBtn = new Button();
            openBtn = new Button();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            enrollCoursesBox = new ListBox();
            addToEnrolledBtn = new Button();
            removeFromEnrolledBtn = new Button();
            availableCoursesBox = new ListBox();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            nameTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mssvTextbox = new TextBox();
            majorCombobox = new ComboBox();
            panel2 = new Panel();
            maleCheckbox = new CheckBox();
            femaleCheckbox = new CheckBox();
            studentDataView = new DataGridView();
            mssv = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            major = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            courseCount = new DataGridViewTextBoxColumn();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(studentDataView, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.81556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.18444F));
            tableLayoutPanel1.Size = new Size(1040, 797);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(tableLayoutPanel4);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(64, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 323);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(906, 47);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(addUpdateBtn);
            flowLayoutPanel1.Controls.Add(deleteBtn);
            flowLayoutPanel1.Controls.Add(deselectBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(447, 41);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // addUpdateBtn
            // 
            addUpdateBtn.Location = new Point(3, 3);
            addUpdateBtn.Name = "addUpdateBtn";
            addUpdateBtn.Size = new Size(126, 29);
            addUpdateBtn.TabIndex = 0;
            addUpdateBtn.Text = "Thêm/Cập Nhật";
            addUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(135, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // deselectBtn
            // 
            deselectBtn.Location = new Point(235, 3);
            deselectBtn.Name = "deselectBtn";
            deselectBtn.Size = new Size(94, 29);
            deselectBtn.TabIndex = 2;
            deselectBtn.Text = "Hủy Chọn";
            deselectBtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(saveAsBtn);
            flowLayoutPanel2.Controls.Add(saveBtn);
            flowLayoutPanel2.Controls.Add(openBtn);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(456, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(447, 41);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // saveAsBtn
            // 
            saveAsBtn.Location = new Point(350, 3);
            saveAsBtn.Name = "saveAsBtn";
            saveAsBtn.Size = new Size(94, 29);
            saveAsBtn.TabIndex = 0;
            saveAsBtn.Text = "Lưu Tại";
            saveAsBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(250, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Lưu";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(150, 3);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(94, 29);
            openBtn.TabIndex = 2;
            openBtn.Text = "Mở";
            openBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(145, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 135);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(enrollCoursesBox, 2, 0);
            tableLayoutPanel3.Controls.Add(addToEnrolledBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(removeFromEnrolledBtn, 1, 1);
            tableLayoutPanel3.Controls.Add(availableCoursesBox, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(577, 111);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // enrollCoursesBox
            // 
            enrollCoursesBox.Dock = DockStyle.Fill;
            enrollCoursesBox.FormattingEnabled = true;
            enrollCoursesBox.Location = new Point(341, 3);
            enrollCoursesBox.Name = "enrollCoursesBox";
            tableLayoutPanel3.SetRowSpan(enrollCoursesBox, 2);
            enrollCoursesBox.SelectionMode = SelectionMode.MultiExtended;
            enrollCoursesBox.Size = new Size(233, 105);
            enrollCoursesBox.TabIndex = 3;
            // 
            // addToEnrolledBtn
            // 
            addToEnrolledBtn.Dock = DockStyle.Fill;
            addToEnrolledBtn.Location = new Point(241, 3);
            addToEnrolledBtn.Name = "addToEnrolledBtn";
            addToEnrolledBtn.Size = new Size(94, 49);
            addToEnrolledBtn.TabIndex = 0;
            addToEnrolledBtn.Text = ">";
            addToEnrolledBtn.UseVisualStyleBackColor = true;
            // 
            // removeFromEnrolledBtn
            // 
            removeFromEnrolledBtn.Dock = DockStyle.Fill;
            removeFromEnrolledBtn.Location = new Point(241, 58);
            removeFromEnrolledBtn.Name = "removeFromEnrolledBtn";
            removeFromEnrolledBtn.Size = new Size(94, 50);
            removeFromEnrolledBtn.TabIndex = 1;
            removeFromEnrolledBtn.Text = "<";
            removeFromEnrolledBtn.UseVisualStyleBackColor = true;
            // 
            // availableCoursesBox
            // 
            availableCoursesBox.Dock = DockStyle.Fill;
            availableCoursesBox.FormattingEnabled = true;
            availableCoursesBox.Location = new Point(3, 3);
            availableCoursesBox.Name = "availableCoursesBox";
            tableLayoutPanel3.SetRowSpan(availableCoursesBox, 2);
            availableCoursesBox.SelectionMode = SelectionMode.MultiExtended;
            availableCoursesBox.Size = new Size(232, 105);
            availableCoursesBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 1);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 0;
            label5.Text = "Chọn các môn học tham gia";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7869415F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.21306F));
            tableLayoutPanel2.Controls.Add(nameTextbox, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(mssvTextbox, 1, 0);
            tableLayoutPanel2.Controls.Add(majorCombobox, 1, 2);
            tableLayoutPanel2.Controls.Add(panel2, 1, 3);
            tableLayoutPanel2.Location = new Point(146, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(582, 147);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // nameTextbox
            // 
            nameTextbox.Dock = DockStyle.Fill;
            nameTextbox.Location = new Point(188, 39);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(391, 27);
            nameTextbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 36);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(179, 36);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(179, 36);
            label3.TabIndex = 2;
            label3.Text = "Chuyên Ngành";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(179, 39);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mssvTextbox
            // 
            mssvTextbox.Location = new Point(188, 3);
            mssvTextbox.Name = "mssvTextbox";
            mssvTextbox.Size = new Size(234, 27);
            mssvTextbox.TabIndex = 4;
            // 
            // majorCombobox
            // 
            majorCombobox.Dock = DockStyle.Fill;
            majorCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            majorCombobox.FormattingEnabled = true;
            majorCombobox.Location = new Point(188, 75);
            majorCombobox.Name = "majorCombobox";
            majorCombobox.Size = new Size(391, 28);
            majorCombobox.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(maleCheckbox);
            panel2.Controls.Add(femaleCheckbox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(188, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 33);
            panel2.TabIndex = 7;
            // 
            // maleCheckbox
            // 
            maleCheckbox.AutoSize = true;
            maleCheckbox.Dock = DockStyle.Left;
            maleCheckbox.Location = new Point(51, 0);
            maleCheckbox.Name = "maleCheckbox";
            maleCheckbox.Size = new Size(63, 33);
            maleCheckbox.TabIndex = 4;
            maleCheckbox.Text = "Nam";
            maleCheckbox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckbox
            // 
            femaleCheckbox.AutoSize = true;
            femaleCheckbox.Checked = true;
            femaleCheckbox.CheckState = CheckState.Checked;
            femaleCheckbox.Dock = DockStyle.Left;
            femaleCheckbox.Location = new Point(0, 0);
            femaleCheckbox.Name = "femaleCheckbox";
            femaleCheckbox.Size = new Size(51, 33);
            femaleCheckbox.TabIndex = 5;
            femaleCheckbox.Text = "Nữ";
            femaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // studentDataView
            // 
            studentDataView.AllowUserToDeleteRows = false;
            studentDataView.Anchor = AnchorStyles.Top;
            studentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataView.Columns.AddRange(new DataGridViewColumn[] { mssv, name, major, gender, courseCount });
            studentDataView.Location = new Point(62, 408);
            studentDataView.MultiSelect = false;
            studentDataView.Name = "studentDataView";
            studentDataView.RowHeadersWidth = 51;
            studentDataView.Size = new Size(915, 347);
            studentDataView.TabIndex = 1;
            // 
            // mssv
            // 
            mssv.DataPropertyName = "MSSV";
            mssv.HeaderText = "MSSV";
            mssv.MinimumWidth = 6;
            mssv.Name = "mssv";
            mssv.ReadOnly = true;
            mssv.Width = 125;
            // 
            // name
            // 
            name.DataPropertyName = "HoTen";
            name.HeaderText = "Họ Tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 250;
            // 
            // major
            // 
            major.DataPropertyName = "MajorDisplay";
            major.HeaderText = "Chuyên Ngành";
            major.MinimumWidth = 6;
            major.Name = "major";
            major.ReadOnly = true;
            major.Width = 250;
            // 
            // gender
            // 
            gender.DataPropertyName = "GenderDisplay";
            gender.HeaderText = "Giới Tính";
            gender.MinimumWidth = 6;
            gender.Name = "gender";
            gender.ReadOnly = true;
            gender.Width = 125;
            // 
            // courseCount
            // 
            courseCount.DataPropertyName = "EnrollCoursesCount";
            courseCount.HeaderText = "Số Môn";
            courseCount.MinimumWidth = 6;
            courseCount.Name = "courseCount";
            courseCount.ReadOnly = true;
            courseCount.Width = 125;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "data.json";
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "data.json";
            // 
            // FromBai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 797);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FromBai9";
            Text = "wwwww";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView studentDataView;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameTextbox;
        private TextBox mssvTextbox;
        private ComboBox majorCombobox;
        private Panel panel1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button addToEnrolledBtn;
        private Button removeFromEnrolledBtn;
        private ListBox enrollCoursesBox;
        private ListBox availableCoursesBox;
        private Panel panel2;
        private CheckBox maleCheckbox;
        private CheckBox femaleCheckbox;
        private DataGridViewTextBoxColumn mssv;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn major;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn courseCount;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button addUpdateBtn;
        private Button deleteBtn;
        private Button saveAsBtn;
        private Button saveBtn;
        private Button openBtn;
        private Button deselectBtn;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
