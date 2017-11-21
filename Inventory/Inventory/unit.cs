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
    public partial class unit : Form
    {
        public unit()
        {
            InitializeComponent();
        }
                public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into unit values(" + txt_unit_id.Text + ",'" + txt_unit_name.Text +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearr();
            display();
            countt();
        }
        public void countt()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(unit_id) from unit", con);
            int count = Convert.ToInt16(cmd.ExecuteScalar());
            count++;
            txt_unit_id.Text = Convert.ToString(count);
            con.Close();
        }
        public void clearr()
        {
            txt_unit_id.Clear();
            txt_unit_name.Clear();

        }
        public void display()
        {
            DataTable dt = new DataTable();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from unit order by unit_id", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            adptr.Fill(dt);
            gd_unit.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void unit_Load(object sender, EventArgs e)
        {
            display();
            countt();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearr();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update unit set unit_name=@unit where unit_id=" + txt_unit_id.Text, con);
            cmd.Parameters.AddWithValue("@unit", txt_unit_name.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }

        private void gd_unit_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_unit_id.Text=gd_unit.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_unit_name.Text = gd_unit.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

       
    }
}
