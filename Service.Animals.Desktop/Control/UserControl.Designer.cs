namespace Service.Animals.Desktop.Control
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.PanelLogReg = new Guna.UI.WinForms.GunaPanel();
            this.BtnSignUp = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSignIn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.BtnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.PanelLogReg.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogReg
            // 
            this.PanelLogReg.AutoSize = true;
            this.PanelLogReg.Controls.Add(this.BtnSignUp);
            this.PanelLogReg.Controls.Add(this.BtnSignIn);
            this.PanelLogReg.Controls.Add(this.gunaLabel1);
            this.PanelLogReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogReg.Location = new System.Drawing.Point(0, 0);
            this.PanelLogReg.Name = "PanelLogReg";
            this.PanelLogReg.Size = new System.Drawing.Size(134, 76);
            this.PanelLogReg.TabIndex = 7;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AnimationHoverSpeed = 0.07F;
            this.BtnSignUp.AnimationSpeed = 0.03F;
            this.BtnSignUp.BaseColor = System.Drawing.Color.White;
            this.BtnSignUp.BorderColor = System.Drawing.Color.Black;
            this.BtnSignUp.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSignUp.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSignUp.CheckedForeColor = System.Drawing.Color.Black;
            this.BtnSignUp.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSignUp.CheckedImage")));
            this.BtnSignUp.CheckedLineColor = System.Drawing.Color.Gray;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSignUp.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSignUp.ForeColor = System.Drawing.Color.Black;
            this.BtnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("BtnSignUp.Image")));
            this.BtnSignUp.ImageOffsetX = 5;
            this.BtnSignUp.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnSignUp.LineColor = System.Drawing.SystemColors.Control;
            this.BtnSignUp.Location = new System.Drawing.Point(0, 45);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.BtnSignUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSignUp.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnSignUp.OnHoverImage = null;
            this.BtnSignUp.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.BtnSignUp.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSignUp.Size = new System.Drawing.Size(134, 31);
            this.BtnSignUp.TabIndex = 8;
            this.BtnSignUp.Text = "Регистрация";
            this.BtnSignUp.TextOffsetX = 10;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.AnimationHoverSpeed = 0.07F;
            this.BtnSignIn.AnimationSpeed = 0.03F;
            this.BtnSignIn.BaseColor = System.Drawing.Color.White;
            this.BtnSignIn.BorderColor = System.Drawing.Color.Black;
            this.BtnSignIn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSignIn.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSignIn.CheckedForeColor = System.Drawing.Color.Black;
            this.BtnSignIn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSignIn.CheckedImage")));
            this.BtnSignIn.CheckedLineColor = System.Drawing.Color.Gray;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSignIn.ForeColor = System.Drawing.Color.Black;
            this.BtnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("BtnSignIn.Image")));
            this.BtnSignIn.ImageOffsetX = 5;
            this.BtnSignIn.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnSignIn.LineColor = System.Drawing.SystemColors.Control;
            this.BtnSignIn.Location = new System.Drawing.Point(0, 14);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.BtnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSignIn.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnSignIn.OnHoverImage = null;
            this.BtnSignIn.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.BtnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSignIn.Size = new System.Drawing.Size(134, 31);
            this.BtnSignIn.TabIndex = 7;
            this.BtnSignIn.Text = "Войти";
            this.BtnSignIn.TextOffsetX = 10;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(134, 14);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "     Авторизация";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.AutoSize = true;
            this.gunaPanel1.Controls.Add(this.BtnExit);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 76);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(134, 45);
            this.gunaPanel1.TabIndex = 11;
            // 
            // BtnExit
            // 
            this.BtnExit.AnimationHoverSpeed = 0.07F;
            this.BtnExit.AnimationSpeed = 0.03F;
            this.BtnExit.BaseColor = System.Drawing.Color.White;
            this.BtnExit.BorderColor = System.Drawing.Color.Black;
            this.BtnExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnExit.CheckedForeColor = System.Drawing.Color.Black;
            this.BtnExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.CheckedImage")));
            this.BtnExit.CheckedLineColor = System.Drawing.Color.Gray;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExit.FocusedColor = System.Drawing.Color.Empty;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageOffsetX = 5;
            this.BtnExit.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnExit.LineColor = System.Drawing.SystemColors.Control;
            this.BtnExit.Location = new System.Drawing.Point(0, 14);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.BtnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnExit.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnExit.OnHoverImage = null;
            this.BtnExit.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.BtnExit.OnPressedColor = System.Drawing.Color.Black;
            this.BtnExit.Size = new System.Drawing.Size(134, 31);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Выход";
            this.BtnExit.TextOffsetX = 10;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(134, 14);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Закрыть программу";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.PanelLogReg);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(134, 121);
            this.PanelLogReg.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton BtnSignUp;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSignIn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaPanel PanelLogReg;
    }
}
