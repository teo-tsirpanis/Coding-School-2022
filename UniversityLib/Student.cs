namespace EpsilonNet.CodingSchool2022.UniversityLib;

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
