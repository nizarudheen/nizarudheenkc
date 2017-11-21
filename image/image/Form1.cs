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
using System.IO;
namespace image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Int32 count;

        public static byte[] arr;
        
            public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void gddisplay()
        {
            countt();
            txt_addno.Text =Convert.ToString( count);
            DataTable ds = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from data", con);

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            adptr.Fill(ds);
            gd_details.ColumnCount = 2;
            gd_details.Columns[0].Name = "admnno";
            gd_details.Columns[0].HeaderText = "admnno";
            gd_details.Columns[1].Name = "name";
            gd_details.Columns[1].HeaderText = "name";
           
            
          
            
            for (int i = 0; i < ds.Rows.Count; i++) 
            {
                gd_details.Rows.Add();
                gd_details.Rows[i].Cells[0].Value=ds.Rows[i][0];
                gd_details.Rows[i].Cells[1].Value = ds.Rows[i][1];
                

            }

            con.Close();

        }
        public void clear()
        {
            
            txt_name.Clear();
            ptr_box.Image = null;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files(*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                if(fd.ShowDialog()==DialogResult.OK)
                {
                    ptr_box.Image=new Bitmap(fd.FileName);
                   fd.Dispose();
                    Image img=ptr_box.Image;
                    ImageConverter converter=new ImageConverter();
                   
                    arr=(byte[])converter.ConvertTo(img,typeof(byte[]));

                    
                }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into data values("+txt_addno.Text+",'"+txt_name.Text+"',@photo)", con);
            cmd.Parameters.AddWithValue("@photo", arr);
             cmd.ExecuteNonQuery();
          
            con.Close();
            gddisplay();
          

            clear();
        }
        public void countt()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand("select count (id) from data", con);

            count = Convert.ToInt32(cmdd.ExecuteScalar());
            cmdd.ExecuteNonQuery();
            count++;
            txt_addno.Text = Convert.ToString(count);
            con.Close();
        }

        private void ptr_box_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable sd=new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from data where id="+txt_addno.Text,con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            adptr.Fill(sd);
            txt_name.Text = Convert.ToString(sd.Rows[0][1]);
            if (sd.Rows[0][2] != System.DBNull.Value)
            {
                arr = (byte[])sd.Rows[0][2];
                MemoryStream ms = new MemoryStream(arr);
                ptr_box.Image = Image.FromStream(ms);
            }
            con.Close();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gddisplay();
        }

       

        private void gd_name_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

      

        private void txt_nmsearch_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_nmsearch_TextChanged(object sender, EventArgs e)
        {
            if (gd_details.Columns.Count > 0)
                gd_details.Columns.Clear();
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select id,name from data where name like '" + txt_nmsearch.Text + "%'", con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            adptr.Fill(dt);
            gd_details.DataSource = dt;
            con.Close();
          ////  SqlDataReader reader = cmd.ExecuteReader();
        //     AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
        //  while (reader.Read())
        //{
        //    MyCollection.Add(reader.GetString(0));
        //}
        //    txt_nmsearch.AutoCompleteCustomSource=MyCollection;
            
        //    con.Close();
        }
    }                                                                                   
}
