using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Telegram.Bot;

namespace TelegramMailer.Models
{
    class Mailer
    {
        private readonly TelegramBotClient BotClient;
        public Mailer(string botToken)
        {
            BotClient = new TelegramBotClient(botToken);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        /// <summary>
        /// Send text message to all users/chats with IDs
        /// </summary>
        /// <param name="usersIDs">List of chat/user IDs</param>
        /// <param name="text">Message text</param>
        /// <param name="delay">Delay between requests</param>
        public async void SendTextMessage(List<long> IDs, string text, int delay = 500)
        {
            int complete = 0;
            for (int i = 0; i < IDs.Count; i++, Thread.Sleep(delay))
            {
                try
                {
                    // Попытка отправить сообщение в чат {usersIDs[i]}
                    await BotClient.SendTextMessageAsync(IDs[i], text);
                    // Сообщение в чат {usersIDs[i]} успешно отправлено
                    complete++;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    // Ошибка: {exception.Message}
                    // Источник: {exception.Source}
                    // Тип: {exception.GetType()}
                }
            }

            MessageBox.Show($"Complete {complete} of {IDs.Count}.");
        }
    }
}
