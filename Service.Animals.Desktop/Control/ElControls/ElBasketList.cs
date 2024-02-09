using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Control.ElControls
{
    public partial class ElBasketList : UserControl
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public ElBasketList()
        {
            InitializeComponent();
        }

        private void btnDeleteSoonFilm_Click(object sender, EventArgs e)
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
