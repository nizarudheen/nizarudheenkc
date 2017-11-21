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
    
    public partial class Listbox_Printing : Form
    {
        public Listbox_Printing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[]number = new int[500];
            int n=Convert.ToInt32(txt_nmbr.Text);
            for (int i = 1; i <= 5; i++)
            {
                int result = n * i;
 listBox1.Items.Add(n+" * "+i+" = "+result);         
            }
        }
    }
}
