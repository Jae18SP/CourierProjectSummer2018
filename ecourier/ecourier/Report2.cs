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
    public partial class Report2 : DevExpress.XtraEditors.XtraUserControl
    {
        public Report2()
        {
            InitializeComponent(); 
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        } 

        public void bindData()
        {
            try
            {
                string query = @"SELECT TicketTable.CustomerId, CustomerTable.CustomerName, CustomerTable.CustomerMobile, TicketTable.DeliverStatus,(select sum(id) from TicketTable tt1 where  tt1.CustomerId=TicketTable.CustomerId) as totalTickets
                                    FROM CustomerTable INNER JOIN TicketTable ON CustomerTable.ID = TicketTable.CustomerId;"; 
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
                    DataTable table = new DataTable();
                    table.Columns.Add("CustomerId", typeof(int));
                    table.Columns.Add("CustomerName", typeof(string));
                    table.Columns.Add("CustomerMobile", typeof(string));
                    table.Columns.Add("TotalDelivered", typeof(int));
                    table.Columns.Add("TotalNotDelivered", typeof(int));
                    table.Columns.Add("TotalTickets", typeof(int));
                    table.Columns["TotalDelivered"].DefaultValue = 0;
                    table.Columns["TotalNotDelivered"].DefaultValue = 0;
                    foreach (DataRow dr in results.Rows)
                    {
                        DataRow[] result = table.Select("CustomerId="+dr["CustomerId"].ToString());
                        if(result!=null && result.Count()>0)
                        {
                            if (dr["DeliverStatus"].ToString() == "Delviered")
                            {
                                result[0]["TotalDelivered"] = Convert.ToUInt32(result[0]["TotalDelivered"])+1;
                            }
                            else
                            {
                                result[0]["TotalNotDelivered"] = Convert.ToUInt32(result[0]["TotalNotDelivered"]) + 1;
                            }

                        }
                        else
                        { 
                            DataRow drNew = table.NewRow();
                            drNew["CustomerId"] = dr["CustomerId"];
                            drNew["CustomerName"] = dr["CustomerName"];
                            drNew["CustomerMobile"] = dr["CustomerMobile"];
                            drNew["TotalTickets"] = dr["totalTickets"]; 
                            if (dr["DeliverStatus"].ToString() == "Delivered")
                            {
                                drNew["TotalDelivered"] = 1; 
                            } 
                            else
                            {
                                drNew["TotalNotDelivered"] = 1;
                            }
                            table.Rows.Add(drNew);
                        }
                    }
                    gridControl.DataSource = table;
                }
            }
            catch (Exception)
            {

            }
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            bindData();
        }
    }
}
