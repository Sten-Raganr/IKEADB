using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    
namespace IKEADB
{
    public partial class Form1 : Form
    {
        string connectionStrings;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionStrings = ConfigurationManager.ConnectionStrings["IKEADB.Properties.Settings.IkeaConnectionString"].ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRoomsTable();
        }
        private void PopulateRoomsTable()
        {
            using (connection = new SqlConnection(connectionStrings))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Room", connection))
            {
                DataTable RoomTable = new DataTable();
                adapter.Fill(RoomTable);

                ListOFRoooms.DisplayMember = "RoomName";
                ListOFRoooms.ValueMember = "Id";
                ListOFRoooms.DataSource = RoomTable;
            }
        }

        private void ListOFRoooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSeriesTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void PopulateSeriesTable()
        {
            string query = "SELECT Series.SeriesName,Room.RoomName FROM Room INNER JOIN Series ON Series.RoomId = Room.Id WHERE Room.Id = @RoomId";
             using (connection = new SqlConnection(connectionStrings))
             using (SqlCommand command = new SqlCommand (query, connection))
             using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RoomId", ListOFRoooms.SelectedValue);
                DataTable Seriesestable = new DataTable();
                adapter.Fill(Seriesestable);

                Serieses.DisplayMember = "Seriesname";
                Serieses.ValueMember = "Id";
                Serieses.DataSource = Seriesestable;
            }
        }
    }
}
