using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Managment_System
{
    public partial class Login : Form
    {
        private static string User;
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Pharmacy Managment System\Pharmacy Managment System\PharmacyDB.mdf;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin Obj = new Admin();
            this.Hide();
            Obj.Show();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text==""||txtPassword.Text=="")
            {
                MessageBox.Show("Enter Username and Password to Login");
                
            }

            try
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM SellerTbl WHERE SellerName=@UserName AND SellerPassword=@Password";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    User = txtUserName.Text;
                    Selling Obj = new Selling();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have entered wrong Username and Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
