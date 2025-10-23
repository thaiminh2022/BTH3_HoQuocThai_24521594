using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Bai09
{
    public partial class FromBai9 : Form
    {
        GenderType _currentSelectedGender = GenderType.Female;
        BindingList<Student> _students = [];
        CoursesDualListBox _coursesDualListBox;
        StorageJSON _storageJson = new();

        public FromBai9()
        {
            InitializeComponent();

            _coursesDualListBox = new(availableCoursesBox, enrollCoursesBox);

            _students = new([.. _storageJson.Load()]);

            if (_students.Count == 0)
            {
                _students.Add(
                    new("MSSV1", "Ho QUoc Thai", MajorType.SoftwareEngineering, GenderType.Male, []));
            }
            studentDataView.AutoGenerateColumns = false;
            studentDataView.DataSource = _students;
            studentDataView.SelectionChanged += StudentDataView_SelectionChanged;

            var items = Enum.GetValues<MajorType>()
                            .Select(e => new KeyValuePair<MajorType, string>(e, e.ToDisplayString()))
                            .ToArray();

            majorCombobox.DataSource = items;
            majorCombobox.DisplayMember = "Value";
            majorCombobox.ValueMember = "Key";



            maleCheckbox.CheckedChanged += CheckBoxChanged;
            femaleCheckbox.CheckedChanged += CheckBoxChanged;

            addToEnrolledBtn.Click += AddToEnrolledBtn_Click;
            removeFromEnrolledBtn.Click += RemoveFromEnrolledBtn_Click;

            // saveInfoBtn.Click += SaveInfoBtn_Click;
            deselectBtn.Click += DeselectBtn_Click;

        }

        private void DeselectBtn_Click(object? sender, EventArgs e)
        {
            studentDataView.ClearSelection();
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
        private void SaveInfoBtn_Click(object? sender, EventArgs e)
        {
            mssvTextbox.Text = mssvTextbox.Text.Trim();
            nameTextbox.Text = nameTextbox.Text.Trim();

            if (!CheckValidity(mssvTextbox, "Phải nhập mssv"))
                return;

            foreach (var student in _students)
            {
                if (student.MSSV == mssvTextbox.Text)
                {
                    MessageBoxHelper.ShowError("MSSV bị trùng");
                    return;
                }
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
            _students.Add(st);
            try
            {
                _storageJson.Store(_students);
                MessageBoxHelper.ShowInfo($"Thông tin đã được lưu tại: {_storageJson.FilePath}");
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Lỗi khi lưu: {ex.Message}");
            }

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
