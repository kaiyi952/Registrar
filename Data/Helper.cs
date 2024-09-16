namespace Registrar;

public static class Helper
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

  private static readonly Random random = new Random();
  private static readonly HashSet<int> usedIds = new HashSet<int>();
  private static List<Student>? students = null;
  public static List<Student> GetStudents()
  {
    if (students == null)
    {
      students = new List<Student>();
      InitializeStudents();
    }
    return students;
  }

  private static void InitializeStudents()
  {
    AddStudent("John","Smith","Full Time");
    AddStudent("Martha","Joes","Part Time");
    AddStudent("Rose","Tyler","Coop");
  }

  private static void AddStudent(string firstName,string lastName,string type)
  {
    Student student = new Student
    {
      Id = GenerateUniqueId(),
      FirstName = firstName,
      LastName = lastName,
      Type = type
    };
    students.Add(student);
  }
  public static int GenerateUniqueId()
  {
    int newId;
    do{
      newId = random.Next(100000,1000000);
    }while(usedIds.Contains(newId));

    usedIds.Add(newId);
    return newId;
  }

}
