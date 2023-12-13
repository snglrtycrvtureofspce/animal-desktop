using Service.Animals.Desktop.Control.ElControls;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Control
{
    public partial class BasketControl : UserControl
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;
      
        public BasketControl()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gunaTextBox1.Text != "" && gunaTextBox2.Text != "" && gunaTextBox3.Text != "")
                {
                    MessageBox.Show("Заказ успешно оформлен.");



                    SqlConnection connection = new SqlConnection(_connectionString);
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM [basket]", connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все данные!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BasketControl_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tickets]", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                gunaLabel6.Text = reader[3].ToString() + " руб.";
                gunaLabel7.Text = reader[3].ToString() + " руб.";
            }
            reader.Close();
            connection.Close();
        }
    }
}
