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
            this.BtnSignUP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BtnSignIN = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.PanelLogReg.Controls.Add(this.BtnSignUP);
            this.PanelLogReg.Controls.Add(this.BtnSignIN);
            this.PanelLogReg.Controls.Add(this.gunaLabel1);
            this.PanelLogReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogReg.Location = new System.Drawing.Point(0, 0);
            this.PanelLogReg.Name = "PanelLogReg";
            this.PanelLogReg.Size = new System.Drawing.Size(134, 76);
            this.PanelLogReg.TabIndex = 7;
            // 
            // BtnSignUP
            // 
            this.BtnSignUP.AnimationHoverSpeed = 0.07F;
            this.BtnSignUP.AnimationSpeed = 0.03F;
            this.BtnSignUP.BaseColor = System.Drawing.Color.White;
            this.BtnSignUP.BorderColor = System.Drawing.Color.Black;
            this.BtnSignUP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSignUP.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSignUP.CheckedForeColor = System.Drawing.Color.Black;
            this.BtnSignUP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSignUP.CheckedImage")));
            this.BtnSignUP.CheckedLineColor = System.Drawing.Color.Gray;
            this.BtnSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSignUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSignUP.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSignUP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSignUP.ForeColor = System.Drawing.Color.Black;
            this.BtnSignUP.Image = ((System.Drawing.Image)(resources.GetObject("BtnSignUP.Image")));
            this.BtnSignUP.ImageOffsetX = 5;
            this.BtnSignUP.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnSignUP.LineColor = System.Drawing.SystemColors.Control;
            this.BtnSignUP.Location = new System.Drawing.Point(0, 45);
            this.BtnSignUP.Name = "BtnSignUP";
            this.BtnSignUP.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.BtnSignUP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSignUP.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnSignUP.OnHoverImage = null;
            this.BtnSignUP.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.BtnSignUP.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSignUP.Size = new System.Drawing.Size(134, 31);
            this.BtnSignUP.TabIndex = 8;
            this.BtnSignUP.Text = "Регистрация";
            this.BtnSignUP.TextOffsetX = 10;
            this.BtnSignUP.Click += new System.EventHandler(this.BtnSignUP_Click);
            // 
            // BtnSignIN
            // 
            this.BtnSignIN.AnimationHoverSpeed = 0.07F;
            this.BtnSignIN.AnimationSpeed = 0.03F;
            this.BtnSignIN.BaseColor = System.Drawing.Color.White;
            this.BtnSignIN.BorderColor = System.Drawing.Color.Black;
            this.BtnSignIN.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnSignIN.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnSignIN.CheckedForeColor = System.Drawing.Color.Black;
            this.BtnSignIN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnSignIN.CheckedImage")));
            this.BtnSignIN.CheckedLineColor = System.Drawing.Color.Gray;
            this.BtnSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSignIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSignIN.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSignIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSignIN.ForeColor = System.Drawing.Color.Black;
            this.BtnSignIN.Image = ((System.Drawing.Image)(resources.GetObject("BtnSignIN.Image")));
            this.BtnSignIN.ImageOffsetX = 5;
            this.BtnSignIN.ImageSize = new System.Drawing.Size(18, 18);
            this.BtnSignIN.LineColor = System.Drawing.SystemColors.Control;
            this.BtnSignIN.Location = new System.Drawing.Point(0, 14);
            this.BtnSignIN.Name = "BtnSignIN";
            this.BtnSignIN.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.BtnSignIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSignIN.OnHoverForeColor = System.Drawing.Color.Black;
            this.BtnSignIN.OnHoverImage = null;
            this.BtnSignIN.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.BtnSignIN.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSignIN.Size = new System.Drawing.Size(134, 31);
            this.BtnSignIN.TabIndex = 7;
            this.BtnSignIN.Text = "Войти";
            this.BtnSignIN.TextOffsetX = 10;
            this.BtnSignIN.Click += new System.EventHandler(this.BtnSignIN_Click);
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
            this.BtnExit.Click += new System.EventHandler(this.btnExit_Click);
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
        private Guna.UI.WinForms.GunaAdvenceButton BtnSignUP;
        private Guna.UI.WinForms.GunaAdvenceButton BtnSignIN;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaPanel PanelLogReg;
    }
}
