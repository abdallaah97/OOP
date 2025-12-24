namespace oop
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CrditHours { get; set; }

        public string DisplayCourseInfo()
        {
            return $"CourseName : {CourseName} , CourseCode : {CourseCode}, CrditHours {CrditHours}";
        }
    }
}
