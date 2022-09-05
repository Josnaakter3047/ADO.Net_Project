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
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPictureFile.Text = openFileDialog1.FileName;
            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
        private void LoadCombo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id,designation FROM Designation", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDesignation.DataSource = ds.Tables[0];
            cmbDesignation.DisplayMember = "designation";
            cmbDesignation.ValueMember = "id";
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into Employees(empId,empName,empAddress,empEmail,empPhone,salary,photo,designationId) Values(@empId,@n,@ad,@e,@phone,@salary,@photo,@si)";
            cmd.Parameters.AddWithValue("@empId",txtEmpId.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@ad", txtAddress.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
            cmd.Parameters.Add(new SqlParameter("@photo", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@si", cmbDesignation.SelectedValue);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Inserted Successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            AllClear();

        }
        private void AllClear()
        {
            txtEmpId.Text = "";
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPictureFile.Clear();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            cmbDesignation.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
