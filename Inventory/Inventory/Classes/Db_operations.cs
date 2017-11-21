using System;
using System.Collections.Generic;
using System.Linq;



using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Inventory.Classes
{
   public class Db_operations
    {
       Classes.Db db = new Classes.Db();
   
       public void insert_customer(Classes.Db_Variables variabl)
       {
           SqlCommand cmd = new SqlCommand("insert into tbl_customer values ("+variabl.customer_id+",'"+variabl.customer_name+"','"+variabl.address+"','"+variabl.mob+"','"+variabl.date+"')", db.cn());
           cmd.ExecuteNonQuery();
       }
       public int generate_id()
       {
           int id = 0;
           SqlCommand cmd = new SqlCommand("select isnull(max(id),0) as id from tbl_customer", db.cn());
           id = Convert.ToInt32(cmd.ExecuteScalar());
           return ++id;
       }
       public DataTable customer_display()
       {

           SqlCommand cmd = new SqlCommand("select * from tbl_customer", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;
          
       }
       public DataTable sales_display(string itemname)
       {
           SqlCommand cmd = new SqlCommand("select it_name,saleprice from item where It_name like '"+ itemname+"%'", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;
       }
       public int generate_no()
       {
        
           SqlCommand cmd = new SqlCommand("select count(no) from salesman", db.cn());
           int count=Convert.ToInt32(cmd.ExecuteScalar());
           return ++count;
       }
       public void insert_salesman(Classes.Db_Variables sale)
   {
       SqlCommand cmd = new SqlCommand("insert into salesman values(" + sale.slman_no + ",'" + sale.slman_name + "','" + sale.slman_address + "','" + sale.slman_dob + "','" + sale.slman_mob + "')", db.cn());
       cmd.ExecuteNonQuery();
       }
       public DataTable salesman_display()
       {

           SqlCommand cmd = new SqlCommand("select * from salesman", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;
       }
       public DataTable suppliers_display()
       {
           SqlCommand cmd = new SqlCommand("select * from salesman", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;

       }
       public DataTable item_searchs()
       {
           SqlCommand cmd = new SqlCommand("select it_name,it_code from item", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;
       }
       public int price(string searchss)
       {
           SqlCommand cmd = new SqlCommand("select purchaserate from item where it_name='" + searchss + "'", db.cn());
           int  cost = Convert.ToInt16(cmd.ExecuteScalar());
           return cost;
       }
       public void save_purchase_head(Classes.Db_Variables v)

       {
           SqlCommand cmd=new SqlCommand("insert into purchase_head values ("+v.pr_vouchar+",'"+v.pr_date+"','"+v.pr_supplier+"',"+v.pr_gross_total+","+v.pr_discount+","+v.pr_net_total+")",db.cn());
           cmd.ExecuteNonQuery();
       }
       public void save_purchase_detail(Classes.Db_Variables v)
       {
           SqlCommand cmd = new SqlCommand("insert into purchase_detail values(@voucher,@name,@price,@quantity,@total,@code)", db.cn());
           cmd.Parameters.AddWithValue("@voucher", v.pr_vouchar);
           cmd.Parameters.AddWithValue("@name", v.prd_item);
           cmd.Parameters.AddWithValue("@price", v.prd_price);

           cmd.Parameters.AddWithValue("@quantity", v.prd_quantity);

           cmd.Parameters.AddWithValue("@total",v.prd_total);
           cmd.Parameters.AddWithValue("@code", v.prd_item_code);
           cmd.ExecuteNonQuery();
       }
       public int stock(string code)
       {
           SqlCommand cmd = new SqlCommand("select (isnull(purchase_stock.p_stock,0)-isnull(sale_stock.s_stock,0)) as currentstock from item left outer join (select prd_item_code,sum(isnull(prd_quantity,0)) as p_stock from purchase_detail group by prd_item_code) as purchase_stock on item.it_code=purchase_stock.prd_item_code left outer join (select sum(isnull(sd_quantity,0)) as s_stock,sd_item_code from sale_detail group by sd_item_code) as sale_stock on item.it_code=sale_stock.sd_item_code where item.it_code=" + code, db.cn());
           int stock = Convert.ToInt32(cmd.ExecuteScalar());
           return stock;
       }
       public DataTable stock_details()
       {
           SqlCommand cmd = new SqlCommand("select item.it_name,item.it_unit,item.it_category,item.saleprice,item.it_brand,item.it_code,isnull(purchase_stock.p_stock,0)as p_stock,isnull(sale_stock.s_stock,0)as s_stock,(isnull(purchase_stock.p_stock,0)-isnull(sale_stock.s_stock,0)) as currentstock from item left outer join (select prd_item_code,sum(isnull(prd_quantity,0)) as p_stock from purchase_detail group by prd_item_code) as purchase_stock on item.it_code=purchase_stock.prd_item_code left outer join (select sum(isnull(sd_quantity,0)) as s_stock,sd_item_code from sale_detail group by sd_item_code) as sale_stock on item.it_code=sale_stock.sd_item_code", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;

       }
       public DataTable stock_search(string text)
       {
           SqlCommand cmd = new SqlCommand("select item.it_name,item.it_unit,item.it_category,item.saleprice,item.it_brand,item.it_code,isnull(purchase_stock.p_stock,0)as p_stock,isnull(sale_stock.s_stock,0)as s_stock,(isnull(purchase_stock.p_stock,0)-isnull(sale_stock.s_stock,0)) as currentstock from item left outer join (select prd_item_code,sum(isnull(prd_quantity,0)) as p_stock from purchase_detail group by prd_item_code) as purchase_stock on item.it_code=purchase_stock.prd_item_code left outer join (select sum(isnull(sd_quantity,0)) as s_stock,sd_item_code from sale_detail group by sd_item_code) as sale_stock on item.it_code=sale_stock.sd_item_code where item.it_name like '"+text+"%'",db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }


       public int bill_no()
       
       
       {
           SqlCommand cmd = new SqlCommand("select count(bill_no) from sale_head",db.cn());
           int count=Convert.ToInt32(cmd.ExecuteScalar());
           return ++count;
       }
       public DataTable customers()
       {
           SqlCommand cmd = new SqlCommand("select * from tbl_customer", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;

       }
       public int sale_price(string saleprice)
       {
           SqlCommand cmd = new SqlCommand("select saleprice from item where it_code="+saleprice,db.cn());
           int prise = Convert.ToInt32(cmd.ExecuteScalar());
           return prise;
                
       }
       public void save_sale_head(Classes.Db_Variables v)
       {
           SqlCommand cmd = new SqlCommand("insert into sale_head values(" + v.bill_no + ",'" + v.sh_date + "','" + v.sh_name + "'," + v.sh_gtotal + "," + v.sh_discount + "," + v.sh_net_total + ")", db.cn());
           cmd.ExecuteNonQuery();
       }
       public void save_sale_detail(Classes.Db_Variables v)
       {
           SqlCommand cmd = new SqlCommand("insert into sale_detail values("+v.bill_no+",'"+v.sd_item+"',"+v.sd_quantity+","+v.sd_price+","+v.sd_total+","+v.sd_item_code+")", db.cn());
           cmd.ExecuteNonQuery();
       }
       public DataTable report()
       {
           SqlCommand cmd = new SqlCommand("select item.it_code,item.it_name,isnull(s.saled,0)as saled from item left outer join (select sd_item_code,sum(isnull(sd_quantity,0))as saled from sale_detail group by sd_item_code )as s on item.it_code=s.sd_item_code order by s.saled desc", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;

       }
       public DataTable sales_report_head()
       {

           SqlCommand cmd2 = new SqlCommand("select * from sale_head", db.cn());
           DataTable st = new DataTable();
           SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
           adpt.Fill(st);
           return st;


       }
       public DataTable  sales_report_detail(int bill_no)
       {
           SqlCommand cmd = new SqlCommand("select sale_detail.bill_no,sale_head.sh_name,sale_head.sh_date,sale_detail.sd_item_code,sale_detail.sd_item,sale_detail.sd_price,sale_detail.sd_quantity,sale_detail.sd_total from sale_detail left outer join sale_head on sale_detail.bill_no=sale_head.bill_no where sale_detail.bill_no="+bill_no+" order by sale_detail.sd_item_code ", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;

       }
       public DataTable date_search(DateTime date1,DateTime date2)
       {
           SqlCommand cmd = new SqlCommand("select * from sale_head where sh_date between @date1 and @date2", db.cn());
           cmd.Parameters.Add("@date1",SqlDbType.DateTime).Value = date1;
           cmd.Parameters.Add("@date2", SqlDbType.DateTime).Value = date2;
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;
       }
       public DataTable sales_report_detail_search(int bill_no,string txt)
       {
           SqlCommand cmd = new SqlCommand("select sale_detail.bill_no,sale_head.sh_name,sale_head.sh_date,sale_detail.sd_item_code,sale_detail.sd_item,sale_detail.sd_price,sale_detail.sd_quantity,sale_detail.sd_total from sale_detail left outer join sale_head on sale_detail.bill_no=sale_head.bill_no where sale_detail.bill_no=" + bill_no + " and sd_item like'"+txt+"%' order by sale_detail.sd_item_code ", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;

       }
       public DataTable sales_report_head_total(int bill_no)
       {

           SqlCommand cmd = new SqlCommand("select sum(isnull(sd_quantity,0))as total_quantity,sum(isnull(sd_total,0))as bill_total from sale_detail where bill_no= " + bill_no, db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           adptr.Fill(dt);
           return dt;
       }
       public DataTable sales_man_search(object niz)
       {
           SqlCommand cmd = new SqlCommand("select *from salesman where no =" + niz, db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }
       public DataTable sales_man_search_compo()
       {
           SqlCommand cmd = new SqlCommand("select no,sl_man_name from salesman", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }
       public DataTable sales_display(int bill)
       {

           SqlCommand cmd2 = new SqlCommand("select * from sale_detail where bill_no="+bill, db.cn());
           DataTable st = new DataTable();
           SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
           adpt.Fill(st);
           return st;


       }



       public void update_sale_detail(Classes.Db_Variables v)
       {
           
          
           SqlCommand cmd = new SqlCommand("insert into sale_detail values(" + v.bill_no + ",'" + v.sd_item + "'," + v.sd_quantity + "," + v.sd_price + "," + v.sd_total + "," + v.sd_item_code + ")" , db.cn());
           cmd.ExecuteNonQuery();
       }
       public void sales_deleted(Classes.Db_Variables v)
       {
           SqlCommand cmd1 = new SqlCommand("insert into sale_deleted values(" + v.bill_no + ",'" + v.dl_item + "'," + v.dl_quantity + "," + v.dl_price + "," + v.dl_total + "," + v.dl_item_code + ")" , db.cn());
           cmd1.ExecuteNonQuery();
           SqlCommand cmd2 = new SqlCommand("delete from sale_detail where bill_no=" + v.bill_no, db.cn());
           cmd2.ExecuteNonQuery();
       }
       public void setting_yes()
       {
           SqlCommand cmd = new SqlCommand("update setting set  p = 'true' where p = 'false'", db.cn());
           cmd.ExecuteNonQuery();
       }
       public void setting_no()
       {
           SqlCommand cmd = new SqlCommand("update setting set  p = 'false' where p = 'true'", db.cn());
           cmd.ExecuteNonQuery();
       }
       public DataTable print_setting()
       {

           SqlCommand cmd2 = new SqlCommand("select p from setting ", db.cn());
           DataTable st = new DataTable();
           SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
           adpt.Fill(st);
           return st;


       }
       public void ledger_insert(Classes.Db_Variables v)
       {
           SqlCommand cmd = new SqlCommand("insert into ledger values(" + v.ld_id + ",'" + v.ld_name + "','" +v.ld_type+ "')", db.cn());
           cmd.ExecuteNonQuery();
       }
       public int ledger_id()
       {
           SqlCommand cmd = new SqlCommand("select count(ledger_id) from ledger", db.cn());
           int count = Convert.ToInt32(cmd.ExecuteScalar());
           return ++count;
       }
       public DataTable ledger_data()
       {

           SqlCommand cmd2 = new SqlCommand("select * from ledger", db.cn());
           DataTable st = new DataTable();
           SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
           adpt.Fill(st);
           return st;
       }
       public DataTable pay_compo()
       {

           SqlCommand cmd2 = new SqlCommand("select ledger_id,ledger_name from ledger", db.cn());
           DataTable st = new DataTable();
           SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
           adpt.Fill(st);
           return st;
       }
       public int pay_no()
       {
           SqlCommand cmd2 = new SqlCommand("select count(pay_no) from pay", db.cn());
           int count = Convert.ToInt32(cmd2.ExecuteScalar());
           return ++count;
       }
       //public int pay_code()
       //{
       //    SqlCommand cmd2 = new SqlCommand("select count(pay_no) from pay", db.cn());
       //    int count = Convert.ToInt32(cmd2.ExecuteScalar());
       //    return ++count;
       //}
       public DataTable pay_compoo()
       {

           SqlCommand cmd2 = new SqlCommand("select no,sl_man_name from salesman", db.cn());
           DataTable st = new DataTable();
           SqlDataAdapter adpt = new SqlDataAdapter(cmd2);
           adpt.Fill(st);
           return st;
       }
       public void payment_insert(Classes.Db_Variables v)
       {


           SqlCommand cmd = new SqlCommand("insert into pay values(" + v.pay_no + ",'" + v.pay_name + "','" + v.pay_ledger + "'," + v.pay_amount + ",@date  )", db.cn());
           cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = v.pay_date;

           cmd.ExecuteNonQuery();
       }
       public DataTable pay_gd()
       {
           SqlCommand cmd = new SqlCommand("select  pay.pay_no,pay.pay_name,pay.pay_amount,pay.pay_date,ledger.ledger_name from pay left outer join ledger on pay.pay_ledger=ledger.ledger_id order by pay.pay_no", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }
       public int receipt_no()
       {
           SqlCommand cmd2 = new SqlCommand("select count(recp_no) from receipt", db.cn());
           int count = Convert.ToInt32(cmd2.ExecuteScalar());
           return ++count;
       }


       public void receipt_insert(Classes.Db_Variables v)
       {


           SqlCommand cmd = new SqlCommand("insert into receipt values(" + v.recp_no + ",'" + v.recp_name + "','" + v.recp_ledger + "'," + v.recp_amount + ",@date  )", db.cn());
           cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = v.recp_date;

           cmd.ExecuteNonQuery();
       }
       public DataTable receipt_gd()
       {
           SqlCommand cmd = new SqlCommand("select  receipt.recp_no,receipt.recp_name,receipt.recp_amount,receipt.recp_date,ledger.ledger_name from receipt left outer join ledger on receipt.recp_ledger=ledger.ledger_id order by receipt.recp_no", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }
       public int trans_no()
       {
           SqlCommand cmd2 = new SqlCommand("select count(tr_id) from trans", db.cn());
           int count = Convert.ToInt32(cmd2.ExecuteScalar());
           return ++count;
       }
       public void trans_insert(Classes.Db_Variables v)
       {


           SqlCommand cmd = new SqlCommand("insert into trans values(@id,@date,@credit,@debit,@amound,@type)", db.cn());
           cmd.Parameters.AddWithValue("@id", v.tr_id);
           cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = v.tr_date;
           cmd.Parameters.AddWithValue("@credit", v.tr_credit);
           cmd.Parameters.AddWithValue("@debit", v.tr_debit);
           cmd.Parameters.AddWithValue("@amound", v.tr_amound);
           cmd.Parameters.AddWithValue("@type", v.tr_type);
           cmd.ExecuteNonQuery();
       }
       public DataTable trans_select_debit()
       {
           SqlCommand cmd = new SqlCommand("select  trans.tr_date,trans.tr_amound,ledger.ledger_name from trans left outer join ledger on trans.tr_debit=ledger.ledger_id where trans.tr_type ='debit'order by trans.tr_id", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }
       public DataTable trans_select_credit()
       {
           SqlCommand cmd = new SqlCommand("select  trans.tr_date,trans.tr_amound,ledger.ledger_name from trans left outer join ledger on trans.tr_credit=ledger.ledger_id where trans.tr_type ='credit'order by trans.tr_id", db.cn());
           DataTable dt = new DataTable();
           SqlDataAdapter adptr = new SqlDataAdapter(cmd);
           cmd.ExecuteNonQuery();
           adptr.Fill(dt);
           return dt;
       }
       public int debit_total()
       {
           SqlCommand cmd2 = new SqlCommand("select  sum(isnull(trans.tr_amound,0)) from trans left outer join ledger on trans.tr_debit=ledger.ledger_id where trans.tr_type ='debit'", db.cn());
           int total = Convert.ToInt32(cmd2.ExecuteScalar());
           return total;
       }
       public int credit_total()
       {
           SqlCommand cmd2 = new SqlCommand("select sum(isnull(trans.tr_amound,0))  from trans left outer join ledger on trans.tr_credit=ledger.ledger_id where trans.tr_type ='credit'", db.cn());
           int total = Convert.ToInt32(cmd2.ExecuteScalar());
           return total;
       }
   
    }
}
