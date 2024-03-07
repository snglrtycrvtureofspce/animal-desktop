namespace Service.Animals.Desktop.Form.Admin
{
    partial class AnimalTypesAdminForm
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
            System.Windows.Forms.Label typeNameLabel;
            System.Windows.Forms.Label typeDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalTypesAdminForm));
            this.lostAnimalsDesktop_ServiceDataSet = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.animalTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalTypesTableAdapter = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalTypesTableAdapter();
            this.tableAdapterManager = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.animalTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.animalTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.animalTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.typeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            typeNameLabel = new System.Windows.Forms.Label();
            typeDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesBindingNavigator)).BeginInit();
            this.animalTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typeNameLabel
            // 
            typeNameLabel.AutoSize = true;
            typeNameLabel.Font = new System.Drawing.Font("Verdana", 12F);
            typeNameLabel.Location = new System.Drawing.Point(8, 176);
            typeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            typeNameLabel.Name = "typeNameLabel";
            typeNameLabel.Size = new System.Drawing.Size(181, 18);
            typeNameLabel.TabIndex = 4;
            typeNameLabel.Text = "Наименование типа:";
            // 
            // typeDescriptionLabel
            // 
            typeDescriptionLabel.AutoSize = true;
            typeDescriptionLabel.Font = new System.Drawing.Font("Verdana", 12F);
            typeDescriptionLabel.Location = new System.Drawing.Point(8, 196);
            typeDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            typeDescriptionLabel.Name = "typeDescriptionLabel";
            typeDescriptionLabel.Size = new System.Drawing.Size(140, 18);
            typeDescriptionLabel.TabIndex = 6;
            typeDescriptionLabel.Text = "Описание типа:";
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalTypesBindingSource
            // 
            this.animalTypesBindingSource.DataMember = "AnimalTypes";
            this.animalTypesBindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // animalTypesTableAdapter
            // 
            this.animalTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = null;
            this.tableAdapterManager.AnimalTypesTableAdapter = this.animalTypesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MovementPointsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // animalTypesBindingNavigator
            // 
            this.animalTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalTypesBindingNavigator.BindingSource = this.animalTypesBindingSource;
            this.animalTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animalTypesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.animalTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalTypesBindingNavigatorSaveItem});
            this.animalTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalTypesBindingNavigator.Name = "animalTypesBindingNavigator";
            this.animalTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalTypesBindingNavigator.Size = new System.Drawing.Size(371, 31);
            this.animalTypesBindingNavigator.TabIndex = 0;
            this.animalTypesBindingNavigator.Text = "bindingNavigator1";
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
            // animalTypesBindingNavigatorSaveItem
            // 
            this.animalTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalTypesBindingNavigatorSaveItem.Image")));
            this.animalTypesBindingNavigatorSaveItem.Name = "animalTypesBindingNavigatorSaveItem";
            this.animalTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.animalTypesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.animalTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalTypesBindingNavigatorSaveItem_Click);
            // 
            // animalTypesDataGridView
            // 
            this.animalTypesDataGridView.AutoGenerateColumns = false;
            this.animalTypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.animalTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.animalTypesDataGridView.DataSource = this.animalTypesBindingSource;
            this.animalTypesDataGridView.Location = new System.Drawing.Point(8, 25);
            this.animalTypesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animalTypesDataGridView.Name = "animalTypesDataGridView";
            this.animalTypesDataGridView.RowHeadersWidth = 62;
            this.animalTypesDataGridView.RowTemplate.Height = 28;
            this.animalTypesDataGridView.Size = new System.Drawing.Size(353, 143);
            this.animalTypesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AnimalTypeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AnimalTypeId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 96;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeDescription";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 109;
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalTypesBindingSource, "TypeName", true));
            this.typeNameTextBox.Location = new System.Drawing.Point(191, 179);
            this.typeNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.typeNameTextBox.TabIndex = 5;
            // 
            // typeDescriptionTextBox
            // 
            this.typeDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalTypesBindingSource, "TypeDescription", true));
            this.typeDescriptionTextBox.Location = new System.Drawing.Point(191, 200);
            this.typeDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeDescriptionTextBox.Name = "typeDescriptionTextBox";
            this.typeDescriptionTextBox.Size = new System.Drawing.Size(170, 20);
            this.typeDescriptionTextBox.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SaveButton.Location = new System.Drawing.Point(8, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(353, 49);
            this.SaveButton.TabIndex = 52;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.DeleteButton.Location = new System.Drawing.Point(181, 225);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(180, 48);
            this.DeleteButton.TabIndex = 51;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.AddButton.Location = new System.Drawing.Point(8, 225);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 48);
            this.AddButton.TabIndex = 50;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AnimalTypesAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 335);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(typeNameLabel);
            this.Controls.Add(this.typeNameTextBox);
            this.Controls.Add(typeDescriptionLabel);
            this.Controls.Add(this.typeDescriptionTextBox);
            this.Controls.Add(this.animalTypesDataGridView);
            this.Controls.Add(this.animalTypesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnimalTypesAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы животных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalTypesAdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AnimalTypesAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesBindingNavigator)).EndInit();
            this.animalTypesBindingNavigator.ResumeLayout(false);
            this.animalTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource animalTypesBindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.AnimalTypesTableAdapter animalTypesTableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalTypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView animalTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.TextBox typeDescriptionTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}