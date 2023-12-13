using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Control
{
    public partial class InfoProductControl : UserControl
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public InfoProductControl()
        {
            InitializeComponent();
        }


        bool changet3 = false;
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (changet3)
            {
                gunaAdvenceButton1.ForeColor = Color.Black;
                gunaAdvenceButton1.BackColor = SystemColors.Control;
                gunaAdvenceButton1.Text = "Добавить в корзину";
                gunaAdvenceButton1.ImageOffsetX = 0;
                DeleteBasketBook();
            }
            else
            {
                gunaAdvenceButton1.ForeColor = Color.White;
                gunaAdvenceButton1.BackColor = Color.Black;
                gunaAdvenceButton1.Text = "Товар в корзине";
                gunaAdvenceButton1.ImageOffsetX = 10;
                AddBasketProduct();
            }
            changet3 = !changet3;
        }
        
        private void AddBasketProduct()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO basket (name, price) VALUES ('" + gunaLabel1.Text + "', '" + gunaLabel12.Text + "')", connection);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        private void DeleteBasketBook()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM basket WHERE name='" + gunaLabel1.Text + "'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }
        
    }
}
