using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr = new Classes.Db_operations();
        Classes.Db_Variables v = new Classes.Db_Variables();

        private void txt_item_search_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txt_item_search.SelectedIndex > -1)
            {
                txt_price.Text = opr.sale_price(txt_item_search.SelectedValue.ToString()).ToString();
                txt_stock.Text = opr.stock(txt_item_search.SelectedValue.ToString()).ToString();
            }
        }



        private void txt_item_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_quantity.Focus();
            }

        }
        public void bind()
        {
           
            txt_item_search.ValueMember = "it_code";
            txt_item_search.DisplayMember = "it_name";
            txt_item_search.DataSource = opr.item_searchs();
        }


        private void sales_Load(object sender, EventArgs e)
        {

            bind();
            txt_bill_no.Text = Convert.ToString(opr.bill_no());
            txt_payment_id.Text = Convert.ToString(opr.trans_no());

            binds();

        }
        public void binds()
        {
            DataTable dt = new DataTable();
            dt = opr.customers();
            DataRow row = dt.NewRow();
            dt.Rows.InsertAt(row, 0);
            txt_customer.ValueMember = "Id";
            txt_customer.DisplayMember = "Name";
            txt_customer.DataSource = dt;
        }

        private void txt_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            int a, b;
            if (txt_quantity.Text == "")
            {
                a = 0;
                b = Convert.ToInt32(txt_stock.Text);
            }
           
            else

            {
                a = Convert.ToInt32(txt_quantity.Text);
                b = Convert.ToInt32(txt_stock.Text);
            }

            if (e.KeyCode == Keys.Enter)
                if (a > b)
                {
                    MessageBox.Show("out of stock");
                    txt_quantity.Focus();
                }
                else
                {
                    txt_price.Focus();
                }
        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            if (txt_quantity.Text == "")
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

        private void txt_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }
        int b = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "save")
            {
                int a;
                if (txt_total.Text == "")
                {
                    txt_quantity.Focus();
                }
                else
                {

                    a = Convert.ToInt32(txt_total.Text);
                    b = b + a;
                    txt_gross_total.Text = Convert.ToString(b);
                    gd_sale.ColumnCount = 6;
                }
                gd_sale.Columns[0].Name = "code";
                gd_sale.Columns[0].HeaderText = "code";
                gd_sale.Columns[1].Name = "name";
                gd_sale.Columns[1].HeaderText = "name";
                gd_sale.Columns[2].Name = "quantity";
                gd_sale.Columns[2].HeaderText = "quantity";
                gd_sale.Columns[3].Name = "price";

                gd_sale.Columns[3].HeaderText = "price";
                gd_sale.Columns[4].Name = "total";
                gd_sale.Columns[4].HeaderText = "total";
                gd_sale.Columns[5].Name = "item code";
                gd_sale.Columns[5].HeaderText = "item code";


                //****************************************************************


                gd_sale.Rows.Add();

                gd_sale.Rows[i].Cells[0].Value = txt_bill_no.Text;
                gd_sale.Rows[i].Cells[1].Value = txt_item_search.Text;
                gd_sale.Rows[i].Cells[2].Value = txt_quantity.Text;
                gd_sale.Rows[i].Cells[3].Value = txt_price.Text;
                gd_sale.Rows[i].Cells[4].Value = txt_total.Text;
                gd_sale.Rows[i].Cells[5].Value = txt_item_search.SelectedValue;

                i++;

                txt_item_search.Focus();

            }
            else if (btn_save.Text == "update")
            {
                i = gd_sale.Rows.Count;
                gd_sale.Rows.Add();

                gd_sale.Rows[i].Cells[0].Value = txt_bill_no.Text;
                gd_sale.Rows[i].Cells[1].Value = txt_item_search.Text;
                gd_sale.Rows[i].Cells[2].Value = txt_quantity.Text;
                gd_sale.Rows[i].Cells[3].Value = txt_price.Text;
                gd_sale.Rows[i].Cells[4].Value = txt_total.Text;
                gd_sale.Rows[i].Cells[5].Value = txt_item_search.SelectedValue;
                i++;
            }
            totalll();
        }

        int i = 0;

        public void totalll()
        {
            int b = 0;
            for (int i = 0; i < gd_sale.Rows.Count; i++)
            {
                int a;
                a = Convert.ToInt32(gd_sale.Rows[i].Cells["total"].Value);
                b = b + a;
                txt_gross_total.Text = Convert.ToString(b);

            }
        }
        private void btn_add_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public void clearr()
        {
            txt_discount.Text = "0";
            txt_gross_total.Text = "0";
            txt_net_amount.Text = "0";
            txt_quantity.Text = "0";
            txt_total.Text = "0";
            gd_sale.Rows.Clear();
            b = 0;
            i = 0;
            txt_bill_no.Text = Convert.ToString(opr.bill_no());
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearr();
            sales_Load(sender, e);
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            if (txt_discount.Text == "")
            {
                a = Convert.ToInt32(txt_gross_total.Text);
                b = 0;
                c = a - b;
                txt_net_amount.Text = Convert.ToString(c);
            }
            else if (txt_gross_total.Text == "")
            {
                a = 0;
                b = Convert.ToInt32(txt_discount.Text);
                c = a - b;
                txt_net_amount.Text = Convert.ToString(c);
            }
            else
            {
                a = Convert.ToInt32(txt_gross_total.Text);
                b = Convert.ToInt32(txt_discount.Text);
                c = a - b;
                txt_net_amount.Text = Convert.ToString(c);
            }

        }

        private void txt_gross_total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int a, b, c;
                if (txt_discount.Text == "")
                {
                    a = Convert.ToInt32(txt_gross_total.Text);
                    b = 0;
                    c = a - b;
                    txt_net_amount.Text = Convert.ToString(c);
                }
                else if (txt_gross_total.Text == "")
                {
                    a = 0;
                    b = Convert.ToInt32(txt_discount.Text);
                    c = a - b;
                    txt_net_amount.Text = Convert.ToString(c);
                }
                else
                {
                    a = Convert.ToInt32(txt_gross_total.Text);
                    b = Convert.ToInt32(txt_discount.Text);
                    c = a - b;
                    txt_net_amount.Text = Convert.ToString(c);
                }
                txt_discount.Focus();
            }
        }

        private void txt_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_net_amount.Focus();
            }
        }

        private void txt_net_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void txt_quantity_Leave(object sender, EventArgs e)
        {
            if (txt_quantity.Text == "")
            {
                txt_quantity.Text = Convert.ToString(0);
            }
        }

        private void txt_customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_bill_no_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_date.Focus();

            }
        }

        private void txt_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_customer.Focus();
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

            v.tr_debit = ("5").ToString();
                v.tr_credit = ("").ToString();
                v.tr_type = "debit".ToString();
           
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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "save")
            {
                v.bill_no = txt_bill_no.Text;

                if (txt_date.Text == "")
                {
                    v.sh_date = "";
                }
                else
                {
                    v.sh_date = txt_date.Text;
                }


                if (txt_customer.Text == "")
                {
                    MessageBox.Show("plz enter the name");

                    txt_customer.Focus();
                    return;
                }
                else
                {
                    v.sh_name = txt_customer.Text;
                }


                if (txt_gross_total.Text == "")
                {
                    v.sh_gtotal = "0";
                }
                else
                {
                    v.sh_gtotal = txt_gross_total.Text;
                }
                if (txt_discount.Text == "")
                {
                    v.sh_discount = "0";
                }
                else
                {
                    v.sh_discount = txt_discount.Text;
                }
                if (txt_net_amount.Text == "")
                {
                    MessageBox.Show("plz enter the amount");
                    txt_quantity.Focus();
                    return;

                }
                else
                {
                    v.sh_net_total = txt_net_amount.Text;
                }

                //5555555555555555555555555555555555555555555555555555555555555555555555
                for (int i = 0; i < gd_sale.Rows.Count; i++)
                {
                    v.bill_no = gd_sale.Rows[i].Cells[0].Value.ToString();
                    v.sd_item = gd_sale.Rows[i].Cells[1].Value.ToString();
                    v.sd_quantity = gd_sale.Rows[i].Cells[2].Value.ToString();
                    v.sd_price = gd_sale.Rows[i].Cells[3].Value.ToString();
                    v.sd_total = gd_sale.Rows[i].Cells[4].Value.ToString();

                    v.sd_item_code = gd_sale.Rows[i].Cells[5].Value.ToString();

                    opr.save_sale_detail(v);

                }
                txt_payment_id.Text = Convert.ToString(opr.trans_no());

                trans();
                opr.save_sale_head(v);

                MessageBox.Show("inserted");
               
            }





            else if (btn_save.Text == "update")
            {
                deleted_table();
                v.bill_no = txt_bill_no.Text;
                if (txt_date.Text == "")
                {
                    v.sh_date = "";
                }
                else
                {
                    v.sh_date = txt_date.Text;
                }


                if (txt_customer.Text == "")
                {
                    MessageBox.Show("plz enter the name");

                    txt_customer.Focus();
                    return;
                }
                else
                {
                    v.sh_name = txt_customer.Text;
                }


                if (txt_gross_total.Text == "")
                {
                    v.sh_gtotal = "0";
                }
                else
                {
                    v.sh_gtotal = txt_gross_total.Text;
                }
                if (txt_discount.Text == "")
                {
                    v.sh_discount = "0";
                }
                else
                {
                    v.sh_discount = txt_discount.Text;
                }
                if (txt_net_amount.Text == "")
                {
                    MessageBox.Show("plz enter the amount");
                    txt_quantity.Focus();
                    return;

                }
                else
                {
                    v.sh_net_total = txt_net_amount.Text;
                }

                //5555555555555555555555555555555555555555555555555555555555555555555555
                for (int i = 0; i < gd_sale.Rows.Count; i++)
                {
                    v.bill_no = gd_sale.Rows[i].Cells[0].Value.ToString();
                    v.sd_item = gd_sale.Rows[i].Cells[1].Value.ToString();
                    v.sd_quantity = gd_sale.Rows[i].Cells[2].Value.ToString();
                    v.sd_price = gd_sale.Rows[i].Cells[3].Value.ToString();
                    v.sd_total = gd_sale.Rows[i].Cells[4].Value.ToString();

                    v.sd_item_code = gd_sale.Rows[i].Cells[5].Value.ToString();

                    opr.update_sale_detail(v);

                }



                MessageBox.Show("updated");
            }


            print_setting();





        }
        public void deleted_table()
        {
            DataTable dt = new DataTable();
            int bill_txt = Convert.ToInt32(txt_bill_no.Text);
            dt = opr.sales_display(bill_txt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                v.bill_no = dt.Rows[i]["bill_no"].ToString();
                v.dl_item = dt.Rows[i]["sd_item"].ToString();
                v.dl_quantity = dt.Rows[i]["sd_quantity"].ToString();
                v.dl_price = dt.Rows[i]["sd_price"].ToString();
                v.dl_total = dt.Rows[i]["sd_total"].ToString();

                v.dl_item_code = dt.Rows[i]["sd_item_code"].ToString();

                opr.sales_deleted(v);

            }

        }

        private void txt_customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_item_search.Focus();
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gd_sale_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gd_sale_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gd_sale.Rows.Remove(gd_sale.Rows[e.RowIndex]);
        }

        private void btn_pluss_Click(object sender, EventArgs e)
        {
            int indx = 0;
            DataTable dt = new DataTable();
            int bill = opr.bill_no();
            int txt_bill = Convert.ToInt32(txt_bill_no.Text) + 1;
            if (txt_bill <= bill)
            {
                txt_bill_no.Text = Convert.ToString(txt_bill);
                if (opr.sales_display(txt_bill) != null)
                {


                    dt = opr.sales_display(txt_bill);

                    gd_sale.ColumnCount = 6;

                    gd_sale.Columns[0].Name = "code";
                    gd_sale.Columns[0].HeaderText = "code";
                    gd_sale.Columns[1].Name = "name";
                    gd_sale.Columns[1].HeaderText = "name";
                    gd_sale.Columns[2].Name = "quantity";
                    gd_sale.Columns[2].HeaderText = "quantity";
                    gd_sale.Columns[3].Name = "price";

                    gd_sale.Columns[3].HeaderText = "price";
                    gd_sale.Columns[4].Name = "total";
                    gd_sale.Columns[4].HeaderText = "total";
                    gd_sale.Columns[5].Name = "item code";
                    gd_sale.Columns[5].HeaderText = "item code";
                    gd_sale.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        gd_sale.Rows.Add();
                        gd_sale.Rows[indx].Cells["code"].Value = Convert.ToString(dt.Rows[i]["bill_no"]);
                        gd_sale.Rows[indx].Cells["name"].Value = Convert.ToString(dt.Rows[i]["sd_item"]);
                        gd_sale.Rows[indx].Cells["quantity"].Value = Convert.ToString(dt.Rows[i]["sd_quantity"]);

                        gd_sale.Rows[indx].Cells["price"].Value = Convert.ToString(dt.Rows[i]["sd_price"]);

                        gd_sale.Rows[indx].Cells["total"].Value = Convert.ToString(dt.Rows[i]["sd_total"]);

                        gd_sale.Rows[indx].Cells["item code"].Value = Convert.ToString(dt.Rows[i]["sd_item_code"]);

                        indx++;
                    }
                }
                else
                {
                    gd_sale.Rows.Clear();
                }

            }
            else
            {
                btn_pluss.Enabled = false;
            }
            txt_bill = Convert.ToInt32(txt_bill_no.Text);
            bill = opr.bill_no();

            if (txt_bill > 0)
            {

                btn_minus.Enabled = true;
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int indx = 0;
            btn_save.Text = "update";
            DataTable dt = new DataTable();
            int bill = opr.bill_no();
            int txt_bill = Convert.ToInt32(txt_bill_no.Text) - 1;

            if (txt_bill > 0)
            {
                txt_bill_no.Text = Convert.ToString(txt_bill);
                dt = opr.sales_display(txt_bill);
                gd_sale.ColumnCount = 6;

                gd_sale.Columns[0].Name = "code";
                gd_sale.Columns[0].HeaderText = "code";
                gd_sale.Columns[1].Name = "name";
                gd_sale.Columns[1].HeaderText = "name";
                gd_sale.Columns[2].Name = "quantity";
                gd_sale.Columns[2].HeaderText = "quantity";
                gd_sale.Columns[3].Name = "price";

                gd_sale.Columns[3].HeaderText = "price";
                gd_sale.Columns[4].Name = "total";
                gd_sale.Columns[4].HeaderText = "total";
                gd_sale.Columns[5].Name = "item code";
                gd_sale.Columns[5].HeaderText = "item code";
                gd_sale.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    gd_sale.Rows.Add();
                    gd_sale.Rows[indx].Cells["code"].Value = Convert.ToString(dt.Rows[i]["bill_no"]);
                    gd_sale.Rows[indx].Cells["name"].Value = Convert.ToString(dt.Rows[i]["sd_item"]);
                    gd_sale.Rows[indx].Cells["quantity"].Value = Convert.ToString(dt.Rows[i]["sd_quantity"]);

                    gd_sale.Rows[indx].Cells["price"].Value = Convert.ToString(dt.Rows[i]["sd_price"]);

                    gd_sale.Rows[indx].Cells["total"].Value = Convert.ToString(dt.Rows[i]["sd_total"]);

                    gd_sale.Rows[indx].Cells["item code"].Value = Convert.ToString(dt.Rows[i]["sd_item_code"]);
                    indx++;

                }
                if (bill > txt_bill)
                {
                    btn_pluss.Enabled = true;
                }
            }
            else
            {
                btn_minus.Enabled = false;
            }

        }

        public void print_setting()
        {
            DataTable dt = new DataTable();
            dt = opr.print_setting();
            if (Convert.ToBoolean(dt.Rows[0]["p"]))
            {
                printbill_sales();
            }
           

        }



///XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX///







        private void btn_print_Click(object sender, EventArgs e)
        {
            printbill_sales();
        }

        public void printbill_sales()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            PrintPreviewDialog prev = new PrintPreviewDialog();
            doc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("print", 840, 1188);
            doc.PrintPage += new PrintPageEventHandler(print_document);
            prev.Document = doc;
            prev.ShowDialog();

        }

       



        public void print_document(object sender, PrintPageEventArgs e)
        {
            Pen blackpen = new Pen(System.Drawing.Color.Black, 1);
            System.Drawing.Font invoice = new System.Drawing.Font("Times New Roman", 40, FontStyle.Bold);

            System.Drawing.Font heading = new System.Drawing.Font("Times New Roman", 24, FontStyle.Bold);
            System.Drawing.Font header = new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold);
            System.Drawing.Font text = new System.Drawing.Font("Times New Roman", 18, FontStyle.Regular);
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            e.Graphics.DrawString("AL AMEEN BANANA MERCHANT", heading, new SolidBrush(System.Drawing.Color.Black), 150, 10);
            e.Graphics.DrawString("Near REC road,market,Kunnamangalam,calicut,kerala,PIN CODE:673582", text, new SolidBrush(System.Drawing.Color.Black), 20, 45);
            e.Graphics.DrawString("Phone:9497084191", header, new SolidBrush(System.Drawing.Color.Black), 590, 90);
            e.Graphics.DrawString("Mob  :9400681529", header, new SolidBrush(System.Drawing.Color.Black), 590, 125);
            e.Graphics.DrawRectangle(blackpen, 10, 80, 818, 100);
            e.Graphics.DrawRectangle(blackpen, 10, 180, 818, 100);
            e.Graphics.DrawRectangle(blackpen, 10, 280, 818, 50);

            e.Graphics.DrawRectangle(blackpen, 10, 330, 818, 600);


            e.Graphics.DrawString("Invoice ", invoice, new SolidBrush(System.Drawing.Color.Black), 160, 100);

            e.Graphics.DrawString("Invoice No    :", text, new SolidBrush(System.Drawing.Color.Black), 20, 185);
            e.Graphics.DrawString(txt_bill_no.Text, text, new SolidBrush(System.Drawing.Color.Black), 190, 185);

            e.Graphics.DrawString("Invoice Date  :", text, new SolidBrush(System.Drawing.Color.Black), 20, 210);
            e.Graphics.DrawString(txt_date.Text, text, new SolidBrush(System.Drawing.Color.Black), 190, 210);

            e.Graphics.DrawString("Customer Name:", text, new SolidBrush(System.Drawing.Color.Black), 20, 235);
            e.Graphics.DrawString(txt_customer.Text, text, new SolidBrush(System.Drawing.Color.Black), 190, 235);

            e.Graphics.DrawLine(blackpen, 580, 80, 580, 180);
            e.Graphics.DrawLine(blackpen, 45, 280, 45, 930);


            e.Graphics.DrawLine(blackpen, 300, 280, 300, 930);
            e.Graphics.DrawLine(blackpen, 400, 280, 400, 930);

            e.Graphics.DrawLine(blackpen, 500, 280, 500, 930);

            e.Graphics.DrawLine(blackpen, 600, 280, 600, 930);
            e.Graphics.DrawString("SI", header, new SolidBrush(System.Drawing.Color.Black), 15, 295);
            e.Graphics.DrawString("ITEM", header, new SolidBrush(System.Drawing.Color.Black), 55, 295);

            e.Graphics.DrawString("UNIT", header, new SolidBrush(System.Drawing.Color.Black), 305, 295);
            e.Graphics.DrawString("QTY", header, new SolidBrush(System.Drawing.Color.Black), 405, 295);

            e.Graphics.DrawString("PRICE", header, new SolidBrush(System.Drawing.Color.Black), 505, 295);

            e.Graphics.DrawString("TOTAL", header, new SolidBrush(System.Drawing.Color.Black), 605, 295);
            e.Graphics.DrawString("Gross Total :", header, new SolidBrush(System.Drawing.Color.Black), 475, 1000);
            e.Graphics.DrawString(txt_gross_total.Text, header, new SolidBrush(System.Drawing.Color.Black), 650, 1000);
            e.Graphics.DrawString("Discount     :", header, new SolidBrush(System.Drawing.Color.Black), 475, 1035);
            e.Graphics.DrawString(txt_discount.Text, header, new SolidBrush(System.Drawing.Color.Black), 650, 1035);

            e.Graphics.DrawString("Net amount :", header, new SolidBrush(System.Drawing.Color.Black), 475, 1070);
            e.Graphics.DrawString(txt_net_amount.Text, header, new SolidBrush(System.Drawing.Color.Black), 650, 1070);

            if (gd_sale.Rows.Count <= 0)
            {
                MessageBox.Show("Add items to the list");
            }
            else
            {

                int b = 0;
                int indx = 0;

                for (int i = 0; i < gd_sale.Rows.Count; i++)
                {
                    int a = 25;
                    b = b + a;
                    e.Graphics.DrawString(Convert.ToString(i + 1), text, new SolidBrush(System.Drawing.Color.Black), 15, 305 + b);
                    e.Graphics.DrawString(Convert.ToString(gd_sale.Rows[indx].Cells["name"].Value), text, new SolidBrush(System.Drawing.Color.Black), 55, 305 + b);

                    e.Graphics.DrawString(Convert.ToString(gd_sale.Rows[indx].Cells["quantity"].Value), text, new SolidBrush(System.Drawing.Color.Black), 405, 305 + b);

                    e.Graphics.DrawString(Convert.ToString(gd_sale.Rows[indx].Cells["price"].Value), text, new SolidBrush(System.Drawing.Color.Black), 505, 305 + b);

                    e.Graphics.DrawString(Convert.ToString(gd_sale.Rows[indx].Cells["total"].Value), text, new SolidBrush(System.Drawing.Color.Black), 605, 305 + b);
                    indx++;
                }

            }






        }
        

       //void printDocumentA4Form8_PrintPage(object sender, PrintPageEventArgs e)
       // {
       //     Pen blackpen = new Pen(System.Drawing.Color.Black, 1);
       //     System.Drawing.Font head = new System.Drawing.Font("Times New Roman", 20, FontStyle.Bold);
       //     System.Drawing.Font Headerfont1 = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);
       //     System.Drawing.Font Headerfont3 = new System.Drawing.Font("Times New Roman", 10, FontStyle.Regular);
       //     System.Drawing.Font Headerfont4 = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);
           
       //     //bool hasmorepages = false;
       //     //float xpos;
       //     int startx = 50;
       //     int starty = 20;
       //     int offset = 15;
       //     //bool PRINTTOTALPAGE = true;
       //     //int w = e.MarginBounds.Width / 2;
       //     //int x = e.MarginBounds.Left;
       //     //int y = e.MarginBounds.Top;
       //     //string vchno = "";
       //     //string snno = "";
       //     //string dated = "";
       //     //string vchtype = "";
       //     //string partclrs = "";
       //     //string debit = "";
       //     //string credit = "";
       //     //string balance = "";
       //     //string narration = "";
       //     //int value = 0;
       //     //var tabDataForeColor = System.Drawing.Color.Black;
       //     //int height = 100 + y;
       //     //Pen blackPen1 = new Pen(System.Drawing.Color.Black, 1);
       //     //var txtDataWidth = e.Graphics.MeasureString(CompanyName, Headerfont1).Width;
       //     //double pricWtax = 0;
       //     //decimal a = 0;
       //     StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

       //     e.Graphics.DrawString(textBox1.Text, head, new SolidBrush(System.Drawing.Color.Black), 50, 40);





       //       //  height += 15;
       //       ////  sf.LineAlignment = StringAlignment.Center;
       //       ////  sf.Alignment = StringAlignment.Center;
       //       //  xpos = e.MarginBounds.Left + (e.MarginBounds.Width / 2);
       //         e.Graphics.DrawRectangle(blackpen, 10, 10, 820, 1168);
       //         e.Graphics.DrawLine(blackpen, 10, 80, 830, 80); //h
       //         e.Graphics.DrawLine(blackpen, 10, 110, 830, 110); //h
       //         e.Graphics.DrawLine(blackpen, 10, 1090, 830, 1090); //h
       //         e.Graphics.DrawLine(blackpen, 10, 1130, 830, 1130); //h
       //         e.Graphics.DrawLine(blackpen, 35, 80, 35, 1090); //v sl no
       //         e.Graphics.DrawLine(blackpen, 120, 80, 120, 1090); //voucher
       //         e.Graphics.DrawLine(blackpen, 188, 80, 188, 1090); //date
       //         e.Graphics.DrawLine(blackpen, 290, 80, 290, 1090); //vouchrtype
       //         e.Graphics.DrawLine(blackpen, 460, 80, 460, 1130); //particulars
       //         e.Graphics.DrawLine(blackpen, 540, 80, 540, 1130); //debit     
       //         e.Graphics.DrawLine(blackpen, 625, 80, 625, 1130); //CREDIT
       //         e.Graphics.DrawLine(blackpen, 720, 80, 720, 1130); //balance             

       //         string headtext = "No".PadRight(3) + "VoucherNo".PadRight(13) + "Date".PadRight(9) + "VoucherType".PadRight(20) + "Particulars".PadRight(28) + "Debit".PadRight(15) + "Credit".PadRight(15) + "Balance".PadRight(16) + "Narration";
       //         e.Graphics.DrawString(headtext, Headerfont1, new SolidBrush(System.Drawing.Color.Black), startx - 40, starty + offset + 50);
       //         offset = offset + 40;
       //         float fontheight = Headerfont1.GetHeight();

       //         e.Graphics.DrawRectangle(blackpen, 10, 500, 820, 35);
       //     //e.HasMorePages = hasmorepages;
       // }


        //public void printingPreview()
        //{
        //    PrintDocument doc = new PrintDocument();
        //    PrintPreviewDialog prvdlg4 = new PrintPreviewDialog();

        //    doc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Form8", 840, 1188);

        //    doc.PrintPage += new PrintPageEventHandler(printDocumentA4Form8_PrintPage);
        //    prvdlg4.Document = doc;

        //    prvdlg4.ShowDialog();

        //}








       
       
    }

}
