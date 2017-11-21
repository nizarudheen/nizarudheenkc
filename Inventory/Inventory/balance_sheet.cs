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
    public partial class balance_sheet : Form
    {
        public balance_sheet()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr=new Classes.Db_operations ();
        private void balance_sheet_Load(object sender, EventArgs e)
        {
            balance_gd();
        }
        public void balance_gd()
        {
            if (gd_balance.Rows.Count > 0)
            {
                gd_balance.Rows.Clear();
               
            }
            int i;
            int n=0;
             int indxx=0;
            DataTable credit = new DataTable();
            credit=opr.trans_select_credit();

            DataTable debit = new DataTable();
            debit=opr.trans_select_debit();
            if(credit.Rows.Count>debit.Rows.Count)
            {
                 n=credit.Rows.Count;
            }
            else
            {
                n=debit.Rows.Count;
            }
            for (i = 0; i <= n; i++)
            {
                gd_balance.Rows.Add();
               
            }

            for ( i = 0; i <debit.Rows.Count; i++)
            {


               
                gd_balance.Rows[indxx].Cells["db_date"].Value = debit.Rows[i]["tr_date"].ToString();
                gd_balance.Rows[indxx].Cells["debit"].Value = debit.Rows[i]["ledger_name"].ToString();
                gd_balance.Rows[indxx].Cells["db_amound"].Value = debit.Rows[i]["tr_amound"].ToString();
                indxx++;
                
            }
            indxx = 0;
            for ( i = 0; i <credit.Rows.Count; i++)
            {

               
                gd_balance.Rows.Add();
                gd_balance.Rows[indxx].Cells["cr_date"].Value = credit.Rows[i]["tr_date"].ToString();
                gd_balance.Rows[indxx].Cells["credit"].Value = credit.Rows[i]["ledger_name"].ToString();
                gd_balance.Rows[indxx].Cells["cr_amound"].Value = credit.Rows[i]["tr_amound"].ToString();
                indxx++;
            }
            gd_balance.Rows.Add();
            
            totalll_debit();
           

        }
        public void totalll_debit()
        {
            int indx = gd_balance.Rows.Count-1;

            int a = opr.debit_total();

                gd_balance.Rows[indx].Cells["db_amound"].Value = Convert.ToString(a);
            
        
            
            int b = opr.credit_total();
            gd_balance.Rows[indx-2].Cells["cr_amound"].Value = Convert.ToString(a-b);
            
                gd_balance.Rows[indx].Cells["cr_amound"].Value = Convert.ToString(a);
            
        }
    }
}
