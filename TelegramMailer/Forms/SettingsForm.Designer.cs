
namespace TelegramMailer.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.NameLabel = new Guna.UI.WinForms.GunaLabel();
            this.MinimizeButton = new Guna.UI.WinForms.GunaLabel();
            this.CloseButton = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.DisplayErrorsCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.DragForm = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.DragForm2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.HeaderPanel.Size = new System.Drawing.Size(240, 24);
            this.HeaderPanel.TabIndex = 15;
            // 
            // NameLabel
            // 
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.NameLabel.Location = new System.Drawing.Point(56, 1);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(118, 23);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Settings";
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
            this.MinimizeButton.Location = new System.Drawing.Point(191, 0);
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
            this.CloseButton.Location = new System.Drawing.Point(215, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "✖";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Raavi", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 32);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 27);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "Logger type:";
            // 
            // DisplayErrorsCheckBox
            // 
            this.DisplayErrorsCheckBox.AutoCheck = false;
            this.DisplayErrorsCheckBox.AutoSize = true;
            this.DisplayErrorsCheckBox.Checked = true;
            this.DisplayErrorsCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.DisplayErrorsCheckBox.CheckedState.BorderRadius = 2;
            this.DisplayErrorsCheckBox.CheckedState.BorderThickness = 0;
            this.DisplayErrorsCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.DisplayErrorsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayErrorsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisplayErrorsCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DisplayErrorsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.DisplayErrorsCheckBox.Location = new System.Drawing.Point(17, 119);
            this.DisplayErrorsCheckBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DisplayErrorsCheckBox.Name = "DisplayErrorsCheckBox";
            this.DisplayErrorsCheckBox.Size = new System.Drawing.Size(169, 23);
            this.DisplayErrorsCheckBox.TabIndex = 20;
            this.DisplayErrorsCheckBox.Text = "Display error messages";
            this.DisplayErrorsCheckBox.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.DisplayErrorsCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.DisplayErrorsCheckBox.UncheckedState.BorderRadius = 3;
            this.DisplayErrorsCheckBox.UncheckedState.BorderThickness = 2;
            this.DisplayErrorsCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DisplayErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Raavi", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 92);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 27);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Other:";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Animated = true;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BorderRadius = 14;
            this.SaveButton.CheckedState.Parent = this.SaveButton;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.CustomImages.Parent = this.SaveButton;
            this.SaveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.SaveButton.HoverState.Parent = this.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(118, 155);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ShadowDecoration.BorderRadius = 14;
            this.SaveButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.SaveButton.ShadowDecoration.Enabled = true;
            this.SaveButton.ShadowDecoration.Parent = this.SaveButton;
            this.SaveButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.SaveButton.Size = new System.Drawing.Size(110, 30);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoCheck = false;
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.Checked = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(102)))), ((int)(((byte)(252)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2RadioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2RadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.guna2RadioButton1.Location = new System.Drawing.Point(17, 59);
            this.guna2RadioButton1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(96, 23);
            this.guna2RadioButton1.TabIndex = 23;
            this.guna2RadioButton1.TabStop = true;
            this.guna2RadioButton1.Text = "TXT Logger";
            this.guna2RadioButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Animated = true;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderRadius = 14;
            this.BackButton.CheckedState.Parent = this.BackButton;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.CustomImages.Parent = this.BackButton;
            this.BackButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.HoverState.Parent = this.BackButton;
            this.BackButton.Location = new System.Drawing.Point(12, 155);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.BorderRadius = 14;
            this.BackButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(252)))));
            this.BackButton.ShadowDecoration.Enabled = true;
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.BackButton.Size = new System.Drawing.Size(64, 30);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this.HeaderPanel;
            // 
            // DragForm2
            // 
            this.DragForm2.TargetControl = this.NameLabel;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 197);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.guna2RadioButton1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DisplayErrorsCheckBox);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        internal Guna.UI.WinForms.GunaLabel NameLabel;
        private Guna.UI.WinForms.GunaLabel MinimizeButton;
        private Guna.UI.WinForms.GunaLabel CloseButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox DisplayErrorsCheckBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI.WinForms.GunaDragControl DragForm;
        private Guna.UI.WinForms.GunaDragControl DragForm2;
    }
}