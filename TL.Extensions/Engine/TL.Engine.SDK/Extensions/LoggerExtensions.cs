using System;
using TL.Engine.SDK.Extensions;

namespace Microsoft.Extensions.Logging
{
    /// <summary>
    /// Расширения типа <see cref="ILogger"/>.
    /// </summary>
    public static class LoggerExtensions
    {
        public static void TLog(this ILogger logger, LogLevel logLevel, Exception exception, string message, params object[] args)
        {
            logger.Log(logLevel, exception, message.AddDateTimeMs(), args);
        }

        public static void TLog(this ILogger logger, LogLevel logLevel, EventId eventId, string message, params object[] args)
        {
            logger.Log(logLevel, eventId, message.AddDateTimeMs(), args);
        }

        public static void TLog(this ILogger logger, LogLevel logLevel, string message, params object[] args)
        {
            logger.Log(logLevel, message.AddDateTimeMs(), args);
        }

        public static void TLog(this ILogger logger, LogLevel logLevel, EventId eventId, Exception exception, string message, params object[] args)
        {
            logger.Log(logLevel, eventId, exception, message.AddDateTimeMs(), args);
        }

        public static void TLogInformation(this ILogger logger, string message, params object[] args)
        {
            logger.LogInformation(message.AddDateTimeMs(), args);
        }

        public static void TLogInformation(this ILogger logger, EventId eventId, string message, params object[] args)
        {
            logger.LogInformation(eventId, message.AddDateTimeMs(), args);
        }

        public static void TLogInformation(this ILogger logger, Exception exception, string message, params object[] args)
        {
            logger.LogInformation(exception, message.AddDateTimeMs(), args);
        }

        public static void TLogInformation(this ILogger logger, EventId eventId, Exception exception, string message, params object[] args)
        {
            logger.LogInformation(eventId, exception, message.AddDateTimeMs(), args);
        }

        public static void TLogWarning(this ILogger logger, string message, params object[] args)
        {
            logger.LogWarning(message.AddDateTimeMs(), args);
        }

        public static void TLogWarning(this ILogger logger, EventId eventId, string message, params object[] args)
        {
            logger.LogWarning(eventId, message.AddDateTimeMs(), args);
        }

        public static void TLogWarning(this ILogger logger, Exception exception, string message, params object[] args)
        {
            logger.LogWarning(exception, message.AddDateTimeMs(), args);
        }

        public static void TLogWarning(this ILogger logger, EventId eventId, Exception exception, string message, params object[] args)
        {
            logger.LogWarning(eventId, exception, message.AddDateTimeMs(), args);
        }

        public static void TLogCritical(this ILogger logger, string message, params object[] args)
        {
            logger.LogCritical(message.AddDateTimeMs(), args);
        }

        public static void TLogCritical(this ILogger logger, EventId eventId, string message, params object[] args)
        {
            logger.LogCritical(eventId, message.AddDateTimeMs(), args);
        }

        public static void TLogCritical(this ILogger logger, Exception exception, string message, params object[] args)
        {
            logger.LogCritical(exception, message.AddDateTimeMs(), args);
        }

        public static void TLogCritical(this ILogger logger, EventId eventId, Exception exception, string message, params object[] args)
        {
            logger.LogCritical(eventId, exception, message.AddDateTimeMs(), args);
        }

        public static void TLogError(this ILogger logger, string message, params object[] args)
        {
            logger.LogError(message.AddDateTimeMs(), args);
        }

        public static void TLogError(this ILogger logger, EventId eventId, string message, params object[] args)
        {
            logger.LogError(eventId, message.AddDateTimeMs(), args);
        }

        public static void TLogError(this ILogger logger, Exception exception, string message, params object[] args)
        {
            logger.LogError(exception, message.AddDateTimeMs(), args);
        }

        public static void TLogError(this ILogger logger, EventId eventId, Exception exception, string message, params object[] args)
        {
            logger.LogError(eventId, exception, message.AddDateTimeMs(), args);
        }
    }
}
