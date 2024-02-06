using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form.Admin
{
    public partial class UsersAdminForm : System.Windows.Forms.Form
    {
        public UsersAdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            usersBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                usersBindingSource.RemoveCurrent();
            }
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.usersTableAdapter.Update(this.lostAnimalsDesktop_ServiceDataSet.Users);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsersBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAnimalsDesktop_ServiceDataSet);
        }

        private void UsersAdminForm_Load(object sender, System.EventArgs e)
        {
            this.usersTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.Users);
        }

        private void UsersAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
