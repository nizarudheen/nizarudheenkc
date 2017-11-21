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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void upload_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into category values(" + txt_catg_id.Text + ",'" + txt_catg_name.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearr();
            display();
            countt();
        }
        public void clearr()
        {
            txt_catg_id.Clear();
            txt_catg_name.Clear();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearr();
        }
        public void display()
        {
            DataTable dt = new DataTable();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from category", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            adptr.Fill(dt);
            gd_details_catg.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void countt()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(catg_id) from category", con);
            int count = Convert.ToInt16(cmd.ExecuteScalar());
            count++;
            txt_catg_id.Text = Convert.ToString(count);
            con.Close();
        }

        private void gd_details_catg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void category_Load(object sender, EventArgs e)
        {
            display();
            countt();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update category set catg_name=@unit where catg_id="+txt_catg_id.Text , con);
            cmd.Parameters.AddWithValue("@unit", txt_catg_name.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }

        private void gd_details_catg_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_catg_id.Text = gd_details_catg.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_catg_name.Text = gd_details_catg.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
       
    }
}
