
namespace project_01
{
    partial class frmRoomDetails
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cmbBed = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtvShowRoom = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvShowRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddRoom.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(523, 307);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(115, 48);
            this.btnAddRoom.TabIndex = 14;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // cmbBed
            // 
            this.cmbBed.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cmbBed.FormattingEnabled = true;
            this.cmbBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Duplex",
            "Cabana",
            "King",
            "Queen",
            "Quad"});
            this.cmbBed.Location = new System.Drawing.Point(331, 206);
            this.cmbBed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBed.Name = "cmbBed";
            this.cmbBed.Size = new System.Drawing.Size(325, 34);
            this.cmbBed.TabIndex = 12;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "AC",
            "Non-Ac"});
            this.cmbRoomType.Location = new System.Drawing.Point(331, 145);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(325, 34);
            this.cmbRoomType.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(331, 266);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(325, 33);
            this.txtPrice.TabIndex = 13;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(331, 90);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(325, 33);
            this.txtRoomNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add New Rooms";
            // 
            // dtvShowRoom
            // 
            this.dtvShowRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvShowRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvShowRoom.Location = new System.Drawing.Point(46, 384);
            this.dtvShowRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtvShowRoom.Name = "dtvShowRoom";
            this.dtvShowRoom.Size = new System.Drawing.Size(786, 228);
            this.dtvShowRoom.TabIndex = 15;
            this.dtvShowRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvShowRoom_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(763, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 629);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtvShowRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.cmbBed);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRoomDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoomDetails";
            this.Load += new System.EventHandler(this.frmRoomDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvShowRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ComboBox cmbBed;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvShowRoom;
        private System.Windows.Forms.Button btnClose;
    }
}