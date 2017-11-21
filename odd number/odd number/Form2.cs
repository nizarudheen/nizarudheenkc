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
namespace odd_number
{
    public partial class Form2 : Form
    {
        public Form2()
        {
           // current = this;
            InitializeComponent();
        }
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

            Form3 f = new Form3();
            f.txtname.Text ="student name :"+Convert.ToString(txt_name.Text);
            f.txtstandred.Text = Convert.ToString(txt_standred.Text);
            if (txt_male.Checked == true)
            {
                f.txtmalefemale.Text = "male";
            }
            else
            {
                f.txtmalefemale.Text = "female";
            
            }
          
            f.txtaddress.Text = Convert.ToString(txt_address.Text);
            f.txtdateofbirth.Text = Convert.ToString(txt_date.Text);
            f.txtaddno.Text = Convert.ToString(txt_admnno.Text);
            

            f.gd_details.ColumnCount = 6;
            f.gd_details.Columns[0].Name = "name";
            f.gd_details.Columns[1].Name = "Standred";
            f.gd_details.Columns[2].Name = "male/female";
            f.gd_details.Columns[3].Name = "address";
            f.gd_details.Columns[4].Name = "DOB";
            f.gd_details.Columns[5].Name = "admission no";

            //f.gd_details.Columns[2].HeaderText = "male/female";
          //  f.gd_details.Columns[3].HeaderText = "address";
          //  f.gd_details.Columns[4].HeaderText = "DOB";
           // f.gd_details.Columns[5].HeaderText = "admission no"; 





            f.gd_details.Rows.Add();
            f.gd_details.Rows[0].Cells["name"].Value = txt_name.Text;
            f.gd_details.Rows[0].Cells["Standred"].Value = txt_standred.Text;
            if (txt_male.Checked == true)
            {
                f.gd_details.Rows[0].Cells["male/female"].Value = txt_male.Text;
            }
            else
            {
                f.gd_details.Rows[0].Cells["male/female"].Value = txt_female.Text;
            }

            f.gd_details.Rows[0].Cells["address"].Value = txt_address.Text;
            f.gd_details.Rows[0].Cells["DOB"].Value = txt_date.Text;
            f.gd_details.Rows[0].Cells["admission no"].Value = txt_admnno.Text;
            f.ShowDialog();
            
        }

        public void insert_data()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into student values (" + txt_admnno.Text + ",'" + txt_name.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

          
        private void button2_Click(object sender, EventArgs e)
        {
            insert_data();
            DataTable dt= new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM student where ad_no="+txt_address.Text, conn);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            adpter.Fill(dt);
            conn.Close();
          
        }
    }
}
