namespace snglrtycrvtureofspce.Animal.Desktop.Form.Admin
{
    partial class LocationsAdminForm
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
            System.Windows.Forms.Label locationNameLabel;
            System.Windows.Forms.Label locationDescriptionLabel;
            System.Windows.Forms.Label latitudeLabel;
            System.Windows.Forms.Label longitudeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationsAdminForm));
            this.lostAnimalsDesktop_ServiceDataSet = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationsTableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.LocationsTableAdapter();
            this.tableAdapterManager = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.locationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.locationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameTextBox = new System.Windows.Forms.TextBox();
            this.locationDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            locationNameLabel = new System.Windows.Forms.Label();
            locationDescriptionLabel = new System.Windows.Forms.Label();
            latitudeLabel = new System.Windows.Forms.Label();
            longitudeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingNavigator)).BeginInit();
            this.locationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // locationNameLabel
            // 
            locationNameLabel.AutoSize = true;
            locationNameLabel.Font = new System.Drawing.Font("Verdana", 12F);
            locationNameLabel.Location = new System.Drawing.Point(8, 176);
            locationNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            locationNameLabel.Name = "locationNameLabel";
            locationNameLabel.Size = new System.Drawing.Size(213, 18);
            locationNameLabel.TabIndex = 4;
            locationNameLabel.Text = "Наименование локации:";
            // 
            // locationDescriptionLabel
            // 
            locationDescriptionLabel.AutoSize = true;
            locationDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12F);
            locationDescriptionLabel.Location = new System.Drawing.Point(8, 197);
            locationDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            locationDescriptionLabel.Name = "locationDescriptionLabel";
            locationDescriptionLabel.Size = new System.Drawing.Size(172, 18);
            locationDescriptionLabel.TabIndex = 6;
            locationDescriptionLabel.Text = "Описание локации:";
            // 
            // latitudeLabel
            // 
            latitudeLabel.AutoSize = true;
            latitudeLabel.Font = new System.Drawing.Font("Verdana", 12F);
            latitudeLabel.Location = new System.Drawing.Point(8, 218);
            latitudeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            latitudeLabel.Name = "latitudeLabel";
            latitudeLabel.Size = new System.Drawing.Size(77, 18);
            latitudeLabel.TabIndex = 8;
            latitudeLabel.Text = "Широта:";
            // 
            // longitudeLabel
            // 
            longitudeLabel.AutoSize = true;
            longitudeLabel.Font = new System.Drawing.Font("Verdana", 12F);
            longitudeLabel.Location = new System.Drawing.Point(8, 239);
            longitudeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            longitudeLabel.Name = "longitudeLabel";
            longitudeLabel.Size = new System.Drawing.Size(82, 18);
            longitudeLabel.TabIndex = 10;
            longitudeLabel.Text = "Долгота:";
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = null;
            this.tableAdapterManager.AnimalTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationsTableAdapter = this.locationsTableAdapter;
            this.tableAdapterManager.MovementPointsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // locationsBindingNavigator
            // 
            this.locationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locationsBindingNavigator.BindingSource = this.locationsBindingSource;
            this.locationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.locationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.locationsBindingNavigatorSaveItem});
            this.locationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.locationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locationsBindingNavigator.Name = "locationsBindingNavigator";
            this.locationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locationsBindingNavigator.Size = new System.Drawing.Size(540, 31);
            this.locationsBindingNavigator.TabIndex = 0;
            this.locationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // locationsBindingNavigatorSaveItem
            // 
            this.locationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locationsBindingNavigatorSaveItem.Image")));
            this.locationsBindingNavigatorSaveItem.Name = "locationsBindingNavigatorSaveItem";
            this.locationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.locationsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.locationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.locationsBindingNavigatorSaveItem_Click);
            // 
            // locationsDataGridView
            // 
            this.locationsDataGridView.AutoGenerateColumns = false;
            this.locationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.locationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.locationsDataGridView.DataSource = this.locationsBindingSource;
            this.locationsDataGridView.Location = new System.Drawing.Point(8, 25);
            this.locationsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationsDataGridView.Name = "locationsDataGridView";
            this.locationsDataGridView.RowHeadersWidth = 62;
            this.locationsDataGridView.RowTemplate.Height = 28;
            this.locationsDataGridView.Size = new System.Drawing.Size(522, 143);
            this.locationsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LocationId";
            this.dataGridViewTextBoxColumn1.HeaderText = "LocationId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LocationName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LocationName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 101;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LocationDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "LocationDescription";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 126;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Latitude";
            this.dataGridViewTextBoxColumn4.HeaderText = "Latitude";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Longitude";
            this.dataGridViewTextBoxColumn5.HeaderText = "Longitude";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 79;
            // 
            // locationNameTextBox
            // 
            this.locationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationsBindingSource, "LocationName", true));
            this.locationNameTextBox.Location = new System.Drawing.Point(222, 176);
            this.locationNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationNameTextBox.Name = "locationNameTextBox";
            this.locationNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.locationNameTextBox.TabIndex = 5;
            // 
            // locationDescriptionTextBox
            // 
            this.locationDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationsBindingSource, "LocationDescription", true));
            this.locationDescriptionTextBox.Location = new System.Drawing.Point(222, 197);
            this.locationDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationDescriptionTextBox.Name = "locationDescriptionTextBox";
            this.locationDescriptionTextBox.Size = new System.Drawing.Size(129, 20);
            this.locationDescriptionTextBox.TabIndex = 7;
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationsBindingSource, "Latitude", true));
            this.latitudeTextBox.Location = new System.Drawing.Point(222, 218);
            this.latitudeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(129, 20);
            this.latitudeTextBox.TabIndex = 9;
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationsBindingSource, "Longitude", true));
            this.longitudeTextBox.Location = new System.Drawing.Point(222, 239);
            this.longitudeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(129, 20);
            this.longitudeTextBox.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SaveButton.Location = new System.Drawing.Point(355, 218);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 38);
            this.SaveButton.TabIndex = 55;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.DeleteButton.Location = new System.Drawing.Point(443, 176);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 38);
            this.DeleteButton.TabIndex = 54;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.AddButton.Location = new System.Drawing.Point(355, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(82, 38);
            this.AddButton.TabIndex = 53;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LocationsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 266);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(locationNameLabel);
            this.Controls.Add(this.locationNameTextBox);
            this.Controls.Add(locationDescriptionLabel);
            this.Controls.Add(this.locationDescriptionTextBox);
            this.Controls.Add(latitudeLabel);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(longitudeLabel);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.locationsDataGridView);
            this.Controls.Add(this.locationsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LocationsAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Локации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationsAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.LocationsAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingNavigator)).EndInit();
            this.locationsBindingNavigator.ResumeLayout(false);
            this.locationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.LocationsTableAdapter locationsTableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton locationsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView locationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox locationNameTextBox;
        private System.Windows.Forms.TextBox locationDescriptionTextBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}