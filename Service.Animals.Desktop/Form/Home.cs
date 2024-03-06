using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Service.Animals.Desktop.Control;
using Service.Animals.Desktop.Control.ElControls;
using Service.Animals.Desktop.Form.Admin;

namespace Service.Animals.Desktop.Form
{
    public partial class Home : System.Windows.Forms.Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public Home()
        {
            InitializeComponent();
            _obj = this;
            this.ActiveControl = logo;
        }

        static Home _obj;
        public static Home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Home();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return InfoPanel; }
            set { InfoPanel = value; }
        }

        public Guna.UI.WinForms.GunaPanel PnlAdmin
        {
            get { return AdminPanel; }
            set { AdminPanel = value; }
        }

        public Guna.UI.WinForms.GunaLabel PnlLableUser
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public Guna.UI.WinForms.GunaPanel PnlBasket
        {
            get { return gunaPanel1; }
            set { gunaPanel1 = value; }
        }

        Point lastPoint;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = logo;
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }        

        //--------------------------------- Заказы
        private void btnOrder_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            OrderControl orderControl = new OrderControl();
            InfoPanel.Controls.Add(orderControl);
            orderControl.Dock = DockStyle.Fill;
            orderControl.BringToFront();
            PrintOrder(orderControl);
        }

        private void PrintOrder(OrderControl orderControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tickets]", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Random random = new Random();

            orderControl.flowLayoutPanel1.Controls.Clear();
            while (reader.Read())
            {
                ElOrderList Item = new ElOrderList();
                Item.gunaLabel1.Text = reader[5].ToString();
                Item.gunaLabel2.Text = reader[4].ToString();
                Item.gunaLabel4.Text += random.Next(1, 1500).ToString();
                Item.Size = new Size(709, 36);

                orderControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        //-------------------------------- Билеты
        private void PrintTickets(ProductControl productControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ElProduct Item = new ElProduct();

                Item.SeatType.Text = reader[5].ToString();

                productControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void sellTicketsButton_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            ProductControl productControl = new ProductControl();
            InfoPanel.Controls.Add(productControl);
            productControl.Dock = DockStyle.Fill;
            productControl.BringToFront();

            PrintTickets(productControl);
        }

        //------------------------------------------ Корзина
        private void btnBasket_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            BasketControl basketControl = new BasketControl();
            InfoPanel.Controls.Add(basketControl);
            basketControl.Dock = DockStyle.Fill;
            basketControl.BringToFront();

            PrintBasket(basketControl);
            CountBasket(basketControl);
        }

        private void CountBasket(BasketControl basketControl)
        {
            /*SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM basket", connection);
            connection.Open();
            basketControl.gunaLabel5.Text = "Итого: " + cmd.ExecuteScalar().ToString() + " билетов";
            connection.Close();*/
        }

        private void PrintBasket(BasketControl basketControl)
        {
            /*SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM basket", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ElBasketList Item = new ElBasketList();

                Item.gunaLabel1.Text = reader[0].ToString();
                Item.gunaLabel2.Text = reader[1].ToString();
                basketControl.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();*/
        }

        private void UserPicture_Click(object sender, EventArgs e)
        {
            Control.UserControl1 userControl = new Control.UserControl1();
            InfoPanel.Controls.Add(userControl);

            if (UserName.Text != "Имя")
            {
                userControl.PanelLogReg.Visible = false;
                userControl.Size = new Size(134, 45);
            }

            userControl.Location = new Point(626, 0);
            userControl.BringToFront();
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.Show();
        }

        private void crewButton_Click(object sender, EventArgs e) // форма экипажа
        {
            this.Hide();
            CrewForm crewForm = new CrewForm();
            crewForm.Show();
        }

        private void ticketsButton_Click(object sender, EventArgs e) // форма билетов
        {
            this.Hide();
            TicketsForm ticketsForm = new TicketsForm();
            ticketsForm.Show();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void airplanesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirplanesForm airplanesForm = new AirplanesForm();
            airplanesForm.Show();
        }

        private void ReferenceButton_Click(object sender, EventArgs e) // Reference
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\reference.chm");
        }

        // User Part



        // Administrative Part

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            AdminControl adminControl1 = new AdminControl();
            InfoPanel.Controls.Add(adminControl1);
            adminControl1.Dock = DockStyle.Fill;
            adminControl1.BringToFront();

            PrintListUserAdmin(adminControl1);
            /*PrintListProductAdmin(adminControl1);*/
            PrintStatisticAdmin(adminControl1);
        }

        private void PrintStatisticAdmin(AdminControl adminControl1)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            /*SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tickets", connection);
            connection.Open();
            adminControl1.CountTickets.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Tickets", connection);
            connection.Open();
            adminControl1.CountBuyTickets.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();*/

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users", connection);
            connection.Open();
            adminControl1.CountUsers.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();
        }

        private void PrintListProductAdmin(AdminControl adminControl1)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Tickets]", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            adminControl1.flowLayoutPanel1.Controls.Clear();

            while (reader.Read())
            {
                ElProductList Item = new ElProductList();
                Item.gunaLabel1.Text = reader[5].ToString();
                Item.gunaLabel2.Text = reader[3].ToString();
                Item.gunaLabel3.Text = reader[4].ToString();
                Item.gunaLabel4.Text += reader[0].ToString();
                adminControl1.flowLayoutPanel1.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void PrintListUserAdmin(AdminControl adminControl1)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", connection);

            // SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Tickets", connection);
            // var temp = cmd2.ExecuteScalar().ToString();

            SqlDataReader reader = cmd.ExecuteReader();
            adminControl1.flowLayoutPanel3.Controls.Clear();
            while (reader.Read())
            {
                ElUserList Item = new ElUserList();
                Item.gunaLabel1.Text += reader[3].ToString();
                Item.gunaLabel3.Text += reader[1].ToString();
                Item.gunaLabel4.Text += reader[5].ToString();
                // Item.gunaLabel2.Text += temp.ToString();
                adminControl1.flowLayoutPanel3.Controls.Add(Item);
            }

            reader.Close();
            connection.Close();
        }

        private void AnimalTypesAdminButton_Click(object sender, EventArgs e) // Table "AnimalTypes"
        {
            this.Hide();
            AnimalTypesAdminForm animalTypesAdminForm = new AnimalTypesAdminForm();
            animalTypesAdminForm.Show();
        }

        private void AnimalsAdminButton_Click(object sender, EventArgs e) // Table "Animals"
        {
            this.Hide();
            AnimalsAdminForm animalsAdminForm = new AnimalsAdminForm();
            animalsAdminForm.Show();
        }

        private void LocationsAdminButton_Click(object sender, EventArgs e) // Table "Locations"
        {
            this.Hide();
            LocationsAdminForm locationsAdminForm = new LocationsAdminForm();
            locationsAdminForm.Show();
        }

        private void MovementPointsAdminButton_Click(object sender, EventArgs e) // Table "MovementPoints"
        {
            this.Hide();
            MovementPointsAdminForm movementPointsAdminForm = new MovementPointsAdminForm();
            movementPointsAdminForm.Show();
        }

        private void UsersAdminButton_Click(object sender, EventArgs e) // Table "Users"
        {
            this.Hide();
            UsersAdminForm usersAdminForm = new UsersAdminForm();
            usersAdminForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            /*SqlConnection connection = new SqlConnection(_connectionString);
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
            }*/
        }
    }
}