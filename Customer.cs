using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
namespace ecourier
{
    public partial class Customer : DevExpress.XtraEditors.XtraUserControl
    { 
        public static int CustomerId=0;
        public Customer()
        {
            InitializeComponent();
            bindData();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }  

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerId = 0;
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            bindData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach(int i in gridView.GetSelectedRows())
            {
                DataRow row = gridView.GetDataRow(i);
                CustomerId = Convert.ToInt32(row[0].ToString());
                AddCustomer addEmployees = new AddCustomer();
                addEmployees.ShowDialog();
                bindData();
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        public void bindData()
        {
            DataTable dt = customerTableTableAdapter.GetData();
            if (dt != null && dt.Rows.Count > 0)
            {
                gridControl.DataSource = dt;
                bsiRecordsCount.Caption = "RECORDS : " + dt.Rows.Count.ToString();
            }
            else
            {
                gridControl.DataSource = null;
                bsiRecordsCount.Caption = "RECORDS : 0";
            }
        }
    }
} 