using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class sales_details : Form
    {
        public sales_details()
        {
            InitializeComponent();
        }
        Classes.Db_Variables var = new Classes.Db_Variables();
        Classes.Db_operations opr = new Classes.Db_operations();

        private void txt_item_name_TextChanged(object sender, EventArgs e)
        {
          //  var.item_name = txt_item_name.Text;
          gd_sales.DataSource= opr.sales_display(txt_item_name.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
