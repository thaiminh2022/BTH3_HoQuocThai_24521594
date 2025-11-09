using System.ComponentModel;
using System.Text.Json;

namespace Bai09
{
    public partial class FromBai9 : Form
    {
        GenderType _currentSelectedGender = GenderType.Female;
        
        readonly BindingList<Student> _students = [];
        bool isDirty = false;

        CoursesDualListBox _coursesDualListBox;
        StorageJSON? _storageJson;

        public FromBai9()
        {
            InitializeComponent();

            // Setup dual box
            _coursesDualListBox = new(availableCoursesBox, enrollCoursesBox);

            // Set up dataview
            studentDataView.AutoGenerateColumns = false;
            studentDataView.DataSource = _students;
            studentDataView.SelectionChanged += StudentDataView_SelectionChanged;

            // Setup major options
            var items = Enum.GetValues<MajorType>()
                            .Select(e => new KeyValuePair<MajorType, string>(e, e.ToDisplayString()))
                            .ToArray();
            majorCombobox.DataSource = items;
            majorCombobox.DisplayMember = "Value";
            majorCombobox.ValueMember = "Key";



            // Checkbox
            maleCheckbox.CheckedChanged += CheckBoxChanged;
            femaleCheckbox.CheckedChanged += CheckBoxChanged;

            // Dual box
            addToEnrolledBtn.Click += AddToEnrolledBtn_Click;
            removeFromEnrolledBtn.Click += RemoveFromEnrolledBtn_Click;

            // Tools button
            addUpdateBtn.Click += AddUpdateBtn_Click;
            deleteBtn.Click += DeleteBtn_Click;
            deselectBtn.Click += DeselectBtn_Click;
            helpToolStripButton.Click += HelpToolStripButton_Click;


            // Saving
            saveBtn.Click += (_, _) => SaveClick();
            saveAsBtn.Click += (_, _) => SaveAsClick();
            openBtn.Click += (_, _) => OpenClick();

            // toolstrip
            newToolStripBtn.Click += NewToolStripBtn_Click;
            openToolStripButton.Click += (_, _) => OpenClick();
            saveToolStripButton.Click += (_, _) => SaveClick();

            // form
            FormClosing += FromBai9_FormClosing;
        }

        private void HelpToolStripButton_Click(object? sender, EventArgs e)
        {
            var message = "App version 1.0";
            MessageBoxHelper.ShowInfo(message);
        }

        private void NewToolStripBtn_Click(object? sender, EventArgs e)
        {
            if (!isDirty)
            {
                ClearInput();
                _students.Clear();
                _storageJson = null;
                isDirty = false;
                saveFileDialog.FileName = string.Empty;

                return;
            }

            DialogResult result = MessageBoxHelper.ShowConfirmation(
                     "Chưa lưu thông tin, lưu trước khi tạo?",
                     MessageBoxButtons.YesNoCancel
            );

            if (result == DialogResult.Yes)
            {
                var saved = SaveClick();

                if (saved) {
                    ClearInput();
                    _students.Clear();
                    isDirty = false;
                }

            } else if (result == DialogResult.No)
            {
                ClearInput();
                _students.Clear();
                isDirty = false;
            }
        }

        private void FromBai9_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!isDirty) return;


            DialogResult result = MessageBoxHelper.ShowConfirmation(
                "Chưa lưu thông tin, lưu trước khi đóng?",
                MessageBoxButtons.YesNoCancel
            );

            if (result == DialogResult.Yes) {
                var saved = SaveClick();
                if (!saved) e.Cancel = true;

            }else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }


        }


        private void OpenClick()
        {
            if (_storageJson is null)
            {
                openFileDialog.InitialDirectory = StorageJSON.DefaultDirectory;
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                _storageJson ??= new StorageJSON(filePath);
                _storageJson.FilePath = filePath;

                try
                {
                    var sts = _storageJson.Load();
                    _students.Clear();
                    foreach (var item in sts)
                    {
                        _students.Add(item);
                    }

                    this.Text = $"Students Database - {Path.GetFileName(filePath)}";
                    isDirty = false;
                }
                catch (JsonException ex)
                {
                    MessageBoxHelper.ShowError($"Không đúng loại file: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBoxHelper.ShowError(ex.Message);
                }
            }
        }
        private bool SaveAsClick()
        {
            if (_storageJson is null)
            {
                saveFileDialog.InitialDirectory = StorageJSON.DefaultDirectory;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storageJson = new StorageJSON(saveFileDialog.FileName);
                    _storageJson.Store(_students);
                    this.Text = $"Students Database - {Path.GetFileName(saveFileDialog.FileName)}";
                    isDirty = false;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBoxHelper.ShowError($"Không thể lưu: {ex.Message}");
                    _storageJson = new();
                    return false;
                }
            }
            return false;

        }
        private bool SaveClick()
        {
            if (_storageJson is null)
            {
               return SaveAsClick();
            }
            try
            {
                _storageJson.Store(_students);
                MessageBoxHelper.ShowInfo($"File đã được lưu tại: {_storageJson.FilePath}");
                isDirty = false;
                return true;

            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Không thể lưu: {ex.Message}");
                return false;
            }
        }

        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            if (MessageBoxHelper.ShowConfirmation("Bạn có muốn xóa không") == DialogResult.Cancel)
                return;

            mssvTextbox.Text = mssvTextbox.Text.Trim();
            int index = -1;
            for (int i = 0; i < _students.Count; i++)
            {
                Student? item = _students[i];
                if (item.MSSV == mssvTextbox.Text)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                _students.RemoveAt(index);
                isDirty = true;
            }else
            {
                MessageBoxHelper.ShowError("Tài khoản không tồn tại");
            }
        }

        void ClearInput()
        {
            mssvTextbox.Text = string.Empty;
            nameTextbox.Text = string.Empty;
            _coursesDualListBox.Reset();
        }

        private void DeselectBtn_Click(object? sender, EventArgs e)
        {
            studentDataView.ClearSelection();
            ClearInput();
        }

        private void StudentDataView_SelectionChanged(object? sender, EventArgs e)
        {
            if (studentDataView.SelectedRows.Count == 0)
            {
                return;
            }
            var st = (Student)studentDataView.SelectedRows[0].DataBoundItem;

            mssvTextbox.Text = st.MSSV.ToString();
            nameTextbox.Text = st.HoTen;

            if (st.Gender == GenderType.Male)
            {
                maleCheckbox.Checked = true;
            }
            else
            {
                femaleCheckbox.Checked = true;
            }

            majorCombobox.SelectedItem =
                new KeyValuePair<MajorType, string>(st.Major, st.Major.ToDisplayString());
            _coursesDualListBox.ChangeBaseOnStudent(st);
        }

        private void RemoveFromEnrolledBtn_Click(object? sender, EventArgs e)
        {
            _coursesDualListBox.MoveSelectedBToA();
            
        }

        private void AddToEnrolledBtn_Click(object? sender, EventArgs e)
        {
            _coursesDualListBox.MoveSelectedAToB();
        }

        bool CheckValidity(TextBox txt, string errorMsg)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBoxHelper.ShowError(errorMsg);
                return false;
            }
            return true;
        }
        private void AddUpdateBtn_Click(object? sender, EventArgs e)
        {
            mssvTextbox.Text = mssvTextbox.Text.Trim();
            nameTextbox.Text = nameTextbox.Text.Trim();

            if (!CheckValidity(mssvTextbox, "Phải nhập mssv"))
                return;

            if (mssvTextbox.Text.Any(char.IsWhiteSpace))
            {
                MessageBoxHelper.ShowError("Mã sinh viên không được có khoảng trắng");
                return;
            }


            if (!CheckValidity(nameTextbox, "Phải nhập tên"))
                return;

            var selectedMajor = (MajorType?)majorCombobox.SelectedValue;
            if (selectedMajor == null)
            {
                MessageBoxHelper.ShowError("Chọn ngành học");
                return;
            }

            // Creating student
            var st = new Student(
                mssvTextbox.Text,
                nameTextbox.Text,
                selectedMajor.Value,
                _currentSelectedGender,
                _coursesDualListBox.GetEnrollCourses()
            );

            int index = -1;

            for (int i = 0; i < _students.Count; i++)
            {
                Student? student = _students[i];
                if (student.MSSV == mssvTextbox.Text)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                _students.Add(st);
            }
            else
            {
                //_students.RemoveAt(index);
                //_students.Insert(index, st);
                _students[index] = st;
            }
            isDirty = true;
        }

        private void CheckBoxChanged(object? sender, EventArgs e)
        {
            // Weird ass pattern, idc
            maleCheckbox.CheckedChanged -= CheckBoxChanged;
            femaleCheckbox.CheckedChanged -= CheckBoxChanged;

            maleCheckbox.Checked = false;
            femaleCheckbox.Checked = false;

            if (sender is CheckBox chx)
            {
                chx.Checked = true;

                if (chx == maleCheckbox)
                {
                    _currentSelectedGender = GenderType.Male;
                }
                else
                {
                    _currentSelectedGender = GenderType.Female;
                }
            }

            maleCheckbox.CheckedChanged += CheckBoxChanged;
            femaleCheckbox.CheckedChanged += CheckBoxChanged;
        }


    }
}
