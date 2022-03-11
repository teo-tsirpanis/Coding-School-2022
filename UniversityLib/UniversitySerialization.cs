using Newtonsoft.Json;

namespace EpsilonNet.CodingSchool2022.UniversityLib;

public class UniversitySerialization
{
    public static University ReadFromFile(string path)
    {
        string json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<University>(json);
    }

    public static void WriteToFile(University university, string path)
    {
        string serializedJson = JsonConvert.SerializeObject(university);
        File.WriteAllText(path, serializedJson);
    }
}
