namespace EpsilonNet.CodingSchool2022.Session_05;

public class ActionResponse
{
    public Guid RequestID { get; }

    public Guid ResponseID { get; }

    public string Output { get; }

    public ActionResponse(Guid requestId, Guid responseId, string output)
    {
        RequestID = requestId;
        ResponseID = responseId;
        Output = output;
    }
}
