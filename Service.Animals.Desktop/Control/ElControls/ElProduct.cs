using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Service.Animals.Desktop.Form;

namespace Service.Animals.Desktop.Control.ElControls
{
    public partial class ElProduct : UserControl
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public ElProduct()
        {
            InitializeComponent();
        }

        private void ElProduct_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Tickets] WHERE SeatType='" + this.SeatType.Text + "'", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                InfoProductControl infoproductControl = new InfoProductControl();
                if (Home.Instance.PnlLableUser.Visible == true) { infoproductControl.gunaAdvenceButton1.Visible = true; }
                Home.Instance.PnlContainer.Controls.Add(infoproductControl);
                if (Home.Instance.PnlLableUser.Visible == true) { infoproductControl.gunaAdvenceButton1.Visible = true; }

                while (reader.Read())
                {
                    infoproductControl.gunaLabel1.Text = reader[5].ToString(); // название товара
                    infoproductControl.gunaLabel2.Text = reader[4].ToString(); // категория
                    infoproductControl.gunaLabel5.Text = reader[0].ToString(); // №
                    infoproductControl.gunaLabel12.Text = reader[3] + " руб."; // цена
                }
                
                infoproductControl.Dock = DockStyle.Fill;
                Home.Instance.PnlContainer.Controls["InfoProductControl"].BringToFront();
                reader.Close();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }
    }
}
