using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bai09
{
    internal class Student
    {
        public string MSSV { get; private set; }
        public string HoTen { get; private set; }
        public MajorType Major { get; private set; }

        [JsonIgnore]
        public string MajorDisplay => Major.ToDisplayString();

        public GenderType Gender { get; private set; }

        [JsonIgnore]
        public string GenderDisplay => Gender == GenderType.Male ? "Nam" : "Nữ";

        public List<RequireCourseType> EnrollCourses { get; private set; }

        [JsonIgnore]
        public int EnrollCoursesCount => EnrollCourses.Count;

        public Student(string mSSV, 
            string hoTen, 
            MajorType major, 
            GenderType gender, 
            List<RequireCourseType> enrollCourses)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            Major = major;
            Gender = gender;
            EnrollCourses = enrollCourses;
        }

        public Student? FromJSON(string json)
        {
            return JsonSerializer.Deserialize<Student>(json);
        }
    }
}
