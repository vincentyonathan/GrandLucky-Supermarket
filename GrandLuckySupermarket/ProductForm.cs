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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=MSI;Initial Catalog=grandluckydb;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Product.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void fillcombo()
        {
            //Bind the combo box with Database
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CategoryName FROM CategoryTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            CatCB.ValueMember = "CategoryName";
            CatCB.DataSource = dt;
            AS.ValueMember = "CategoryName";
            AS.DataSource = dt;
            Con.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriesForm cat = new CategoriesForm();
            cat.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO ProductTable VALUES(" + ProductId.Text + ",'" + ProductName.Text + "'," + ProductQty.Text + ", "+ProductPrice.Text+", '"+CatCB.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();
                ProductId.Text = "";
                ProductName.Text = "";
                ProductQty.Text = "";
                ProductPrice.Text = "";
                CatCB.Text = "Select Category";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "")
                {
                    MessageBox.Show("Select The Product to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM ProductTable WHERE ProductId=" + ProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully.");
                    Con.Close();
                    populate();
                    ProductId.Text = "";
                    ProductName.Text = "";
                    ProductQty.Text = "";
                    ProductPrice.Text = "";
                    CatCB.Text = "Select Category";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductId.Text = Product.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = Product.SelectedRows[0].Cells[1].Value.ToString();
            ProductQty.Text = Product.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = Product.SelectedRows[0].Cells[3].Value.ToString();
            CatCB.Text = Product.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductId.Text == "" || ProductName.Text == "" || ProductQty.Text == "" ||ProductPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE ProductTable SET ProductName='" + ProductName.Text + "', ProductQty='" + ProductQty.Text + "', ProductPrice='"+ProductPrice.Text+"' WHERE ProductId = " + ProductId.Text + "";
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully.");
                    Con.Close();
                    populate();
                    ProductId.Text = "";
                    ProductName.Text = "";
                    ProductQty.Text = "";
                    ProductPrice.Text = "";
                    CatCB.Text = "Select Category";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM ProductTable WHERE ProductCategory = '" + AS.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Product.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
