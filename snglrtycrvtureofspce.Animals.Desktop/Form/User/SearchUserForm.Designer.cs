namespace snglrtycrvtureofspce.Animal.Desktop.Form.User
{
    partial class SearchUserForm
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
            System.Windows.Forms.Label SearchByLocationLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserForm));
            this.lostAnimalsDesktop_ServiceDataSet = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.animalLocationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalLocationViewTableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalLocationViewTableAdapter();
            this.tableAdapterManager = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.animalLocationViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.animalLocationViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilterSearchAnimalsByLocation = new System.Windows.Forms.TextBox();
            this.cbFilterSearchAnimalsByLocation = new System.Windows.Forms.ComboBox();
            this.animalVisitViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalVisitViewTableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalVisitViewTableAdapter();
            this.animalVisitViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilterSearchLocationByAnimalsAndDate = new System.Windows.Forms.TextBox();
            this.cbFilterSearchLocationByAnimalsAndDate = new System.Windows.Forms.ComboBox();
            SearchByLocationLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalLocationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalLocationViewBindingNavigator)).BeginInit();
            this.animalLocationViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalLocationViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalVisitViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalVisitViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByLocationLabel
            // 
            SearchByLocationLabel.AutoSize = true;
            SearchByLocationLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SearchByLocationLabel.Location = new System.Drawing.Point(9, 25);
            SearchByLocationLabel.Name = "SearchByLocationLabel";
            SearchByLocationLabel.Size = new System.Drawing.Size(452, 16);
            SearchByLocationLabel.TabIndex = 70;
            SearchByLocationLabel.Text = "Поиск животного по всем местам посещённым им локаций:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            label2.Location = new System.Drawing.Point(50, 304);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 16);
            label2.TabIndex = 75;
            label2.Text = "Критерий:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            label1.Location = new System.Drawing.Point(50, 274);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 16);
            label1.TabIndex = 73;
            label1.Text = "Фильтрация:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(543, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(406, 16);
            label3.TabIndex = 76;
            label3.Text = "Поиск по локации (по животному и дате посещения):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Verdana", 9.75F);
            label4.Location = new System.Drawing.Point(497, 304);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 16);
            label4.TabIndex = 80;
            label4.Text = "Критерий:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Verdana", 9.75F);
            label5.Location = new System.Drawing.Point(497, 274);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 16);
            label5.TabIndex = 78;
            label5.Text = "Фильтрация:";
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalLocationViewBindingSource
            // 
            this.animalLocationViewBindingSource.DataMember = "AnimalLocationView";
            this.animalLocationViewBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // animalLocationViewTableAdapter
            // 
            this.animalLocationViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = null;
            this.tableAdapterManager.AnimalTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MovementPointsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // animalLocationViewBindingNavigator
            // 
            this.animalLocationViewBindingNavigator.AddNewItem = null;
            this.animalLocationViewBindingNavigator.BindingSource = this.animalLocationViewBindingSource;
            this.animalLocationViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalLocationViewBindingNavigator.DeleteItem = null;
            this.animalLocationViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.animalLocationViewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalLocationViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalLocationViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalLocationViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalLocationViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalLocationViewBindingNavigator.Name = "animalLocationViewBindingNavigator";
            this.animalLocationViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalLocationViewBindingNavigator.Size = new System.Drawing.Size(1088, 25);
            this.animalLocationViewBindingNavigator.TabIndex = 0;
            this.animalLocationViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // animalLocationViewDataGridView
            // 
            this.animalLocationViewDataGridView.AutoGenerateColumns = false;
            this.animalLocationViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.animalLocationViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalLocationViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.animalLocationViewDataGridView.DataSource = this.animalLocationViewBindingSource;
            this.animalLocationViewDataGridView.Location = new System.Drawing.Point(53, 44);
            this.animalLocationViewDataGridView.Name = "animalLocationViewDataGridView";
            this.animalLocationViewDataGridView.Size = new System.Drawing.Size(360, 220);
            this.animalLocationViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НаименованиеЖивотного";
            this.dataGridViewTextBoxColumn1.HeaderText = "НаименованиеЖивотного";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 165;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НаименованиеЛокации";
            this.dataGridViewTextBoxColumn2.HeaderText = "НаименованиеЛокации";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 152;
            // 
            // tbFilterSearchAnimalsByLocation
            // 
            this.tbFilterSearchAnimalsByLocation.Location = new System.Drawing.Point(152, 275);
            this.tbFilterSearchAnimalsByLocation.Name = "tbFilterSearchAnimalsByLocation";
            this.tbFilterSearchAnimalsByLocation.Size = new System.Drawing.Size(261, 20);
            this.tbFilterSearchAnimalsByLocation.TabIndex = 74;
            this.tbFilterSearchAnimalsByLocation.TextChanged += new System.EventHandler(this.tbFilterSearchAnimalsByLocation_TextChanged);
            // 
            // cbFilterSearchAnimalsByLocation
            // 
            this.cbFilterSearchAnimalsByLocation.FormattingEnabled = true;
            this.cbFilterSearchAnimalsByLocation.Items.AddRange(new object[] {
            "НаименованиеЖивотного",
            "НаименованиеЛокации"});
            this.cbFilterSearchAnimalsByLocation.Location = new System.Drawing.Point(152, 305);
            this.cbFilterSearchAnimalsByLocation.Name = "cbFilterSearchAnimalsByLocation";
            this.cbFilterSearchAnimalsByLocation.Size = new System.Drawing.Size(261, 21);
            this.cbFilterSearchAnimalsByLocation.TabIndex = 72;
            this.cbFilterSearchAnimalsByLocation.SelectedIndexChanged += new System.EventHandler(this.cbFilterSearchAnimalsByLocation_SelectedIndexChanged);
            // 
            // animalVisitViewBindingSource
            // 
            this.animalVisitViewBindingSource.DataMember = "AnimalVisitView";
            this.animalVisitViewBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // animalVisitViewTableAdapter
            // 
            this.animalVisitViewTableAdapter.ClearBeforeFill = true;
            // 
            // animalVisitViewDataGridView
            // 
            this.animalVisitViewDataGridView.AutoGenerateColumns = false;
            this.animalVisitViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.animalVisitViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalVisitViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.animalVisitViewDataGridView.DataSource = this.animalVisitViewBindingSource;
            this.animalVisitViewDataGridView.Location = new System.Drawing.Point(500, 44);
            this.animalVisitViewDataGridView.Name = "animalVisitViewDataGridView";
            this.animalVisitViewDataGridView.Size = new System.Drawing.Size(477, 220);
            this.animalVisitViewDataGridView.TabIndex = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "НаименованиеЛокации";
            this.dataGridViewTextBoxColumn3.HeaderText = "НаименованиеЛокации";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 152;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "НаименованиеЖивотного";
            this.dataGridViewTextBoxColumn4.HeaderText = "НаименованиеЖивотного";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 165;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ДатаПосещения";
            this.dataGridViewTextBoxColumn5.HeaderText = "ДатаПосещения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 117;
            // 
            // tbFilterSearchLocationByAnimalsAndDate
            // 
            this.tbFilterSearchLocationByAnimalsAndDate.Location = new System.Drawing.Point(599, 275);
            this.tbFilterSearchLocationByAnimalsAndDate.Name = "tbFilterSearchLocationByAnimalsAndDate";
            this.tbFilterSearchLocationByAnimalsAndDate.Size = new System.Drawing.Size(378, 20);
            this.tbFilterSearchLocationByAnimalsAndDate.TabIndex = 79;
            this.tbFilterSearchLocationByAnimalsAndDate.TextChanged += new System.EventHandler(this.tbFilterSearchLocationByAnimalsAndDate_TextChanged);
            // 
            // cbFilterSearchLocationByAnimalsAndDate
            // 
            this.cbFilterSearchLocationByAnimalsAndDate.FormattingEnabled = true;
            this.cbFilterSearchLocationByAnimalsAndDate.Items.AddRange(new object[] {
            "НаименованиеЛокации",
            "НаименованиеЖивотного",
            "ДатаПосещения"});
            this.cbFilterSearchLocationByAnimalsAndDate.Location = new System.Drawing.Point(599, 305);
            this.cbFilterSearchLocationByAnimalsAndDate.Name = "cbFilterSearchLocationByAnimalsAndDate";
            this.cbFilterSearchLocationByAnimalsAndDate.Size = new System.Drawing.Size(378, 21);
            this.cbFilterSearchLocationByAnimalsAndDate.TabIndex = 77;
            this.cbFilterSearchLocationByAnimalsAndDate.SelectedIndexChanged += new System.EventHandler(this.cbFilterSearchLocationByAnimalsAndDate_SelectedIndexChanged);
            // 
            // SearchUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(label4);
            this.Controls.Add(this.tbFilterSearchLocationByAnimalsAndDate);
            this.Controls.Add(label5);
            this.Controls.Add(this.cbFilterSearchLocationByAnimalsAndDate);
            this.Controls.Add(label3);
            this.Controls.Add(this.animalVisitViewDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbFilterSearchAnimalsByLocation);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbFilterSearchAnimalsByLocation);
            this.Controls.Add(SearchByLocationLabel);
            this.Controls.Add(this.animalLocationViewDataGridView);
            this.Controls.Add(this.animalLocationViewBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchUserForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalLocationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalLocationViewBindingNavigator)).EndInit();
            this.animalLocationViewBindingNavigator.ResumeLayout(false);
            this.animalLocationViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalLocationViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalVisitViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalVisitViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource animalLocationViewBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalLocationViewTableAdapter animalLocationViewTableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalLocationViewBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView animalLocationViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tbFilterSearchAnimalsByLocation;
        private System.Windows.Forms.ComboBox cbFilterSearchAnimalsByLocation;
        private System.Windows.Forms.BindingSource animalVisitViewBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalVisitViewTableAdapter animalVisitViewTableAdapter;
        private System.Windows.Forms.DataGridView animalVisitViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox tbFilterSearchLocationByAnimalsAndDate;
        private System.Windows.Forms.ComboBox cbFilterSearchLocationByAnimalsAndDate;
    }
}