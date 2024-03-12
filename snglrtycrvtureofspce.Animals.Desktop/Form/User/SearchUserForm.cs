using System;
using System.Data;
using System.Windows.Forms;

namespace snglrtycrvtureofspce.Animal.Desktop.Form.User
{
    public partial class SearchUserForm : System.Windows.Forms.Form
    {
        public SearchUserForm()
        {
            InitializeComponent();
        }

        private void tbFilterSearchAnimalsByLocation_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterSearchAnimalsByLocation.SelectedItem == null) return;
            var bs = (BindingSource)animalLocationViewDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilterSearchAnimalsByLocation.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(decimal))
            {
                dv.RowFilter = $"CONVERT({selectedText}, 'System.String') LIKE '%{tbFilterSearchAnimalsByLocation.Text.ToLower()}%'";
            }
            else
            {
                dv.RowFilter = $"{selectedText} LIKE '%{tbFilterSearchAnimalsByLocation.Text.ToLower()}%'";
            }
        }

        private void cbFilterSearchAnimalsByLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterSearchAnimalsByLocation.SelectedItem == null) return;
            var bs = (BindingSource)animalLocationViewDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilterSearchAnimalsByLocation.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(decimal))
            {
                dv.RowFilter = $"CONVERT({selectedText}, 'System.String') LIKE '%{tbFilterSearchAnimalsByLocation.Text.ToLower()}%'";
            }
            else
            {
                dv.RowFilter = $"{selectedText} LIKE '%{tbFilterSearchAnimalsByLocation.Text.ToLower()}%'";
            }
        }

        private void tbFilterSearchLocationByAnimalsAndDate_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterSearchLocationByAnimalsAndDate.SelectedItem == null) return;
            var bs = (BindingSource)animalVisitViewDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilterSearchLocationByAnimalsAndDate.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(DateTime))
            {
                dv.RowFilter = $"CONVERT({selectedText}, 'System.String') LIKE '%{tbFilterSearchLocationByAnimalsAndDate.Text.ToLower()}%'";
            }
            else
            {
                dv.RowFilter = $"{selectedText} LIKE '%{tbFilterSearchLocationByAnimalsAndDate.Text.ToLower()}%'";
            }
        }

        private void cbFilterSearchLocationByAnimalsAndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterSearchLocationByAnimalsAndDate.SelectedItem == null) return;
            var bs = (BindingSource)animalVisitViewDataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilterSearchLocationByAnimalsAndDate.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(DateTime))
            {
                dv.RowFilter = $"CONVERT({selectedText}, 'System.String') LIKE '%{tbFilterSearchLocationByAnimalsAndDate.Text.ToLower()}%'";
            }
            else
            {
                dv.RowFilter = $"{selectedText} LIKE '%{tbFilterSearchLocationByAnimalsAndDate.Text.ToLower()}%'";
            }
        }

        private void SearchUserForm_Load(object sender, EventArgs e)
        {
            this.animalVisitViewTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.AnimalVisitView);
            this.animalLocationViewTableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.AnimalLocationView);
        }

        private void SearchUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
