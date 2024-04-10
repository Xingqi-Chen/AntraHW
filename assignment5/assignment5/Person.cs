using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace assignment5;
public abstract class Person : IPersonService
{
    protected DateTime Birthday { get; set; }
    protected decimal Salary {
        get
        {
            return Salary;
        }
        set
        {
            if(Salary < 0)
            {
                Salary = 0;
            }
            else
            {
                Salary = value;
            }
        }
    }

    protected List<string> Addresses { get; } = [];

    public Person(DateTime birthday)
    {
        this.Birthday = birthday;
    }

    public int CalculateAge()
    {
        DateTime now = DateTime.Today;
        int age = now.Year - Birthday.Year;

        if (now.Month < Birthday.Month || (now.Month == Birthday.Month && now.Day < Birthday.Day))
        {
            age--;
        }
        return age;
    }

    public string[] GetAddresses()
    {
        return Addresses.ToArray();
    }

    public void AddAddress(string address)
    {
        this.Addresses.Add(address);
    }

    public virtual decimal CalculateSalary()
    {
        return Salary;
    }
}

public class Student: Person, IStudentService
{
    public List<Course> Courses { get; } = [];
    protected Dictionary<Course, char> Grades { get; } = [];
    private Dictionary<char, decimal> gradeGPA { get; } = new Dictionary<char, decimal>()
    {
        {'A', 4.0m},
        {'B', 3.0m},
        {'C', 2.0m},
        {'D', 1.0m},
        {'F', 0.0m}
    };

    public Student(DateTime birthday): base(birthday) { }

    public void TakeCourse(Course course)
    {
        Courses.Add(course);
    }

    public void AssignGrade(Course course, char grade)
    {
        Grades[course] = grade;
    }

    public decimal CalculateGPA()
    {
        decimal result = 0;
        foreach(Course course in Courses)
        {
            result += gradeGPA[Grades[course]];
        }
        return result;
    }
}

public class Course: ICourseService
{
    public string Name { get; set; }
    public List<Student> Students { get; } = [];

    public Course(string name)
    {
        this.Name = name;
    }

    public void EnrollStudent(Student student)
    {
        this.Students.Add(student);
    }
}

public class Department: IDepartmentService
{
    public Instructor? HeadInstructor { set; get; }
    public List<Course> Courses { get; } = [];
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    private decimal Budget { get; set; }

    public Department(decimal budget, DateTime startDate, DateTime endDate)
    {
        Budget = budget;
        StartDate = startDate;
        EndDate = endDate;
    }

    public void AddCourse(Course course)
    {
        this.Courses.Add(course);
    }

    public void AssignHeadInstructor(Instructor instructor)
    {
        this.HeadInstructor = instructor;
    }
}

public class Instructor: Person, IInstructorService
{
    public Department Department { get; set; }
    public DateTime JoinDate { get; set; }
    public Instructor(DateTime birthday, DateTime joinDate, Department department) : base(birthday)
    {
        this.JoinDate = joinDate;
        this.Department = department;
    }

    override public decimal CalculateSalary()
    {
        int years = DateTime.Now.Year - JoinDate.Year;
        return base.CalculateSalary() + years * 1000;
    }
}

public interface IPersonService
{
    public int CalculateAge();
    public decimal CalculateSalary();
    public string[] GetAddresses();
}

public interface IStudentService: IPersonService
{
    public void TakeCourse(Course course);

    public void AssignGrade(Course course, char grade);

    public decimal CalculateGPA();
}

public interface IInstructorService: IPersonService
{

}

public interface ICourseService
{
    public void EnrollStudent(Student student);
}

public interface IDepartmentService
{
    public void AddCourse(Course course);
    public void AssignHeadInstructor(Instructor instructor);
}