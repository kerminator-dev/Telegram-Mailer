using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Telegram.Bot;
using TelegramMailer.Models.Loggers;

namespace TelegramMailer.Models
{
    class Mailer
    {
        #region Fields

        private static TelegramBotClient _BotClient;

        #endregion

        #region Properties

        public ILogger Logger { get; private set; }

        public bool LoggedIn { get; private set; } = false;

        #endregion


        public Mailer(string token, ILogger logger)
        {
            _BotClient = new TelegramBotClient(token);
            Logger = logger;

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            CheckBotClient();
        }

        #region Methods

        public void CheckBotClient()
        {
            try
            {
                var currentUser = _BotClient.GetMeAsync();

                Logger.WriteMessage
                (
                    $"Logged in as {currentUser.Result.FirstName}.",
                    Enums.LogTypes.Message
                );

                LoggedIn = true;
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException)
            {
                Logger.WriteMessage($"Wrong token!", Enums.LogTypes.Error);
                if (Properties.Settings.Default.DisplayErrorMessages)
                    MessageBox.Show($"Wrong token!");
                LoggedIn = false;
            }
            catch (AggregateException)
            {
                Logger.WriteMessage($"Wrong token!", Enums.LogTypes.Error);
                if (Properties.Settings.Default.DisplayErrorMessages)
                    MessageBox.Show($"Wrong token!");
                LoggedIn = false;
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Send text message to all users/chats with IDs
        /// </summary>
        /// <param name="usersIDs">List of chat/user IDs</param>
        /// <param name="text">Message text</param>
        /// <param name="delay">Delay between requests</param>
        public async void SendTextMessage(List<long> IDs, string text, int delay = 500)
        {
            if (!LoggedIn) return;

            int complete = 0;

            for (int i = 0; i < IDs.Count; i++, Thread.Sleep(delay))
            {
                try
                {
                    Logger.WriteMessage($"Trying to send a chat message to {IDs[i]}..", Enums.LogTypes.Message);
                    await _BotClient.SendTextMessageAsync(IDs[i], text);
                    Logger.WriteMessage($"Message to {IDs[i]} successfully sent.", Enums.LogTypes.Message);

                    complete++;
                }
                catch (Exception exception)
                {
                    Logger.WriteMessage(exception.Message, Enums.LogTypes.Error);
                }
            }

            Logger.WriteMessage($"Complete {complete} of {IDs.Count}." + Environment.NewLine, Enums.LogTypes.Message);
            MessageBox.Show($"Complete {complete} of {IDs.Count}.");
        }

        #endregion
    }
}
