using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Service.Animals.Desktop.Form
{
    public partial class QueryForm : System.Windows.Forms.Form
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings
            ["connectionString"].ConnectionString;

        public QueryForm()
        {
            InitializeComponent();
        }

        private void query1Button_Click(object sender, EventArgs e)
            // Определить расчётное время полета по всем маршрутам
        {
            string query = "SELECT FlightID, Distance, Speed " +
                           "FROM Flights " +
                           "INNER JOIN Airplanes " +
                           "ON Flights.AirplaneID = Airplanes.AirplaneID";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            DataTable result = new DataTable();
            result.Columns.Add("FlightID", typeof(int));
            result.Columns.Add("FlightTime", typeof(double));

            foreach (DataRow row in dt.Rows)
            {
                var flightTime2 = Convert.ToDouble(row["Distance"]) / Convert.ToDouble(row["Speed"]);
                result.Rows.Add(row["FlightID"], flightTime2);
            }

            queryDataGridView.DataSource = result;
        }

        private void query2Button_Click(object sender, EventArgs e)
            // Определить расход топлива по всем маршрутам
        {
            string query = "SELECT FlightID, Distance, Airplanes.FuelConsumption " +
                           "FROM Flights " +
                           "INNER JOIN Airplanes " +
                           "ON Flights.AirplaneID = Airplanes.AirplaneID";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            DataTable result = new DataTable();
            result.Columns.Add("FlightID", typeof(int));
            result.Columns.Add("FuelConsumption", typeof(double));

            foreach (DataRow row in dt.Rows)
            {
                var fuelConsumption = Convert.ToDouble(row["Distance"]) * Convert.ToDouble(row["FuelConsumption"]);
                result.Rows.Add(row["FlightID"], fuelConsumption);
            }

            queryDataGridView.DataSource = result;
        }

        private void query3Button_Click(object sender, EventArgs e)
            // Вывести экипаж, совершивший максимальное количество полетов
            // за прошедшую неделю
        {
            string query = "SELECT TOP 1 cm.FullName AS CrewName, COUNT(f.FlightID) AS FlightsCount " +
                           "FROM Crew c " +
                           "INNER JOIN CrewMember cm ON c.CrewMemberID = cm.CrewMemberID " +
                           "INNER JOIN Flights f ON c.FlightsID = f.FlightID " +
                           "WHERE f.DepartureDate BETWEEN DATEADD(DAY, -7, GETDATE()) AND GETDATE() " +
                           "GROUP BY cm.FullName " +
                           "ORDER BY COUNT(f.FlightID) DESC";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            queryDataGridView.DataSource = dt;
        }

        private void query4Button_Click(object sender, EventArgs e)
            // Вывести данные о том, сколько свободных мест оставалось в
            // самолетах, совершавших полет по одному из рейсов за вчерашний день
        {
            string query = "SELECT Flights.FlightID, Airplanes.NumberOfSeats - COUNT(Tickets.PassengerID) AS FreeSeats " +
                           "FROM Flights " +
                           "INNER JOIN Airplanes ON Flights.AirplaneID = Airplanes.AirplaneID " +
                           "LEFT JOIN Tickets ON Flights.FlightID = Tickets.FlightID " +
                           "WHERE Flights.DepartureDate = DATEADD(day, -1, GETDATE()) " +
                           "GROUP BY Flights.FlightID, Airplanes.NumberOfSeats";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                queryDataGridView.DataSource = dt;
            }
        }

        private void query5Button_Click(object sender, EventArgs e)
            // Рассчитать убытки компании за счет непроданных билетов за вчерашний день
        {
            string query = "SELECT SUM(TicketPrice) AS Losses " +
                           "FROM Tickets " +
                           "INNER JOIN Flights " +
                           "ON Tickets.FlightID = Flights.FlightID " +
                           "WHERE DepartureDate = DATEADD(DAY, -1, GETDATE())";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            queryDataGridView.DataSource = dt;
        }

        private void query6Button_Click(object sender, EventArgs e)
            // Вывести список самолетов, которые не ремонтировались в течение более чем 3 лет
        {
            string query = "SELECT * FROM Airplanes WHERE LastRepairDate < DATEADD(YEAR, -3, GETDATE())";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            queryDataGridView.DataSource = dt;
        }

        private void query7Button_Click(object sender, EventArgs e)
            // Определить каким количеством самолетов каждого типа владеет компания
        {
            string query = "SELECT Type, COUNT(*) AS NumberOfAirplanes FROM Airplanes GROUP BY Type";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            queryDataGridView.DataSource = dt;
        }

        private void query8Button_Click(object sender, EventArgs e)
            // Определить средний “возраст” самолетов компании
        {
            string query = "SELECT AVG(DATEDIFF(YEAR, ManufactureDate, GETDATE())) AS AverageAge FROM Airplanes";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }

            queryDataGridView.DataSource = dt;
        }

        private void QueryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}