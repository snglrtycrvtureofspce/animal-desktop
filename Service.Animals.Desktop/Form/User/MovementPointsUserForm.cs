using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System;

namespace Service.Animals.Desktop.Form.User
{
    public partial class MovementPointsUserForm : System.Windows.Forms.Form
    {
        public MovementPointsUserForm()
        {
            InitializeComponent();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null) return;
            var bs = (BindingSource)v4DataGridView.DataSource;
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
            var bs = (BindingSource)v4DataGridView.DataSource;
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
                    var workSheet = package.Workbook.Worksheets.Add("ТочкиПеремещения");

                    workSheet.Cells["A1"].Value = "IdЖивотного";
                    workSheet.Cells["B1"].Value = "IdЛокации";

                    workSheet.Cells["A1:B1"].Style.Font.Bold = true;
                    workSheet.Cells["A1:B1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    for (int row = 0; row < v4DataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < v4DataGridView.Columns.Count; col++)
                        {
                            workSheet.Cells[row + 2, col + 1].Value = v4DataGridView[col, row].Value;
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
                dataSet.Tables.Add(v4TableAdapter.GetData().Copy());

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

        private void MovementPointsUserForm_Load(object sender, EventArgs e)
        {
            this.v4TableAdapter.Fill(this.lostAnimalsDesktop_ServiceDataSet.V4);
        }

        private void MovementPointsUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
