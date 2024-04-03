using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Managment_System
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            ShowCustomer();
        }

        private readonly SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Pharmacy Managment System\Pharmacy Managment System\PharmacyDB.mdf;Integrated Security=True");

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            this.Hide();
            Obj.Show();
        }

        private void GoDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            this.Hide();
            Obj.Show();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer Obj = new Manufacturer();
            this.Hide();
            Obj.Show();
        }

        private void GoManufacturer_Click(object sender, EventArgs e)
        {
            Manufacturer Obj = new Manufacturer();
            this.Hide();
            Obj.Show();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            this.Hide();
            Obj.Show();
        }

        private void GoMedicines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            this.Hide();
            Obj.Show();
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Sellers Obj = new Sellers();
            this.Hide();
            Obj.Show();
        }

        private void GoSellers_Click(object sender, EventArgs e)
        {
            Sellers Obj = new Sellers();
            this.Hide();
            Obj.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling Obj = new Selling();
            this.Hide();
            Obj.Show();
        }

        private void GoSelling_Click(object sender, EventArgs e)
        {
            Selling Obj = new Selling();
            this.Hide();
            Obj.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            this.Hide();
            Obj.Show();
        }

        private void GoLogout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            this.Hide();
            Obj.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowCustomer()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM CustomerTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                var ds = new DataSet();
                sda.Fill(ds);
                DGVCustomer.DataSource = ds.Tables[0];
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

        private void Reset()
        {
            txtCustomersName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtGender.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomersName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtMobileNo.Text) || txtGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl (CustomerName, CustomerAddress, CustomerMobileNo, CustomerGender) VALUES (@Name, @Address, @MobileNo, @Gender)", Con);
                cmd.Parameters.AddWithValue("@Name", txtCustomersName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");
                ShowCustomer();
                Reset();
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

        private int Key = 0;

        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCustomer.Rows[e.RowIndex];
                txtCustomersName.Text = row.Cells["CustomerName"].Value.ToString();
                txtAddress.Text = row.Cells["CustomerAddress"].Value.ToString();
                txtMobileNo.Text = row.Cells["CustomerMobileNo"].Value.ToString();
                txtDOB.Text = row.Cells["CustomerDOB"].Value.ToString();
                txtGender.SelectedItem = row.Cells["CustomerGender"].Value.ToString();
                if (string.IsNullOrEmpty(txtCustomersName.Text))
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells["CustomerId"].Value);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the customer");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE CustomerId = @CKey", Con);
                cmd.Parameters.AddWithValue("@CKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted successfully");
                ShowCustomer();
                Reset();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomersName.Text) || string.IsNullOrEmpty(txtAddress.Text) || txtGender.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CustomerName=@Name, CustomerAddress=@Address, CustomerMobileNo=@MobileNo, CustomerGender=@Gender WHERE CustomerId=@CKey", Con);
                cmd.Parameters.AddWithValue("@Name", txtCustomersName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@CKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully");
                ShowCustomer();
                Reset();
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
