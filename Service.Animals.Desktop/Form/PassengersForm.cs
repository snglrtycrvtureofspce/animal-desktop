/*
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form
{
    public partial class PassengersForm : System.Windows.Forms.Form
    {
        public PassengersForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            passengersBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление записи",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                passengersBindingSource.RemoveCurrent();
                passengersTableAdapter.Update(airlinesDataSet);
                MessageBox.Show("Запись удалена.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            passengersBindingSource.EndEdit();
            passengersTableAdapter.Update(airlinesDataSet);
        }

        private void passengersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airlinesDataSet);
        }

        private void PassengersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airlinesDataSet.Passengers". При необходимости она может быть перемещена или удалена.
            this.passengersTableAdapter.Fill(this.airlinesDataSet.Passengers);
        }

        private void PassengersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passengersBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passengersBindingSource.MovePrevious();
        }

        private void ExportToXml(string fileName)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(passengersTableAdapter.GetData().Copy());

                dataSet.WriteXml(fileName);
                MessageBox.Show("Данные экспортированы в файл " + fileName, "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при экспорте данных: " + ex.Message, "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml";
            saveFileDialog.Title = "Выберите файл для экспорта данных";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToXml(saveFileDialog.FileName);
            }
        }

        private void ExportToExcel(string fileName)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Passengers");

                    // Заголовки столбцов
                    worksheet.Cells["A1"].Value = "PassengerID";
                    worksheet.Cells["B1"].Value = "FullName";
                    worksheet.Cells["C1"].Value = "PassportData";

                    worksheet.Cells["A1:C1"].Style.Font.Bold = true;
                    worksheet.Cells["A1:C1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    // Заполнение данными из DataGridView
                    for (int row = 0; row < passengersDataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < passengersDataGridView.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = passengersDataGridView[col, row].Value;
                        }
                    }

                    package.SaveAs(new FileInfo(fileName));
                    MessageBox.Show("Данные экспортированы в файл " + fileName, "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при экспорте данных: " + ex.Message, "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Выберите файл для экспорта данных в Excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(saveFileDialog.FileName);
            }
        }
    }
}
*/
