using System;
using System.Windows.Forms;
using Service.Animals.Desktop.Form;

namespace Service.Animals.Desktop.Control
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Hide();
            SIGNin sIGNin = new SIGNin();
            sIGNin.Show();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Hide();
            SIGNup sIGNup = new SIGNup();
            sIGNup.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
