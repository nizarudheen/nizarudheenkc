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
    public partial class sales_man_view : Form
    {
        public sales_man_view()
        {
            InitializeComponent();

        }
        Classes.Db_operations op = new Classes.Db_operations();


        private void sales_man_view_Load(object sender, EventArgs e)
        {
            bind();
            gd_sl_man_view.DataSource = op.salesman_display();
        }

        private void txt_search_salesman_TextChanged(object sender, EventArgs e)
        {
           // txt_search_salesman
        }
        void bind()
        {
            txt_sales_man_search.ValueMember = "no";
            txt_sales_man_search.DisplayMember = "sl_man_name";
            txt_sales_man_search.DataSource = op.sales_man_search_compo();
        }

        private void txt_sales_man_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            gd_sl_man_view.DataSource = op.sales_man_search(txt_sales_man_search.SelectedValue);
        }
    }
}
