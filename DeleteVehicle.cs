using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vehicle_Number_Plate_Detection
{
    public partial class DeleteVehicle : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\VehicleDB.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataset;
        const string DEFAULT_STATEMENT = @"SELECT * FROM Vehicles";

        public DeleteVehicle()
        {
            InitializeComponent();
        }

        private void DeleteVehicle_Load(object sender, EventArgs e)
        {
            DisplayAllVehicles(DEFAULT_STATEMENT);
            txtDeletevehicle.Focus();
        }

        public void DisplayAllVehicles(string sql_statement)                                                                               //Create a function that receives an sql statement 
        {                                                                                                                                  //and displays data from database to datagridview box
            try
            {
                connection.Open();

                command = new SqlCommand(sql_statement, connection);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Vehicles");

                dataGrid.DataSource = dataset;
                dataGrid.DataMember = "Vehicles";

                connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error Connecting to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);                //Display appropriate message if any error occurs
            }
        }

        private void txtDeletevehicle_TextChanged(object sender, EventArgs e)
        {
            string sql_statement = "SELECT * FROM Vehicles WHERE NumberPlate LIKE '%" + txtDeletevehicle.Text.ToUpper() + "%' ";
            DisplayAllVehicles(sql_statement);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql_statement = "DELETE FROM Vehicles WHERE NumberPlate LIKE '%" + txtDeletevehicle.Text.ToUpper() + "%' ";
                command = new SqlCommand(sql_statement,connection);
                adapter = new SqlDataAdapter();               
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Record Deleted Successfully!");

                DisplayAllVehicles(DEFAULT_STATEMENT);

                txtDeletevehicle.Text = "";
                txtDeletevehicle.Focus();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error Connecting to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);                //Display appropriate message if any error occurs
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
