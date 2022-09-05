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
    public partial class frmLogIn : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnlogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "josna" && txtPassword.Text == "pass")
            {
                lblWorng.Visible = false;
                frmHome fp = new frmHome();
                this.Hide();
                fp.Show();
            }
            else
            {
                lblWorng.Visible = true;
                txtPassword.Clear();

            }
        }
    }
}
