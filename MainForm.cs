using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Employee customer = new Employee();
            customer.Show();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            Employee customer = new Employee();
            customer.Dispose();
            Product product = new Product();
            product.Dispose();


        }
    }
}
