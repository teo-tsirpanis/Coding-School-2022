namespace EpsilonNet.CodingSchool2022.Session_03;

public class Institute
{
    public Guid ID { get; }

    public string Name { get; set; }

    public int YearsInService { get; set; }

    public Institute()
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
