using EpsilonNet.CodingSchool2022.Session_05.SpecificResolvers;

namespace EpsilonNet.CodingSchool2022.Session_05;

public class ActionResolver
{
    public MessageLogger Logger { get; }

    public ActionResolver(MessageLogger logger)
    {
        Logger = logger;
    }

    private AbstractSpecificResolver? GetSpecificResolver(ActionEnum action)
    {
        switch (action)
        {
            case ActionEnum.Convert:
                Logger.Write($"Using {nameof(ConvertSpecificResolver)}.");
                return new ConvertSpecificResolver();
            case ActionEnum.Uppercase:
                Logger.Write($"Using {nameof(UppercaseSpecificResolver)}.");
                return new UppercaseSpecificResolver();
            case ActionEnum.Reverse:
                Logger.Write($"Using {nameof(ReverseSpecificResolver)}.");
                return new ReverseSpecificResolver();
            default:
                Logger.Write($"Invalid action type {action}.");
                return null;
        }
    }

    ActionResponse? Execute(ActionRequest request)
    {
        Logger.Write($"Received request {request.RequestID} with type {request.Action} and input '{request.Input}'.");

        AbstractSpecificResolver? specificResolver = GetSpecificResolver(request.Action);

        if (specificResolver == null)
        {
            Logger.Write("Specific resolver not found.");
            return null;
        }

        string? result = specificResolver.Execute(request.Input, Logger);

        if (result == null)
        {
            Logger.Write("The resolver returned null.");
            return null;
        }

        Logger.Write($"The resolver succeeded and returned {result}.");

        return new ActionResponse(request.RequestID, Guid.NewGuid(), result);
    }
}
