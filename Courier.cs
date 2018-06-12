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
    public partial class Courier : DevExpress.XtraEditors.XtraUserControl
    {
        public static int CourierId = 0;
        public Courier()
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
            CourierId = 0;
            AddCourier addCourier = new AddCourier();
            addCourier.ShowDialog();
            bindData();
        }

        public void bindData()
        {
            DataTable dt = courierTableTableAdapter.GetData();
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
                CourierId = Convert.ToInt32(row[0].ToString());
                AddCourier addCourier = new AddCourier();
                addCourier.ShowDialog();
                bindData();
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Really close?", "Exit", MessageBoxButtons.YesNo) ==  System.Windows.Forms.DialogResult.Yes)
            {

                foreach (int i in gridView.GetSelectedRows())
                {
                    DataRow row = gridView.GetDataRow(i);
                    CourierId = Convert.ToInt32(row[0].ToString());
                    courierTableTableAdapter.DeleteQuery(true, DateTime.Now, CourierId);
                    ecourierDatabaseDataSet.AcceptChanges();
                }
                MessageBox.Show("Courier Patener has been Deleted");
                bindData();
            }
            else
            { 
                MessageBox.Show("Courier Patener is Safe");
            }
        }
    }
}
