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
    public partial class FlightsForm : System.Windows.Forms.Form
    {
        public FlightsForm()
        {
            InitializeComponent();
        }

        private void flightsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)v1DataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)v1DataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
        }

        private void FlightsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.V1". При необходимости она может быть перемещена или удалена.
            this.v1TableAdapter.Fill(this.airlinesDataSet.V1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.V1". При необходимости она может быть перемещена или удалена.
            this.v1TableAdapter.Fill(this.airlinesDataSet.V1);
        }
    }
}