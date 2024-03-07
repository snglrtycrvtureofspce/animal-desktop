namespace Service.Animals.Desktop.Form.User
{
    partial class MovementPointsUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovementPointsUserForm));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.lostAnimalsDesktop_ServiceDataSet = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSet();
            this.v4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v4TableAdapter = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.V4TableAdapter();
            this.tableAdapterManager = new Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager();
            this.v4BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.v4DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.ExportToExcelButton = new System.Windows.Forms.ToolStripButton();
            this.ExportToXmlButton = new System.Windows.Forms.ToolStripButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v4BindingNavigator)).BeginInit();
            this.v4BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v4DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lostAnimalsDesktop_ServiceDataSet
            // 
            this.lostAnimalsDesktop_ServiceDataSet.DataSetName = "LostAnimalsDesktop_ServiceDataSet";
            this.lostAnimalsDesktop_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v4BindingSource
            // 
            this.v4BindingSource.DataMember = "V4";
            this.v4BindingSource.DataSource = this.lostAnimalsDesktop_ServiceDataSet;
            // 
            // v4TableAdapter
            // 
            this.v4TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimalsTableAdapter = null;
            this.tableAdapterManager.AnimalTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MovementPointsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Service.Animals.Desktop.LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // v4BindingNavigator
            // 
            this.v4BindingNavigator.AddNewItem = null;
            this.v4BindingNavigator.BindingSource = this.v4BindingSource;
            this.v4BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v4BindingNavigator.DeleteItem = null;
            this.v4BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.ExportToExcelButton,
            this.ExportToXmlButton});
            this.v4BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v4BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v4BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v4BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v4BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v4BindingNavigator.Name = "v4BindingNavigator";
            this.v4BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v4BindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.v4BindingNavigator.TabIndex = 0;
            this.v4BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // v4DataGridView
            // 
            this.v4DataGridView.AutoGenerateColumns = false;
            this.v4DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.v4DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v4DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.v4DataGridView.DataSource = this.v4BindingSource;
            this.v4DataGridView.Location = new System.Drawing.Point(12, 28);
            this.v4DataGridView.Name = "v4DataGridView";
            this.v4DataGridView.Size = new System.Drawing.Size(226, 220);
            this.v4DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdЖивотного";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdЖивотного";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdЛокации";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdЛокации";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            label2.Location = new System.Drawing.Point(12, 286);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 16);
            label2.TabIndex = 75;
            label2.Text = "Критерий:";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(114, 257);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(124, 20);
            this.tbFilter.TabIndex = 74;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 9.75F);
            label1.Location = new System.Drawing.Point(12, 256);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 16);
            label1.TabIndex = 73;
            label1.Text = "Фильтрация:";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "IdЖивотного",
            "IdЛокации"});
            this.cbFilter.Location = new System.Drawing.Point(114, 287);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(124, 21);
            this.cbFilter.TabIndex = 72;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcelButton.Image")));
            this.ExportToExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(111, 22);
            this.ExportToExcelButton.Text = "Экспорт в Excel";
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // ExportToXmlButton
            // 
            this.ExportToXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToXmlButton.Image")));
            this.ExportToXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToXmlButton.Name = "ExportToXmlButton";
            this.ExportToXmlButton.Size = new System.Drawing.Size(105, 22);
            this.ExportToXmlButton.Text = "Экспорт в Xml";
            this.ExportToXmlButton.Click += new System.EventHandler(this.ExportToXmlButton_Click);
            // 
            // MovementPointsUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 318);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.v4DataGridView);
            this.Controls.Add(this.v4BindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovementPointsUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Точки перемещения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovementPointsUserForm_FormClosing);
            this.Load += new System.EventHandler(this.MovementPointsUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lostAnimalsDesktop_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v4BindingNavigator)).EndInit();
            this.v4BindingNavigator.ResumeLayout(false);
            this.v4BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v4DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LostAnimalsDesktop_ServiceDataSet lostAnimalsDesktop_ServiceDataSet;
        private System.Windows.Forms.BindingSource v4BindingSource;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.V4TableAdapter v4TableAdapter;
        private LostAnimalsDesktop_ServiceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v4BindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView v4DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ToolStripButton ExportToExcelButton;
        private System.Windows.Forms.ToolStripButton ExportToXmlButton;
    }
}