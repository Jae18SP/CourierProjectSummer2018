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
    public partial class AddCourier : DevExpress.XtraEditors.XtraForm
    {
        int courierId = 0;
        public AddCourier()
        {
            InitializeComponent();
            courierId = Courier.CourierId;
            if(courierId!=0)
            {
                bindData(courierId);
            }
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            try
            {
                WindowsUIButton btn = e.Button as WindowsUIButton;
                if (btn.Caption != null && btn.Caption.Equals("Save And Close"))
                {
                    if (courierId==0)
                    {
                        string workingHours = WorkingHoursDateEdit.Time.ToShortTimeString() + " TO " + WorkingHoursDateEditTo.Time.ToShortTimeString();
                        courierTableTableAdapter.InsertQuery(CourierNameTextEdit.Text, ContactNumberTextEdit.Text, workingHours, isActiveCheckEdit.Checked ? true : false, false, DateTime.Now, DateTime.Now);
                        ecourierDatabaseDataSet.AcceptChanges();
                        this.Close(); 
                    }
                    else
                    {
                        string workingHours = WorkingHoursDateEdit.Time.ToShortTimeString() + " TO " + WorkingHoursDateEditTo.Time.ToShortTimeString();
                        courierTableTableAdapter.UpdateQuery(CourierNameTextEdit.Text, ContactNumberTextEdit.Text, workingHours, isActiveCheckEdit.Checked ? true : false, DateTime.Now,courierId);
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

        public void bindData(int courierId)
        {
            DataTable dt = courierTableTableAdapter.GetDataByCourierId(courierId);
            if(dt!=null && dt.Rows.Count>0)
            {
                CourierNameTextEdit.Text = dt.Rows[0]["CourierName"].ToString();
                ContactNumberTextEdit.Text = dt.Rows[0]["ContactNumber"].ToString();
                string time = dt.Rows[0]["WorkingHours"].ToString(); 
                //WorkingHoursDateEdit.EditValue = dt.Rows[0]["WorkingHours"].ToString();
                //WorkingHoursDateEditTo.EditValue = dt.Rows[0]["WorkingHours"].ToString();
                isActiveCheckEdit.Checked = Convert.ToBoolean(dt.Rows[0]["isActive"].ToString());//? true : false, false, DateTime.Now, DateTime.Now
            }
        }

        private void AddCourier_Load(object sender, EventArgs e)
        {

        }
    }
}