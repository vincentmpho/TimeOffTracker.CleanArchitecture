using Microsoft.Extensions.Logging;
using TimeOffTracker.Application.Logging;

namespace TimeOffTracker.Infrastructure.Logging
{
    public class LoggerAdpter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerAdpter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }

        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }
    }
}
