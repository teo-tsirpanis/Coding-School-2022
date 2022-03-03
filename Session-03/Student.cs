namespace EpsilonNet.CodingSchool2022.Session_03;

public class Student : Person
{
    public int RegistrationNumber { get; set; }

    public Course[] Courses { get; set; }

    public Student()
    {
    }

    public void Attend(Course course, DateTime dateTime)
    {
    }

    public void WriteExam(Course course, DateTime dateTime)
    {
    }
}
