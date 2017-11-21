using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int frst = Convert.ToInt32(txt_1.Text);
            if (frst % 2 == 0)
            {
                MessageBox.Show("even number");
            }
            else
            {
                MessageBox.Show("odd number");
            }
        }

       
       
    }
}
