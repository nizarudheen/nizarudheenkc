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
    public partial class ledger : Form
    {
        public ledger()
        {
            InitializeComponent();
        }
        Classes.Db_Variables v = new Classes.Db_Variables();
        Classes.Db_operations opr = new Classes.Db_operations();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_ledger_id.Text == "")
            {
                MessageBox.Show("plz click add button");
                txt_ledger_id.Focus();
                return;

            }
            else
            {
                v.ld_id = txt_ledger_id.Text;
            }
            if (txt_ledger_name.Text == "")
            {
                MessageBox.Show("plz enter the ledger name");
                txt_ledger_name.Focus();
                return;
            }
            else
            {
                v.ld_name = txt_ledger_name.Text;
            }
            if (rad_expence.Checked == true)
            {
                v.ld_type = "credit";
            }
            else if (rad_income.Checked == true)
            {
                v.ld_type = "debit";
            }
            else if (rad_expence.Checked == false && rad_income.Checked == false)
            {
                MessageBox.Show("plz select the type");
                rad_expence.Focus();
                return;
            }
            opr.ledger_insert(v);
            MessageBox.Show("value inserted");
            gd_ledger_view.DataSource = opr.ledger_data();

            txt_ledger_id.Text = Convert.ToString(opr.ledger_id());
            txt_ledger_name.Clear();
        }

        private void ledger_Load(object sender, EventArgs e)
        {
            txt_ledger_id.Text = Convert.ToString(opr.ledger_id());
            gd_ledger_view.DataSource = opr.ledger_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txt_ledger_id.Text = Convert.ToString(opr.ledger_id());
            txt_ledger_name.Clear();
        }

    }
}
