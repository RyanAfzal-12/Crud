using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crud
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            productDataGridView.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string ID = idtxt.Text;
            string Title = titletxt.Text;
            string Price = pricetxt.Text;
            string Stock = stocktxt.Text;
            string company = companytxt.Text;
            string Expiry = expirytxt.Text;
            dbcon dbcon = new dbcon();
            string insert_query = "INSERT INTO ProductForm (ID, Title, Price,Stock, company,Expiry) VALUES ('" + ID + "', '" + Title + "', '" + Price + "','" + Stock + "', '" + company + "', '" + Expiry + "')";
            dbcon.Udi(insert_query);


            MessageBox.Show("Record saved successfully.");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string ID = idtxt.Text;
            string Title = titletxt.Text;
            string Price = pricetxt.Text;
            string Stock = stocktxt.Text;
            string company = companytxt.Text;
            string Expiry = expirytxt.Text;
            dbcon dbcon = new dbcon();
            string update_query = "UPDATE  ProductForm SET Title= '" + Title + "', Price='" + Price + "',Stock= '" + Stock + "', company= '" + company + "',Expiry='" + Expiry + "' WHERE ID = '" + ID + "'";
            dbcon.Udi(update_query);
            MessageBox.Show("Record Updated successfully.");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string ID = idtxt.Text;
            dbcon dbcon = new dbcon();
            string delete_query = "DELETE FROM  ProductForm WHERE ID = '" + ID + "'";
            dbcon.Udi(delete_query);
            MessageBox.Show("Record Deleted successfully.");

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Price = pricetxt.Text;
            dbcon dbcon = new dbcon();
            string select_query = "Select * from ProductForm where Price >= 700 AND Price <= 2000";
            DataTable dt = dbcon.FetchData(select_query);
            if (dt.Rows.Count == 1)
            {
                titletxt.Text = dt.Rows[0]["ID"].ToString();
                idtxt.Text = dt.Rows[0]["Price"].ToString();
                stocktxt.Text = dt.Rows[0]["Stock"].ToString();
                companytxt.Text = dt.Rows[0]["company"].ToString();
                expirytxt.Text = dt.Rows[0]["Expiry"].ToString();

            }
            else if (dt.Rows.Count > 1)
            {
                productDataGridView.AutoGenerateColumns = true;
                productDataGridView.DataSource = dt;
                productDataGridView.Visible = true;

            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string ID = idtxt.Text;
            string Title = titletxt.Text;
            string Price = pricetxt.Text;
            string Stock = stocktxt.Text;
            string company = companytxt.Text;
            string Expiry = expirytxt.Text;
            dbcon dbcon = new dbcon();
            string viewall_query = "Select * from ProductForm";
            DataTable dt = dbcon.FetchData(viewall_query);
            idtxt.Text = dt.Rows[0]["ID"].ToString();
            titletxt.Text = dt.Rows[0]["Title"].ToString();
            pricetxt.Text = dt.Rows[0]["Price"].ToString();
            stocktxt.Text = dt.Rows[0]["Stock"].ToString();
            companytxt.Text = dt.Rows[0]["company"].ToString();
            expirytxt.Text = dt.Rows[0]["Expiry"].ToString();
            productDataGridView.AutoGenerateColumns = true;
            productDataGridView.DataSource = dt;
            productDataGridView.Visible = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            idtxt.Clear();
            titletxt.Clear();
            pricetxt.Clear();
            stocktxt.Clear();
            companytxt.Clear();
            expirytxt.Clear();

        }
    }

}


