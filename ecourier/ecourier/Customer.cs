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

        private void customerTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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
                    foreach(DataRow dr in dt.Rows)
                    {
                        customerTableTableAdapter.InsertQuery(dr["Name"].ToString(),"0",0,true, false, DateTime.Now, DateTime.Now);
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

                excelcon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+path+";Extended Properties='Excel 12.0 Xml;HDR=YES;'";

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