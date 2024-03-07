namespace Service.Animals.Desktop.Form.Admin
{
    partial class AnimalsAdminForm
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
            System.Windows.Forms.Label animalTypeIdLabel;
            System.Windows.Forms.Label animalNameLabel;
            System.Windows.Forms.Label animalDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalsAdminForm));
            this.lostAnimalsDesktop_ServiceDataSet = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalsTableAdapter();
            this.tableAdapterManager = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.movementPointsTableAdapter = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.MovementPointsTableAdapter();
            this.animalsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.animalsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameTextBox = new System.Windows.Forms.TextBox();
            this.animalDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.animalTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.animalTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.animalTypesTableAdapter = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalTypesTableAdapter();
            animalTypeIdLabel = new System.Windows.Forms.Label();
            animalNameLabel = new System.Windows.Forms.Label();
            animalDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingNavigator)).BeginInit();
            this.animalsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // animalTypeIdLabel
            // 
            animalTypeIdLabel.AutoSize = true;
            animalTypeIdLabel.Font = new System.Drawing.Font("Verdana", 12F);
            animalTypeIdLabel.Location = new System.Drawing.Point(8, 176);
            animalTypeIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            animalTypeIdLabel.Name = "animalTypeIdLabel";
            animalTypeIdLabel.Size = new System.Drawing.Size(137, 18);
            animalTypeIdLabel.TabIndex = 4;
            animalTypeIdLabel.Text = "Animal Type Id:";
            // 
            // animalNameLabel
            // 
            animalNameLabel.AutoSize = true;
            animalNameLabel.Font = new System.Drawing.Font("Verdana", 12F);
            animalNameLabel.Location = new System.Drawing.Point(8, 196);
            animalNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            animalNameLabel.Name = "animalNameLabel";
            animalNameLabel.Size = new System.Drawing.Size(124, 18);
            animalNameLabel.TabIndex = 6;
            animalNameLabel.Text = "Animal Name:";
            // 
            // animalDescriptionLabel
            // 
            animalDescriptionLabel.AutoSize = true;
            animalDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12F);
            animalDescriptionLabel.Location = new System.Drawing.Point(8, 217);
            animalDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            animalDescriptionLabel.Name = "animalDescriptionLabel";
            animalDescriptionLabel.Size = new System.Drawing.Size(169, 18);
            animalDescriptionLabel.TabIndex = 8;
            animalDescriptionLabel.Text = "Animal Description:";
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = this.animalsTableAdapter;
            this.tableAdapterManager.AnimalTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MovementPointsTableAdapter = this.movementPointsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // movementPointsTableAdapter
            // 
            this.movementPointsTableAdapter.ClearBeforeFill = true;
            // 
            // animalsBindingNavigator
            // 
            this.animalsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalsBindingNavigator.BindingSource = this.animalsBindingSource;
            this.animalsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animalsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.animalsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalsBindingNavigatorSaveItem});
            this.animalsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalsBindingNavigator.Name = "animalsBindingNavigator";
            this.animalsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalsBindingNavigator.Size = new System.Drawing.Size(457, 31);
            this.animalsBindingNavigator.TabIndex = 0;
            this.animalsBindingNavigator.Text = "bindingNavigator1";
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
            // animalsBindingNavigatorSaveItem
            // 
            this.animalsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalsBindingNavigatorSaveItem.Image")));
            this.animalsBindingNavigatorSaveItem.Name = "animalsBindingNavigatorSaveItem";
            this.animalsBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.animalsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.animalsBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalsBindingNavigatorSaveItem_Click);
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.AutoGenerateColumns = false;
            this.animalsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.animalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.animalsDataGridView.DataSource = this.animalsBindingSource;
            this.animalsDataGridView.Location = new System.Drawing.Point(8, 25);
            this.animalsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.RowHeadersWidth = 62;
            this.animalsDataGridView.RowTemplate.Height = 28;
            this.animalsDataGridView.Size = new System.Drawing.Size(439, 143);
            this.animalsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AnimalId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalTypeId";
            this.dataGridViewTextBoxColumn2.HeaderText = "AnimalTypeId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnimalName";
            this.dataGridViewTextBoxColumn3.HeaderText = "AnimalName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnimalDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "AnimalDescription";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 116;
            // 
            // animalNameTextBox
            // 
            this.animalNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "AnimalName", true));
            this.animalNameTextBox.Location = new System.Drawing.Point(176, 196);
            this.animalNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalNameTextBox.Name = "animalNameTextBox";
            this.animalNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.animalNameTextBox.TabIndex = 7;
            // 
            // animalDescriptionTextBox
            // 
            this.animalDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "AnimalDescription", true));
            this.animalDescriptionTextBox.Location = new System.Drawing.Point(176, 217);
            this.animalDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalDescriptionTextBox.Name = "animalDescriptionTextBox";
            this.animalDescriptionTextBox.Size = new System.Drawing.Size(115, 20);
            this.animalDescriptionTextBox.TabIndex = 9;
            // 
            // animalTypeIdComboBox
            // 
            this.animalTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalsBindingSource, "AnimalTypeId", true));
            this.animalTypeIdComboBox.DataSource = this.animalTypesBindingSource;
            this.animalTypeIdComboBox.DisplayMember = "AnimalTypeId";
            this.animalTypeIdComboBox.FormattingEnabled = true;
            this.animalTypeIdComboBox.Location = new System.Drawing.Point(176, 174);
            this.animalTypeIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalTypeIdComboBox.Name = "animalTypeIdComboBox";
            this.animalTypeIdComboBox.Size = new System.Drawing.Size(115, 21);
            this.animalTypeIdComboBox.TabIndex = 10;
            this.animalTypeIdComboBox.ValueMember = "AnimalTypeId";
            // 
            // animalTypesBindingSource
            // 
            this.animalTypesBindingSource.DataMember = "AnimalTypes";
            this.animalTypesBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SaveButton.Location = new System.Drawing.Point(294, 196);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(156, 44);
            this.SaveButton.TabIndex = 55;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.DeleteButton.Location = new System.Drawing.Point(372, 175);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 21);
            this.DeleteButton.TabIndex = 54;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.AddButton.Location = new System.Drawing.Point(294, 174);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(77, 22);
            this.AddButton.TabIndex = 53;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // animalTypesTableAdapter
            // 
            this.animalTypesTableAdapter.ClearBeforeFill = true;
            // 
            // AnimalsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 245);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.animalTypeIdComboBox);
            this.Controls.Add(animalTypeIdLabel);
            this.Controls.Add(animalNameLabel);
            this.Controls.Add(this.animalNameTextBox);
            this.Controls.Add(animalDescriptionLabel);
            this.Controls.Add(this.animalDescriptionTextBox);
            this.Controls.Add(this.animalsDataGridView);
            this.Controls.Add(this.animalsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnimalsAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalsAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AnimalsAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingNavigator)).EndInit();
            this.animalsBindingNavigator.ResumeLayout(false);
            this.animalsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox animalNameTextBox;
        private System.Windows.Forms.TextBox animalDescriptionTextBox;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.MovementPointsTableAdapter movementPointsTableAdapter;
        private System.Windows.Forms.ComboBox animalTypeIdComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.BindingSource animalTypesBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalTypesTableAdapter animalTypesTableAdapter;
    }
}