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
    public partial class crewAdminForm : System.Windows.Forms.Form
    {
        public crewAdminForm()
        {
            InitializeComponent();
        }

        private void crewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);

        }

        private void crewAdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.CrewMember". При необходимости она может быть перемещена или удалена.
            this.crewMemberTableAdapter.Fill(this.airlinesDataSet.CrewMember);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airlinesDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Crew". При необходимости она может быть перемещена или удалена.
            this.crewTableAdapter.Fill(this.airlinesDataSet.Crew);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            crewBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                crewBindingSource.RemoveCurrent();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.crewBindingSource.EndEdit();
                this.crewTableAdapter.Update(this.airlinesDataSet.Crew);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crewAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
