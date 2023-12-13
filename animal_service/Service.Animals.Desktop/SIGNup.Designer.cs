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
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSignUP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxSurname = new Guna.UI.WinForms.GunaTextBox();
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
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.CheckedBaseColor = System.Drawing.Color.White;
            this.btnClose.CheckedBorderColor = System.Drawing.Color.White;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnClose.CheckedImage")));
            this.btnClose.CheckedLineColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.LineColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(205, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 30;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSignUP
            // 
            this.btnSignUP.AnimationHoverSpeed = 0.07F;
            this.btnSignUP.AnimationSpeed = 0.03F;
            this.btnSignUP.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUP.BaseColor = System.Drawing.Color.Black;
            this.btnSignUP.BorderColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSignUP.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignUP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignUP.CheckedImage")));
            this.btnSignUP.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUP.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUP.ForeColor = System.Drawing.Color.White;
            this.btnSignUP.Image = null;
            this.btnSignUP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignUP.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUP.Location = new System.Drawing.Point(28, 248);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnSignUP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignUP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignUP.OnHoverImage = null;
            this.btnSignUP.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUP.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUP.Radius = 15;
            this.btnSignUP.Size = new System.Drawing.Size(192, 30);
            this.btnSignUP.TabIndex = 28;
            this.btnSignUP.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.btnSignUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSurname.BaseColor = System.Drawing.Color.White;
            this.TextBoxSurname.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxSurname.BorderSize = 1;
            this.TextBoxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSurname.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxSurname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxSurname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TextBoxSurname.Location = new System.Drawing.Point(16, 102);
            this.TextBoxSurname.MaxLength = 30;
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.PasswordChar = '\0';
            this.TextBoxSurname.Radius = 13;
            this.TextBoxSurname.Size = new System.Drawing.Size(213, 35);
            this.TextBoxSurname.TabIndex = 24;
            this.TextBoxSurname.Text = "Фамилия";
            this.TextBoxSurname.Enter += new System.EventHandler(this.TextBoxSurname_Enter);
            this.TextBoxSurname.Leave += new System.EventHandler(this.TextBoxSurname_Leave);
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
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSignUP);
            this.Controls.Add(this.TextBoxSurname);
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
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignUP;
        private Guna.UI.WinForms.GunaTextBox TextBoxSurname;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel Label;
    }
}