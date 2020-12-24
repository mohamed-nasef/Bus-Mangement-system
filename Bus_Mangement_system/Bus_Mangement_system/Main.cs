using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        //these are variables for panel heightd
        //السلاامو عليكم ورحمه الله وبرككاتووو
        int iconHeight = 75;
        int reportPanelHeight = 206;
        int dailyticketPanelHeight = 127;

        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Main_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        #region function
        private void customizeDesign()
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
            }
            else
            {
                panelMenu.Visible = false;
            }
            studentSubPanel.Visible = false;
            paneliconStudent.Height = iconHeight;
            busSubPanel.Visible = false;
            paneliconBus.Height = iconHeight;
            driverSubPanel.Visible = false;
            paneliconDriver.Height = iconHeight;
            reportSubPanel.Visible = false;
            paneliconReport.Height = iconHeight;
            dailyticketSubPanel.Visible = false;
            paneliconDailyTicket.Height = iconHeight;
        }
        private void hideSubMenu()
        {
            if (studentSubPanel.Visible == true)
            {
                studentSubPanel.Visible = false;
                paneliconStudent.Height = iconHeight;
            }
            if (busSubPanel.Visible == true)
            {
                busSubPanel.Visible = false;
                paneliconBus.Height = iconHeight;
            }
            if (driverSubPanel.Visible == true)
            {
                driverSubPanel.Visible = false;
                paneliconDriver.Height = iconHeight;
            }
            if (reportSubPanel.Visible == true)
            {
                reportSubPanel.Visible = false;
                paneliconReport.Height = iconHeight;
            }
            if (dailyticketSubPanel.Visible == true)
            {
                dailyticketSubPanel.Visible = false;
                paneliconDailyTicket.Height = iconHeight;
            }
        }
        private void showSubMenu(Panel subMenu, Panel iconPanel, int height = 243)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
                iconPanel.Height = height;
            }
            else
            {
                subMenu.Visible = false;
                iconPanel.Height = iconHeight;

            }
        }

        #endregion

        #region Drawer
        private void btnDrawer_Click(object sender, EventArgs e)
        {
            customizeDesign();
        }
        #endregion

        #region Student


        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(studentSubPanel, paneliconStudent);
        }

        private void btniconStudent_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(studentSubPanel, paneliconStudent);
            //new form

        }
        private void addStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void booking_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void reportStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        #endregion

        #region Bus
        private void btnBus_Click(object sender, EventArgs e)
        {
            showSubMenu(busSubPanel, paneliconBus);
        }

        private void btniconBus_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(busSubPanel, paneliconBus);
        }

        private void addBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void editBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void Fees_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void reportBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }
        #endregion

        #region Driver
        private void btnDriver_Click(object sender, EventArgs e)
        {
            showSubMenu(driverSubPanel, paneliconDriver);
        }

        private void btniconDriver_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(driverSubPanel, paneliconDriver);
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void editDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void salary_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void reportDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }
        #endregion

        #region DailyTickets
        private void btnDailyTickets_Click(object sender, EventArgs e)
        {
            showSubMenu(dailyticketSubPanel, paneliconDailyTicket, dailyticketPanelHeight);
        }

        private void btniconDailyTicket_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(dailyticketSubPanel, paneliconDailyTicket, dailyticketPanelHeight);
        }

        private void addDailyTicket_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }
        #endregion

        #region Report
        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(reportSubPanel, paneliconReport, reportPanelHeight);
        }

        private void btniconReport_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(reportSubPanel, paneliconReport, reportPanelHeight);
        }

        private void monthlyReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void dailyReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void universityReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }
        #endregion

    }
}
