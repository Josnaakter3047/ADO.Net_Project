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
    public partial class frmCustomersDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=myHotel;Integrated Security=True");
        functionConnection fn = new functionConnection();
        String query;
        public frmCustomersDetails()
        {
            InitializeComponent();
        }

        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
            query = "Select customerId as 'Customer ID',customerName as 'Customer Name',dob as 'Date Of Birth',religion as Religion,address as Address,gender as Gender,nationality as Nationality,nationalId as 'National ID',contactNo as 'Contact No',email as Email,checkInDate as 'Check In Date',checkOutDate as 'Check Out Date',checkOutStatus as 'Check Out Status',Rooms.roomNo as 'Room No',Rooms.bed as Bed,Rooms.price as Price ,Rooms.roomType as 'Room Type',picture as Picture from Customers inner join Rooms on Customers.roomId=Rooms.roomId where customerName like '" + txtCusName.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmCustomersDetails_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select customerId as 'Customer ID',customerName as 'Customer Name',dob as 'Date Of Birth',religion as Religion,address as Address,gender as Gender,nationality as Nationality,nationalId as 'National ID',contactNo as 'Contact No',email as Email,checkInDate as 'Check In Date',checkOutDate as 'Check Out Date',checkOutStatus as 'Check Out Status',Rooms.roomNo as 'Room No',Rooms.bed as Bed,Rooms.price as Price ,Rooms.roomType as 'Room Type',picture as 'Customer Photo' from Customers inner join Rooms on Customers.roomId=Rooms.roomId", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowTemplate.Height = 100;

            //Change Image Size To Fit DataGridView Cell
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
