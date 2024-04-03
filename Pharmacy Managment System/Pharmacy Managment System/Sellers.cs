﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy_Managment_System
{
    public partial class Sellers : Form
    {
        public Sellers()
        {
            InitializeComponent();
            ShowSeller();
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

        private void btnMedichines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            this.Hide();
            Obj.Show();
        }

        private void GoMedichines_Click(object sender, EventArgs e)
        {
            Medicines Obj = new Medicines();
            this.Hide();
            Obj.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            this.Hide();
            Obj.Show();
        }

        private void GoCustomers_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            this.Hide();
            Obj.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling Obj = new Selling();
            this.Hide();
            Obj.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowSeller()
        {
            Con.Open();
            string Query = "Sellect * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVSellers.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtSellerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtGender.SelectedIndex = 0;
            txtPassword.Text = "";
            Key = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSellerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtGender.SelectedIndex == -1 || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into  SellerTbl(SellerName,SellerAddress,SellerMobilNo,SellerDOB,SellerGender,SellerPassword)values(@SN,@SA,@SMN,@SD,@SG,@SP)", Con);
                    cmd.Parameters.AddWithValue("@SN", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@SMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@SD", txtDOB.Text);
                    cmd.Parameters.AddWithValue("@SG", txtGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SP", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Added SuccessFuly");
                    Con.Close();
                    ShowSeller();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void DGVSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSellerName.Text = DGVSellers.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = DGVSellers.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = DGVSellers.SelectedRows[0].Cells[3].Value.ToString();
            txtDOB.Text = DGVSellers.SelectedRows[0].Cells[4].Value.ToString();
            txtGender.SelectedItem = DGVSellers.SelectedRows[0].Cells[5].Value.ToString();
            txtPassword.Text = DGVSellers.SelectedRows[0].Cells[2].Value.ToString();
            if (txtSellerName.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(DGVSellers.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Seller");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from SellerTbl where SellerId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    ShowSeller();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSellerName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtGender.SelectedIndex == -1 || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into  SellerTbl(SellerName,SellerAddress,SellerMobilNo,SellerDOB,SellerGender,SellerPassword)values(@SN,@SA,@SMN,@SD,@SG,@SP)", Con);
                    cmd.Parameters.AddWithValue("@SN", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SA", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@SMN", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@SD", txtDOB.Text);
                    cmd.Parameters.AddWithValue("@SG", txtGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SP", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Added SuccessFuly");
                    Con.Close();
                    ShowSeller();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void Sellers_Load(object sender, EventArgs e)
        {

        }
    }
}
