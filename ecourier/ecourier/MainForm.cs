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
using DevExpress.XtraBars.Navigation;

namespace ecourier
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        { 
            InitializeComponent();
            addControls();
            if(Properties.Settings.Default.isAdmin==0)
            {
                customersNavBarGroup.Visible = false;
                navBarGroup1.Visible = false;
            }
        }
        #region unUsed Code
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {

        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void navBarControl_Click(object sender, EventArgs e)
        {

        }  
        #endregion
        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Customer
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage3;
            
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //Courier
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage4;
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //OrderTaker
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage2;
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //ScheduleTask
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage4;
        }

        public void addControls()
        {
            Courier courier = new Courier();
            OrderTaker orderTaker = new OrderTaker();
            Customer customer = new Customer();
            // ScheduleTicket scheduleTicket = new ScheduleTicket();
            TicketMaster ticketMaster = new TicketMaster();
            Report report = new Report();
            Report2 report1 = new Report2();
            Report3 report2 = new Report3();
            navigationPage1.Controls.Add(ticketMaster);
            navigationPage2.Controls.Add(orderTaker);
            navigationPage3.Controls.Add(customer);
            navigationPage4.Controls.Add(courier);
            navigationPage5.Controls.Add(report);
            navigationPage6.Controls.Add(report1);
            navigationPage7.Controls.Add(report2);
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //PickupMaster pickupMaster = new PickupMaster();
            //pickupMaster.Show();
        } 
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PickupMaster pickupMaster = new PickupMaster();
            pickupMaster.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { 
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage1;
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage5;
        }

        private void navBarControl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if(e.Link.Caption== "Tickets")
            {
                //Tickets
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage1;
            }
            else if(e.Link.Caption == "Customers")
            {
                //Customer
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage3;
            }
            else if (e.Link.Caption == "Employees")
            {
                //OrderTaker
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage2;
            }
            else if (e.Link.Caption == "Reports")
            {
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage5;
            }
            else if (e.Link.Caption == "Mapping")
            {
                PickupMaster pickupMaster = new PickupMaster();
                pickupMaster.ShowDialog();
            } 
        }

        private void officeNavigationBar_ItemClick(object sender, NavigationBarItemEventArgs e)
        {
            if (e.Item.Text == "Tickets")
            {
                //Tickets
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage1;
            }
            else if (e.Item.Text == "Customers")
            {
                //Customer
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage3;
            }
            else if (e.Item.Text == "Employees")
            {
                //OrderTaker
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage2;
            }
            else if (e.Item.Text == "Reports")
            {
                ribbonPage.Visible = false;
                navigationFrame.SelectedPage = navigationPage5;
            }
            else if (e.Item.Text == "Mapping")
            {
                PickupMaster pickupMaster = new PickupMaster();
                pickupMaster.ShowDialog();
            }
            else if (e.Item.Text == "Logout")
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure to Logout?", "Logout?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                } 
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage6;
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ribbonPage.Visible = false;
            navigationFrame.SelectedPage = navigationPage7;
        }
    }
}