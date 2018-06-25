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

namespace ecourier
{
    public partial class ScheduleTicket : DevExpress.XtraEditors.XtraForm
    {
        public ScheduleTicket()
        {
            InitializeComponent();
        }

        public void bindCombo()
        {
            PickuptableTableAdapter pickuptableTableAdapter = new PickuptableTableAdapter();
            comboBox2.DataSource = pickuptableTableAdapter.GetData();
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Pickup_Intersaction_name";


            PickuptableTableAdapter pickuptableTableAdapter1 = new PickuptableTableAdapter();
            comboBox3.DataSource = pickuptableTableAdapter1.GetData();
            comboBox3.ValueMember = "Id";
            comboBox3.DisplayMember = "Pickup_Intersaction_name";

            CustomerTableTableAdapter customerTableTableAdapter = new CustomerTableTableAdapter();
            comboBox1.DataSource = customerTableTableAdapter.GetData();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "CustomerName"; customerTableTableAdapter.GetData().Rows[0]["CustomerName"].ToString();


            CourierTableTableAdapter courierTableTableAdapter = new CourierTableTableAdapter();
            comboBox4.DataSource = courierTableTableAdapter.GetData();
            comboBox4.ValueMember = "Id";
            comboBox4.DisplayMember = "CourierName";
            if (TicketMaster.checkStatus == 1)
            {
                hidelayout1();
            }
            else if (TicketMaster.checkStatus == 2)
            {
                hidelayout2();
            }
            else if (TicketMaster.checkStatus == 3)
            {
                hidelayout3();
            }
        }

        private void ScheduleTicket_Load(object sender, EventArgs e)
        {
            bindCombo();
            int pickupId = TicketMaster.pickupId;
            if (pickupId != 0)
            {
                bindData();
            }
        }

        public void hidelayout1()
        {
            layoutControlItem10.ContentVisible = false;
            layoutControlItem9.ContentVisible = false;
            layoutControlItem8.ContentVisible = false;
            layoutControlItem11.ContentVisible = false;
            layoutControlItem12.ContentVisible = false;
            layoutControlItem13.ContentVisible = false;
            layoutControlItem14.ContentVisible = false;
        }

        public void hidelayout2()
        {
            layoutControlItem10.ContentVisible = false;
            layoutControlItem9.ContentVisible = false;
            layoutControlItem8.ContentVisible = false;
            layoutControlItem11.ContentVisible = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            dateEdit1.Enabled = false;
            timeEdit2.Enabled = false;
            dateEdit2.Enabled = false;
            timeEdit3.Enabled = false;
        }

        public void hidelayout3()
        {
            layoutControlItem12.ContentVisible = false;
            layoutControlItem13.ContentVisible = false;
            layoutControlItem14.ContentVisible = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            dateEdit1.Enabled = false;
            timeEdit2.Enabled = false;
            dateEdit2.Enabled = false;
            timeEdit3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string startDistinaction = comboBox2.Text.ToString();
                string endDestination = comboBox3.Text.ToString();
                if (startDistinaction != "" && endDestination != "")
                {
                    List<GraphNode<String>> list = new List<GraphNode<String>>();
                    string connString = ConfigurationManager.ConnectionStrings["ecourier.Properties.Settings.ecourierDatabaseConnectionString"].ConnectionString;
                    DataTable results = new DataTable();
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        OleDbCommand cmd = new OleDbCommand(@"SELECT * from Pickuptable where isActive=true", conn);
                        conn.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(results);
                        conn.Close();
                    } 
                    //double[,] matrix = new double[MATRIX_ROWS, MATRIX_COLUMNS];
                    #region creatingMap
                    const int MATRIX_ROWS = 7;
                    const int MATRIX_COLUMNS = 7;
                    for (int i = 0; i < MATRIX_ROWS; i++)
                    {
                        for (int j = 0; j < MATRIX_COLUMNS; j++)
                        {
                            string rowName = "";
                            string colName = "";
                            if (i == 0)
                            {
                                rowName = "A";
                            }
                            else if (i == 1)
                            {
                                rowName = "B";
                            }
                            else if (i == 2)
                            {
                                rowName = "C";
                            }
                            else if (i == 3)
                            {
                                rowName = "D";
                            }
                            else if (i == 4)
                            {
                                rowName = "E";
                            }
                            else if (i == 5)
                            {
                                rowName = "F";
                            }
                            else if (i == 6)
                            {
                                rowName = "G";
                            }

                            if (j == 0)
                            {
                                colName = "1st";
                            }
                            else if (j == 1)
                            {
                                colName = "2nd";
                            }
                            else if (j == 2)
                            {
                                colName = "3rd";
                            }
                            else if (j == 3)
                            {
                                colName = "4th";
                            }
                            else if (j == 4)
                            {
                                colName = "5th";
                            }
                            else if (j == 5)
                            {
                                colName = "6th";
                            }
                            else if (j == 6)
                            {
                                colName = "7th";
                            }
                            string streatName = colName + " Ave and " + rowName;
                            var A1 = new GraphNode<String>("" + streatName + " Street");
                            list.Add(A1);
                        }
                    }
                    for (int i = 0; i < MATRIX_ROWS; i++)
                    {
                        for (int j = 0; j < MATRIX_COLUMNS; j++)
                        {
                            if (i != 0)
                            {
                                list[(i * MATRIX_COLUMNS) + j].AddNeighbour(list[((i - 1) * MATRIX_COLUMNS) + j], 1);
                            }
                            if (i != MATRIX_ROWS - 1)
                            {
                                list[(i * MATRIX_COLUMNS) + j].AddNeighbour(list[((i + 1) * MATRIX_COLUMNS) + j], 1);
                            }
                            if (j != 0)
                            {
                                list[(i * MATRIX_COLUMNS) + j].AddNeighbour(list[(i * MATRIX_COLUMNS) + j - 1], 1);
                            }
                            if (j != MATRIX_COLUMNS - 1)
                            {
                                list[(i * MATRIX_COLUMNS) + j].AddNeighbour(list[(i * MATRIX_COLUMNS) + j + 1], 1);
                            }
                        }
                    }
                    #endregion 
                    #region findingPath
                    var node1 = list.FirstOrDefault(a => a.Value.Replace(" ", "").ToLower().Contains(comboBox2.Text.Replace(" ", "").ToLower()));
                    var node2 = list.FirstOrDefault(a => a.Value.Replace(" ", "").ToLower().Contains(comboBox3.Text.Replace(" ", "").ToLower()));
                    string pathRoute = "";
                    var graph = list;
                    var dijkstra = new Dijkstra<string>(graph);
                    var path = dijkstra.FindShortestPathBetween(node1, node2);
                    for (int i = 0; i < path.Count; i++)
                    {
                        pathRoute = pathRoute + (path[i].Value) + "\n";
                    } 
                    #endregion

                    richTextBox1.Text = pathRoute;
                    textEdit1.Text = (path.Count * 10).ToString();
                }
                else
                {
                    if (startDistinaction == "")
                    {
                        MessageBox.Show("Please Select Start location");
                    }
                    else
                    {
                        MessageBox.Show("Please Select End location");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again");
            }
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            try
            {
                WindowsUIButton btn = e.Button as WindowsUIButton;
                if (btn.Caption != null && btn.Caption.Equals("Save"))
                {
                    if (TicketMaster.checkStatus == 1)
                    {
                        ticketTableTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(comboBox3.SelectedValue.ToString()), Convert.ToDateTime(dateEdit1.Text.ToString()), Convert.ToDateTime(timeEdit2.Text.ToString()), Convert.ToDateTime(dateEdit2.Text.ToString()), Convert.ToDateTime(timeEdit3.Text.ToString()), DateTime.Now, DateTime.Now);
                        ecourierDatabaseDataSet.AcceptChanges();
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        comboBox3.Text = "";
                        dateEdit1.Text = "";
                        timeEdit2.Text = "";
                        dateEdit2.Text = "";
                        timeEdit3.Text = "";
                    }
                    else if (TicketMaster.checkStatus == 2)
                    {
                        ticketTableTableAdapter.UpdateRouteQuery(DateTime.Now, textEdit1.Text, richTextBox1.Text, TicketMaster.pickupId);
                        ecourierDatabaseDataSet.AcceptChanges();
                        TicketMaster.pickupId = 0;
                        this.Close();
                    }
                    else if (TicketMaster.checkStatus == 3)
                    {
                        DateTime deliverdTime = Convert.ToDateTime(Convert.ToDateTime(dateEdit3.Text + " " + timeEdit1.Text));
                        ticketTableTableAdapter.UpdateCourierQuery(Convert.ToInt32(comboBox4.SelectedValue.ToString()), deliverdTime,"Delivered", DateTime.Now, TicketMaster.pickupId);
                        ecourierDatabaseDataSet.AcceptChanges();
                        TicketMaster.pickupId = 0;
                        this.Close();
                    }
                }
                else if (btn.Caption != null && btn.Caption.Equals("Save And Close"))
                {
                    if (TicketMaster.checkStatus == 1)
                    {
                        ticketTableTableAdapter.InsertQuery(Convert.ToInt32(comboBox1.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(comboBox3.SelectedValue.ToString()), Convert.ToDateTime(dateEdit1.Text.ToString()), Convert.ToDateTime(timeEdit2.Text.ToString()), Convert.ToDateTime(dateEdit2.Text.ToString()), Convert.ToDateTime(timeEdit3.Text.ToString()), DateTime.Now, DateTime.Now);
                        ecourierDatabaseDataSet.AcceptChanges();
                        this.Close();
                    }
                    else if (TicketMaster.checkStatus == 2)
                    {
                        ticketTableTableAdapter.UpdateRouteQuery(DateTime.Now, textEdit1.Text, richTextBox1.Text, TicketMaster.pickupId);
                        ecourierDatabaseDataSet.AcceptChanges();
                        TicketMaster.pickupId = 0;
                        this.Close();
                    }
                    else if (TicketMaster.checkStatus == 3)
                    {
                        DateTime deliverdTime = Convert.ToDateTime(Convert.ToDateTime(dateEdit3.Text + " " + timeEdit1.Text));
                        ticketTableTableAdapter.UpdateCourierQuery(Convert.ToInt32(comboBox4.SelectedValue.ToString()), deliverdTime, comboBox5.Text, DateTime.Now, TicketMaster.pickupId);
                        ecourierDatabaseDataSet.AcceptChanges();
                        TicketMaster.pickupId = 0;
                        this.Close();
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("SOMETHING WENT WRONG " + EX.Message);
            }
        }

        public void bindData()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["ecourier.Properties.Settings.ecourierDatabaseConnectionString"].ConnectionString;
                DataTable results = new DataTable();
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    OleDbCommand cmd = new OleDbCommand(@"SELECT * from TicketTable where id=" + TicketMaster.pickupId, conn);
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(results);
                    conn.Close();
                }
                if (results != null && results.Rows.Count > 0)
                {
                    comboBox1.SelectedValue = results.Rows[0]["CustomerId"].ToString();
                    comboBox2.SelectedValue = results.Rows[0]["PickupIntersectionId"].ToString();
                    comboBox3.SelectedValue = results.Rows[0]["DeliverIntersectionId"].ToString();
                    dateEdit1.EditValue = Convert.ToDateTime(results.Rows[0]["PickUpDate"].ToString()).ToShortDateString();
                    timeEdit2.EditValue = Convert.ToDateTime(results.Rows[0]["PickupTime"].ToString()).ToShortTimeString();
                    dateEdit2.EditValue = Convert.ToDateTime(results.Rows[0]["DeliveryDate"].ToString()).ToShortDateString();
                    timeEdit3.EditValue = Convert.ToDateTime(results.Rows[0]["DeliveryTime"].ToString()).ToShortTimeString();
                    if (TicketMaster.checkStatus == 2)
                    {
                        if (results.Rows[0]["DirectionRoute"].ToString() != "")
                        {
                            richTextBox1.Text = results.Rows[0]["DirectionRoute"].ToString();
                        }
                        if (results.Rows[0]["EstimatedRate"].ToString() != "")
                        {
                            textEdit1.Text = results.Rows[0]["EstimatedRate"].ToString();
                        }
                    }
                    else if (TicketMaster.checkStatus == 2)
                    {

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Items != null && comboBox1.Items.Count > 0 && !comboBox1.SelectedValue.ToString().Contains("System"))
                {
                    string connString = ConfigurationManager.ConnectionStrings["ecourier.Properties.Settings.ecourierDatabaseConnectionString"].ConnectionString;
                    DataTable results = new DataTable();
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        string id = comboBox1.Text;
                        OleDbCommand cmd = new OleDbCommand(@"SELECT * from CustomerTable where Id=" + comboBox1.SelectedValue.ToString(), conn);
                        conn.Open();
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(results);
                        conn.Close();
                    }
                    if (results != null && results.Rows.Count > 0)
                    {
                        comboBox2.SelectedValue = results.Rows[0]["pickuIntersectionId"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        } 

        private void timeEdit2_EditValueChanged(object sender, EventArgs e)
        {
            timeEdit3.EditValue = Convert.ToDateTime(timeEdit2.EditValue).AddHours(4);
        }
    }
}