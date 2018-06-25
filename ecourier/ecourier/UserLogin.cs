using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using ecourier.ecourierDatabaseDataSetTableAdapters;
using System.Web.Script.Serialization;
using System.Net;
using System.Text.RegularExpressions;
using DevExpress.XtraBars.Docking2010;
using System.Configuration;
using System.Data.OleDb;

namespace ecourier
{
    public partial class UserLogin : DevExpress.XtraEditors.XtraForm
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["ecourier.Properties.Settings.ecourierDatabaseConnectionString"].ConnectionString;
            DataTable results = new DataTable();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(@"SELECT * from EmployeeTable where UserName='" + txtUserName.Text + "' and  Password='"+txtPassword.Text+"'", conn);
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(results);
                conn.Close();
            }
            if(results!=null && results.Rows.Count>0)
            {
                if(results.Rows[0]["isAdmin"].ToString()=="True")
                {
                    Properties.Settings.Default.isAdmin = 1;
                }
                else
                {
                    Properties.Settings.Default.isAdmin = 0; 
                }
                this.DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
