namespace EpsilonNet.CodingSchool2022.Session_03;

public class Person
{
    public Guid ID { get; }

    public string Name { get; set; }

    public int Age { get; set; }

    public Person()
    {
        ID = Guid.NewGuid();
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }
}
