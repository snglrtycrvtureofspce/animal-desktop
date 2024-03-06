using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form.Admin
{
    public partial class AnimalsAdminForm : System.Windows.Forms.Form
    {
        public AnimalsAdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            animalsBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                animalsBindingSource.RemoveCurrent();
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalsBindingSource.EndEdit();
                this.animalsTableAdapter.Update(this.lostAnimalsDesktop_ServiceDataSet.Animals);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void animalsBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.animalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAnimalsDesktop_ServiceDataSet);
        }

        private void AnimalsAdminForm_Load(object sender, System.EventArgs e)
        {
            this.animalTypesTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.AnimalTypes);
            this.animalsTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.Animals);
        }

        private void AnimalsAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
