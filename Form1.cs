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
    public partial class Form1 : Form
    {       
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + @"\Users.mdf;Integrated Security=True");
        SqlCommand command;
        int login_attempt = 5;
        Encryption encrypt = new Encryption();
        Email email = new Email();  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            menuStrip.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql_command = @"SELECT COUNT (*) AS CNT FROM Login WHERE Username = @username AND Password = @password";
            Authenticate(sql_command);
        }

        public void Authenticate(string sql_command)                                                                                                           //Create a function to authenticate system user 
        {
            try                                                                                                                                                //Use Try-Catch block to catch any errors connecting to the database, or using sql-commands
            {
                if (login_attempt == 1)
                {
                    email.SendEmailAlert("Password Authentication Failed!!!");
                    MessageBox.Show("Failed to authenticate");
                    Application.Exit();

                }

                command = new SqlCommand(sql_command, conn);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                conn.Open();

                if (command.ExecuteScalar().ToString() == "1")                                                                                                 //Use if statement to verify user authentication
                {
                    MessageBox.Show("Welcome " + txtUsername.Text.ToString() + " !");

                    menuStrip.Show();
                    grpLogin.Hide();

                }
                else
                {
                    MessageBox.Show("Access denied...");
                    --login_attempt;
                    lblLoginAttempt.Text = ("You have only " + login_attempt.ToString() + " attempts left to try.");

                }

                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show("Error connecting to database...", error.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);                                 //Display appropriate error message to the user
            }
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchVehicle vehicle = new SearchVehicle();
            vehicle.MdiParent = this;
            vehicle.Show();
        }

        private void addVehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddVehicle vehicle = new AddVehicle();
            vehicle.MdiParent= this;
            vehicle.Show();
        }

        private void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteVehicle vehicle = new DeleteVehicle();
            vehicle.MdiParent = this;
            vehicle.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser user = new RegisterUser();
            user.MdiParent = this;
            user.Show();
        }

        private void detectNumberPlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detection detection = new Detection();
            detection.MdiParent = this;
            detection.Show();
        }
    }
}
