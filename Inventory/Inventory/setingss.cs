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
    public partial class setingss : Form
    {
        public setingss()
        {
            InitializeComponent();
        }
        Classes.Db_operations opr = new Classes.Db_operations();
        private void setingss_Load(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                dt = opr.print_setting();
                if (Convert.ToBoolean(dt.Rows[0]["p"]))
                {
                    rad_yes.Checked = true;
                }
                else
                {
                    rad_no.Checked = true;

                }
            }

        }

        private void rad_no_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (rad_yes.Checked == true)
            {
                opr.setting_yes();
            }
            else if (rad_no.Checked == true)
            {
                opr.setting_no();
            }
            MessageBox.Show("Settings saved");

        }
    }
}
