using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }
        public Classes.Db_operations opr = new Classes.Db_operations();

        private void report_Load(object sender, EventArgs e)
        {
            gd_report.DataSource = opr.report();
           
        }
     
        
       
    
    }
    
}
