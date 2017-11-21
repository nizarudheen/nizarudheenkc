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
    public partial class sale_report : Form
    {
        public sale_report()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr = new Classes.Db_operations();
        DataTable head = new DataTable();
        DataTable detail = new DataTable();
        DataTable tota = new DataTable();
        public int indx = 0;
        private void sale_report_Load(object sender, EventArgs e)
        {
            bind();
            report(); 
        }
        void bind()
        {
            txt_search.ValueMember = "it_code";
            txt_search.DisplayMember = "it_name";
            txt_search.DataSource = opr.item_searchs();
        }
        public void report()
        {
            if (gd_sale_report.RowCount > 0)
            {
                gd_sale_report.Rows.Clear();
                indx = 0;
            }

            
            head = opr.sales_report_head();
            for (int i = 0; i < head.Rows.Count; i++)
            {
                int bill = Convert.ToInt32(head.Rows[i]["bill_no"]);
                gd_sale_report.Rows.Add();
                gd_sale_report.Rows[indx].Cells["bill_no"].Value = bill.ToString();
               
                gd_sale_report.Rows[indx].Cells["name"].Value = Convert.ToString(head.Rows[i]["sh_name"]);
              

                gd_sale_report.Rows[indx].Cells["date"].Value = Convert.ToString(head.Rows[i]["sh_date"]);
                gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.Plum;
               

                detail = opr.sales_report_detail(bill);
                for (int j = 0; j < detail.Rows.Count; j++)
                {
                    indx++;
                    gd_sale_report.Rows.Add();

                    gd_sale_report.Rows[indx].Cells["code"].Value = Convert.ToString(detail.Rows[j]["sd_item_code"]);
                    gd_sale_report.Rows[indx].Cells["item"].Value = Convert.ToString(detail.Rows[j]["sd_item"]);
                    gd_sale_report.Rows[indx].Cells["price"].Value = Convert.ToString(detail.Rows[j]["sd_price"]);
                    gd_sale_report.Rows[indx].Cells["quantity"].Value = Convert.ToString(detail.Rows[j]["sd_quantity"]);
                    gd_sale_report.Rows[indx].Cells["total"].Value = Convert.ToString(detail.Rows[j]["sd_total"]);
                    gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.PeachPuff;

                    tota = opr.sales_report_head_total(bill);
                   
                }
                indx++;
                gd_sale_report.Rows.Add();
                gd_sale_report.Rows[indx].Cells["total"].Value = Convert.ToString(tota.Rows[0]["bill_total"]);
                gd_sale_report.Rows[indx].Cells["quantity"].Value = Convert.ToString(tota.Rows[0]["total_quantity"]);
                gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.LightCoral;
                indx++;
               
            }
           
            
        }

        public void report2()
        
        {

            if (gd_sale_report.RowCount > 0)
            {
                gd_sale_report.Rows.Clear();
                indx = 0;
            }
            head = opr.date_search(txt_date1.Value, txt_date2.Value);
            for (int i = 0; i < head.Rows.Count; i++)
            {
                int bill = Convert.ToInt32(head.Rows[i]["bill_no"]);
                gd_sale_report.Rows.Add();
                gd_sale_report.Rows[indx].Cells["bill_no"].Value = bill.ToString();

                gd_sale_report.Rows[indx].Cells["name"].Value = Convert.ToString(head.Rows[i]["sh_name"]);

                gd_sale_report.Rows[indx].Cells["date"].Value = Convert.ToString(head.Rows[i]["sh_date"]);
                gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.Plum;


                detail = opr.sales_report_detail(bill);
                for (int j = 0; j < detail.Rows.Count; j++)
                {
                    indx++;
                    gd_sale_report.Rows.Add();

                    gd_sale_report.Rows[indx].Cells["code"].Value = Convert.ToString(detail.Rows[j]["sd_item_code"]);
                    gd_sale_report.Rows[indx].Cells["item"].Value = Convert.ToString(detail.Rows[j]["sd_item"]);
                    gd_sale_report.Rows[indx].Cells["price"].Value = Convert.ToString(detail.Rows[j]["sd_price"]);
                    gd_sale_report.Rows[indx].Cells["quantity"].Value = Convert.ToString(detail.Rows[j]["sd_quantity"]);
                    gd_sale_report.Rows[indx].Cells["total"].Value = Convert.ToString(detail.Rows[j]["sd_total"]);
                    gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.PeachPuff;
                    tota = opr.sales_report_head_total(bill); 
                }
                indx++;
                gd_sale_report.Rows.Add();
                gd_sale_report.Rows[indx].Cells["total"].Value = Convert.ToString(tota.Rows[0]["bill_total"]);
                gd_sale_report.Rows[indx].Cells["quantity"].Value = Convert.ToString(tota.Rows[0]["total_quantity"]);
                gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.Chocolate;
                indx++;
            }

        }
        public void report22()

        {
            if (gd_sale_report.RowCount > 0)
            {
                gd_sale_report.Rows.Clear();
                indx = 0;
            }

            head = opr.date_search(txt_date1.Value, txt_date2.Value);
            for (int i = 0; i < head.Rows.Count; i++)
            {
                int bill = Convert.ToInt32(head.Rows[i]["bill_no"]);
                gd_sale_report.Rows.Add();
                gd_sale_report.Rows[indx].Cells["bill_no"].Value = bill.ToString();

                gd_sale_report.Rows[indx].Cells["name"].Value = Convert.ToString(head.Rows[i]["sh_name"]);

                gd_sale_report.Rows[indx].Cells["date"].Value = Convert.ToString(head.Rows[i]["sh_date"]);
                gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.Plum;


                detail = opr.sales_report_detail_search(bill,txt_search.Text);
                for (int j = 0; j < detail.Rows.Count; j++)
                {
                    indx++;
                    gd_sale_report.Rows.Add();

                    gd_sale_report.Rows[indx].Cells["code"].Value = Convert.ToString(detail.Rows[j]["sd_item_code"]);
                    gd_sale_report.Rows[indx].Cells["item"].Value = Convert.ToString(detail.Rows[j]["sd_item"]);
                    gd_sale_report.Rows[indx].Cells["price"].Value = Convert.ToString(detail.Rows[j]["sd_price"]);
                    gd_sale_report.Rows[indx].Cells["quantity"].Value = Convert.ToString(detail.Rows[j]["sd_quantity"]);
                    gd_sale_report.Rows[indx].Cells["total"].Value = Convert.ToString(detail.Rows[j]["sd_total"]);
                    gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.PeachPuff;
                    
                }
                indx++;
            }

        }

        private void gd_sale_report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbox.Checked==true)
            {
                button1.Enabled = true;
                txt_date1.Enabled = true;
                txt_date2.Enabled = true;
            }
            else
            {
                txt_date1.Enabled = false;
                txt_date2.Enabled = false;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gd_sale_report.RowCount > 0)
            {
                gd_sale_report.Rows.Clear();
                indx = 0;
            }
            if (ckbox.Checked == true)
            {
                sale_report_Load(sender, e);
                report2();
                totalll();
            }
            else
            {
                sale_report_Load(sender, e);
                report();
                totalll();
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void report1()
        {
            if (gd_sale_report.RowCount > 0)
            {
                gd_sale_report.Rows.Clear();
                indx = 0;
            }

            head = opr.sales_report_head();
            for (int i = 0; i < head.Rows.Count; i++)
            {
                int bill = Convert.ToInt32(head.Rows[i]["bill_no"]);
                
                gd_sale_report.Rows.Add();
                gd_sale_report.Rows[indx].Cells["bill_no"].Value = bill.ToString();

                gd_sale_report.Rows[indx].Cells["name"].Value = Convert.ToString(head.Rows[i]["sh_name"]);


                gd_sale_report.Rows[indx].Cells["date"].Value = Convert.ToString(head.Rows[i]["sh_date"]);
                gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.Plum;


                detail = opr.sales_report_detail_search(bill, txt_search.Text);
                for (int j = 0; j < detail.Rows.Count; j++)
                {
                    indx++;
                    gd_sale_report.Rows.Add();

                    gd_sale_report.Rows[indx].Cells["code"].Value = Convert.ToString(detail.Rows[j]["sd_item_code"]);
                    gd_sale_report.Rows[indx].Cells["item"].Value = Convert.ToString(detail.Rows[j]["sd_item"]);
                    gd_sale_report.Rows[indx].Cells["price"].Value = Convert.ToString(detail.Rows[j]["sd_price"]);
                    gd_sale_report.Rows[indx].Cells["quantity"].Value = Convert.ToString(detail.Rows[j]["sd_quantity"]);
                    gd_sale_report.Rows[indx].Cells["total"].Value = Convert.ToString(detail.Rows[j]["sd_total"]);
                    gd_sale_report.Rows[indx].DefaultCellStyle.BackColor = Color.PeachPuff;
                 
                   
                }
                indx++;
                 
            }
           
       

        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gd_sale_report.RowCount > 0)
            {
                gd_sale_report.Rows.Clear();
                indx = 0;
            }
            if (ckbox.Checked == true)
            {

                report22();
                totalll();
            }
               
            else
            {
                
                report1();
                totalll();
            }
           
            txt_total.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        public void  totalll()
        {
            int b=0;
            for (int i = 0; i < gd_sale_report.Rows.Count; i++)
            {
                int a;
                a = Convert.ToInt32(gd_sale_report.Rows[i].Cells["total"].Value);
                b = b + a;
                txt_total.Text = Convert.ToString(b);
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {


            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < gd_sale_report.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = gd_sale_report.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < gd_sale_report.Rows.Count - 1; i++)
            {
                for (int j = 0; j < gd_sale_report.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = gd_sale_report.Rows[i].Cells[j].Value;
                }
            }


           

            System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog();
            saveDlg.InitialDirectory = @"C:\";
            saveDlg.Filter = "Excel files (*.xls)|*.xls";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Export Excel File To";
            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveDlg.FileName;
                workbook.SaveCopyAs(path);
                workbook.Saved = true;
                workbook.Close(true, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
        
    }
}
