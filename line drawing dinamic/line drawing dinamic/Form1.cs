using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace line_drawing_dinamic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
       private void line(object sender, PaintEventArgs e)

        {
            Pen myPen = new Pen(System.Drawing.Color.Black,1);
            e.Graphics.DrawLine(myPen, 5, 5, 80, 90);
            
            
        }
    }
}
