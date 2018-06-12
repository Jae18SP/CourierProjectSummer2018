using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using DevExpress.XtraBars.Docking2010;

namespace ecourier
{
    public partial class AddEmployees : DevExpress.XtraEditors.XtraForm
    {
        int EmployeeId = 0;
        public AddEmployees()
        {
            InitializeComponent();
            EmployeeId = OrderTaker.EmployeeId;
            if (EmployeeId != 0)
            {
                bindData(EmployeeId);
            }
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            try
            {
                WindowsUIButton btn = e.Button as WindowsUIButton;
                if (btn.Caption != null && btn.Caption.Equals("Save And Close"))
                {
                    if (EmployeeId == 0)
                    { 
                        employeeTableTableAdapter.InsertQuery(UserNameTextEdit.Text, PasswordTextEdit.Text, isActiveCheckEdit.Checked ? true : false, false, DateTime.Now, DateTime.Now, isAdminUser.Checked ? true : false);
                        ecourierDatabaseDataSet.AcceptChanges();
                        this.Close();
                    }
                    else
                    {
                         
                        employeeTableTableAdapter.UpdateQuery(UserNameTextEdit.Text, PasswordTextEdit.Text, isActiveCheckEdit.Checked ? true : false, DateTime.Now, isAdminUser.Checked ? true : false, EmployeeId);
                        ecourierDatabaseDataSet.AcceptChanges();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went wrong");
            }
        }
        public void bindData(int EmployeeId)
        {
            try
            {
                DataTable dt = employeeTableTableAdapter.GetDataByEmployeeId(EmployeeId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    UserNameTextEdit.Text = dt.Rows[0]["UserName"].ToString();
                    PasswordTextEdit.Text = dt.Rows[0]["Password"].ToString();
                    isActiveCheckEdit.Checked = Convert.ToBoolean(dt.Rows[0]["isActive"].ToString());//? true : false, false, DateTime.Now, DateTime.Now
                    isAdminUser.Checked = Convert.ToBoolean(dt.Rows[0]["isAdmin"].ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("SOMETHING WENT WRONG");
            }
        }

    }
}