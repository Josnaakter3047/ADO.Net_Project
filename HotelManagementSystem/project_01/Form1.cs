using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_01
{
    public partial class frmHome : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        public frmHome()
        {
            InitializeComponent();
            Control.SetInitial(this);
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureRestore_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Control.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Control.Minimize(this);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Control.DoMaximize(this, btn);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.MdiParent = this;
            emp.Show();
        }

        private void employeesInoformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDeleteUpdate du =new frmEmployeeDeleteUpdate();
            du.MdiParent = this;
            du.Show();
        }

        private void reportForEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeReport er = new frmEmployeeReport();
            er.MdiParent = this;
            er.Show();
        }

        private void reportForCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void roomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomDetails room = new frmRoomDetails();
            room.MdiParent = this;
            room.Show();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerRegistration reg = new frmCustomerRegistration();
            reg.MdiParent = this;
            reg.Show();
           
        }

        private void custoemrsCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckOut cho = new frmCheckOut();
            cho.MdiParent = this;
            cho.Show();
        }

        private void customersInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerInformation info= new frmCustomerInformation();
            info.MdiParent = this;
            info.Show();
        }

        private void customerDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCustomersDetails cusDetails = new frmCustomersDetails();
            cusDetails.MdiParent = this;
            cusDetails.Show();
        }

        private void customersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerReport rCus = new frmCustomerReport();
            rCus.MdiParent = this;
            rCus.Show();
            
        }

        private void addDesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesignation des = new frmDesignation();
            des.MdiParent = this;
            des.Show();
        }
    }
}
