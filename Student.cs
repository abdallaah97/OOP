namespace oop
{
    public class Student : Person
    {
        public string StudentNumber  { get; set; }
        public string Major  { get; set; }
        public List<Course> Courses  { get; set; }

        public override string DisplayPersonInfo()
        {
            return $"{base.DisplayPersonInfo()} , StudentNumber {StudentNumber} , Major : {Major}";
        }

        public void EnrollInCourse(Course course)
        {
            if (Courses == null)
            {
                Courses = new List<Course>();
            }
            Courses.Add(course);
        }

        public List<string> ShowEnrolledCourses()
        {
            if (Courses == null)
            {
                Courses = new List<Course>();
            }
            var result = new List<string>();
            foreach (var item in Courses)
            {
                result.Add($"{item.CourseName} - {item.CourseCode}" );
            }

            return result;
        }
    }
}
