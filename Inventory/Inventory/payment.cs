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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr = new Classes.Db_operations();
        Classes.Db_Variables v = new Classes.Db_Variables();

        private void button1_Click(object sender, EventArgs e)
        {
            v.pay_no = txt_pay_no.Text;
            if (txt_name.Text == "")
            {
                MessageBox.Show("plz enter the description");
                txt_name.Focus();
                return;
            }
            else
            {
                v.pay_name = txt_name.Text;

            }
            if (txt_ledger.Text == "")
            {
                MessageBox.Show("plz select the ledger");
                txt_ledger.Focus();
                return;
            }
            else
            {
                v.pay_ledger = txt_ledger.SelectedValue.ToString();
            }
            if (txt_amount.Text == "")
            {
                MessageBox.Show("plz enter the Amount");
                txt_amount.Focus();
                return;
            }
            else
            {
                v.pay_amount = txt_amount.Text;
            }
            v.pay_date = txt_date.Value;

            opr.payment_insert(v);
            trans();
            MessageBox.Show("inserted");
            gd_pay.DataSource = opr.pay_gd();
            bind();
        }
         public void bind()
        {
            txt_ledger.ValueMember = "ledger_id";
            txt_ledger.DisplayMember = "ledger_name";

            txt_ledger.DataSource= opr.pay_compo();
            txt_pay_no.Text = Convert.ToString(opr.pay_no());
            txt_payment_id.Text = Convert.ToString(opr.trans_no());

        }
         

         private void payment_Load(object sender, EventArgs e)
         {
             bind();
             gd_pay.DataSource = opr.pay_gd();
             
         }

         private void txt_amount_TextChanged(object sender, EventArgs e)
         {
             
         }

         private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
         {
             if(!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
             {
                 e.Handled=true;
             }
             
         }

         private void btn_add_Click(object sender, EventArgs e)
         {
             bind();
             txt_name.Clear();
             txt_amount.Clear();
             txt_payment_id.Text = Convert.ToString(opr.trans_no());

         }
         public void trans()
         {
             if (txt_payment_id.Text =="")
             {
                 MessageBox.Show("plz enter correct transaction id");
             }
             else
             {
                 v.tr_id = txt_payment_id.Text;
             }
             v.tr_date = txt_date.Value;

             v.tr_credit = txt_ledger.SelectedValue.ToString();
                 v.tr_debit = ("").ToString();
                 v.tr_type = "credit".ToString();
             
             if (txt_amount.Text == "")
             {
                 MessageBox.Show("plz enter the net amount");
                 txt_amount.Focus();
                 return;
             }
             else
             {
                 v.tr_amound = txt_amount.Text;
             }
             opr.trans_insert(v);
         }
    }
}
