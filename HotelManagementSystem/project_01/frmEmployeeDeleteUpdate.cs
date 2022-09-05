using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_01
{
    public partial class frmEmployeeDeleteUpdate : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        public frmEmployeeDeleteUpdate()
        {
            InitializeComponent();
        }

        private void frmEmployeeDeleteUpdate_Load(object sender, EventArgs e)
        {

        }
        private void LoadCombo()
        {
            //con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id,designation FROM Designation", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDesignation.DataSource = ds.Tables[0];
            cmbDesignation.DisplayMember = "designation";
            cmbDesignation.ValueMember = "id";

            SqlDataAdapter sda2 = new SqlDataAdapter("Select empId from Employees", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmbEmployeeID.ValueMember = "empId";
            cmbEmployeeID.DisplayMember = "empId";
            cmbEmployeeID.DataSource = dt2;
            //con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select empId,empName,empAddress,empEmail,empPhone,salary,designationId,photo from Employees where empId=@i";
            cmd.Parameters.AddWithValue("@i", cmbEmployeeID.SelectedValue);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtEmpName.Text = dr.GetString(1);
                txtAddress.Text = dr.GetString(2);
                txtEmail.Text = dr.GetString(3);
                txtPhone.Text = dr.GetString(4);
                cmbDesignation.SelectedValue = dr.GetInt32(5);
                pictureBox1.Image = Image.FromStream(dr.GetStream(6));
            }

            con.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPhoto.Text = openFileDialog1.FileName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Employees where empId=@i", con);
            cmd.Parameters.AddWithValue("@i", cmbEmployeeID.SelectedValue);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Deleted successfully!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            LoadCombo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPhoto.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update Employees SET empName=@n,empAddress=@ad,empEmail=@e,empPhone=@phone,designationId=@degi,photo=@p WHERE empId=@i";
            cmd.Parameters.AddWithValue("@i",cmbEmployeeID.Text);
            cmd.Parameters.AddWithValue("@n", txtEmpName.Text);
            cmd.Parameters.AddWithValue("@ad", txtAddress.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@degi", cmbDesignation.SelectedValue);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Updated Successfully!!!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            con.Close();
            LoadCombo();
        }
    }
}
