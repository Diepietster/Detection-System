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
    public partial class SearchVehicle : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\VehicleDB.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataset;
        const string DEFAULT_STATEMENT = @"SELECT * FROM Vehicles";

        public SearchVehicle()
        {
            InitializeComponent();
        }

        public void DisplayAllVehicles(string sql_statement)                                                                               //Create a function that receives an sql statement 
        {                                                                                                                                  //and displays data from database to datagridview box
            try
            {
                connection.Open();

                command = new SqlCommand(sql_statement,connection);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();    

                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Vehicles");

                dataGridSearch.DataSource = dataset;
                dataGridSearch.DataMember = "Vehicles";

                connection.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message, "Error Connecting to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);                //Display appropriate message if any error occurs
            }
        }

        private void SearchVehicle_Load(object sender, EventArgs e)
        {
            DisplayAllVehicles(DEFAULT_STATEMENT);          
        }

        private void txtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            string sql_statement = @"SELECT * FROM Vehicles WHERE NumberPlate LIKE '%"+txtSearchVehicle.Text.ToUpper()+"%'";               //Filter through database as you type
            DisplayAllVehicles(sql_statement);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                                                                                                                  //Close this form
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql_statement;

            if (chckAllowed.Checked && chckStolen.Checked)
            {
                MessageBox.Show("Invalid Request...Please select only one option.");
            }
            else if(chckAllowed.Checked)
            {
                sql_statement = @"SELECT * FROM Vehicles WHERE SecurityClearance = 'ALLOWED'";
                DisplayAllVehicles(sql_statement);
            }
            else if(chckStolen.Checked)
            {
                sql_statement = @"SELECT * FROM Vehicles WHERE SecurityClearance = 'STOLEN'";
                DisplayAllVehicles(sql_statement);
            }
            else
            {
                MessageBox.Show("Please select one option provided.");
                DisplayAllVehicles(DEFAULT_STATEMENT);
            }
             
        }
    }
}
