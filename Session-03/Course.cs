namespace EpsilonNet.CodingSchool2022.Session_03;

public class Course
{
    public Guid ID { get; }

    public string Code { get; set; }

    public string Subject { get; set; }

    public Course()
    {
        ID = Guid.NewGuid();
    }
}
