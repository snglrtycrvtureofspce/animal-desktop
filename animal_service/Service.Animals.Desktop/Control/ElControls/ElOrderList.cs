using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Control.ElControls
{
    public partial class ElOrderList : UserControl
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public ElOrderList()
        {
            InitializeComponent();
        }
    }
}
