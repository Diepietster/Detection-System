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
    public partial class RegisterUser : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename="+Application.StartupPath+@"\Users.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        Encryption encrypt = new Encryption();

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql_statement = $"INSERT INTO Login(Username, Password, Email) VALUES(@username, @password, @email)";
                command = new SqlCommand(sql_statement, connection);
                adapter = new SqlDataAdapter();
                command.Parameters.AddWithValue("@username",txtUsername.Text);
                command.Parameters.AddWithValue("@password", encrypt.EncryptPassword(txtPassword.Text.ToString()));
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("User added.");

                this.Close();
            }
            catch (SqlException Error)
            {
                MessageBox.Show("Error adding user.");
                MessageBox.Show(Error.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
