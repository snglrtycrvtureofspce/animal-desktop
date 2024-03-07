using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form.User
{
    public partial class LocationsUserForm : System.Windows.Forms.Form
    {
        public LocationsUserForm()
        {
            InitializeComponent();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)v3DataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(decimal))
            {
                dv.RowFilter = $"CONVERT({selectedText}, 'System.String') LIKE '%{tbFilter.Text.ToLower()}%'";
            }
            else
            {
                dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)v3DataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(decimal))
            {
                dv.RowFilter = $"CONVERT({selectedText}, 'System.String') LIKE '%{tbFilter.Text.ToLower()}%'";
            }
            else
            {
                dv.RowFilter = $"{selectedText} LIKE '%{tbFilter.Text.ToLower()}%'";
            }
        }

        private void ExportToExcel(string fileName)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var workSheet = package.Workbook.Worksheets.Add("Локации");

                    workSheet.Cells["A1"].Value = "НаименованиеЛокации";
                    workSheet.Cells["B1"].Value = "ОписаниеЛокации";
                    workSheet.Cells["C1"].Value = "Широта";
                    workSheet.Cells["D1"].Value = "Долгота";

                    workSheet.Cells["A1:D1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:D1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    for (int row = 0; row < v3DataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < v3DataGridView.Columns.Count; col++)
                        {
                            workSheet.Cells[row + 2, col + 1].Value = v3DataGridView[col, row].Value;
                        }
                    }

                    workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();

                    package.SaveAs(new FileInfo(fileName));
                    MessageBox.Show("Данные экспортированы в файл " + fileName, "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при экспорте данных: " + ex.Message, "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Выберите файл для экспорта данных в Excel"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(saveFileDialog.FileName);
            }
        }

        private void ExportToXml(string fileName)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(v3TableAdapter.GetData().Copy());

                dataSet.WriteXml(fileName);
                MessageBox.Show("Данные экспортированы в файл " + fileName, "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при экспорте данных: " + ex.Message, "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToXmlButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Files|*.xml",
                Title = "Выберите файл для экспорта данных"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToXml(saveFileDialog.FileName);
            }
        }

        private void LocationsUserForm_Load(object sender, EventArgs e)
        {
            this.v3TableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.V3);
        }

        private void LocationsUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
