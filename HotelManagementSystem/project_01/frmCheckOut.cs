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
    public partial class frmCheckOut : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        functionConnection fn = new functionConnection();
        String query;
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myHotelDataSet.Customers' table. You can move, or remove it, as needed.
           
            //this.customersTableAdapter.Fill(this.myHotelDataSet.Customers);
            query = "Select customerId as 'Customer ID',customerName as 'Customer Name',dob as 'Date Of Birth',religion as Religion,address as Address,gender as Gender,nationality as Nationality,nationalId as 'National ID',contactNo as 'Contact No',email as Email,checkInDate as 'Check In Date',checkOutStatus as 'Check Out Status',Rooms.roomNo as 'Room No',Rooms.roomType as 'Room Type',Rooms.bed as Bed,Rooms.price as Price,picture as 'Customer Photo' from Customers inner join Rooms on Customers.roomId=Rooms.roomId where checkOutStatus='No'";
            DataSet ds = fn.getData(query);
            dgvCheckOut.DataSource = ds.Tables[0];

            dgvCheckOut.RowTemplate.Height = 100;

            //Change Image Size To Fit DataGridView Cell
            for (int i = 0; i < dgvCheckOut.Columns.Count; i++)
            {
                if (dgvCheckOut.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvCheckOut.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }

        }

        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
            query = "Select c.customerId,c.customerName,c.dob,c.religion,c.address,c.gender,c.nationality,c.nationalId,c.contactNo,c.email,c.checkInDate,c.checkOutStatus,r.roomNo,r.roomType,r.bed,r.price,c.picture From Customers c Inner Join Rooms r On c.roomId = r.roomId where customerName like '" + txtCusName.Text + "%' and checkOutStatus = 'No'";
            DataSet ds = fn.getData(query);
            dgvCheckOut.DataSource = ds.Tables[0];
            dgvCheckOut.RowTemplate.Height = 100;
            for (int i = 0; i < dgvCheckOut.Columns.Count; i++)
            {
                if (dgvCheckOut.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvCheckOut.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }
        }

        int id;
        private void dgvCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheckOut.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dgvCheckOut.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtName.Text = dgvCheckOut.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = dgvCheckOut.Rows[e.RowIndex].Cells[12].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update Customers set checkOutStatus='Yes', checkOutDate='" + cdate + "' where customerId=" + id + " update Rooms set booked='No' where roomNo='" + txtRoomNo.Text + "' ";
                    fn.setData(query, "Check Out Successfully");
                    frmCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtCusName.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
            txtCheckOutDate.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
