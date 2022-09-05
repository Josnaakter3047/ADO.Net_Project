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
    public partial class frmCustomerInformation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        public frmCustomerInformation()
        {
            InitializeComponent();
        }

        private void btnCusRegClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select c.customerId,c.customerName,c.dob,c.religion,c.address,c.gender,c.nationality,c.nationalId,c.contactNo,c.email,c.checkInDate,c.checkOutDate,r.roomNo,r.roomType,r.bed,r.price From Customers c Inner Join Rooms r On c.roomId= r.roomId WHERE customerId=@i";
            cmd.Parameters.AddWithValue("@i", cmbCusID.SelectedValue);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCusName.Text = dr.GetString(1);
                cmbReligion.Text = dr.GetString(3);
                txtAddress.Text = dr.GetString(4);
                cmbGender.Text = dr.GetString(5);
                txtNationality.Text = dr.GetString(6);
                txtNationalID.Text = dr.GetString(7);
                txtContactNumber.Text = dr.GetString(8);
                txtEmail.Text = dr.GetString(9);

            }

            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT customerId FROM Customers", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmbCusID.ValueMember = "customerId";
            cmbCusID.DisplayMember = "customerId";
            cmbCusID.DataSource = dt2;
        }

        private void frmCustomerInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
