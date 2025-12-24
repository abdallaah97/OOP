using oop;

Person student1 = new Student()
{
    Id = Helper.GenerateId(),
    FullName = "Abdallah Fawaz",
    Email = "abdallahmarabah@gmail.com",
    PhoneNumber = "1234567890",
    StudentNumber = "1",
    Major = Major.CIS.ToString()
};

Person student2 = new Student()
{
    Id = Helper.GenerateId(),
    FullName = "Ahmad Khaled",
    Email = "test@gmail.com",
    PhoneNumber = "0794335453",
    StudentNumber = "2",
    Major = Major.CS.ToString()
};

Person teacher = new Teacher()
{
    Id = Helper.GenerateId(),
    FullName = "Ahmad Khaled",
    Email = "test@gmail.com",
    PhoneNumber = "0794335453",
    TeacherNumber = "2",
    Department = "Dept test"
};

Console.WriteLine(student1.DisplayPersonInfo());
Console.WriteLine(student2.DisplayPersonInfo());


Course course1 = new Course()
{
    CourseCode = "1",
    CourseName = "C#",
    CrditHours = 12
};

Course course2 = new Course()
{
    CourseCode = "2",
    CourseName = "SQL",
    CrditHours = 10
};

student1.DisplayPersonInfo(new );
student1.EnrollInCourse(course2);


List<string> listStr = student1.ShowEnrolledCourses();
foreach (var item in listStr)
{
    Console.WriteLine(item);
}

