namespace Service.Animals.Desktop.Form
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.queryDataGridView = new System.Windows.Forms.DataGridView();
            this.query8Button = new System.Windows.Forms.Button();
            this.query7Button = new System.Windows.Forms.Button();
            this.query2Button = new System.Windows.Forms.Button();
            this.query3Button = new System.Windows.Forms.Button();
            this.query4Button = new System.Windows.Forms.Button();
            this.query5Button = new System.Windows.Forms.Button();
            this.query6Button = new System.Windows.Forms.Button();
            this.query1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // queryDataGridView
            // 
            this.queryDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGridView.Location = new System.Drawing.Point(12, 12);
            this.queryDataGridView.Name = "queryDataGridView";
            this.queryDataGridView.Size = new System.Drawing.Size(1454, 314);
            this.queryDataGridView.TabIndex = 10;
            // 
            // query8Button
            // 
            this.query8Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query8Button.Location = new System.Drawing.Point(1107, 432);
            this.query8Button.Name = "query8Button";
            this.query8Button.Size = new System.Drawing.Size(359, 94);
            this.query8Button.TabIndex = 18;
            this.query8Button.Text = "Определить средний “возраст” самолетов компании";
            this.query8Button.UseVisualStyleBackColor = true;
            this.query8Button.Click += new System.EventHandler(this.query8Button_Click);
            // 
            // query7Button
            // 
            this.query7Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query7Button.Location = new System.Drawing.Point(742, 432);
            this.query7Button.Name = "query7Button";
            this.query7Button.Size = new System.Drawing.Size(359, 94);
            this.query7Button.TabIndex = 17;
            this.query7Button.Text = "Определить каким количеством самолетов каждого типа владеет компания";
            this.query7Button.UseVisualStyleBackColor = true;
            this.query7Button.Click += new System.EventHandler(this.query7Button_Click);
            // 
            // query2Button
            // 
            this.query2Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query2Button.Location = new System.Drawing.Point(377, 332);
            this.query2Button.Name = "query2Button";
            this.query2Button.Size = new System.Drawing.Size(359, 94);
            this.query2Button.TabIndex = 16;
            this.query2Button.Text = "Определить расход топлива по всем маршрутам";
            this.query2Button.UseVisualStyleBackColor = true;
            this.query2Button.Click += new System.EventHandler(this.query2Button_Click);
            // 
            // query3Button
            // 
            this.query3Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query3Button.Location = new System.Drawing.Point(742, 332);
            this.query3Button.Name = "query3Button";
            this.query3Button.Size = new System.Drawing.Size(359, 94);
            this.query3Button.TabIndex = 15;
            this.query3Button.Text = "Вывести экипаж, совершивший максимальное количество полетов за прошедшую неделю";
            this.query3Button.UseVisualStyleBackColor = true;
            this.query3Button.Click += new System.EventHandler(this.query3Button_Click);
            // 
            // query4Button
            // 
            this.query4Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query4Button.Location = new System.Drawing.Point(1107, 332);
            this.query4Button.Name = "query4Button";
            this.query4Button.Size = new System.Drawing.Size(359, 94);
            this.query4Button.TabIndex = 14;
            this.query4Button.Text = "Вывести данные о том, сколько свободных мест оставалось в самолетах, совершавших " +
    "полет по одному из рейсов за вчерашний день";
            this.query4Button.UseVisualStyleBackColor = true;
            this.query4Button.Click += new System.EventHandler(this.query4Button_Click);
            // 
            // query5Button
            // 
            this.query5Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query5Button.Location = new System.Drawing.Point(12, 432);
            this.query5Button.Name = "query5Button";
            this.query5Button.Size = new System.Drawing.Size(359, 94);
            this.query5Button.TabIndex = 13;
            this.query5Button.Text = "Рассчитать убытки компании за счет непроданных билетов за вчерашний день";
            this.query5Button.UseVisualStyleBackColor = true;
            this.query5Button.Click += new System.EventHandler(this.query5Button_Click);
            // 
            // query6Button
            // 
            this.query6Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query6Button.Location = new System.Drawing.Point(377, 432);
            this.query6Button.Name = "query6Button";
            this.query6Button.Size = new System.Drawing.Size(359, 94);
            this.query6Button.TabIndex = 12;
            this.query6Button.Text = "Вывести список самолетов, которые не ремонтировались в течение более чем 3 лет";
            this.query6Button.UseVisualStyleBackColor = true;
            this.query6Button.Click += new System.EventHandler(this.query6Button_Click);
            // 
            // query1Button
            // 
            this.query1Button.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query1Button.Location = new System.Drawing.Point(12, 332);
            this.query1Button.Name = "query1Button";
            this.query1Button.Size = new System.Drawing.Size(359, 94);
            this.query1Button.TabIndex = 11;
            this.query1Button.Text = "Определить расчетное время полета по всем маршрутам";
            this.query1Button.UseVisualStyleBackColor = true;
            this.query1Button.Click += new System.EventHandler(this.query1Button_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 536);
            this.Controls.Add(this.query8Button);
            this.Controls.Add(this.query7Button);
            this.Controls.Add(this.query2Button);
            this.Controls.Add(this.query3Button);
            this.Controls.Add(this.query4Button);
            this.Controls.Add(this.query5Button);
            this.Controls.Add(this.query6Button);
            this.Controls.Add(this.query1Button);
            this.Controls.Add(this.queryDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запросы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView queryDataGridView;
        private System.Windows.Forms.Button query8Button;
        private System.Windows.Forms.Button query7Button;
        private System.Windows.Forms.Button query2Button;
        private System.Windows.Forms.Button query3Button;
        private System.Windows.Forms.Button query4Button;
        private System.Windows.Forms.Button query5Button;
        private System.Windows.Forms.Button query6Button;
        private System.Windows.Forms.Button query1Button;
    }
}