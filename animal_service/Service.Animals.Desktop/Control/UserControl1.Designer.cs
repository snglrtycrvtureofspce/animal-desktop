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
            this.btnSignUP = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSignIN = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.PanelLogReg.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogReg
            // 
            this.PanelLogReg.AutoSize = true;
            this.PanelLogReg.Controls.Add(this.btnSignUP);
            this.PanelLogReg.Controls.Add(this.btnSignIN);
            this.PanelLogReg.Controls.Add(this.gunaLabel1);
            this.PanelLogReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogReg.Location = new System.Drawing.Point(0, 0);
            this.PanelLogReg.Name = "PanelLogReg";
            this.PanelLogReg.Size = new System.Drawing.Size(134, 76);
            this.PanelLogReg.TabIndex = 7;
            // 
            // btnSignUP
            // 
            this.btnSignUP.AnimationHoverSpeed = 0.07F;
            this.btnSignUP.AnimationSpeed = 0.03F;
            this.btnSignUP.BaseColor = System.Drawing.Color.White;
            this.btnSignUP.BorderColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSignUP.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedForeColor = System.Drawing.Color.Black;
            this.btnSignUP.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignUP.CheckedImage")));
            this.btnSignUP.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnSignUP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUP.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignUP.ForeColor = System.Drawing.Color.Black;
            this.btnSignUP.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUP.Image")));
            this.btnSignUP.ImageOffsetX = 5;
            this.btnSignUP.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSignUP.LineColor = System.Drawing.SystemColors.Control;
            this.btnSignUP.Location = new System.Drawing.Point(0, 45);
            this.btnSignUP.Name = "btnSignUP";
            this.btnSignUP.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnSignUP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignUP.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSignUP.OnHoverImage = null;
            this.btnSignUP.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnSignUP.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUP.Size = new System.Drawing.Size(134, 31);
            this.btnSignUP.TabIndex = 8;
            this.btnSignUP.Text = "Регистрация";
            this.btnSignUP.TextOffsetX = 10;
            this.btnSignUP.Click += new System.EventHandler(this.btnSignUP_Click);
            // 
            // btnSignIN
            // 
            this.btnSignIN.AnimationHoverSpeed = 0.07F;
            this.btnSignIN.AnimationSpeed = 0.03F;
            this.btnSignIN.BaseColor = System.Drawing.Color.White;
            this.btnSignIN.BorderColor = System.Drawing.Color.Black;
            this.btnSignIN.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSignIN.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignIN.CheckedForeColor = System.Drawing.Color.Black;
            this.btnSignIN.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSignIN.CheckedImage")));
            this.btnSignIN.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnSignIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignIN.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIN.ForeColor = System.Drawing.Color.Black;
            this.btnSignIN.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIN.Image")));
            this.btnSignIN.ImageOffsetX = 5;
            this.btnSignIN.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSignIN.LineColor = System.Drawing.SystemColors.Control;
            this.btnSignIN.Location = new System.Drawing.Point(0, 14);
            this.btnSignIN.Name = "btnSignIN";
            this.btnSignIN.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnSignIN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIN.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSignIN.OnHoverImage = null;
            this.btnSignIN.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnSignIN.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIN.Size = new System.Drawing.Size(134, 31);
            this.btnSignIN.TabIndex = 7;
            this.btnSignIN.Text = "Войти";
            this.btnSignIN.TextOffsetX = 10;
            this.btnSignIN.Click += new System.EventHandler(this.btnSignIN_Click);
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
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 76);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(134, 45);
            this.gunaPanel1.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.White;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExit.CheckedForeColor = System.Drawing.Color.Black;
            this.btnExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExit.CheckedImage")));
            this.btnExit.CheckedLineColor = System.Drawing.Color.Gray;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffsetX = 5;
            this.btnExit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnExit.LineColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(0, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverLineColor = System.Drawing.SystemColors.Control;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(134, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.TextOffsetX = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
        private Guna.UI.WinForms.GunaAdvenceButton btnSignUP;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignIN;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaPanel PanelLogReg;
    }
}
