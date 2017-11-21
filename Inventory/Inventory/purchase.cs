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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr = new Classes.Db_operations();
        Classes.Db_Variables v = new Classes.Db_Variables();
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_voucher_no.Clear();
            txt_supplier.Text = "";
            txt_payment_id.Text = Convert.ToString(opr.trans_no());

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_supplier_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txt_item_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_item_search_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            txt_price.Text = opr.price(txt_item_search.Text).ToString();
        }

        private void txt_item_search_TextChanged_1(object sender, EventArgs e)
        {
           
            
           
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ( ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_price.Focus();

        }

        private void txt_item_search_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    txt_quantity.Focus();
            //}
        }
 
        private void gd_purchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int x = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            int a = 0;
                a = Convert.ToInt32(txt_total.Text);
                x = x + a;
                txt_gross_total.Text = Convert.ToString(x);

            gd_purchase.ColumnCount = 6;
            gd_purchase.Columns[0].Name = "voucher_no";
            gd_purchase.Columns[0].HeaderText = "voucher_no";
            gd_purchase.Columns[1].Name = "item_name";
            gd_purchase.Columns[1].HeaderText = "item_name";
            gd_purchase.Columns[2].Name = "price";
            gd_purchase.Columns[2].HeaderText = "price";
            gd_purchase.Columns[3].Name = "quantity";
            gd_purchase.Columns[3].HeaderText = "quantity";
            gd_purchase.Columns[4].Name = "total";
            gd_purchase.Columns[4].HeaderText = "total";
            gd_purchase.Columns[5].HeaderText = "item_code";
            gd_purchase.Columns[5].Name = "item_code";
                gd_purchase.Rows.Add();
                gd_purchase.Rows[indx].Cells[0].Value = txt_voucher_no.Text;
                gd_purchase.Rows[indx].Cells[1].Value = txt_item_search.Text;
                gd_purchase.Rows[indx].Cells[2].Value = txt_price.Text;
                gd_purchase.Rows[indx].Cells[3].Value =  txt_quantity.Text;

                gd_purchase.Rows[indx].Cells[4].Value = txt_total.Text;
                gd_purchase.Rows[indx].Cells[5].Value = txt_item_search.SelectedValue;
                indx++;
                txt_discount.Focus();

           
        }
        int indx = 0;
        private void purchase_Load(object sender, EventArgs e)
        {
            txt_item_search.Text =null;
            bind();
            biind();
            txt_payment_id.Text = Convert.ToString(opr.trans_no());

        }

        void bind()
        {
            txt_supplier.ValueMember = "no";
            txt_supplier.DisplayMember = "sl_man_name";
            txt_supplier.DataSource = opr.suppliers_display();
        }
        void biind()
        {
            txt_item_search.ValueMember = "It_code";
            txt_item_search.DisplayMember = "it_name";
            txt_item_search.DataSource = opr.item_searchs();
        }
       
        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            if (txt_quantity.Text=="")
            {
                a = 0;
                b = Convert.ToInt32(txt_price.Text);
                c = a * b;
                txt_total.Text = Convert.ToString(c);
            }
           
            else

            {
             
                a = Convert.ToInt32(txt_quantity.Text);
                b = Convert.ToInt32(txt_price.Text);
                c = a * b;
                txt_total.Text = Convert.ToString(c);
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            if (txt_price.Text == "")
            {
                a = Convert.ToInt32(txt_quantity.Text);
                b = 0;
                c = a * b;
                txt_total.Text = Convert.ToString(c);
            }
            else if (txt_quantity.Text == "")
            {
                a = 0;
                b = Convert.ToInt32(txt_price.Text);
                c = a * b;
                txt_total.Text = Convert.ToString(c);
            }
            else

            {

                a = Convert.ToInt32(txt_quantity.Text);
                b = Convert.ToInt32(txt_price.Text);
                c = a * b;
                txt_total.Text = Convert.ToString(c);
            }
            
        }

        private void txt_supplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_item_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        public void trans()
        {
            if (txt_payment_id.Text == "")
            {
                MessageBox.Show("plz enter correct transaction id");
                return;
            }
            else
            {
                v.tr_id = txt_payment_id.Text;
            }
            v.tr_date = txt_date.Value;

            v.tr_debit =  ("").ToString();
            v.tr_credit = ("6").ToString();
            v.tr_type = "credit".ToString();

            if (txt_net_amount.Text == "")
            {
                MessageBox.Show("plz enter the net amount");
                txt_net_amount.Focus();
                return;
            }
            else
            {
                v.tr_amound = txt_net_amount.Text;
            }
            opr.trans_insert(v);
            txt_payment_id.Text = Convert.ToString(opr.trans_no());

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_voucher_no.Text == "")
            {
                MessageBox.Show("plz enter vouchar no");
                txt_voucher_no.Focus();
                return;
            }
            else
            {
                v.pr_vouchar = txt_voucher_no.Text;
            }
            if (txt_date.Text == "")
                v.pr_date = "";
            if (txt_supplier.Text == "")
            {
                MessageBox.Show("plz enter the name");
                txt_supplier.Focus();
                return;

            }
            else
            {
                v.pr_date = txt_date.Text;

            }
            if (txt_supplier.Text == "")
            {
                MessageBox.Show("enter the name");
            }
            else
                v.pr_supplier = txt_supplier.Text;
            if (txt_gross_total.Text == "")
            {
                v.pr_gross_total = "";
            }
            else 
            {
                v.pr_gross_total = txt_gross_total.Text;
            }
            if (txt_discount.Text == "")
            {
                v.pr_discount = "0";
            }
            else
            {
                v.pr_discount = txt_discount.Text;
            }
            if (txt_net_amount.Text == "")
            {
                MessageBox.Show("plz enter the amount");
                txt_quantity.Focus();
                return;

            }
            else
            {
                v.pr_net_total = txt_net_amount.Text;
            }

//5555555555555555555555555555555555555555555555555555555555555555555555
            for (int i = 0; i < gd_purchase.Rows.Count; i++)
            {
                v.pr_vouchar = gd_purchase.Rows[i].Cells[0].Value.ToString();
                v.prd_item = gd_purchase.Rows[i].Cells[1].Value.ToString();
                v.prd_price = gd_purchase.Rows[i].Cells[2].Value.ToString();
                v.prd_quantity = gd_purchase.Rows[i].Cells[3].Value.ToString();
                v.prd_total = gd_purchase.Rows[i].Cells[4].Value.ToString();

                v.prd_item_code = gd_purchase.Rows[i].Cells[5].Value.ToString();

                opr.save_purchase_detail(v);

            }


            opr.save_purchase_head(v);
            trans();
            MessageBox.Show("inserted");









            

        }



        private void txt_quantity_Leave(object sender, EventArgs e)
        {
            if (txt_quantity.Text == "")
            {
                txt_quantity.Text = "0";
            }
        }

        private void txt_price_Leave(object sender, EventArgs e)
        {
            if (txt_price.Text == "")
                txt_price.Text = "0";

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "";
                txt_net_amount.Text = txt_gross_total.Text;

            }
            else 
            {
                int a, b, c;
                a = Convert.ToInt32(txt_gross_total.Text);
                b = Convert.ToInt32(txt_discount.Text);
                c = a - b;
                txt_net_amount.Text = Convert.ToString(c);
            }
      
        }

        private void txt_voucher_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_supplier.Focus();
        }

        private void txt_item_search_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_quantity.Focus();
        }

        private void txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_add.Focus();


        }

        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_discount.Focus();
        }

        private void txt_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_discount.Text == "")
                {
                    int a, b, c;
                    a = Convert.ToInt32(txt_gross_total.Text);
                    b = 0;
                    c = a - b;
                    txt_net_amount.Text = Convert.ToString(c);
                }
                else
                {
                    int a, b, c;
                    a = Convert.ToInt32(txt_gross_total.Text);
                    b = Convert.ToInt32(txt_discount.Text);
                    c = a - b;
                    txt_net_amount.Text = Convert.ToString(c);
                }
                btn_save.Focus();
            }
               
        }

        private void txt_voucher_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&(!Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btn_save_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    txt_discount.Focus();

        }

        private void txt_supplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_item_search.Focus();
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&(!Char.IsControl(e.KeyChar)))
                e.Handled=true;
        }

        private void btn_add_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
