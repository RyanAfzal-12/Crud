using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            customerDataGridView.Visible = false;

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string ID = idtextbox.Text;
            string Name = nametextbox.Text;
            string Cell = celltextbox.Text;
            string Email = emailtextbox.Text;
            string Address = addresstextbox.Text;
            dbcon dbcon = new dbcon();
            string insert_query = "INSERT INTO Employee (ID, Name, Cell,Email, Address) VALUES ('" + ID + "', '" + Name + "', '" + Cell + "','" + Email + "', '" + Address + "')";
            dbcon.Udi(insert_query);
            MessageBox.Show("Record Updated successfully.");


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string Name = nametextbox.Text;
            dbcon dbcon = new dbcon();
            string select_query = "Select * from Employee where  Name= '" + Name + "' ";
            DataTable dt = dbcon.FetchData(select_query);
            if (dt.Rows.Count == 1)
            {
                idtextbox.Text = dt.Rows[0]["ID"].ToString();
                nametextbox.Text = dt.Rows[0]["Name"].ToString();
                celltextbox.Text = dt.Rows[0]["Cell"].ToString();
                emailtextbox.Text = dt.Rows[0]["Email"].ToString();
                addresstextbox.Text = dt.Rows[0]["Address"].ToString();

            }
            else if (dt.Rows.Count > 1)
            {
                customerDataGridView.AutoGenerateColumns = true;
                customerDataGridView.DataSource = dt;
                customerDataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string ID = idtextbox.Text;
            string Name = nametextbox.Text;
            string Cell = celltextbox.Text;
            string Email = emailtextbox.Text;
            string Address = addresstextbox.Text;
            dbcon dbcon = new dbcon();
            string update_query = "UPDATE Employee SET  Name='" + Name + "' , Cell='" + Cell + "',Email = '" + Email + "', Address= '" + Address + "' WHERE ID = '" + ID + "'";
            dbcon.Udi(update_query);
            MessageBox.Show("Record Updated successfully.");
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            string ID = idtextbox.Text;
            dbcon dbcon = new dbcon();
            string delete_query = "DELETE FROM Employee  WHERE ID = '" + ID + "'";
            dbcon.Udi(delete_query);
            MessageBox.Show("Record Deleted successfully.");
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            string ID = idtextbox.Text;
            string Name = nametextbox.Text;
            string Cell = celltextbox.Text;
            string Email = emailtextbox.Text;
            string Address = addresstextbox.Text;
            dbcon dbcon = new dbcon();
            string viewall_query = "Select * from Employee";
            DataTable dt = dbcon.FetchData(viewall_query);
            if (dt.Rows.Count > 1)
            {
                idtextbox.Text = dt.Rows[0]["ID"].ToString();
                nametextbox.Text = dt.Rows[0]["Name"].ToString();
                celltextbox.Text = dt.Rows[0]["Cell"].ToString();
                emailtextbox.Text = dt.Rows[0]["Email"].ToString();
                addresstextbox.Text = dt.Rows[0]["Address"].ToString();
                customerDataGridView.AutoGenerateColumns = true;
                customerDataGridView.DataSource = dt;
                customerDataGridView.Visible = true;
            }


        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            idtextbox.Clear();
            nametextbox.Clear();
            celltextbox.Clear();
            emailtextbox.Clear();
            addresstextbox.Clear();
        }
    }
}

