namespace EpsilonNet.CodingSchool2022.Session_03;

public class Schedule
{
    public Guid ID { get; set; }

    public Guid CourseID { get; set; }

    public Guid ProfessorID { get; set; }

    // Was "Callendar", fixed.
    public DateTime Calendar { get; set; }

    public Schedule()
    {
        ID = Guid.NewGuid();
    }
}
