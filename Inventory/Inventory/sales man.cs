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
    public partial class sales_man : Form
    {
        public sales_man()
        {
            InitializeComponent();
        }
        Classes.Db_Variables v = new Classes.Db_Variables();
        Classes.Db_operations opr = new Classes.Db_operations();
        private void txt_nmbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void sales_man_Load(object sender, EventArgs e)
        {
            btn_insert.Enabled = false;
            txt_nmbr.Text = opr.generate_no().ToString();
            gd_salesman.DataSource = opr.salesman_display();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            v.slman_no = (txt_nmbr.Text);
            if (txt_name.Text == "")
            {
                MessageBox.Show("plz enter the name");
                txt_name.Focus();
                return;
            }
            else
            {
                v.slman_name = txt_name.Text;
            }
            if (txt_address.Text == "")
            {
                v.slman_address = "";

            }
            else
            {
                v.slman_address = txt_address.Text;

            }
            if (txt_mob.Text == "")
            {
                v.slman_mob = "";

            }
            else
            {
                v.slman_mob = txt_mob.Text;

            }
            v.slman_dob = txt_date.Text;
            opr.insert_salesman(v);
            MessageBox.Show("inserted");
            gd_salesman.DataSource = opr.salesman_display();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_nmbr.Text = opr.generate_no().ToString();
            txt_name.Clear();
            txt_mob.Clear();
           
            txt_address.Clear();
            btn_insert.Enabled = true;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_mob.Clear();
            
            txt_address.Clear();
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_name_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();

            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_date.Focus();
            }
        }

        private void txt_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                txt_mob.Focus();
            }
        }

        private void txt_mob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_insert.Focus();
            }
        }
    }
}