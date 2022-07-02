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
using System.IO;
using Patagames.Ocr;

namespace Vehicle_Number_Plate_Detection
{
    public partial class Detection : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\VehicleDB.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataset;
        SqlDataReader reader;
        const string DEFAULT_STATEMENT = @"SELECT * FROM Vehicles";

        Email email = new Email();

        public Detection()
        {
            InitializeComponent();
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

                dataGridAuthenticate.DataSource = dataset;
                dataGridAuthenticate.DataMember = "Vehicles";

                connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error Connecting to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);                //Display appropriate message if any error occurs
            }
        }
        private void Detection_Load(object sender, EventArgs e)
        {
            DisplayAllVehicles(DEFAULT_STATEMENT);
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            string sql_statement = "SELECT * FROM Vehicles WHERE NumberPlate='" + txtAuthenticate.Text.ToUpper().Replace(" ", "") + "'";
            Authenticate(sql_statement);

            txtAuthenticate.Text = "";
            txtAuthenticate.Focus();

            DisplayAllVehicles(DEFAULT_STATEMENT);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            string photopath;
            byte[] binaryPhoto;                                                                                                            //Create byte array

            OpenFileDialog file =  new OpenFileDialog();
            file.Filter = "jpg|*.jpg|png|*.png|Jpegs|*.Jpegs";
            file.Title = "Please select an image";

            if(file.ShowDialog() == DialogResult.OK)                                                                                       //Use OpenFileDialog so the user can select which image to upload 
            {
                picUpload.Image = new Bitmap(file.OpenFile());                                                                             //Upload selected image to picture box
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read); 
                BinaryReader br = new BinaryReader(fs);
                binaryPhoto = br.ReadBytes((int)fs.Length);
                fs.Close();

                picUpload.ImageLocation = photopath;

                using(var objOcr = OcrApi.Create())
                {
                    objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                    string numberPlate = objOcr.GetTextFromImage(picUpload.ImageLocation);
                    numberPlate = numberPlate.ToUpper().Replace(" ", "");

                    MessageBox.Show(numberPlate);

                    string sql_statement = $"SELECT * FROM Vehicles WHERE NumberPlate LIKE '%{numberPlate}%'";
                    Authenticate(sql_statement);

                    DisplayAllVehicles(DEFAULT_STATEMENT);

                }
            }

        }

        public void Authenticate(string sql_statement)
        {
            try                                                                                                                            //Use try catch block to catch any errors
            {
                string securityClearance;
                DisplayAllVehicles(sql_statement);

                connection.Open();

                command = new SqlCommand(sql_statement, connection);
                reader = command.ExecuteReader();                                                                                          //Use data reader to read through objects in database

                while (reader.Read())                                                                                                       //Use while loop to loop through database and to assign securityClearance value
                {
                    securityClearance = reader.GetValue(1).ToString();

                    if (securityClearance == "ALLOWED")
                    {
                        MessageBox.Show("Vehicle is granted access");
                    }
                    else
                    {                                                                                                                      //If vehicle is stolen email appropriate people
                        email.SendEmailAlert("STOLEN Vehicle reported at detection bay. Vehicle number plate " + reader.GetValue(0).ToString());
                        MessageBox.Show("Access denied, stolen vehicle has been reported to authorities via email.");
                    }
                }

                connection.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "Error Connecting to Database", MessageBoxButtons.OK, MessageBoxIcon.Error);                //Display appropriate message if any error occurs
            }
        }
    }
}
