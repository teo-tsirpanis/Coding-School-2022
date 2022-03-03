namespace EpsilonNet.CodingSchool2022.Session_03;

public class Professor : Person
{
    public string Rank { get; set; }

    public Course[] Courses { get; set; }

    public Professor()
    {
    }

    public void Teach(Course course, DateTime date)
    {
    }

    // The spec uses all caps for "ID", but different casing in parameters has zero impact
    // (in contrast with properties and how they would be stored in a database for example).
    public void SetGrade(Guid studentId, Guid courseId, int grade)
    {
    }

    public new string GetName()
    {
        if (Name.StartsWith("Dr. "))
            return Name;
        return "Dr. " + Name;
    }
}
