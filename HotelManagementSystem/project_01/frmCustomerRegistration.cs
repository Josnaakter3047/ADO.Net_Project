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
    public partial class frmCustomerRegistration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        functionConnection fn = new functionConnection();
        String query;
        public frmCustomerRegistration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            
        }
        public void ClearAllText()
        {
            txtCustomerName.Clear();
            dateDob.ResetText();
            cmbReligion.SelectedIndex = -1;
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            txtNationality.Clear();
            txtNationalID.Clear();
            txtEmail.Clear();
            txtContactNumber.Clear();
            dateCheckIn.ResetText();
            cmbBed.SelectedIndex = -1;
            cmbRmNo.SelectedIndex = -1;
            cmbRmNo.Items.Clear();
            txtRegPrice.Clear();
            pictureBox1.Image.Dispose();
            txtPicture.Clear();


        }

        private void btnCusRegClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerRegistration_Load(object sender, EventArgs e)
        {

        }
        
        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            
            if (txtCustomerName.Text != "" && dateDob.Text != "" && cmbReligion.Text != "" && txtAddress.Text != "" && cmbGender.Text != "" && txtNationality.Text != "" && txtNationalID.Text != "" && txtContactNumber.Text != "" && txtEmail.Text != "" && dateCheckIn.Text != "")
            {
                Image img = Image.FromFile(txtPicture.Text);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert Into Customers(customerName,dob,religion,address,gender,nationality,nationalId,contactNo,email,checkInDate,picture,roomId)" +
                    " Values(@cusName,@dob,@religion,@address,@gender,@nationality,@nationalId,@contactNo,@email,@checkInDate,@picture,@roomId)";
                
                cmd.Parameters.AddWithValue("@cusName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@dob", dateDob.Text);
                cmd.Parameters.AddWithValue("@religion", cmbReligion.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@nationality", txtNationality.Text);
                cmd.Parameters.AddWithValue("@nationalId", txtNationalID.Text);
                cmd.Parameters.AddWithValue("@contactNo", txtContactNumber.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@checkInDate", dateCheckIn.Text);
                cmd.Parameters.Add(new SqlParameter("@picture", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@roomId", rid);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Customer Add Successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    query = "Update Rooms set booked = 'Yes' Where roomNo = '" + cmbRmNo.Text + "'";
                    fn.setData(query, "Room No " + cmbRmNo.Text + " reserved successfully !! ");
                }
                con.Close();
                ClearAllText();
            }

            else
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheckOutClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomType.SelectedIndex = -1;
            cmbRmNo.Items.Clear();
            txtRegPrice.Clear();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRmNo.Items.Clear();
            txtRegPrice.Clear();
            query = "select roomNo from Rooms where bed = '" + cmbBed.Text + "' and roomType = '" + cmbRoomType.Text + "' and booked='No'";
            setComboBox(query, cmbRmNo);
        }

        private void cmbRmNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select price,roomId from Rooms where roomNo='" + cmbRmNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtRegPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = Int32.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }
    }
}
