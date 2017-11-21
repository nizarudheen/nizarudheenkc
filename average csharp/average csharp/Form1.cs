using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace average_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txt_1.Text );
            int j = Convert.ToInt32(txt_2.Text);
            int k = Convert.ToInt32(txt_3.Text);
            int l = Convert.ToInt32(txt_4.Text);
            int result = (i + j + k + l) / 4;
            txt_5.Text = "the average of "+i+","+j+","+k+","+l+" = "+result;
        }

        
    }
}
