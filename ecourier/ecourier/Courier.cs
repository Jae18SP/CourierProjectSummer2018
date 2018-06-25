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
using System.Data.OleDb;
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
        System.Data.DataTable dtExcelColumn = new System.Data.DataTable();
        System.Data.DataTable dtExcelData = new System.Data.DataTable();
        OleDbConnection cn = new OleDbConnection();
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog Excelname = new OpenFileDialog();
            Excelname.Filter = "Excel Files(*.xlsx)|*.xlsx";
            Excelname.ShowDialog();
            string Excel_name = Excelname.FileName;
            // txtexcel.Text = Excel_name;
            if (Excel_name.Trim() == "")
            {
                MessageBox.Show("Please Select Valid Excel");
                return;
            }
            else
            {
                cn = openexcelconnection(Excel_name);
                OleDbCommand cmds = new OleDbCommand();
                try
                {
                    DataTable objSheetNames = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null); ;
                    string ExcelSheetName = objSheetNames.Rows[0]["Table_Name"].ToString();
                    cmds.CommandText = "Select * from [" + ExcelSheetName + "]";
                    System.Data.DataTable dt = new System.Data.DataTable();
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmds.CommandText, cn);
                    adp.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        courierTableTableAdapter.InsertQuery(dr["Name"].ToString(), "0", "0", true, false, DateTime.Now, DateTime.Now);
                        ecourierDatabaseDataSet.AcceptChanges();
                    }
                    bindData();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private static OleDbConnection excelcon = null;
        public static OleDbConnection openexcelconnection(string path)
        {
            try
            {
                excelcon = new OleDbConnection();

                //excelcon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";";
                // excelcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties = "Excel 12.0 Xml;HDR=YES";

                excelcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0 Xml;HDR=YES;'";

                excelcon.Open();
                return excelcon;
            }
            catch (Exception ee)
            {
                return null;
                //XGlobals.WriteCriticalLog("openexcelconnection()ImportExcel :" + ee.Message + " : " + ee.StackTrace);
            }
        }
    }
}
