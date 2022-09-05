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
    public partial class frmDesignation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        functionConnection fn = new functionConnection();
        String query;
        public frmDesignation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDesignation.Text != "")
            {
                String deg = txtDesignation.Text;
                query = "Insert Into Designation(designation) Values('" + txtDesignation.Text + "')";
                fn.setData(query, "Designation Added Successfully!!!");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill All Filed.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearAll()
        {
            txtDesignation.Clear();

        }

        private void frmDesignation_Load(object sender, EventArgs e)
        {
            query = "select id as 'ID', designation as 'Designation' from Designation";
            DataSet ds = fn.getData(query);
            dtvShowDesignation.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
