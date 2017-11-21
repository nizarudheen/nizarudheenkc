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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Brand_Load(object sender, EventArgs e)
        {
            display();
            countt();

        }
        public void display()
        {
            DataTable dt = new DataTable();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from brand order by brandid ", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            adptr.Fill(dt);
            gd_brand.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void clear()
        {
            txt_brand_id.Clear();
            txt_brand_name.Clear();
            
        }
        public void countt()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select count(brandid) from brand", con);
        int count = Convert.ToInt16(cmd.ExecuteScalar());
        count++;
        txt_brand_id.Text = Convert.ToString(count);
        con.Close();
    }
       

        private void btn_upload_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into brand values(" + txt_brand_id.Text + ",'" + txt_brand_name.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            clear();
            countt();
     }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void r(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void r(object sender, EventArgs e)
        {

        }

        private void gd_brand_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_brand_id.Text = gd_brand.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_brand_name.Text = gd_brand.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void txt_brand_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_brand_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_upload.Focus();
            }
        }
    }
}
