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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int frst = Convert.ToInt32(txt_first.Text);
            int scnd = Convert.ToInt32(txt_scnd.Text);
            txt_result.Text = (frst + scnd).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_first.Clear();
            txt_scnd.Clear();
            txt_result.Clear();
           
        }

        private void btn_minus(object sender, EventArgs e)
        {
            decimal frst = Convert.ToDecimal(txt_first.Text);
            decimal scnd = Convert.ToDecimal(txt_scnd.Text);
            txt_result.Text = (frst - scnd).ToString();
        }

        private void btn_multiplication(object sender, EventArgs e)
        {
            decimal frst = Convert.ToDecimal(txt_first.Text);
            decimal scnd = Convert.ToDecimal(txt_scnd.Text);
            txt_result.Text = (frst * scnd).ToString();
        }

        private void btn_division(object sender, EventArgs e)
        {
            decimal frst = Convert.ToDecimal(txt_first.Text);
            decimal scnd = Convert.ToDecimal(txt_scnd.Text);
            txt_result.Text = (frst / scnd).ToString();
        }

       
        
    }
}
