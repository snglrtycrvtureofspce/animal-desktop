using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form.Admin
{
    public partial class LocationsAdminForm : System.Windows.Forms.Form
    {
        public LocationsAdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            locationsBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                locationsBindingSource.RemoveCurrent();
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Validate();
                this.locationsBindingSource.EndEdit();
                this.locationsTableAdapter.Update(this.lostAnimalsDesktop_ServiceDataSet.Locations);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void locationsBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.locationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAnimalsDesktop_ServiceDataSet);
        }

        private void LocationsAdminForm_Load(object sender, System.EventArgs e)
        {
            this.locationsTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.Locations);
        }

        private void LocationsAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
