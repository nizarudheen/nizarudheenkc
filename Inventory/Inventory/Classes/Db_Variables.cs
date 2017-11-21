using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Classes
{
    public class Db_Variables
    {
        public string customer_name { get; set; }
        public int customer_id { get; set; }
        public string mob { get; set; }
        public string address { get; set; }
        public string date { get; set; }
        public string CustomFormat { get; set; }

        //thr6tr7
        public string slman_name { get; set; }
        public string slman_address { get; set; }
        public string slman_mob { get; set; }
        public string dob { get; set; }
        public string slman_no { get; set; }
        public string slman_dob { get; set; }
        public string pr_vouchar { get; set; }
        public string pr_date { get; set; }
        public string pr_supplier { get; set; }
        public string pr_gross_total { get; set; }
        public string pr_discount { get; set; }
        public string pr_net_total { get; set; }



        public string prd_item { get; set; }
        public string prd_item_code { get; set; }
        public string prd_price { get; set; }
        public string prd_quantity { get; set; }
        public string prd_total { get; set; }
        //************************************************
        public string bill_no { get; set; }
        public string sh_date { get; set; }
        public string sh_name { get; set; }
        public string sh_gtotal { get; set; }
        public string sh_discount { get; set; }

        public string sh_net_total { get; set; }

        //************************************************
        public string sd_item { get; set; }
       
        public string sd_price { get; set; }
        public string sd_quantity { get; set; }
        public string sd_total { get; set; }
        public string sd_item_code { get; set; }
        //******************************************8

        public string dl_item { get; set; }

        public string dl_price { get; set; }
        public string dl_quantity { get; set; }
        public string dl_total { get; set; }
        public string dl_item_code { get; set; }
        //***********ledger


        public string ld_id { get; set; }
        public string ld_name { get; set; }
        public string ld_type { get; set; }


        //*****************payments*********

        public string pay_no { get; set; }
        public string pay_name { get; set; }
        public string pay_ledger { get; set; }
        public string pay_amount { get; set; }
        public DateTime pay_date { get; set; }



        public string recp_no { get; set; }
        public string recp_name { get; set; }
        public string recp_ledger { get; set; }
        public string recp_amount { get; set; }
        public DateTime recp_date { get; set; }



        //******************Trans************
        public string tr_type { get; set; }

        public string tr_id { get; set; }
        public string tr_credit { get; set; }
        public string tr_debit { get; set; }
        public string tr_amound { get; set; }
        public DateTime tr_date { get; set; }


    }
}
