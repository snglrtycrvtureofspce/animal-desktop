namespace snglrtycrvtureofspce.Animal.Desktop.Form.User
{
    partial class AnimalsUserForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalsUserForm));
            this.lostAnimalsDesktop_ServiceDataSet = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.v2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v2TableAdapter = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.V2TableAdapter();
            this.tableAdapterManager = new snglrtycrvtureofspce.Animal.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.v2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ExportToExcelButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportToXmlButton = new System.Windows.Forms.ToolStripButton();
            this.v2DataGridView = new System.Windows.Forms.DataGridView();
            this.idТипаЖивотногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеЖивотногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеЖивотногоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2BindingNavigator)).BeginInit();
            this.v2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            label2.Location = new System.Drawing.Point(9, 207);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 16);
            label2.TabIndex = 67;
            label2.Text = "Критерий:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            label1.Location = new System.Drawing.Point(9, 177);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 16);
            label1.TabIndex = 65;
            label1.Text = "Фильтрация:";
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v2BindingSource
            // 
            this.v2BindingSource.DataMember = "V2";
            this.v2BindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // v2TableAdapter
            // 
            this.v2TableAdapter.ClearBeforeFill = true;
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
            // v2BindingNavigator
            // 
            this.v2BindingNavigator.AddNewItem = null;
            this.v2BindingNavigator.BindingSource = this.v2BindingSource;
            this.v2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v2BindingNavigator.DeleteItem = null;
            this.v2BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.v2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.ExportToExcelButton,
            this.bindingNavigatorSeparator2,
            this.ExportToXmlButton});
            this.v2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v2BindingNavigator.Name = "v2BindingNavigator";
            this.v2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v2BindingNavigator.Size = new System.Drawing.Size(507, 31);
            this.v2BindingNavigator.TabIndex = 0;
            this.v2BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcelButton.Image")));
            this.ExportToExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(119, 28);
            this.ExportToExcelButton.Text = "Экспорт в Excel";
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // ExportToXmlButton
            // 
            this.ExportToXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToXmlButton.Image")));
            this.ExportToXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToXmlButton.Name = "ExportToXmlButton";
            this.ExportToXmlButton.Size = new System.Drawing.Size(113, 28);
            this.ExportToXmlButton.Text = "Экспорт в Xml";
            this.ExportToXmlButton.Click += new System.EventHandler(this.ExportToXmlButton_Click);
            // 
            // v2DataGridView
            // 
            this.v2DataGridView.AutoGenerateColumns = false;
            this.v2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.v2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idТипаЖивотногоDataGridViewTextBoxColumn,
            this.наименованиеЖивотногоDataGridViewTextBoxColumn,
            this.описаниеЖивотногоDataGridViewTextBoxColumn});
            this.v2DataGridView.DataSource = this.v2BindingSource;
            this.v2DataGridView.Location = new System.Drawing.Point(8, 25);
            this.v2DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.v2DataGridView.Name = "v2DataGridView";
            this.v2DataGridView.RowHeadersWidth = 62;
            this.v2DataGridView.RowTemplate.Height = 28;
            this.v2DataGridView.Size = new System.Drawing.Size(491, 143);
            this.v2DataGridView.TabIndex = 1;
            // 
            // idТипаЖивотногоDataGridViewTextBoxColumn
            // 
            this.idТипаЖивотногоDataGridViewTextBoxColumn.DataPropertyName = "IdТипаЖивотного";
            this.idТипаЖивотногоDataGridViewTextBoxColumn.HeaderText = "IdТипаЖивотного";
            this.idТипаЖивотногоDataGridViewTextBoxColumn.Name = "idТипаЖивотногоDataGridViewTextBoxColumn";
            this.idТипаЖивотногоDataGridViewTextBoxColumn.Width = 123;
            // 
            // наименованиеЖивотногоDataGridViewTextBoxColumn
            // 
            this.наименованиеЖивотногоDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеЖивотного";
            this.наименованиеЖивотногоDataGridViewTextBoxColumn.HeaderText = "НаименованиеЖивотного";
            this.наименованиеЖивотногоDataGridViewTextBoxColumn.Name = "наименованиеЖивотногоDataGridViewTextBoxColumn";
            this.наименованиеЖивотногоDataGridViewTextBoxColumn.Width = 165;
            // 
            // описаниеЖивотногоDataGridViewTextBoxColumn
            // 
            this.описаниеЖивотногоDataGridViewTextBoxColumn.DataPropertyName = "ОписаниеЖивотного";
            this.описаниеЖивотногоDataGridViewTextBoxColumn.HeaderText = "ОписаниеЖивотного";
            this.описаниеЖивотногоDataGridViewTextBoxColumn.Name = "описаниеЖивотногоDataGridViewTextBoxColumn";
            this.описаниеЖивотногоDataGridViewTextBoxColumn.Width = 139;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(111, 178);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(388, 20);
            this.tbFilter.TabIndex = 66;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "IdТипаЖивотного",
            "НаименованиеЖивотного",
            "ОписаниеЖивотного"});
            this.cbFilter.Location = new System.Drawing.Point(111, 208);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(388, 21);
            this.cbFilter.TabIndex = 64;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // AnimalsUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 241);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.v2DataGridView);
            this.Controls.Add(this.v2BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnimalsUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalUserForm_FormClosing);
            this.Load += new System.EventHandler(this.AnimalUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2BindingNavigator)).EndInit();
            this.v2BindingNavigator.ResumeLayout(false);
            this.v2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource v2BindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.V2TableAdapter v2TableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v2BindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView v2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ToolStripButton ExportToXmlButton;
        private System.Windows.Forms.ToolStripButton ExportToExcelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idТипаЖивотногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеЖивотногоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеЖивотногоDataGridViewTextBoxColumn;
    }
}