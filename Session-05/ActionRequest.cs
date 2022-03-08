namespace EpsilonNet.CodingSchool2022.Session_05;

public class ActionRequest
{
    public Guid RequestID { get; }

    public string Input { get; }

    public ActionEnum Action { get; }

    public ActionRequest(Guid requestId, string input, ActionEnum action)
    {
        RequestID = requestId;
        Input = input;
        Action = action;
    }
}
