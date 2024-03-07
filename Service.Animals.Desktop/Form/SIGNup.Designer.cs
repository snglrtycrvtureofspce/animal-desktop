namespace Service.Animals.Desktop
{
    partial class SIGNup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNup));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelMessenge = new System.Windows.Forms.Label();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.TextBoxPassword = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxUsername = new Guna.UI.WinForms.GunaTextBox();
            this.BtnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSignUP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxEmail = new Guna.UI.WinForms.GunaTextBox();
            this.TextBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.Label = new Guna.UI.WinForms.GunaLabel();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelMessenge);
            this.panelInfo.Controls.Add(this.gunaPictureBox);
            this.panelInfo.Location = new System.Drawing.Point(16, 223);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(213, 19);
            this.panelInfo.TabIndex = 31;
            this.panelInfo.Visible = false;
            // 
            // labelMessenge
            // 
            this.labelMessenge.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMessenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessenge.Location = new System.Drawing.Point(18, 0);
            this.labelMessenge.Name = "labelMessenge";
            this.labelMessenge.Size = new System.Drawing.Size(195, 19);
            this.labelMessenge.TabIndex = 1;
            this.labelMessenge.Text = "Messeng";
            this.labelMessenge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.TextBoxPassword.Location = new System.Drawing.Point(16, 184);
            this.TextBoxPassword.MaxLength = 30;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Radius = 13;
            this.TextBoxPassword.Size = new System.Drawing.Size(213, 35);
            this.TextBoxPassword.TabIndex = 26;
            this.TextBoxPassword.Text = "Пароль";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUsername.BaseColor = System.Drawing.Color.White;
            this.TextBoxUsername.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxUsername.BorderSize = 1;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxUsername.Location = new System.Drawing.Point(16, 143);
            this.TextBoxUsername.MaxLength = 30;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.Radius = 13;
            this.TextBoxUsername.Size = new System.Drawing.Size(213, 35);
            this.TextBoxUsername.TabIndex = 25;
            this.TextBoxUsername.Text = "Имя пользователя";
            this.TextBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.TextBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
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
            this.BtnClose.TabIndex = 30;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSignUP
            // 
            this.BtnSignUP.AnimationHoverSpeed = 0.07F;
            this.BtnSignUP.AnimationSpeed = 0.03F;
            this.BtnSignUP.BackColor = System.Drawing.Color.Transparent;
            this.BtnSignUP.BaseColor = System.Drawing.Color.Black;
            this.BtnSignUP.BorderColor = System.Drawing.Color.Black;
            this.BtnSignUP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSignUP.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSignUP.CheckedForeColor = System.Drawing.Color.White;
            this.BtnSignUP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSignUP.CheckedImage")));
            this.BtnSignUP.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSignUP.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSignUP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSignUP.ForeColor = System.Drawing.Color.White;
            this.BtnSignUP.Image = null;
            this.BtnSignUP.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSignUP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignUP.Location = new System.Drawing.Point(28, 248);
            this.BtnSignUP.Name = "BtnSignUP";
            this.BtnSignUP.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.BtnSignUP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSignUP.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSignUP.OnHoverImage = null;
            this.BtnSignUP.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignUP.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSignUP.Radius = 15;
            this.BtnSignUP.Size = new System.Drawing.Size(192, 30);
            this.BtnSignUP.TabIndex = 28;
            this.BtnSignUP.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.BtnSignUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSignUP.Click += new System.EventHandler(this.BtnSignUP_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxEmail.BaseColor = System.Drawing.Color.White;
            this.TextBoxEmail.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxEmail.BorderSize = 1;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxEmail.Location = new System.Drawing.Point(16, 102);
            this.TextBoxEmail.MaxLength = 30;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.Radius = 13;
            this.TextBoxEmail.Size = new System.Drawing.Size(213, 35);
            this.TextBoxEmail.TabIndex = 24;
            this.TextBoxEmail.Text = "Почта";
            this.TextBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.TextBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxName.BaseColor = System.Drawing.Color.White;
            this.TextBoxName.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxName.BorderSize = 1;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxName.Location = new System.Drawing.Point(16, 61);
            this.TextBoxName.MaxLength = 30;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.Radius = 13;
            this.TextBoxName.Size = new System.Drawing.Size(213, 35);
            this.TextBoxName.TabIndex = 23;
            this.TextBoxName.Text = "Имя";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.Label.Location = new System.Drawing.Point(66, 26);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(113, 25);
            this.Label.TabIndex = 21;
            this.Label.Text = "Регистрация";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SIGNup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(242, 290);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSignUP);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SIGNup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNup";
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelMessenge;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
        private Guna.UI.WinForms.GunaTextBox TextBoxPassword;
        private Guna.UI.WinForms.GunaTextBox TextBoxUsername;
        private Guna.UI.WinForms.GunaAdvenceButton BtnClose;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSignUP;
        private Guna.UI.WinForms.GunaTextBox TextBoxEmail;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel Label;
    }
}