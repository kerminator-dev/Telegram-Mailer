using System;
using System.Windows.Forms;

namespace TelegramMailer.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            LoadSettings();
            SaveButton.Select();
        }

        private void LoadSettings()
        {
            DisplayErrorsCheckBox.Checked = Properties.Settings.Default.DisplayErrorMessages;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Changes will not be saved. Continue?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Do you really want to close the settings? Changes will not be saved.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            // Updating
            Properties.Settings.Default.DisplayErrorMessages = DisplayErrorsCheckBox.Checked;

            // Saving changes
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
