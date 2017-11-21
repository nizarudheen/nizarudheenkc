using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe
{
    public partial class install_db : Form
    {
        public install_db()
        {
            InitializeComponent();
            GetLocalInstance();
        }
        DataTable objTbl;
        private void install_db_Load(object sender, EventArgs e)
        {
            objTbl = new Class.SClass().GetLocalInstance();
            cmbServers1.DataSource = objTbl.DefaultView.ToTable(true, "Server");
            cmbServers1.DisplayMember = "Server";
            cmbServers1.ValueMember = "Server";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public DataTable GetLocalInstance()
        {
            DataTable LocalInstanceNames = new DataTable();
            LocalInstanceNames.Columns.Add("Server", typeof(string));
            LocalInstanceNames.Columns.Add("Instance", typeof(string));
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (string instanceName in instanceKey.GetValueNames())
                    {
                        LocalInstanceNames.Rows.Add(Environment.MachineName, instanceName);
                    }
                }
                else
                {
                    LocalInstanceNames.Rows.Add(Environment.MachineName, "");
                }
            }
            return LocalInstanceNames;
        }
        private void ConfigureDataBase(string serverName, string userId, string password, string ApplicationPath)
        {
            try
            {
                Class.SClass ClassS = new Class.SClass();
                if (ClassS.CheckMsSqlConnection(serverName, userId, password, ApplicationPath))
                {

                    ClassS.UpdateAppConfig("MsSqlServer", serverName);
                    ClassS.UpdateAppConfig("MsSqlUserId", userId);
                    ClassS.UpdateAppConfig("MsSqlPassword", password);
                    ClassS.UpdateAppConfig("ApplicationPath", ApplicationPath);

                    serverName = (ConfigurationManager.AppSettings["MsSqlServer"] == null || ConfigurationManager.AppSettings["MsSqlServer"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlServer"].ToString();
                    userId = (ConfigurationManager.AppSettings["MsSqlUserId"] == null || ConfigurationManager.AppSettings["MsSqlUserId"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlUserId"].ToString();
                    password = (ConfigurationManager.AppSettings["MsSqlPassword"] == null || ConfigurationManager.AppSettings["MsSqlPassword"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlPassword"].ToString();
                    ApplicationPath = (ConfigurationManager.AppSettings["ApplicationPath"] == null || ConfigurationManager.AppSettings["ApplicationPath"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["ApplicationPath"].ToString();
                    if (ClassS.CheckMsSqlConnection(serverName, userId, password, ApplicationPath))
                    {
                        Environment.ExitCode = 100;
                        Form1 f = new Form1();
                        f.Show();
                        // this.Close();

                        //Class.CompanySetup comset = new Class.CompanySetup();
                        //if (comset.ReadCompanyName() == true)
                        //{

                        //    Login Login = new Login();
                        //    Login.Show();
                        //}
                        //else
                        //{
                        //    Initinal_Setup_1 InSp1 = new Initinal_Setup_1();
                        //    InSp1.Show();
                        //}


                        this.Visible = false;
                    }
                    else
                    {
                        Environment.ExitCode = 101;
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbServers1_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbInstance1.Text = string.Empty;
            cmbPath.DataSource = null;
            if (objTbl != null)
            {
                List<string> lstResult = (from table in objTbl.AsEnumerable()
                                          where table.Field<string>("Server").ToString() == (cmbServers1.Text).ToString()
                                          select table.Field<string>("Instance")).Distinct().ToList();

                cmbInstance1.DataSource = lstResult;
            }
        }

        private void cmbServers1_BindingContextChanged(object sender, EventArgs e)
        {
            if (objTbl != null)
            {
                List<string> lstResult = (from table in objTbl.AsEnumerable()
                                          where table.Field<string>("Server").ToString() == (cmbServers1.Text).ToString()
                                          select table.Field<string>("Instance")).Distinct().ToList();

                cmbInstance1.DataSource = lstResult;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cmbPath.Text != string.Empty)
            {
                if (!radioButton3.Checked)
                {
                    ConfigureDataBase(cmbServers1.Text + @"\" + cmbInstance1.Text, null, null, cmbPath.Text);
                }
                else
                {
                    ConfigureDataBase(cmbServers1.Text + @"\" + cmbInstance1.Text, textBox1.Text, textBox2.Text, cmbPath.Text);
                }
            }
            else
            {
                cmbPath.Focus();
                MessageBox.Show("connection path is empty.! \nTry to connect server with credentials.");
            }
        }
    }
}
