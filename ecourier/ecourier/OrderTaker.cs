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
    public partial class OrderTaker : DevExpress.XtraEditors.XtraUserControl
    {
        public static int EmployeeId = 0;
        public OrderTaker()
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
            AddEmployees addEmployees = new AddEmployees();
            addEmployees.ShowDialog(); 
            bindData();
        }

        public void bindData()
        {
            DataTable dt = employeeTableTableAdapter.GetData();
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

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (int i in gridView.GetSelectedRows())
            {
                DataRow row = gridView.GetDataRow(i);
                EmployeeId = Convert.ToInt32(row[0].ToString());
                AddEmployees addEmployees = new AddEmployees();
                addEmployees.ShowDialog();
                bindData();
            }
        }
    }
}
