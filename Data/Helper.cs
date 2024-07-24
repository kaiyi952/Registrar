using Registrar.Models;

namespace Registrar;

public class Helper
{
  public static List<Course> GetCourses ()
  {
    List<Course> courses = [];

    Course course = new Course
    {
      Code = "CST8282",
      Title = "Introduction to Database Systems",
      WeeklyHours = 4
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8253",
      Title = "Web Programming II",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8256",
      Title = "Web Programming Language I",  
      WeeklyHours = 5
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8255",
      Title = "Web Imaging and Animations",  
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8254",
      Title = "Network Operating System",  
      WeeklyHours = 1
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2200",
      Title = "Data Warehouse Design",  
      WeeklyHours = 3
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2240",
      Title = "Advance Database topics",  
      WeeklyHours = 1
    };
    courses.Add(course);   

    return courses;
  }

  public static List<string> GetStudentTypes () {
    return ["Full Time", "Part Time", "Coop"];
  }

  public static List<Student> GetStudents ()
  {
    List<Student> students = [];
    Student student = new Student
        {       Id = 123456,
                FirstName = "John",
                LastName = "Doe",
                Type = "Full Time",
                Courses = GetCourses() 
            };
            students.Add(student);
student = new Student
{
                Id = 234567,
                FirstName = "Ann",
                LastName = "Smith",
                Type = "Coop",
                Courses = GetCourses() 
            };
            students.Add(student);
        

            return students;

  }
      public static int getId()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }
}
