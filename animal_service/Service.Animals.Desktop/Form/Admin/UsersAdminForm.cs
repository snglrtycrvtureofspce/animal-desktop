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

        private void usersBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._LostAnimalsDesktop_ServiceDataSet);

        }

        private void UsersAdminForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_LostAnimalsDesktop_ServiceDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this._LostAnimalsDesktop_ServiceDataSet.Users);

        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            usersBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                usersBindingSource.RemoveCurrent();
            }
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.usersTableAdapter.Update(this._LostAnimalsDesktop_ServiceDataSet.Users);
                MessageBox.Show("Запись сохранена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsersAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
