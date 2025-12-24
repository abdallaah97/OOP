namespace oop
{
    public class Teacher : Person
    {
        public string TeacherNumber { get; set; }
        public string Department { get; set; }
        public List<Course> CoursesTaught { get; set; }

        public override string DisplayPersonInfo()
        {
            return $"{base.DisplayPersonInfo()} , TeacherNumber {TeacherNumber} , Department : {Department}, CoursesTaught : {CoursesTaught.Count()}";
        }

        public void AssignCourse(Course course)
        {
            CoursesTaught.Add(course);
        }

        public List<string> ShowCourses()
        {
            var result = new List<string>();
            foreach (var item in CoursesTaught)
            {
                result.Add($"{item.CourseName} - {item.CourseCode}");
            }

            return result;
        }
    }
}
