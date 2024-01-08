using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form.Admin
{
    public partial class RolesAdminForm : System.Windows.Forms.Form
    {
        public RolesAdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            rolesBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                rolesBindingSource.RemoveCurrent();
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Validate();
                this.rolesBindingSource.EndEdit();
                this.rolesTableAdapter.Update(this.lostAnimalsDesktop_ServiceDataSet);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RolesBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAnimalsDesktop_ServiceDataSet);
        }

        private void RolesAdminForm_Load(object sender, System.EventArgs e)
        {
            this.rolesTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.Roles);
        }

        private void RolesAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
