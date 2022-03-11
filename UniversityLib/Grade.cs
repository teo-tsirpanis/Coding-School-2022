﻿namespace EpsilonNet.CodingSchool2022.UniversityLib;

public class Grade
{
    public Guid ID { get; }

    public Guid StudentID { get; set; }

    public Guid CourseID { get; set; }

    public int Value { get; set; }

    public Grade()
    {
        ID = Guid.NewGuid();
    }
}
