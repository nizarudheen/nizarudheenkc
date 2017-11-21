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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void addBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.ShowDialog();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category c = new category();
            c.ShowDialog();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unit b = new unit();
            b.ShowDialog();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            items a = new items();
            a.ShowDialog();
        }

        private void viewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            item_views b = new item_views();
            b.ShowDialog();

            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sales_man f = new sales_man();
            f.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase f = new purchase();
            f.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sales f = new sales();
            f.ShowDialog();
          //  tabPage1.Controls.Add(f);
           

     }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock f = new stock();

            f.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report g = new report();
            g.ShowDialog();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sale_report b = new sale_report();
            b.ShowDialog();

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sales_man f = new sales_man();
            f.ShowDialog();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            sales_man_view f = new sales_man_view();
            f.ShowDialog();
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            staff f = new staff();
            f.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setingss f = new setingss();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StartTimer();
           

        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }





        private void StartTimer()
        {
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();

            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ledger f = new ledger();
            f.ShowDialog();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payment f = new payment();
            f.ShowDialog();
        }

        private void rrceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reciept f = new reciept();
            f.ShowDialog();

        }

        private void cashBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balance_sheet f = new balance_sheet();
            f.ShowDialog();
        }

       

    }
}
