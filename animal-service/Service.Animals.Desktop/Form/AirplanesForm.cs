using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form
{
    public partial class AirplanesForm : System.Windows.Forms.Form
    {
        public AirplanesForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            airplanesBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                airplanesBindingSource.RemoveCurrent();
                airplanesTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            airplanesBindingSource.EndEdit();
            airplanesTableAdapter.Update(airlinesDataSet);
        }

        private void airplanesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airplanesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void AirplanesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Airplanes". При необходимости она может быть перемещена или удалена.
            this.airplanesTableAdapter.Fill(this.airlinesDataSet.Airplanes);
        }

        private void AirplanesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
