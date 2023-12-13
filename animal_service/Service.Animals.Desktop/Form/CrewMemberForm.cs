using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form
{
    public partial class CrewMemberForm : System.Windows.Forms.Form
    {
        public CrewMemberForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            crewMemberBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crewMemberBindingSource.RemoveCurrent();
                crewMemberTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            crewMemberBindingSource.EndEdit();
            crewMemberTableAdapter.Update(airlinesDataSet);
        }

        private void crewMemberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crewMemberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void CrewMemberForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.CrewMember". При необходимости она может быть перемещена или удалена.
            this.crewMemberTableAdapter.Fill(this.airlinesDataSet.CrewMember);
        }

        private void CrewMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
