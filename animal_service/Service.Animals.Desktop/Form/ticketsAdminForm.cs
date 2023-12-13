using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form
{
    public partial class ticketsAdminForm : System.Windows.Forms.Form
    {
        public ticketsAdminForm()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);

        }

        private void ticketsAdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Passengers". При необходимости она может быть перемещена или удалена.
            this.passengersTableAdapter.Fill(this.airlinesDataSet.Passengers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airlinesDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.airlinesDataSet.Tickets);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                ticketsBindingSource.RemoveCurrent();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ticketsBindingSource.EndEdit();
                this.ticketsTableAdapter.Update(this.airlinesDataSet.Tickets);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ticketsAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
