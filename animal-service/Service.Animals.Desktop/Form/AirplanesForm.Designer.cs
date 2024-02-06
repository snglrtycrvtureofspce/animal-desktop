using Service.Animals.Desktop.airlinesDataSetTableAdapters;

namespace Service.Animals.Desktop.Form
{
    partial class AirplanesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirplanesForm));
            System.Windows.Forms.Label registrationNumberLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label numberOfSeatsLabel;
            System.Windows.Forms.Label payloadLabel;
            System.Windows.Forms.Label speedLabel;
            System.Windows.Forms.Label manufactureDateLabel;
            System.Windows.Forms.Label flightHoursLabel;
            System.Windows.Forms.Label lastRepairDateLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label fuelConsumptionLabel;
            this.airlinesDataSet = new airlinesDataSet();
            this.airplanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airplanesTableAdapter = new AirplanesTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.airplanesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.airplanesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.airplanesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.payloadTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.manufactureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flightHoursTextBox = new System.Windows.Forms.TextBox();
            this.lastRepairDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.fuelConsumptionTextBox = new System.Windows.Forms.TextBox();
            registrationNumberLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            numberOfSeatsLabel = new System.Windows.Forms.Label();
            payloadLabel = new System.Windows.Forms.Label();
            speedLabel = new System.Windows.Forms.Label();
            manufactureDateLabel = new System.Windows.Forms.Label();
            flightHoursLabel = new System.Windows.Forms.Label();
            lastRepairDateLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            fuelConsumptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingNavigator)).BeginInit();
            this.airplanesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airlinesDataSet
            // 
            this.airlinesDataSet.DataSetName = "airlinesDataSet";
            this.airlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplanesBindingSource
            // 
            this.airplanesBindingSource.DataMember = "Airplanes";
            this.airplanesBindingSource.DataSource = this.airlinesDataSet;
            // 
            // airplanesTableAdapter
            // 
            this.airplanesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirplanesTableAdapter = this.airplanesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewMemberTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airplanesBindingNavigator
            // 
            this.airplanesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.airplanesBindingNavigator.BindingSource = this.airplanesBindingSource;
            this.airplanesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.airplanesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.airplanesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.airplanesBindingNavigatorSaveItem});
            this.airplanesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.airplanesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.airplanesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.airplanesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.airplanesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.airplanesBindingNavigator.Name = "airplanesBindingNavigator";
            this.airplanesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.airplanesBindingNavigator.Size = new System.Drawing.Size(1162, 25);
            this.airplanesBindingNavigator.TabIndex = 0;
            this.airplanesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // airplanesBindingNavigatorSaveItem
            // 
            this.airplanesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.airplanesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("airplanesBindingNavigatorSaveItem.Image")));
            this.airplanesBindingNavigatorSaveItem.Name = "airplanesBindingNavigatorSaveItem";
            this.airplanesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.airplanesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.airplanesBindingNavigatorSaveItem.Click += new System.EventHandler(this.airplanesBindingNavigatorSaveItem_Click);
            // 
            // airplanesDataGridView
            // 
            this.airplanesDataGridView.AutoGenerateColumns = false;
            this.airplanesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airplanesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.airplanesDataGridView.DataSource = this.airplanesBindingSource;
            this.airplanesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.airplanesDataGridView.Name = "airplanesDataGridView";
            this.airplanesDataGridView.Size = new System.Drawing.Size(1140, 220);
            this.airplanesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AirplaneID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AirplaneID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegistrationNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegistrationNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfSeats";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumberOfSeats";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Payload";
            this.dataGridViewTextBoxColumn5.HeaderText = "Payload";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Speed";
            this.dataGridViewTextBoxColumn6.HeaderText = "Speed";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ManufactureDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "ManufactureDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FlightHours";
            this.dataGridViewTextBoxColumn8.HeaderText = "FlightHours";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LastRepairDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "LastRepairDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn10.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FuelConsumption";
            this.dataGridViewTextBoxColumn11.HeaderText = "FuelConsumption";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Courier New", 36F);
            this.deleteButton.Location = new System.Drawing.Point(801, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(351, 149);
            this.deleteButton.TabIndex = 49;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(440, 416);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(712, 98);
            this.saveButton.TabIndex = 48;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(440, 260);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(355, 149);
            this.addButton.TabIndex = 47;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // registrationNumberLabel
            // 
            registrationNumberLabel.AutoSize = true;
            registrationNumberLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            registrationNumberLabel.Location = new System.Drawing.Point(12, 263);
            registrationNumberLabel.Name = "registrationNumberLabel";
            registrationNumberLabel.Size = new System.Drawing.Size(183, 16);
            registrationNumberLabel.TabIndex = 27;
            registrationNumberLabel.Text = "Регистрационный номер:";
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "RegistrationNumber", true));
            this.registrationNumberTextBox.Location = new System.Drawing.Point(217, 260);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.registrationNumberTextBox.TabIndex = 28;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            typeLabel.Location = new System.Drawing.Point(12, 289);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(39, 16);
            typeLabel.TabIndex = 29;
            typeLabel.Text = "Тип:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(217, 286);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeTextBox.TabIndex = 30;
            // 
            // numberOfSeatsLabel
            // 
            numberOfSeatsLabel.AutoSize = true;
            numberOfSeatsLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            numberOfSeatsLabel.Location = new System.Drawing.Point(12, 315);
            numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            numberOfSeatsLabel.Size = new System.Drawing.Size(135, 16);
            numberOfSeatsLabel.TabIndex = 31;
            numberOfSeatsLabel.Text = "Количество мест:";
            // 
            // numberOfSeatsTextBox
            // 
            this.numberOfSeatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "NumberOfSeats", true));
            this.numberOfSeatsTextBox.Location = new System.Drawing.Point(217, 312);
            this.numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            this.numberOfSeatsTextBox.Size = new System.Drawing.Size(200, 20);
            this.numberOfSeatsTextBox.TabIndex = 32;
            // 
            // payloadLabel
            // 
            payloadLabel.AutoSize = true;
            payloadLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            payloadLabel.Location = new System.Drawing.Point(12, 341);
            payloadLabel.Name = "payloadLabel";
            payloadLabel.Size = new System.Drawing.Size(143, 16);
            payloadLabel.TabIndex = 33;
            payloadLabel.Text = "Грузоподъёмность:";
            // 
            // payloadTextBox
            // 
            this.payloadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Payload", true));
            this.payloadTextBox.Location = new System.Drawing.Point(217, 338);
            this.payloadTextBox.Name = "payloadTextBox";
            this.payloadTextBox.Size = new System.Drawing.Size(200, 20);
            this.payloadTextBox.TabIndex = 34;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            speedLabel.Location = new System.Drawing.Point(12, 367);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new System.Drawing.Size(79, 16);
            speedLabel.TabIndex = 35;
            speedLabel.Text = "Скорость:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Speed", true));
            this.speedTextBox.Location = new System.Drawing.Point(217, 364);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(200, 20);
            this.speedTextBox.TabIndex = 36;
            // 
            // manufactureDateLabel
            // 
            manufactureDateLabel.AutoSize = true;
            manufactureDateLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            manufactureDateLabel.Location = new System.Drawing.Point(12, 394);
            manufactureDateLabel.Name = "manufactureDateLabel";
            manufactureDateLabel.Size = new System.Drawing.Size(111, 16);
            manufactureDateLabel.TabIndex = 37;
            manufactureDateLabel.Text = "Дата выпуска:";
            // 
            // manufactureDateDateTimePicker
            // 
            this.manufactureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplanesBindingSource, "ManufactureDate", true));
            this.manufactureDateDateTimePicker.Location = new System.Drawing.Point(217, 390);
            this.manufactureDateDateTimePicker.Name = "manufactureDateDateTimePicker";
            this.manufactureDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.manufactureDateDateTimePicker.TabIndex = 38;
            // 
            // flightHoursLabel
            // 
            flightHoursLabel.AutoSize = true;
            flightHoursLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            flightHoursLabel.Location = new System.Drawing.Point(12, 419);
            flightHoursLabel.Name = "flightHoursLabel";
            flightHoursLabel.Size = new System.Drawing.Size(127, 16);
            flightHoursLabel.TabIndex = 39;
            flightHoursLabel.Text = "Налётано часов:";
            // 
            // flightHoursTextBox
            // 
            this.flightHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "FlightHours", true));
            this.flightHoursTextBox.Location = new System.Drawing.Point(217, 416);
            this.flightHoursTextBox.Name = "flightHoursTextBox";
            this.flightHoursTextBox.Size = new System.Drawing.Size(200, 20);
            this.flightHoursTextBox.TabIndex = 40;
            // 
            // lastRepairDateLabel
            // 
            lastRepairDateLabel.AutoSize = true;
            lastRepairDateLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            lastRepairDateLabel.Location = new System.Drawing.Point(12, 446);
            lastRepairDateLabel.Name = "lastRepairDateLabel";
            lastRepairDateLabel.Size = new System.Drawing.Size(199, 16);
            lastRepairDateLabel.TabIndex = 41;
            lastRepairDateLabel.Text = "Дата последнего ремонта:";
            // 
            // lastRepairDateDateTimePicker
            // 
            this.lastRepairDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.airplanesBindingSource, "LastRepairDate", true));
            this.lastRepairDateDateTimePicker.Location = new System.Drawing.Point(217, 442);
            this.lastRepairDateDateTimePicker.Name = "lastRepairDateDateTimePicker";
            this.lastRepairDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastRepairDateDateTimePicker.TabIndex = 42;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            destinationLabel.Location = new System.Drawing.Point(12, 471);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(167, 16);
            destinationLabel.TabIndex = 43;
            destinationLabel.Text = "Назначение самолёта:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(217, 468);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(200, 20);
            this.destinationTextBox.TabIndex = 44;
            // 
            // fuelConsumptionLabel
            // 
            fuelConsumptionLabel.AutoSize = true;
            fuelConsumptionLabel.Font = new System.Drawing.Font("Courier New", 9.75F);
            fuelConsumptionLabel.Location = new System.Drawing.Point(12, 497);
            fuelConsumptionLabel.Name = "fuelConsumptionLabel";
            fuelConsumptionLabel.Size = new System.Drawing.Size(127, 16);
            fuelConsumptionLabel.TabIndex = 45;
            fuelConsumptionLabel.Text = "Расход топлива:";
            // 
            // fuelConsumptionTextBox
            // 
            this.fuelConsumptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airplanesBindingSource, "FuelConsumption", true));
            this.fuelConsumptionTextBox.Location = new System.Drawing.Point(217, 494);
            this.fuelConsumptionTextBox.Name = "fuelConsumptionTextBox";
            this.fuelConsumptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.fuelConsumptionTextBox.TabIndex = 46;
            // 
            // AirplanesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 525);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(registrationNumberLabel);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(numberOfSeatsLabel);
            this.Controls.Add(this.numberOfSeatsTextBox);
            this.Controls.Add(payloadLabel);
            this.Controls.Add(this.payloadTextBox);
            this.Controls.Add(speedLabel);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(manufactureDateLabel);
            this.Controls.Add(this.manufactureDateDateTimePicker);
            this.Controls.Add(flightHoursLabel);
            this.Controls.Add(this.flightHoursTextBox);
            this.Controls.Add(lastRepairDateLabel);
            this.Controls.Add(this.lastRepairDateDateTimePicker);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(fuelConsumptionLabel);
            this.Controls.Add(this.fuelConsumptionTextBox);
            this.Controls.Add(this.airplanesDataGridView);
            this.Controls.Add(this.airplanesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirplanesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Самолёты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AirplanesForm_FormClosing);
            this.Load += new System.EventHandler(this.AirplanesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingNavigator)).EndInit();
            this.airplanesBindingNavigator.ResumeLayout(false);
            this.airplanesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airlinesDataSet airlinesDataSet;
        private System.Windows.Forms.BindingSource airplanesBindingSource;
        private airlinesDataSetTableAdapters.AirplanesTableAdapter airplanesTableAdapter;
        private airlinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator airplanesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton airplanesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView airplanesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox numberOfSeatsTextBox;
        private System.Windows.Forms.TextBox payloadTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.DateTimePicker manufactureDateDateTimePicker;
        private System.Windows.Forms.TextBox flightHoursTextBox;
        private System.Windows.Forms.DateTimePicker lastRepairDateDateTimePicker;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox fuelConsumptionTextBox;
    }
}