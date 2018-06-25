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
    public partial class Report : DevExpress.XtraEditors.XtraUserControl
    {
        public Report()
        {
            InitializeComponent(); 
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        public void customerQuery()
        {
            try
            {
                string query = @"SELECT CustomerTable.CustomerName, Pickuptable.Pickup_Intersaction_name AS PickUp, Pickuptable_1.Pickup_Intersaction_name AS Destination, CourierTable.CourierName, TicketTable.EstimatedRate
            FROM(((TicketTable INNER JOIN CustomerTable ON TicketTable.CustomerId = CustomerTable.ID) INNER JOIN Pickuptable ON TicketTable.PickupIntersectionId = Pickuptable.ID) INNER JOIN Pickuptable AS Pickuptable_1 ON TicketTable.DeliverIntersectionId = Pickuptable_1.ID) INNER JOIN CourierTable ON TicketTable.CourierId = CourierTable.ID
            WHERE(((TicketTable.DeliverStatus) = 'Delivered')) ORDER BY TicketTable.DOC DESC";

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
                    GridColumnSummaryItem item = gridColumn5.Summary.Add(SummaryItemType.Custom);
                    item.FieldName = "EstimatedRate";
                    item.DisplayFormat = "{0:n2}";
                }
            }
            catch (Exception)
            {

            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            customerQuery();
        }
    }
}
