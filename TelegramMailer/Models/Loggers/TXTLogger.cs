using System;
using System.Diagnostics;
using System.IO;
using TelegramMailer.Models.Enums;
using TelegramMailer.Models.Loggers;

namespace TelegramMailer.Models.Logger
{
    class TXTLogger : ILogger
    {
        public string FilePath { get; private set; }

        public TXTLogger(string txtFilePath = "logs.txt")
        {
            FilePath = txtFilePath;
        }

        public void OpenLogs()
        {
            if (!File.Exists(FilePath))
                File.CreateText(FilePath);
            try
            {
                Process.Start("notepad.exe", FilePath);
            }
            catch (Exception) { }
        }

        public void WriteMessage(string message, LogTypes logType)
        {
            switch (logType)
            {
                case LogTypes.Error:
                    WriteMessage($"Error: {message}");
                    break;
                default:
                    WriteMessage(message);
                    break;
            }
        }

        public void WriteMessage(string message)
        {
            try
            {
                message = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}: {message}";
                File.AppendAllText(FilePath, message + Environment.NewLine);
            }
            catch (Exception) { }
        }

        public void ClearLogs()
        {
            File.WriteAllText(FilePath, String.Empty);
        }
    }
}
