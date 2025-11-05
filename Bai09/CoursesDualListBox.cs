using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    internal class CoursesDualListBox
    {
        public ListBox ABox { get; set; }
        public ListBox BBox { get; set; }

        private BindingList<KeyValuePair<RequireCourseType, string>> _availableCourses;
        private BindingList<KeyValuePair<RequireCourseType, string>> _selectedCourses;

        private List<KeyValuePair<RequireCourseType, string>> _defaultValues;

        public CoursesDualListBox(ListBox a, ListBox b)
        {
            ABox = a;
            BBox = b;

            _defaultValues = 
                [.. Enum.GetValues<RequireCourseType>()
                .Select(e => new KeyValuePair<RequireCourseType, string>(e, e.ToDisplayString()))
            ];

            _availableCourses = new([.. _defaultValues]);
            _selectedCourses = [];

            ABox.DataSource = _availableCourses;
            ABox.DisplayMember = "Value";
            ABox.ValueMember = "Key";

            BBox.DataSource = _selectedCourses;
            BBox.DisplayMember = "Value";
            BBox.ValueMember = "Key";
        }

        public void MoveSelectedAToB()
        {
            if (ABox.SelectedItems.Count == 0) return;

            List<KeyValuePair<RequireCourseType, string>> moveItems = [];
            foreach (KeyValuePair<RequireCourseType, string> v in ABox.SelectedItems)
            {
                moveItems.Add(v);
            }
            foreach (var item in moveItems)
            {
                _selectedCourses.Add(item);
                _availableCourses.Remove(item);
            }
        }

        public void MoveSelectedBToA()
        {
            if (BBox.SelectedItems.Count == 0) return;

            List<KeyValuePair<RequireCourseType, string>> moveItems = [];
            foreach (KeyValuePair<RequireCourseType, string> v in BBox.SelectedItems)
            {
                moveItems.Add(v);
            }
            foreach (var item in moveItems)
            {
                _availableCourses.Add(item);
                _selectedCourses.Remove(item);
            }
        }

        public List<RequireCourseType> GetEnrollCourses()
        {
            return [.. _selectedCourses.Select(x => x.Key)];
        }
        public void ChangeBaseOnStudent(Student st)
        {
            _selectedCourses.Clear();
            _availableCourses.Clear();

            foreach (var item in st.EnrollCourses)
            {
                var e = new KeyValuePair<RequireCourseType, string>(item, item.ToDisplayString());
                _selectedCourses.Add(e);
            }
            foreach(var item in _defaultValues)
            {
                if (!st.EnrollCourses.Contains(item.Key))
                {
                    _availableCourses.Add(item);
                }
            }
        }

        public void Reset()
        {
            _availableCourses.Clear();
            foreach (var item in _defaultValues)
            {
                _availableCourses.Add(item);
            }

            _selectedCourses.Clear();
        }
    }
}
