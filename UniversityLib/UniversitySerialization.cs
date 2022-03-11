using System.Text.Json;

namespace EpsilonNet.CodingSchool2022.UniversityLib;

public class UniversitySerialization
{
    public static University ReadFromFile(string path)
    {
        try
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<University>(json);
        }
        catch (FileNotFoundException)
        {
            return new University();
        }
    }

    public static void WriteToFile(University university, string path)
    {
        string serializedJson = JsonSerializer.Serialize(university);
        File.WriteAllText(path, serializedJson);
    }
}
