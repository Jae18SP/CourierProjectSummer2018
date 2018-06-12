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
    public partial class AddCustomer : DevExpress.XtraEditors.XtraForm
    {
        int CustomerId = 0;
        public AddCustomer()
        {
            InitializeComponent();
            CustomerId = Customer.CustomerId;
            if (CustomerId != 0)
            {
                bindData(CustomerId);
            }
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            try
            {
                WindowsUIButton btn = e.Button as WindowsUIButton;
                if (btn.Caption != null && btn.Caption.Equals("Save And Close"))
                {
                    if (CustomerId == 0)
                    {
                        customerTableTableAdapter.InsertQuery(CustomerNameTextEdit.Text, CustomerMobileTextEdit.Text, isActiveCheckEdit.Checked ? true : false, false, DateTime.Now, DateTime.Now);
                        ecourierDatabaseDataSet.AcceptChanges();
                        this.Close();
                    }
                    else
                    {

                        customerTableTableAdapter.UpdateQuery(CustomerNameTextEdit.Text, CustomerMobileTextEdit.Text, isActiveCheckEdit.Checked ? true : false, DateTime.Now, CustomerId);
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

        public void bindData(int CustomerId)
        {
            DataTable dt = customerTableTableAdapter.GetDataByCustomerId(CustomerId);
            if (dt != null && dt.Rows.Count > 0)
            {
                CustomerNameTextEdit.Text = dt.Rows[0]["CustomerName"].ToString();
                CustomerMobileTextEdit.Text = dt.Rows[0]["CustomerMobile"].ToString();
                isActiveCheckEdit.Checked = Convert.ToBoolean(dt.Rows[0]["isActive"].ToString());//? true : false, false, DateTime.Now, DateTime.Now
            }
        }
    }
}