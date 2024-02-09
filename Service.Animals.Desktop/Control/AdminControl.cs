using System;
using System.Windows.Forms;
using Service.Animals.Desktop.Form;

namespace Service.Animals.Desktop.Control
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }
    }
}
