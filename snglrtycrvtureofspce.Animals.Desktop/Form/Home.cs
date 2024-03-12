using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using snglrtycrvtureofspce.Animal.Desktop.Control;
using snglrtycrvtureofspce.Animal.Desktop.Control.ElControls;
using snglrtycrvtureofspce.Animal.Desktop.Form.Admin;
using snglrtycrvtureofspce.Animal.Desktop.Form.User;

namespace snglrtycrvtureofspce.Animal.Desktop.Form
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

        private void UserPicture_Click(object sender, EventArgs e) // User picture
        {
            UserControl1 userControl = new UserControl1();
            InfoPanel.Controls.Add(userControl);

            if (UserName.Text != "Имя")
            {
                userControl.PanelLogReg.Visible = false;
                userControl.Size = new Size(134, 45);
            }

            userControl.Location = new Point(626, 0);
            userControl.BringToFront();
        }

        private void QueryButton_Click(object sender, EventArgs e) // User table "Queries"
        {
            this.Hide();
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void ReferenceButton_Click(object sender, EventArgs e) // Reference
        {
            string referencePath = Path.Combine(Directory.GetCurrentDirectory(), "reference.chm");

            if (File.Exists(referencePath))
            {
                ProcessStartInfo psi = new ProcessStartInfo(referencePath)
                {
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Maximized
                };

                Process.Start(psi);
            }
            else
            {
                MessageBox.Show("Справочный файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // User Part

        private void AnimalTypesUserButton_Click(object sender, EventArgs e) // User table "AnimalTypes"
        {
            this.Hide();
            AnimalTypesUserForm animalTypesUserForm = new AnimalTypesUserForm();
            animalTypesUserForm.Show();
        }

        private void AnimalsUserButton_Click(object sender, EventArgs e) // User table "Animals"
        {
            this.Hide();
            AnimalsUserForm animalsUserForm = new AnimalsUserForm();
            animalsUserForm.Show();
        }

        private void LocationsUserButton_Click(object sender, EventArgs e) // User table "Locations"
        {
            this.Hide();
            LocationsUserForm locationsUserForm = new LocationsUserForm();
            locationsUserForm.Show();
        }

        private void MovementPointsUserButton_Click(object sender, EventArgs e) // User table "MovementPoints"
        {
            this.Hide();
            MovementPointsUserForm movementPointsUserForm = new MovementPointsUserForm();
            movementPointsUserForm.Show();
        }

        private void SearchUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchUserForm searchUserForm = new SearchUserForm();
            searchUserForm.Show();
        }

        // Administrative Part

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            _obj = this;

            if (InfoPanel.Controls.Count > 0)
                InfoPanel.Controls.RemoveAt(0);
            AdminControl adminControl = new AdminControl();
            InfoPanel.Controls.Add(adminControl);
            adminControl.Dock = DockStyle.Fill;
            adminControl.BringToFront();

            PrintStatisticAdmin(adminControl);
            PrintListUsersAdmin(adminControl);
        }

        private void PrintStatisticAdmin(AdminControl adminControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users", connection);
            connection.Open();
            adminControl.CountUsers.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Animals", connection);
            connection.Open();
            adminControl.CountAnimals.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();

            cmd = new SqlCommand("SELECT COUNT(*) FROM AnimalTypes", connection);
            connection.Open();
            adminControl.CountAnimalTypes.Text = "0" + cmd.ExecuteScalar().ToString();
            connection.Close();
        }

        private void PrintListUsersAdmin(AdminControl adminControl)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Users]", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            adminControl.FlowLayoutPanel.Controls.Clear();

            while (reader.Read())
            {
                ElUsersList Item = new ElUsersList();
                Item.gunaLabel1.Text = reader[1].ToString();
                Item.gunaLabel2.Text = reader[3].ToString();
                Item.gunaLabel3.Text = reader[5].ToString();
                Item.gunaLabel4.Text += reader[0].ToString();
                adminControl.FlowLayoutPanel.Controls.Add(Item);
            }
            reader.Close();
            connection.Close();
        }

        private void UsersAdminButton_Click(object sender, EventArgs e) // Admin table "Users"
        {
            this.Hide();
            UsersAdminForm usersAdminForm = new UsersAdminForm();
            usersAdminForm.Show();
        }

        private void AnimalTypesAdminButton_Click(object sender, EventArgs e) // Admin table "AnimalTypes"
        {
            this.Hide();
            AnimalTypesAdminForm animalTypesAdminForm = new AnimalTypesAdminForm();
            animalTypesAdminForm.Show();
        }

        private void AnimalsAdminButton_Click(object sender, EventArgs e) // Admin table "Animals"
        {
            this.Hide();
            AnimalsAdminForm animalsAdminForm = new AnimalsAdminForm();
            animalsAdminForm.Show();
        }

        private void LocationsAdminButton_Click(object sender, EventArgs e) // Admin table "Locations"
        {
            this.Hide();
            LocationsAdminForm locationsAdminForm = new LocationsAdminForm();
            locationsAdminForm.Show();
        }

        private void MovementPointsAdminButton_Click(object sender, EventArgs e) // Admin table "MovementPoints"
        {
            this.Hide();
            MovementPointsAdminForm movementPointsAdminForm = new MovementPointsAdminForm();
            movementPointsAdminForm.Show();
        }
    }
}