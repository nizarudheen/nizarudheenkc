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
namespace odd_number
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SYS15\Documents\TestDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label6_Click(object sender, EventArgs e)
        {

        }
      
        public void update()
        {
           

            con.Open();
            SqlCommand cmd = new SqlCommand(("update studentdetails set name='"+txt_name.Text+"',sex='" +txt_male.Text+"',course='"+ txt_course.Text+"',address='"+txt_adress.Text+"',mobile="+txt_mobile_no.Text+",email='"+txt_email.Text+"',pic='"+ptr_box.Image+"' where admission_no="+txt_addm_no.Text), con);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void display2()
        {
            DataTable dt=new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentdetails",con);
            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            adptr.Fill(dt);
            con.Close();

           
         //   Image image = Image.FromFile("Image Path");
           // img.Image = image;
            //img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //gd_details.RowTemplate.Height = 250; 
            //gd_details.Columns.Add(img);
            
            //img.HeaderText = "Image";
            gd_details.Columns.Add("ad", "ad");
            gd_details.Columns.Add("name", "name");
            gd_details.Columns.Add("image", "image");
            if (dt.Rows.Count > 0)
            {

                Byte[] data = new Byte[0];
                data = (Byte[])(dt.Rows[0][7]);
                MemoryStream mem = new MemoryStream(data);
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                gd_details.Rows.Add(data);
                ptr_box.Image = Image.FromStream(mem);
                ptr_box.Image = Image.FromStream(mem);
                 for (int i = 0; i < dt.Rows.Count; i++)
                 {
                     gd_details.Rows.Add();
                     gd_details.Rows[i].Cells[0].Value = dt.Rows[i][0];
                     gd_details.Rows[i].Cells[1].Value = dt.Rows[i][1];
                     gd_details.Rows[i].Cells[2].Value =Image.FromStream(mem);


                 }
            }
        }
        public void display()
        {
            DataTable dt = new DataTable();
            con.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM studentdetails ", con);
            SqlDataAdapter adpter = new SqlDataAdapter(cmd);
            adpter.Fill(dt);
            con.Close();
            gd_details.DataSource = dt;
        }
        public void insertdata()
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into studentdetails values(" + txt_addm_no.Text + ",'" + txt_name.Text + "','" + txt_male.Text + "','" + txt_course.Text + "','" + txt_adress.Text + "'," + txt_mobile_no.Text + ",'" + txt_email.Text+ "','"+ptr_box.Image+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            insertdata();
           // display();
            display2();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           display2();
            course();
        }

        private void gd_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
      
        
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_addm_no.Text == "")
            {
                MessageBox.Show("insert admission no");
                txt_addm_no.Focus();
                return;
            }
            else if (txt_name.Text == "")
            {
                MessageBox.Show("insert name");
                txt_name.Focus();
                return;
            }
            else if (txt_mobile_no.Text == "")
            {
                MessageBox.Show("insert mobile no");
                txt_mobile_no.Focus();
                return;
            }
            else
            {
                update();
            }
            display();

            btn_clear.PerformClick();
        }
        public void course()
        {
            con.Open();
               SqlCommand cmd = new SqlCommand("select * from course",con);
               SqlDataAdapter cou = new SqlDataAdapter(cmd);
               cmd.ExecuteNonQuery();
               con.Close();
               DataTable dl=new DataTable();
            cou.Fill(dl);
            txt_course.ValueMember = "course_id";
            txt_course.DisplayMember = "course_name";
            txt_course.DataSource = dl;


        }


        private void gd_details_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_addm_no.Text = gd_details.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = gd_details.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_male.Text = gd_details.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_course.Text = gd_details.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_adress.Text = gd_details.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_mobile_no.Text = gd_details.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_email.Text = gd_details.Rows[e.RowIndex].Cells[6].Value.ToString();
           
           
            txt_addm_no.ReadOnly = true;
        }
        public void clear()
        {
            txt_addm_no.ReadOnly = false;
            txt_addm_no.Clear();
            txt_adress.Clear();
            
            txt_email.Clear();
            txt_mobile_no.Clear();
            txt_name.Clear();
            ptr_box.Image = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

            clear();

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            string filename = "";
            fd.ShowDialog();
            fd.Title = "select a image";
            fd.Filter = "image files|*.jpeg;*.png;*.gif;*.icon;.*;";
           
            if (fd.ShowDialog() == DialogResult.OK)
            {

                filename = fd.FileName;
                ptr_box.Image = new Bitmap(filename);
                   
            }
            MessageBox.Show(filename);
            fd.Dispose();
            Image img = ptr_box.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            
           
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txt_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            course();
        }

        

        
    
    

     }
}
