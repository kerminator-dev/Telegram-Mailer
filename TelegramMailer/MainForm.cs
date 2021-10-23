using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TelegramMailer.Models;
using TelegramMailer.Models.Logger;

namespace TelegramMailer
{
    public partial class MainForm : Form
    {
        private Mailer BotMailer;
        private readonly TXTLogger Logger;

        public MainForm()
        {
            InitializeComponent();

            Logger = new TXTLogger();
            TokenTextBox.Select();
        }

        private List<long> GetIDs()
        {
            List<long> IDs = new List<long>();
            string[] strings = IDsTextBox.Text.Split('\n');

            for (int i = 0; i < strings.Length; i++)
            {
                if (long.TryParse(strings[i], out long id))
                {
                    IDs.Add(id);
                }
            }

            return IDs;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (TokenTextBox.Text == string.Empty || MessageTextBox.Text == string.Empty || IDsTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter token, IDs and message text!");
                return;
            }

            List<long> IDs = GetIDs();

            if (IDs.Count == 0)
            {
                MessageBox.Show("Enter Ids! Count of detected IDs: " + IDs.Count);
                return;
            }

            // Messaging
            BotMailer = new Mailer(TokenTextBox.Text, Logger);
            BotMailer.SendTextMessage(IDs, MessageTextBox.Text, 500);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogsButton_Click(object sender, EventArgs e)
        {
            Logger.OpenLogs();
        }

        private void ClearLogsButton_Click(object sender, EventArgs e)
        {
            Logger.ClearLogs();
        }
    }
}
