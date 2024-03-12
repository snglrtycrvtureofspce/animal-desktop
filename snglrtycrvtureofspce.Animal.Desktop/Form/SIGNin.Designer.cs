namespace snglrtycrvtureofspce.Animal.Desktop
{
    partial class SIGNin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNin));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.Message = new System.Windows.Forms.Label();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.BtnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSignIN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxPassword = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxUser = new Guna.UI.WinForms.GunaTextBox();
            this.Label = new Guna.UI.WinForms.GunaLabel();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.Message);
            this.ErrorPanel.Controls.Add(this.gunaPictureBox);
            this.ErrorPanel.Location = new System.Drawing.Point(16, 143);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(213, 19);
            this.ErrorPanel.TabIndex = 29;
            this.ErrorPanel.Visible = false;
            // 
            // Message
            // 
            this.Message.Dock = System.Windows.Forms.DockStyle.Right;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(19, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(194, 19);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaPictureBox
            // 
            this.gunaPictureBox.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox.Image")));
            this.gunaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox.Name = "gunaPictureBox";
            this.gunaPictureBox.Size = new System.Drawing.Size(19, 19);
            this.gunaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox.TabIndex = 0;
            this.gunaPictureBox.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.AnimationHoverSpeed = 0.07F;
            this.BtnClose.AnimationSpeed = 0.03F;
            this.BtnClose.BaseColor = System.Drawing.Color.White;
            this.BtnClose.BorderColor = System.Drawing.Color.White;
            this.BtnClose.CheckedBaseColor = System.Drawing.Color.White;
            this.BtnClose.CheckedBorderColor = System.Drawing.Color.White;
            this.BtnClose.CheckedForeColor = System.Drawing.Color.White;
            this.BtnClose.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.CheckedImage")));
            this.BtnClose.CheckedLineColor = System.Drawing.Color.White;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnClose.FocusedColor = System.Drawing.Color.Empty;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnClose.LineColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(205, -1);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnClose.OnHoverBorderColor = System.Drawing.Color.White;
            this.BtnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnClose.OnHoverImage = null;
            this.BtnClose.OnHoverLineColor = System.Drawing.Color.White;
            this.BtnClose.OnPressedColor = System.Drawing.Color.White;
            this.BtnClose.Size = new System.Drawing.Size(44, 34);
            this.BtnClose.TabIndex = 28;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSignIN
            // 
            this.BtnSignIN.AnimationHoverSpeed = 0.07F;
            this.BtnSignIN.AnimationSpeed = 0.03F;
            this.BtnSignIN.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignIN.BaseColor = System.Drawing.Color.Black;
            this.BtnSignIN.BorderColor = System.Drawing.Color.Black;
            this.BtnSignIN.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSignIN.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSignIN.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSignIN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSignIN.CheckedImage")));
            this.BtnSignIN.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSignIN.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSignIN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSignIN.ForeColor = System.Drawing.Color.White;
            this.BtnSignIN.Image = null;
            this.BtnSignIN.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSignIN.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignIN.Location = new System.Drawing.Point(57, 171);
            this.BtnSignIN.Name = "BtnSignIN";
            this.BtnSignIN.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.BtnSignIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSignIN.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSignIN.OnHoverImage = null;
            this.BtnSignIN.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignIN.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSignIN.Radius = 15;
            this.BtnSignIN.Size = new System.Drawing.Size(131, 30);
            this.BtnSignIN.TabIndex = 25;
            this.BtnSignIN.Text = "ВОЙТИ";
            this.BtnSignIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSignIN.Click += new System.EventHandler(this.BtnSignIN_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPassword.BaseColor = System.Drawing.Color.White;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.BorderSize = 1;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxPassword.Location = new System.Drawing.Point(16, 102);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Radius = 13;
            this.TextBoxPassword.Size = new System.Drawing.Size(213, 35);
            this.TextBoxPassword.TabIndex = 24;
            this.TextBoxPassword.Text = "Пароль";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUser.BaseColor = System.Drawing.Color.White;
            this.TextBoxUser.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxUser.BorderSize = 1;
            this.TextBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUser.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUser.Location = new System.Drawing.Point(16, 61);
            this.TextBoxUser.MaxLength = 30;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.PasswordChar = '\0';
            this.TextBoxUser.Radius = 13;
            this.TextBoxUser.Size = new System.Drawing.Size(213, 35);
            this.TextBoxUser.TabIndex = 23;
            this.TextBoxUser.Text = "Имя пользователя";
            this.TextBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.TextBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Label.Location = new System.Drawing.Point(96, 24);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(53, 25);
            this.Label.TabIndex = 22;
            this.Label.Text = "Вход";
            // 
            // SIGNin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(244, 218);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSignIN);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SIGNin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNin";
            this.ErrorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label Message;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
        private Guna.UI.WinForms.GunaAdvenceButton BtnClose;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSignIN;
        private Guna.UI.WinForms.GunaTextBox TextBoxPassword;
        private Guna.UI.WinForms.GunaTextBox TextBoxUser;
        private Guna.UI.WinForms.GunaLabel Label;
    }
}