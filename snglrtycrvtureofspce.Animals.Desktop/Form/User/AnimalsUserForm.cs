using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;
using System;
using System.Windows.Forms;
using System.Data;

namespace snglrtycrvtureofspce.Animal.Desktop.Form.User
{
    public partial class AnimalsUserForm : System.Windows.Forms.Form
    {
        public AnimalsUserForm()
        {
            InitializeComponent();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)v2DataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(Int32))
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
            var bs = (BindingSource)v2DataGridView.DataSource;
            var dv = (DataView)bs.List;
            var selectedText = cbFilter.SelectedItem.ToString().ToLower();
            if (dv.Table.Columns[selectedText].DataType == typeof(Int32))
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
                    var workSheet = package.Workbook.Worksheets.Add("Животные");

                    workSheet.Cells["A1"].Value = "IdТипаЖивотного";
                    workSheet.Cells["B1"].Value = "НаименованиеЖивотного";
                    workSheet.Cells["C1"].Value = "ОписаниеЖивотного";

                    workSheet.Cells["A1:C1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    for (int row = 0; row < v2DataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < v2DataGridView.Columns.Count; col++)
                        {
                            workSheet.Cells[row + 2, col + 1].Value = v2DataGridView[col, row].Value;
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
                dataSet.Tables.Add(v2TableAdapter.GetData().Copy());

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

        private void AnimalUserForm_Load(object sender, EventArgs e)
        {
            this.v2TableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.V2);
        }

        private void AnimalUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
