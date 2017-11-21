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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection conn1 = new SqlConnection(Properties.Settings.Default.con);
        public  SqlConnection conn =new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\AIN ADMIN\AIN DHANILJITH\samatha\samath\samath\samatha_dh.mdf;Integrated Security=True;Connect Timeout=30");
        Int32 number;
        string name;
        string address;
        Int32 mobile;
         byte[] arr;
        private void button1_Click(object sender, EventArgs e)
        {
            fd.Filter = "Image Files(*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"; 
            if (fd.ShowDialog() == DialogResult.OK)
            {
                ptrbox.Image = new Bitmap(fd.OpenFile());
                fd.Dispose();
            }
            

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_number.Text == "")
            {
                MessageBox.Show("plz enter the number");
                txt_number.Focus();
                return;
            }
            else
            {
                 number = Convert.ToInt32(txt_number.Text);

            }
            if (txt_name.Text == "")
            {
                MessageBox.Show("plz enter the name");
                txt_name.Focus();
                return;
            }
            else
            {
                name = Convert.ToString(txt_name.Text);
            }
            if (txt_adress.Text == "") 
            {
                MessageBox.Show("plz enter the adress");
                txt_adress.Focus();
                return;
            }
            else
            {
                address=Convert.ToString(txt_adress.Text);

            }
            if (txt_mobilee.Text == "")
            {
                MessageBox.Show("plz enter the mobile number");
                txt_mobilee.Focus();
                return;
            }
            else
            {
                mobile = Convert.ToInt32(txt_mobilee.Text);
            }
            if (ptrbox.Image == null)
            {
                MessageBox.Show("plz select a image");
                    btn_search.Focus();
                return;
            }
            else
            {

             Image img = ptrbox.Image;
            ImageConverter con = new ImageConverter();
           
            arr = (byte[])con.ConvertTo(img, typeof(byte[]));
            }

            conn.Open();
           SqlCommand cmd = new SqlCommand("insert into profile values(@number,@name,@adderss,@mobile,@photo)", conn);
           cmd.Parameters.AddWithValue("@number", number);
           cmd.Parameters.AddWithValue("@name", name);
           cmd.Parameters.AddWithValue("@adderss", address);
           cmd.Parameters.AddWithValue("@mobile", mobile);
           cmd.Parameters.Add("@photo", SqlDbType.VarBinary).Value = arr;
           cmd.ExecuteNonQuery();
           conn.Close();

           MessageBox.Show("inserted");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            display f = new display();
            f.ShowDialog();
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
               e.Handled=true;
            }
             

        }

        private void txt_mobilee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
             
        }
    }
}
