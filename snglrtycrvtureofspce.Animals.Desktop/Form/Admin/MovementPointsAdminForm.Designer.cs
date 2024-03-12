namespace snglrtycrvtureofspce.Animal.Desktop.Form.Admin
{
    partial class MovementPointsAdminForm
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
            System.Windows.Forms.Label animalIdLabel;
            System.Windows.Forms.Label locationIdLabel;
            System.Windows.Forms.Label dateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovementPointsAdminForm));
            this.lostAnimalsDesktop_ServiceDataSet = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.movementPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movementPointsTableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.MovementPointsTableAdapter();
            this.tableAdapterManager = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.movementPointsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.movementPointsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.movementPointsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.animalIdComboBox = new System.Windows.Forms.ComboBox();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationIdComboBox = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalsTableAdapter();
            this.locationsTableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.LocationsTableAdapter();
            animalIdLabel = new System.Windows.Forms.Label();
            locationIdLabel = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementPointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementPointsBindingNavigator)).BeginInit();
            this.movementPointsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movementPointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // animalIdLabel
            // 
            animalIdLabel.AutoSize = true;
            animalIdLabel.Font = new System.Drawing.Font("Verdana", 12F);
            animalIdLabel.Location = new System.Drawing.Point(8, 176);
            animalIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            animalIdLabel.Name = "animalIdLabel";
            animalIdLabel.Size = new System.Drawing.Size(126, 18);
            animalIdLabel.TabIndex = 4;
            animalIdLabel.Text = "Id животного:";
            // 
            // locationIdLabel
            // 
            locationIdLabel.AutoSize = true;
            locationIdLabel.Font = new System.Drawing.Font("Verdana", 12F);
            locationIdLabel.Location = new System.Drawing.Point(8, 197);
            locationIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            locationIdLabel.Name = "locationIdLabel";
            locationIdLabel.Size = new System.Drawing.Size(107, 18);
            locationIdLabel.TabIndex = 6;
            locationIdLabel.Text = "Id локации:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new System.Drawing.Font("Verdana", 12F);
            dateTimeLabel.Location = new System.Drawing.Point(8, 218);
            dateTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(54, 18);
            dateTimeLabel.TabIndex = 8;
            dateTimeLabel.Text = "Дата:";
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movementPointsBindingSource
            // 
            this.movementPointsBindingSource.DataMember = "MovementPoints";
            this.movementPointsBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // movementPointsTableAdapter
            // 
            this.movementPointsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = null;
            this.tableAdapterManager.AnimalTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MovementPointsTableAdapter = this.movementPointsTableAdapter;
            this.tableAdapterManager.UpdateOrder = snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // movementPointsBindingNavigator
            // 
            this.movementPointsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movementPointsBindingNavigator.BindingSource = this.movementPointsBindingSource;
            this.movementPointsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movementPointsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movementPointsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.movementPointsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.movementPointsBindingNavigatorSaveItem});
            this.movementPointsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movementPointsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movementPointsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movementPointsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movementPointsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movementPointsBindingNavigator.Name = "movementPointsBindingNavigator";
            this.movementPointsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movementPointsBindingNavigator.Size = new System.Drawing.Size(428, 31);
            this.movementPointsBindingNavigator.TabIndex = 0;
            this.movementPointsBindingNavigator.Text = "bindingNavigator1";
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
            // movementPointsBindingNavigatorSaveItem
            // 
            this.movementPointsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movementPointsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movementPointsBindingNavigatorSaveItem.Image")));
            this.movementPointsBindingNavigatorSaveItem.Name = "movementPointsBindingNavigatorSaveItem";
            this.movementPointsBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.movementPointsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.movementPointsBindingNavigatorSaveItem.Click += new System.EventHandler(this.movementPointsBindingNavigatorSaveItem_Click);
            // 
            // movementPointsDataGridView
            // 
            this.movementPointsDataGridView.AutoGenerateColumns = false;
            this.movementPointsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.movementPointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movementPointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.movementPointsDataGridView.DataSource = this.movementPointsBindingSource;
            this.movementPointsDataGridView.Location = new System.Drawing.Point(8, 25);
            this.movementPointsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.movementPointsDataGridView.Name = "movementPointsDataGridView";
            this.movementPointsDataGridView.RowHeadersWidth = 62;
            this.movementPointsDataGridView.RowTemplate.Height = 28;
            this.movementPointsDataGridView.Size = new System.Drawing.Size(411, 143);
            this.movementPointsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MovementPointId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MovementPointId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalId";
            this.dataGridViewTextBoxColumn2.HeaderText = "AnimalId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LocationId";
            this.dataGridViewTextBoxColumn3.HeaderText = "LocationId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 82;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dateTimeDateTimePicker
            // 
            this.dateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movementPointsBindingSource, "DateTime", true));
            this.dateTimeDateTimePicker.Location = new System.Drawing.Point(135, 222);
            this.dateTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDateTimePicker.Name = "dateTimeDateTimePicker";
            this.dateTimeDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.dateTimeDateTimePicker.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SaveButton.Location = new System.Drawing.Point(262, 213);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(157, 29);
            this.SaveButton.TabIndex = 58;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.DeleteButton.Location = new System.Drawing.Point(347, 176);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(72, 31);
            this.DeleteButton.TabIndex = 57;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.AddButton.Location = new System.Drawing.Point(262, 175);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(79, 32);
            this.AddButton.TabIndex = 56;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // animalIdComboBox
            // 
            this.animalIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movementPointsBindingSource, "AnimalId", true));
            this.animalIdComboBox.DataSource = this.animalsBindingSource;
            this.animalIdComboBox.DisplayMember = "AnimalId";
            this.animalIdComboBox.FormattingEnabled = true;
            this.animalIdComboBox.Location = new System.Drawing.Point(135, 175);
            this.animalIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.animalIdComboBox.Name = "animalIdComboBox";
            this.animalIdComboBox.Size = new System.Drawing.Size(122, 21);
            this.animalIdComboBox.TabIndex = 59;
            this.animalIdComboBox.ValueMember = "AnimalId";
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // locationIdComboBox
            // 
            this.locationIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movementPointsBindingSource, "LocationId", true));
            this.locationIdComboBox.DataSource = this.locationsBindingSource;
            this.locationIdComboBox.DisplayMember = "LocationId";
            this.locationIdComboBox.FormattingEnabled = true;
            this.locationIdComboBox.Location = new System.Drawing.Point(135, 198);
            this.locationIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.locationIdComboBox.Name = "locationIdComboBox";
            this.locationIdComboBox.Size = new System.Drawing.Size(122, 21);
            this.locationIdComboBox.TabIndex = 60;
            this.locationIdComboBox.ValueMember = "LocationId";
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // MovementPointsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 250);
            this.Controls.Add(this.locationIdComboBox);
            this.Controls.Add(this.animalIdComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(animalIdLabel);
            this.Controls.Add(locationIdLabel);
            this.Controls.Add(dateTimeLabel);
            this.Controls.Add(this.dateTimeDateTimePicker);
            this.Controls.Add(this.movementPointsDataGridView);
            this.Controls.Add(this.movementPointsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MovementPointsAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Точки перемещения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovementPointsAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.MovementPointsAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementPointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementPointsBindingNavigator)).EndInit();
            this.movementPointsBindingNavigator.ResumeLayout(false);
            this.movementPointsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movementPointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource movementPointsBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.MovementPointsTableAdapter movementPointsTableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movementPointsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton movementPointsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView movementPointsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DateTimePicker dateTimeDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox animalIdComboBox;
        private System.Windows.Forms.ComboBox locationIdComboBox;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.LocationsTableAdapter locationsTableAdapter;
    }
}