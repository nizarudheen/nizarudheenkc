using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventory
{
    public partial class item_views : Form
    {
        public item_views()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void gd_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void item_views_Load(object sender, EventArgs e)
        {
            display();
        }
        public void display()
    {
        DataTable dt = new DataTable();
        con.Open();
        SqlCommand cmd = new SqlCommand("select item.number,item.it_code,item.it_name,item.purchaserate,item.saleprice,brand.brandid,brand.brand_name,category.catg_id,category.catg_name,unit.unit_name from item left join category on item.it_category=category.catg_name left join brand on item.it_brand=brand.brand_name left join unit on item.it_unit=unit.unit_name order by item.it_name", con);
        SqlDataAdapter adptr = new SqlDataAdapter(cmd);
       
        adptr.Fill(dt);
        gd_view.DataSource = dt;
        cmd.ExecuteNonQuery();
        con.Close();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select item.number,item.it_code,item.it_name,item.saleprice,brand.brandid,brand.brand_name,category.catg_id,category.catg_name,unit.unit_name from item left join category on item.it_category=category.catg_name left join brand on item.it_brand=brand.brand_name left join unit on item.it_unit=unit.unit_name where it_name like '" + txt_view_search.Text + "%' order by item.it_name", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter rdr = new SqlDataAdapter(cmd);
            rdr.Fill(dt);
            gd_view.DataSource = dt;

            con.Close();
        }
    }
}
