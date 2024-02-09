using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form
{
    public partial class AddProduct : System.Windows.Forms.Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) // кнопка закрыть
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
        }
    }
}
