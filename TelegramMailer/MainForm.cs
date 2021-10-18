using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TelegramMailer.Models;

namespace TelegramMailer
{
    public partial class MainForm : Form
    {
        Mailer BotMailer;
        public MainForm()
        {
            InitializeComponent();
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
            if (TokenTextBox.Text != string.Empty  && MessageTextBox.Text != string.Empty && IDsTextBox.Text != string.Empty)
            {
                List<long> IDs = GetIDs();
                if (IDs.Count > 0)
                {
                    BotMailer = new Mailer(TokenTextBox.Text);
                    BotMailer.SendTextMessage(IDs, MessageTextBox.Text, 500);
                }
                else MessageBox.Show("Enter Ids! Count of detected IDs: " + IDs.Count);
            }
            else
            {
                MessageBox.Show("Enter token, IDs andmessage  text!");
            }
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
    }
}
