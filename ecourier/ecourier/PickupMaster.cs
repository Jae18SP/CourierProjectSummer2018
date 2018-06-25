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
    public partial class PickupMaster : DevExpress.XtraEditors.XtraForm
    {
        public static int pickupID = 0;
        public PickupMaster()
        {
            InitializeComponent();
        }

        private void PickupMaster_Load(object sender, EventArgs e)
        { 
            bindData();
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            WindowsUIButton btn = e.Button as WindowsUIButton;
            if (btn.Caption != null && btn.Caption.Equals("Save"))
            { 
                //string workingHours = WorkingHoursDateEdit.Time.ToShortTimeString() + " TO " + WorkingHoursDateEditTo.Time.ToShortTimeString();
                pickuptableTableAdapter.InsertQuery(Pickup_Intersaction_nameTextEdit.Text, DateTime.Now, DateTime.Now, false, isActiveCheckEdit.Checked ? true : false);
                ecourierDatabaseDataSet.AcceptChanges();
                bindData();
                Pickup_Intersaction_nameTextEdit.Text = "";
                //this.Close();
            }
            else if (btn.Caption != null && btn.Caption.Equals("Update"))
            {
                if (pickupID != 0)
                {
                    pickuptableTableAdapter.UpdateQuery(Pickup_Intersaction_nameTextEdit.Text, DateTime.Now, isActiveCheckEdit.Checked ? true : false, pickupID);
                    ecourierDatabaseDataSet.AcceptChanges();
                   // this.Close();
                    Pickup_Intersaction_nameTextEdit.Text = "";
                    pickupID = 0;
                    bindData();
                }
                else
                {
                    MessageBox.Show("Select value to be updated");
                }
            }
            else if (btn.Caption != null && btn.Caption.Equals("Delete"))
            {
                if (pickupID != 0)
                {
                    pickuptableTableAdapter.DeleteQuery(DateTime.Now, true, pickupID);
                    ecourierDatabaseDataSet.AcceptChanges();
                    // this.Close();
                    Pickup_Intersaction_nameTextEdit.Text = "";
                    pickupID = 0;
                    bindData();
                }
                else
                {
                    MessageBox.Show("Select value to be updated");
                }
            }


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            foreach (int i in gridView1.GetSelectedRows())
            {
                DataRow row = gridView1.GetDataRow(i);
                pickupID = Convert.ToInt32(row[0].ToString());
                Pickup_Intersaction_nameTextEdit.Text = row[1].ToString();
            }
        }
        public void bindData()
        {
            DataTable dt = pickuptableTableAdapter.GetData();
            if (dt != null && dt.Rows.Count > 0)
            {
                gridControl1.DataSource = dt; 
            }
            else
            {
                gridControl1.DataSource = null; 
            }
        }
    }
}