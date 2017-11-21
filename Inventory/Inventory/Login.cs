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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Db db = new Classes.Db();
           // SqlCommand cmd = new SqlCommand("select * from tbl_login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", db.cn());
            DataTable dt = new DataTable();
           // SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            //adptr.Fill(dt);
            //if (dt.Rows.Count > 0)
            {
                Form1 f = new Form1();

                f.ShowDialog();

            }
            //else
            //{
            //    MessageBox.Show("password incorrect");
            //    return;
            //}
                
        }
    }
}
