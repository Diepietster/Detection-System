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
    public partial class AddVehicle : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\VehicleDB.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;

        public AddVehicle()
        {
            InitializeComponent();
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try                                                                                                                            //Add vehicle to database, default security clearance is ALLOWED
            {
                if(txtAddVehicle.Text == "")
                {
                    MessageBox.Show("Text field can not be empty.");
                }
                else
                {
                    string sql_command = "INSERT INTO Vehicles(NumberPlate, SecurityClearance) VALUES(@numberPlate, @SecurityClearance)";

                    connection.Open();

                    command = new SqlCommand(sql_command, connection);
                    command.Parameters.AddWithValue("@numberPlate", txtAddVehicle.Text.ToString().ToUpper());
                    command.Parameters.AddWithValue("@securityClearance", "ALLOWED");
                    command.ExecuteNonQuery();


                    connection.Close();

                    MessageBox.Show("New vehicle added to database successfully...");

                    this.Close();
                }
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error Connecting to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);                //Display appropriate message if any error occurs
            }
        }
    }
}
