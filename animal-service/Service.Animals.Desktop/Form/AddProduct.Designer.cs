namespace Service.Animals.Desktop.Form
{
    partial class AddProduct
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
            Guna.UI.WinForms.GunaAdvenceButton btnAddProduct;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.TextBoxName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxBrand = new Guna.UI.WinForms.GunaTextBox();
            this.btnCancel = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TextBoxDescription = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.TextBoxPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            btnAddProduct = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.AnimationHoverSpeed = 0.07F;
            btnAddProduct.AnimationSpeed = 0.03F;
            btnAddProduct.BaseColor = System.Drawing.Color.DimGray;
            btnAddProduct.BorderColor = System.Drawing.Color.Black;
            btnAddProduct.CheckedBaseColor = System.Drawing.Color.Gray;
            btnAddProduct.CheckedBorderColor = System.Drawing.Color.Black;
            btnAddProduct.CheckedForeColor = System.Drawing.Color.White;
            btnAddProduct.CheckedImage = null;
            btnAddProduct.CheckedLineColor = System.Drawing.Color.DimGray;
            btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            btnAddProduct.FocusedColor = System.Drawing.Color.Empty;
            btnAddProduct.Font = new System.Drawing.Font("Sitka Text", 12F);
            btnAddProduct.ForeColor = System.Drawing.Color.White;
            btnAddProduct.Image = null;
            btnAddProduct.ImageSize = new System.Drawing.Size(20, 20);
            btnAddProduct.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnAddProduct.Location = new System.Drawing.Point(315, 393);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.OnHoverBaseColor = System.Drawing.Color.Gray;
            btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Black;
            btnAddProduct.OnHoverForeColor = System.Drawing.Color.White;
            btnAddProduct.OnHoverImage = null;
            btnAddProduct.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            btnAddProduct.OnPressedColor = System.Drawing.Color.Black;
            btnAddProduct.Size = new System.Drawing.Size(107, 31);
            btnAddProduct.TabIndex = 29;
            btnAddProduct.Text = " Добавить";
            btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.AutoScroll = true;
            this.gunaPanel2.Controls.Add(this.TextBoxName);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.gunaLabel3);
            this.gunaPanel2.Controls.Add(this.gunaLabel2);
            this.gunaPanel2.Controls.Add(this.TextBoxBrand);
            this.gunaPanel2.Location = new System.Drawing.Point(33, 30);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(502, 74);
            this.gunaPanel2.TabIndex = 35;
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
            this.TextBoxName.Location = new System.Drawing.Point(130, 3);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.Radius = 10;
            this.TextBoxName.Size = new System.Drawing.Size(266, 30);
            this.TextBoxName.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(3, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(34, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "ФИО";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(4, 48);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(120, 15);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Паспортные данные";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(4, 48);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(40, 15);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Бренд";
            // 
            // TextBoxBrand
            // 
            this.TextBoxBrand.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxBrand.BaseColor = System.Drawing.Color.White;
            this.TextBoxBrand.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxBrand.BorderSize = 1;
            this.TextBoxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxBrand.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxBrand.Location = new System.Drawing.Point(130, 39);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.PasswordChar = '\0';
            this.TextBoxBrand.Radius = 10;
            this.TextBoxBrand.Size = new System.Drawing.Size(266, 30);
            this.TextBoxBrand.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCancel.CheckedForeColor = System.Drawing.Color.White;
            this.btnCancel.CheckedImage = null;
            this.btnCancel.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(428, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "  Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxDescription.BaseColor = System.Drawing.Color.White;
            this.TextBoxDescription.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxDescription.BorderSize = 1;
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDescription.Location = new System.Drawing.Point(33, 257);
            this.TextBoxDescription.MultiLine = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.PasswordChar = '\0';
            this.TextBoxDescription.Radius = 10;
            this.TextBoxDescription.Size = new System.Drawing.Size(502, 130);
            this.TextBoxDescription.TabIndex = 28;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(30, 239);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(62, 15);
            this.gunaLabel6.TabIndex = 27;
            this.gunaLabel6.Text = "Описание";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPrice.BaseColor = System.Drawing.Color.White;
            this.TextBoxPrice.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPrice.BorderSize = 1;
            this.TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBoxPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPrice.Location = new System.Drawing.Point(74, 394);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.PasswordChar = '\0';
            this.TextBoxPrice.Radius = 10;
            this.TextBoxPrice.Size = new System.Drawing.Size(92, 30);
            this.TextBoxPrice.TabIndex = 36;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(36, 401);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel8.TabIndex = 37;
            this.gunaLabel8.Text = "Цена";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(37, 12);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(113, 15);
            this.gunaLabel4.TabIndex = 38;
            this.gunaLabel4.Text = "Данные пассажира";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 454);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(btnAddProduct);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.gunaLabel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaTextBox TextBoxName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox TextBoxBrand;
        public Guna.UI.WinForms.GunaAdvenceButton btnCancel;
        private Guna.UI.WinForms.GunaTextBox TextBoxDescription;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox TextBoxPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}