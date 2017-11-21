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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        Classes.Db_Variables v = new Classes.Db_Variables();
        Classes.Db_operations db_oprt = new Classes.Db_operations();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cstmr_name.Text == "")
            {
                MessageBox.Show("Please enter name");
                return;

            }
            else
            {
                v.customer_name = txt_cstmr_name.Text;
            }
            v.customer_id = Convert.ToInt32(txt_cstmr_id.Text);
            if (txt_cstmr_address.Text == "")
            {
                v.address = "";
            }
            else
            {
                v.address = txt_cstmr_address.Text;
            }
            if (txt_mobile.Text == "")
            {
                v.mob = "";
            }
            else
            {
                v.mob = txt_mobile.Text;
            }

            if (txt_date.CustomFormat == "")
            {
                MessageBox.Show("plz enter date");
            }
            else
            {
                v.date = txt_date.CustomFormat;
            }

            db_oprt.insert_customer(v);
            MessageBox.Show("inserted");
            gd_customer.DataSource = db_oprt.customer_display();

        }

        private void Customer_Load(object sender, EventArgs e)
        {
          txt_cstmr_id.Text= db_oprt.generate_id().ToString();
           ActiveControl = txt_cstmr_name;
           gd_customer.DataSource = db_oprt.customer_display();
        }
      

        private void txt_cstmr_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cstmr_address.Focus();
            }
        }

        private void txt_cstmr_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cstmr_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_mobile.Focus();
            }

        }

        private void txt_cstmr_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_date.Focus();
            }

        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_insert.Focus();

            }
        }

        private void gd_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
            
        
       
    }
}
