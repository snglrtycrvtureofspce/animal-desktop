using System;
using System.Drawing;
using System.Data.SqlClient;
using snglrtycrvtureofspce.Animal.Desktop.Form;

namespace snglrtycrvtureofspce.Animal.Desktop
{
    public partial class SIGNup : System.Windows.Forms.Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public SIGNup()
        {
            InitializeComponent();
            this.ActiveControl = Label;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Имя")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                TextBoxName.Text = "Имя";
                TextBoxName.ForeColor = Color.Gray;
            }
        }

        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "Почта")
            {
                TextBoxEmail.Text = "";
                TextBoxEmail.ForeColor = Color.Black;
            }
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "")
            {
                TextBoxEmail.Text = "В";
                TextBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "Имя пользователя")
            {
                TextBoxUsername.Text = "";
                TextBoxUsername.ForeColor = Color.Black;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "")
            {
                TextBoxUsername.Text = "Имя пользователя";
                TextBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Пароль")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Пароль";
                TextBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void BtnSignUP_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                if (TextBoxName.Text != "Имя" && TextBoxEmail.Text != "Почта" && TextBoxUsername.Text != "Имя пользователя" && TextBoxPassword.Text != "Пароль")
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Name, Email, Age) " +
                                "VALUES (@Username, @Password, @Name, @Email, @Age)", connection);
                    cmd.Parameters.AddWithValue("@Username", TextBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", TextBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@Name", TextBoxName.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@Age", 0);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();   

                    this.Hide();
                    SIGNin sIGNin = new SIGNin();
                    sIGNin.Show();
                }
                else
                {
                    if (TextBoxName.Text == "Имя")
                        TextBoxName.BorderColor = Color.Red;
                    if (TextBoxEmail.Text == "Почта")
                        TextBoxEmail.BorderColor = Color.Red;
                    if (TextBoxPassword.Text == "Пароль")
                        TextBoxPassword.BorderColor = Color.Red;
                    if (TextBoxUsername.Text == "Имя пользователя")
                        TextBoxUsername.BorderColor = Color.Red;
                    panelInfo.Visible = true;
                    labelMessenge.ForeColor = Color.Red;
                    labelMessenge.Text = "Есть пустые поля";
                }
            }
            catch
            {
                panelInfo.Visible = true;
                labelMessenge.ForeColor = Color.Red;
                labelMessenge.Text = "Пользователь уже зарегестрирован!";
                connection.Close();
            }
        }

        private void LabelSignIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            SIGNin sIGNin = new SIGNin();
            sIGNin.Show();
        }
    }
}
