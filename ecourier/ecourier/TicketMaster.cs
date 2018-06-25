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
using System.Data.OleDb;
using System.Configuration;

namespace ecourier
{
    public partial class TicketMaster : DevExpress.XtraEditors.XtraUserControl
    {
        public static int checkStatus = 0;
        public static int pickupId = 0;
        public TicketMaster()
        {
            InitializeComponent();
            BindData();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void ticketTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ScheduleTicket scheduleTicket = new ScheduleTicket();
            checkStatus = 1;
            scheduleTicket.ShowDialog();
            BindData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (int i in gridView.GetSelectedRows())
            {
                DataRow row = gridView.GetDataRow(i);
                pickupId = Convert.ToInt32(row[0].ToString());
                ScheduleTicket scheduleTicket = new ScheduleTicket();
                checkStatus = 2;
                scheduleTicket.ShowDialog();
                BindData();
            }
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (int i in gridView.GetSelectedRows())
            {
                DataRow row = gridView.GetDataRow(i);
                pickupId = Convert.ToInt32(row[0].ToString());
                ScheduleTicket scheduleTicket = new ScheduleTicket();
                checkStatus = 3;
                scheduleTicket.ShowDialog();
                BindData();
            }
        }

        public void BindData() 
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["ecourier.Properties.Settings.ecourierDatabaseConnectionString"].ConnectionString; 
                DataTable results = new DataTable(); 
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    OleDbCommand cmd = new OleDbCommand(@"SELECT TicketTable.ID, CustomerTable.CustomerName, Pickuptable.Pickup_Intersaction_name, Pickuptable_1.Pickup_Intersaction_name, TicketTable.PickUpDate, TicketTable.PickupTime, TicketTable.DeliveryDate, TicketTable.DeliveryTime, TicketTable.DeliverStatus
                FROM((TicketTable INNER JOIN CustomerTable ON TicketTable.CustomerId = CustomerTable.ID) INNER JOIN Pickuptable ON TicketTable.PickupIntersectionId = Pickuptable.ID) INNER JOIN Pickuptable AS Pickuptable_1 ON TicketTable.DeliverIntersectionId = Pickuptable_1.ID;", conn); 
                    conn.Open(); 
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd); 
                    adapter.Fill(results);
                    conn.Close();
                } 
                gridControl.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR IN TICKET MASTER" + ex.Message);
            }
        }
    }
}
