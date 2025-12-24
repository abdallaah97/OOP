namespace oop
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public void AddStudent(Student t)
        {
            Students.Add(t);
        }

        public void AddTeacher(Teacher t)
        {
            Teachers.Add(t);
        }

        public string DisplayDepartmentInfo()
        {
            return $"DeptId : {DeptId} , DeptName : {DeptName}";
        }
    }
}
