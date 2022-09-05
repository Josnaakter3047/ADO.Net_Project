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
    public partial class frmRoomDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        functionConnection fn = new functionConnection();
        String query;
        public frmRoomDetails()
        {
            InitializeComponent();
        }

        private void frmRoomDetails_Load(object sender, EventArgs e)
        {
            query = "Select * From rooms";
            DataSet ds = fn.getData(query);
            dtvShowRoom.DataSource = ds.Tables[0];
        }
        public void ClearAll()
        {
            txtRoomNo.Clear();
            cmbRoomType.SelectedIndex = -1;
            cmbBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && cmbBed.Text != "" && cmbRoomType.Text != "" && txtPrice.Text != "")
            {
                String roomNo = txtRoomNo.Text;
                String bed = cmbBed.Text;
                String type = cmbRoomType.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "Insert Into rooms(roomNo,roomType,bed,price) Values('" + txtRoomNo.Text + "','" + cmbRoomType.Text + "','" + cmbBed.Text + "','" + txtPrice.Text + "')";
                fn.setData(query, "Room Added Successfully!!!");
                frmRoomDetails_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Fill All Filed.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtvShowRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
