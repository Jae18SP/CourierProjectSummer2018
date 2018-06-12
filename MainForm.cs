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
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void navBarControl_Click(object sender, EventArgs e)
        {

        }

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
            navigationFrame.SelectedPage = navigationPage1;
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
            navigationFrame.SelectedPage = navigationPage3;
        }

        public void addControls()
        {
            Courier courier = new Courier();
            OrderTaker orderTaker = new OrderTaker();
            Customer customer = new Customer();
            ScheduleTicket scheduleTicket = new ScheduleTicket();
            navigationPage1.Controls.Add(courier);
            navigationPage2.Controls.Add(orderTaker);
            navigationPage3.Controls.Add(customer);
            navigationPage4.Controls.Add(scheduleTicket);
        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}