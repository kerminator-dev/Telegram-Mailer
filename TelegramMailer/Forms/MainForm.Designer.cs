
namespace TelegramMailer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IDsTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.IDsLabel = new Guna.UI.WinForms.GunaLabel();
            this.MessageTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.MessageLabel = new Guna.UI.WinForms.GunaLabel();
            this.SendButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogsButton = new Guna.UI2.WinForms.Guna2Button();
            this.DragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.NameLabel = new Guna.UI.WinForms.GunaLabel();
            this.MinimizeButton = new Guna.UI.WinForms.GunaLabel();
            this.CloseButton = new Guna.UI.WinForms.GunaLabel();
            this.KeyLabel = new Guna.UI.WinForms.GunaLabel();
            this.TokenTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearLogsButton = new Guna.UI2.WinForms.Guna2Button();
            this.DragForm2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDsTextBox
            // 
            this.IDsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IDsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.IDsTextBox.BaseColor = System.Drawing.Color.White;
            this.IDsTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IDsTextBox.BorderSize = 3;
            this.IDsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDsTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.IDsTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.IDsTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.IDsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.IDsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.IDsTextBox.Location = new System.Drawing.Point(16, 104);
            this.IDsTextBox.MinimumSize = new System.Drawing.Size(134, 389);
            this.IDsTextBox.Multiline = true;
            this.IDsTextBox.Name = "IDsTextBox";
            this.IDsTextBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDsTextBox.PasswordChar = '\0';
            this.IDsTextBox.Radius = 12;
            this.IDsTextBox.SelectedText = "";
            this.IDsTextBox.Size = new System.Drawing.Size(134, 390);
            this.IDsTextBox.TabIndex = 2;
            this.IDsTextBox.Text = "\r";
            this.IDsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip.SetToolTip(this.IDsTextBox, "List of chat IDs (also user IDs). \r\nExample:\r\n541323465145\r\n361325332634\r\n6635636" +
        "23552\r\n343347235336");
            // 
            // IDsLabel
            // 
            this.IDsLabel.Font = new System.Drawing.Font("Raavi", 11F, System.Drawing.FontStyle.Bold);
            this.IDsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.IDsLabel.Location = new System.Drawing.Point(12, 81);
            this.IDsLabel.Name = "IDsLabel";
            this.IDsLabel.Size = new System.Drawing.Size(134, 19);
            this.IDsLabel.TabIndex = 6;
            this.IDsLabel.Text = "Target chat IDs";
            this.IDsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IDsLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ToolTip.SetToolTip(this.IDsLabel, "List of chat IDs (also user IDs). ");
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MessageTextBox.BaseColor = System.Drawing.Color.White;
            this.MessageTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageTextBox.BorderSize = 3;
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.MessageTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.MessageTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.MessageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MessageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.MessageTextBox.Location = new System.Drawing.Point(156, 104);
            this.MessageTextBox.MinimumSize = new System.Drawing.Size(340, 389);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageTextBox.PasswordChar = '\0';
            this.MessageTextBox.Radius = 12;
            this.MessageTextBox.SelectedText = "";
            this.MessageTextBox.Size = new System.Drawing.Size(340, 390);
            this.MessageTextBox.TabIndex = 3;
            this.ToolTip.SetToolTip(this.MessageTextBox, "Message that will be sent to all chat IDs.");
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.Font = new System.Drawing.Font("Raavi", 11F, System.Drawing.FontStyle.Bold);
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.MessageLabel.Location = new System.Drawing.Point(152, 82);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(344, 19);
            this.MessageLabel.TabIndex = 8;
            this.MessageLabel.Text = "Message to send";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MessageLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ToolTip.SetToolTip(this.MessageLabel, "Message that will be sent to all chat IDs.");
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Animated = true;
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.BorderRadius = 14;
            this.SendButton.CheckedState.Parent = this.SendButton;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.CustomImages.Parent = this.SendButton;
            this.SendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.SendButton.HoverState.Parent = this.SendButton;
            this.SendButton.Location = new System.Drawing.Point(390, 499);
            this.SendButton.Name = "SendButton";
            this.SendButton.ShadowDecoration.BorderRadius = 14;
            this.SendButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.SendButton.ShadowDecoration.Enabled = true;
            this.SendButton.ShadowDecoration.Parent = this.SendButton;
            this.SendButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.SendButton.Size = new System.Drawing.Size(106, 30);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Start sending";
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // LogsButton
            // 
            this.LogsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogsButton.Animated = true;
            this.LogsButton.BackColor = System.Drawing.Color.Transparent;
            this.LogsButton.BorderRadius = 14;
            this.LogsButton.CheckedState.Parent = this.LogsButton;
            this.LogsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsButton.CustomImages.Parent = this.LogsButton;
            this.LogsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.LogsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LogsButton.ForeColor = System.Drawing.Color.White;
            this.LogsButton.HoverState.Parent = this.LogsButton;
            this.LogsButton.Location = new System.Drawing.Point(292, 499);
            this.LogsButton.Name = "LogsButton";
            this.LogsButton.ShadowDecoration.BorderRadius = 14;
            this.LogsButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.LogsButton.ShadowDecoration.Enabled = true;
            this.LogsButton.ShadowDecoration.Parent = this.LogsButton;
            this.LogsButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LogsButton.Size = new System.Drawing.Size(92, 30);
            this.LogsButton.TabIndex = 5;
            this.LogsButton.Text = "Open logs";
            this.LogsButton.Click += new System.EventHandler(this.LogsButton_Click);
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this.HeaderPanel;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.HeaderPanel.Controls.Add(this.NameLabel);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(508, 24);
            this.HeaderPanel.TabIndex = 14;
            // 
            // NameLabel
            // 
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.NameLabel.Location = new System.Drawing.Point(186, 1);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(135, 23);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Telegram mailer";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Raavi", 11F, System.Drawing.FontStyle.Bold);
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.MinimizeButton.Location = new System.Drawing.Point(459, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(26, 27);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "__";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.CloseButton.Location = new System.Drawing.Point(483, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "✖";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // KeyLabel
            // 
            this.KeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyLabel.Font = new System.Drawing.Font("Raavi", 11F, System.Drawing.FontStyle.Bold);
            this.KeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.KeyLabel.Location = new System.Drawing.Point(12, 27);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(484, 19);
            this.KeyLabel.TabIndex = 13;
            this.KeyLabel.Text = "Bot Token";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KeyLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.ToolTip.SetToolTip(this.KeyLabel, "Your Bot Key. Example:");
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenTextBox.BackColor = System.Drawing.Color.Transparent;
            this.TokenTextBox.BaseColor = System.Drawing.Color.White;
            this.TokenTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TokenTextBox.BorderSize = 3;
            this.TokenTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TokenTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.TokenTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.TokenTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.TokenTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TokenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.TokenTextBox.Location = new System.Drawing.Point(12, 48);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TokenTextBox.PasswordChar = '*';
            this.TokenTextBox.Radius = 12;
            this.TokenTextBox.SelectedText = "";
            this.TokenTextBox.Size = new System.Drawing.Size(484, 30);
            this.TokenTextBox.TabIndex = 1;
            this.TokenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTip.SetToolTip(this.TokenTextBox, "Your Bot Key. Example:\r\n1912463298:AAFSC2KufFScXnfsrfd3fhlfRBhGQh5YZaY");
            // 
            // ClearLogsButton
            // 
            this.ClearLogsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearLogsButton.Animated = true;
            this.ClearLogsButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearLogsButton.BorderRadius = 14;
            this.ClearLogsButton.CheckedState.Parent = this.ClearLogsButton;
            this.ClearLogsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearLogsButton.CustomImages.Parent = this.ClearLogsButton;
            this.ClearLogsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ClearLogsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ClearLogsButton.ForeColor = System.Drawing.Color.White;
            this.ClearLogsButton.HoverState.Parent = this.ClearLogsButton;
            this.ClearLogsButton.Location = new System.Drawing.Point(194, 499);
            this.ClearLogsButton.Name = "ClearLogsButton";
            this.ClearLogsButton.ShadowDecoration.BorderRadius = 14;
            this.ClearLogsButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.ClearLogsButton.ShadowDecoration.Enabled = true;
            this.ClearLogsButton.ShadowDecoration.Parent = this.ClearLogsButton;
            this.ClearLogsButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.ClearLogsButton.Size = new System.Drawing.Size(92, 30);
            this.ClearLogsButton.TabIndex = 16;
            this.ClearLogsButton.Text = "Clear logs";
            this.ClearLogsButton.Click += new System.EventHandler(this.ClearLogsButton_Click);
            // 
            // DragForm2
            // 
            this.DragForm2.TargetControl = this.NameLabel;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsButton.Animated = true;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BorderRadius = 14;
            this.SettingsButton.CheckedState.Parent = this.SettingsButton;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.CustomImages.Parent = this.SettingsButton;
            this.SettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.HoverState.Parent = this.SettingsButton;
            this.SettingsButton.Location = new System.Drawing.Point(16, 499);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.ShadowDecoration.BorderRadius = 14;
            this.SettingsButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.SettingsButton.ShadowDecoration.Parent = this.SettingsButton;
            this.SettingsButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.SettingsButton.Size = new System.Drawing.Size(79, 30);
            this.SettingsButton.TabIndex = 17;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 541);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ClearLogsButton);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.TokenTextBox);
            this.Controls.Add(this.LogsButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.IDsLabel);
            this.Controls.Add(this.IDsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(508, 541);
            this.Name = "MainForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox IDsTextBox;
        private Guna.UI.WinForms.GunaLabel IDsLabel;
        private Guna.UI.WinForms.GunaLabel MessageLabel;
        private Guna.UI.WinForms.GunaTextBox MessageTextBox;
        private Guna.UI2.WinForms.Guna2Button SendButton;
        private Guna.UI2.WinForms.Guna2Button LogsButton;
        private Guna.UI.WinForms.GunaDragControl DragForm;
        private Guna.UI.WinForms.GunaLabel KeyLabel;
        private Guna.UI.WinForms.GunaTextBox TokenTextBox;
        private System.Windows.Forms.Panel HeaderPanel;
        private Guna.UI.WinForms.GunaLabel CloseButton;
        private Guna.UI.WinForms.GunaLabel MinimizeButton;
        internal Guna.UI.WinForms.GunaLabel NameLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2Button ClearLogsButton;
        private Guna.UI.WinForms.GunaDragControl DragForm2;
        private Guna.UI2.WinForms.Guna2Button SettingsButton;
    }
}