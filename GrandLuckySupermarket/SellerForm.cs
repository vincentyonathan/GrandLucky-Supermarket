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

namespace GrandLuckySupermarket
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=MSI;Initial Catalog=grandluckydb;Integrated Security=True");
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerId.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellerName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellerAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellerPassword.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM SellerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO SellerTable VALUES(" + SellerId.Text + ",'" + SellerName.Text + "','" + SellerAge.Text + "' , '"+SellerPhone.Text+"' , '"+SellerPassword.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Con.Close();
                populate();
                SellerId.Text = "";
                SellerName.Text = "";
                SellerAge.Text = "";
                SellerPhone.Text = "";
                SellerPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerId.Text == "")
                {
                    MessageBox.Show("Select The Seller to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM SellerTable WHERE SellerId="+SellerId.Text+"";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully.");
                    Con.Close();
                    populate();
                    SellerId.Text = "";
                    SellerName.Text = "";
                    SellerAge.Text = "";
                    SellerPhone.Text = "";
                    SellerPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerId.Text == "" || SellerName.Text == "" || SellerAge.Text == "" || SellerPhone.Text == "" || SellerPassword.Text =="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE SellerTable SET SellerName='" + SellerName.Text + "', SellerAge='" + SellerAge.Text + "', SellerPhone = '"+SellerPhone.Text+"', SellerPassword = '"+SellerPassword.Text+"' WHERE SellerId = " + SellerId.Text + "";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated Successfully.");
                    Con.Close();
                    populate();
                    SellerId.Text = "";
                    SellerName.Text = "";
                    SellerAge.Text = "";
                    SellerPhone.Text = "";
                    SellerPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm cat = new CategoriesForm();
            cat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm prod = new ProductForm();
            prod.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
