using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulaInfo
{
    public partial class mainForm : Form
    {
        private Form currentChildForm;
        public mainForm()
        {
            InitializeComponent();
            timer1.Start();
        }
       
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void webButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            openChildForm(new webBrowser());
        }

        private void driversButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            openChildForm(new driversForm());
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            openChildForm(new teamsForm());
        }

        private void standingsButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            openChildForm(new standings());
        }
        private void calendarButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            openChildForm(new calendar());
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        
    }
}
