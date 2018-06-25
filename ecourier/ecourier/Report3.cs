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
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.Data;
namespace ecourier
{
    public partial class Report3 : DevExpress.XtraEditors.XtraUserControl
    {
        public Report3()
        {
            InitializeComponent(); 
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        } 
        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        public void bindData()
        {
            try
            {
                string query = @"SELECT distinct TicketTable.CourierId, CourierTable.CourierName, CourierTable.ContactNumber ,(select count(id) from TicketTable tt1 where  tt1.CourierId=TicketTable.CourierId and tt1.DeliverStatus='Delivered' ) as totalTickets ,((select count(id) from TicketTable tt1 where  tt1.CourierId=TicketTable.CourierId and tt1.DeliverStatus='Delivered' )*5) as bonousAmount
                                FROM CourierTable INNER JOIN TicketTable ON CourierTable.ID = TicketTable.CourierId;";
                string connString = ConfigurationManager.ConnectionStrings["ecourier.Properties.Settings.ecourierDatabaseConnectionString"].ConnectionString;
                DataTable results = new DataTable();
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(results);
                    conn.Close();
                }
                if (results != null && results.Rows.Count > 0)
                { 
                    gridControl.DataSource = results;
                }
            }
            catch (Exception)
            {

            }
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            bindData();
        }
    }
}
