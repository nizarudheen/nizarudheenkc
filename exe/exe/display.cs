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

namespace exe
{
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\AIN ADMIN\AIN DHANILJITH\samatha\samath\samath\samatha_dh.mdf;Integrated Security=True;Connect Timeout=30");
        private void display_Load(object sender, EventArgs e)
        {
             conn.Open();
              DataTable dt=new DataTable ();

            SqlCommand cmd=new SqlCommand ("select * from profile",conn);
            SqlDataAdapter v = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            v.Fill(dt);
            
            conn.Close();
            gd_view.DataSource = dt;
        }
    }
}
