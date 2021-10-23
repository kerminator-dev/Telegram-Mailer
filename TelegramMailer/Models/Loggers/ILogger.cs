using TelegramMailer.Models.Enums;

namespace TelegramMailer.Models.Loggers
{
    interface ILogger
    {
        void WriteMessage(string message, LogTypes logType = LogTypes.Message);
        void WriteMessage(string message);
        void ClearLogs();
        string ToString();
    }
}
