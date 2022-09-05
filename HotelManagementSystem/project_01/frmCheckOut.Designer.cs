
namespace project_01
{
    partial class frmCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCheckOut = new System.Windows.Forms.DataGridView();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckOutClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.myHotelDataSet = new project_01.myHotelDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new project_01.myHotelDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckOutDate.Location = new System.Drawing.Point(657, 534);
            this.txtCheckOutDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(259, 33);
            this.txtCheckOutDate.TabIndex = 17;
            // 
            // dgvCheckOut
            // 
            this.dgvCheckOut.AllowUserToDeleteRows = false;
            this.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCheckOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckOut.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCheckOut.Location = new System.Drawing.Point(12, 181);
            this.dgvCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCheckOut.Name = "dgvCheckOut";
            this.dgvCheckOut.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCheckOut.Size = new System.Drawing.Size(1170, 295);
            this.dgvCheckOut.TabIndex = 16;
            this.dgvCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckOut_CellContentClick);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRoomNo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.Location = new System.Drawing.Point(337, 539);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(258, 33);
            this.txtRoomNo.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(33, 539);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 33);
            this.txtName.TabIndex = 14;
            // 
            // txtCusName
            // 
            this.txtCusName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCusName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.ForeColor = System.Drawing.Color.Black;
            this.txtCusName.Location = new System.Drawing.Point(351, 124);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(461, 33);
            this.txtCusName.TabIndex = 15;
            this.txtCusName.TextChanged += new System.EventHandler(this.txtCusName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(657, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(336, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Room No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(38, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(470, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search Customer Name";
            // 
            // btnCheckOutClose
            // 
            this.btnCheckOutClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnCheckOutClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOutClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOutClose.ForeColor = System.Drawing.Color.White;
            this.btnCheckOutClose.Location = new System.Drawing.Point(1518, -37);
            this.btnCheckOutClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOutClose.Name = "btnCheckOutClose";
            this.btnCheckOutClose.Size = new System.Drawing.Size(43, 41);
            this.btnCheckOutClose.TabIndex = 8;
            this.btnCheckOutClose.Text = "X";
            this.btnCheckOutClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(427, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Check Out";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnCheckOut.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCheckOut.Location = new System.Drawing.Point(983, 521);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(113, 49);
            this.btnCheckOut.TabIndex = 18;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1103, 33);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // myHotelDataSet
            // 
            this.myHotelDataSet.DataSetName = "myHotelDataSet";
            this.myHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.myHotelDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1194, 615);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtCheckOutDate);
            this.Controls.Add(this.dgvCheckOut);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckOutClose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Check Out";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txtCheckOutDate;
        private System.Windows.Forms.DataGridView dgvCheckOut;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckOutClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnClose;
        private myHotelDataSet myHotelDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private myHotelDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}