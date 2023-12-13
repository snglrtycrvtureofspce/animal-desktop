namespace Service.Animals.Desktop.Control.ElControls
{
    partial class ElProduct
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
            this.SeatType = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // SeatType
            // 
            this.SeatType.AutoSize = true;
            this.SeatType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SeatType.Location = new System.Drawing.Point(25, 10);
            this.SeatType.Name = "SeatType";
            this.SeatType.Size = new System.Drawing.Size(62, 15);
            this.SeatType.TabIndex = 1;
            this.SeatType.Text = "Тип места";
            this.SeatType.Visible = false;
            // 
            // ElProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeatType);
            this.Name = "ElProduct";
            this.Size = new System.Drawing.Size(117, 35);
            this.Load += new System.EventHandler(this.ElProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI.WinForms.GunaLabel SeatType;
    }
}
