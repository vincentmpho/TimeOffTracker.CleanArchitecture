namespace TimeOffTracker.Application.Logging
{
    public interface IAppLogger<T>
    {
        //CREATE Abstraction for these log methods
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
    }
}
