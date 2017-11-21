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
    public partial class items : Form
    {
        public items()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(number) from item", con);
            int count=Convert.ToUInt16(cmd.ExecuteScalar());
            txt_it_no.Text = Convert.ToString(count+1);
            cmd.ExecuteNonQuery();
            con.Close();
            txt_it_salesprice.Clear();
            txt_it_brand.Text = "";
            txt_it_name.Clear();
            txt_it_code.Clear();
            txt_it_catg.Text = "";
            txt_it_unit.Text = "";
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into item values(" + txt_it_no.Text + "," + txt_it_code.Text + ",'" + txt_it_name.Text + "','" + txt_it_catg.Text + "','" + txt_it_brand.Text + "','" + txt_it_unit.Text + "'," + txt_it_salesprice.Text + "," + txt_purchase_rate.Text + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
            }
            catch
            {
                con.Close();
                MessageBox.Show("Enter the full details");

            }
        }

        private void txt_it_catg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void display()
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select item.number,item.it_code,item.it_name,item.purchaserate,item.saleprice,brand.brandid,brand.brand_name,category.catg_id,category.catg_name,unit.unit_name from item left join category on item.it_category=category.catg_name left join brand on item.it_brand=brand.brand_name left join unit on item.it_unit=unit.unit_name order by item.it_name", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);

            adptr.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void txt_it_catg_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from category",con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);

            adptr.Fill(dt);
            txt_it_catg.ValueMember = "catg_id";
            txt_it_catg.DisplayMember = "catg_name";
            txt_it_catg.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txt_it_brand_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from brand", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);

            adptr.Fill(dt);
            txt_it_brand.ValueMember = "brandid";
            txt_it_brand.DisplayMember = "brand_name";
            txt_it_brand.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txt_it_unit_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from unit", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);

            adptr.Fill(dt);
            txt_it_unit.ValueMember = "unit_id";
            txt_it_unit.DisplayMember = "unit_name";
            txt_it_unit.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void items_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select item.number,item.it_code,item.it_name,item.saleprice,item.purchaserate,brand.brandid,brand.brand_name,category.catg_id,category.catg_name,unit.unit_name from item left join category on item.it_category=category.catg_name left join brand on item.it_brand=brand.brand_name left join unit on item.it_unit=unit.unit_name order by item.it_name", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);

            adptr.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_it_no.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_it_code.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_it_name.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_it_catg.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_it_brand.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_it_unit.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_it_salesprice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_purchase_rate.Text = dataGridView1.Rows[e.RowIndex].Cells["purchaserate"].Value.ToString();
            btn_update.Enabled = true;
            btn_upload.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update item set number=" + txt_it_no.Text + ",it_code=" + txt_it_code.Text + ",it_name='" + txt_it_name.Text + "',it_category='" + txt_it_catg.Text + "',it_brand='" + txt_it_brand.Text + "',it_unit='" + txt_it_unit.Text + "',saleprice=" + txt_it_salesprice.Text +",purchaserate="+txt_purchase_rate.Text + "where  it_code = " + txt_it_code.Text, con);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select item.number,item.it_code,item.it_name,item.saleprice,brand.brandid,brand.brand_name,category.catg_id,category.catg_name,unit.unit_name from item left join category on item.it_category=category.catg_name left join brand on item.it_brand=brand.brand_name left join unit on item.it_unit=unit.unit_name where it_name like '"+txt_search.Text+"%' order by item.it_name", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter rdr = new SqlDataAdapter(cmd);
            rdr.Fill(dt);
            dataGridView1.DataSource = dt;
         
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_it_salesprice.Clear();
            txt_it_brand.Text = "";
            txt_it_name.Clear();
            txt_it_code.Clear();
            txt_it_catg.Text = "";
            txt_it_unit.Text = "";
            txt_purchase_rate.Clear();

        }

        private void txt_it_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_it_catg.Focus();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
