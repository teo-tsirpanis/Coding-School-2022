namespace EpsilonNet.CodingSchool2022.UniversityLib;

public class University : Institute
{
    public List<Student> Students { get; } = new List<Student>();

    public List<Course> Courses { get; } = new List<Course>();

    public List<Grade> Grades { get; } = new List<Grade>();

    public List<Schedule> ScheduledCourses { get; } = new List<Schedule>();

    public University()
    {
    }

    public void SetSchedule(Guid courseId, Guid professorId, DateTime dateTime)
    {
        var schedule = new Schedule()
        {
            CourseID = courseId,
            ProfessorID = professorId,
            Calendar = dateTime
        };
        ScheduledCourses.Add(schedule);
    }
}
