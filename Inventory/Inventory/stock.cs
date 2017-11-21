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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr = new Classes.Db_operations();
       
        private void stock_Load(object sender, EventArgs e)
        {
            gd_stock_view.DataSource = opr.stock_details();
            stock_color();
        }
        public void stock_color()
        {
            int a;
            for (int i = 0; i <= gd_stock_view.Rows.Count; i++)
            {

                a = Convert.ToInt32(gd_stock_view.Rows[i].Cells[8].Value);
                if (a <= 3)
                {
                    gd_stock_view.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    gd_stock_view.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txt_stock_search_TextChanged(object sender, EventArgs e)
        {
            gd_stock_view.DataSource = opr.stock_search(txt_stock_search.Text);
        }

        private void gd_stock_view_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    
    
    }
}
