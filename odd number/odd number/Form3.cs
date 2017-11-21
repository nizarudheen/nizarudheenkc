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
    public partial class Form3 : Form
    {
        public Form3()
        {
           // current = this;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {


            this.Hide();
           /// Form2.Current.ShowDialog(); 




       
        }

    }
}
