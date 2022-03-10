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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=MSI;Initial Catalog=grandluckydb;Integrated Security=True");
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO CategoryTable VALUES(" + CategoryIDTb.Text + ",'" + CategoryNameTb.Text + "','" + CategoryDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
                CategoryIDTb.Text = "";
                CategoryNameTb.Text = "";
                CategoryDescTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM CategoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryIDTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CategoryDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if(CategoryIDTb.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM CategoryTable WHERE CategoryID=" + CategoryIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully.");
                    Con.Close();
                    populate();
                    CategoryIDTb.Text = "";
                    CategoryNameTb.Text = "";
                    CategoryDescTb.Text = "";
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
                if(CategoryIDTb.Text == "" || CategoryNameTb.Text =="" || CategoryDescTb.Text =="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE CategoryTable SET CategoryName='" + CategoryNameTb.Text + "', CategoryDesc='" + CategoryDescTb.Text + "' WHERE CategoryID = " + CategoryIDTb.Text + "";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully.");
                    Con.Close();
                    populate();
                    CategoryIDTb.Text = "";
                    CategoryNameTb.Text = "";
                    CategoryDescTb.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerForm seller = new SellerForm();
            seller.Show();
        }
    }
}
