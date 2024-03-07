using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form.Admin
{
    public partial class AnimalTypesAdminForm : System.Windows.Forms.Form
    {
        public AnimalTypesAdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            animalTypesBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                animalTypesBindingSource.RemoveCurrent();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalTypesBindingSource.EndEdit();
                this.animalTypesTableAdapter.Update(this.lostAnimalsDesktop_ServiceDataSet.AnimalTypes);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void animalTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAnimalsDesktop_ServiceDataSet);
        }

        private void AnimalTypesAdminForm_Load(object sender, EventArgs e)
        {
            this.animalTypesTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.AnimalTypes);
        }

        private void AnimalTypesAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
