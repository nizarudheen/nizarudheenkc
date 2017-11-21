using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odd_number
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[]number = new int[100];
         public static int j=0;
        private void btn_1_Click(object sender, EventArgs e)
        {
           
            for (int i =0; i <= 99; i++)
            {
                if (number[i] % 2 != 0)
                {
                    listBox1.Items.Add(number[i]);
                }
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        
        {
            
            if(j<=100)
            
           {
               int frst = Convert.ToInt32(txt_1.Text);
               number[j] = frst;
               listBox2.Items.Add(number[j]);
               j++;

           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

       

       
    }
}
