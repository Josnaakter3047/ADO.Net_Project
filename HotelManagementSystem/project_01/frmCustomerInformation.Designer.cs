
namespace project_01
{
    partial class frmCustomerInformation
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
            this.lblCustomerReg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.cmbCusID = new System.Windows.Forms.ComboBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCusRegClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerReg
            // 
            this.lblCustomerReg.AutoSize = true;
            this.lblCustomerReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomerReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerReg.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerReg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCustomerReg.Location = new System.Drawing.Point(250, 28);
            this.lblCustomerReg.Name = "lblCustomerReg";
            this.lblCustomerReg.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.lblCustomerReg.Size = new System.Drawing.Size(424, 67);
            this.lblCustomerReg.TabIndex = 9;
            this.lblCustomerReg.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.cmbReligion);
            this.groupBox1.Controls.Add(this.cmbCusID);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.txtNationalID);
            this.groupBox1.Controls.Add(this.lblNationality);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblReligion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(85, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 486);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(293, 233);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(315, 34);
            this.cmbGender.TabIndex = 4;
            // 
            // cmbReligion
            // 
            this.cmbReligion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Location = new System.Drawing.Point(293, 122);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(315, 34);
            this.cmbReligion.TabIndex = 2;
            // 
            // cmbCusID
            // 
            this.cmbCusID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCusID.FormattingEnabled = true;
            this.cmbCusID.Location = new System.Drawing.Point(293, 22);
            this.cmbCusID.Name = "cmbCusID";
            this.cmbCusID.Size = new System.Drawing.Size(315, 34);
            this.cmbCusID.TabIndex = 0;
            this.cmbCusID.SelectedIndexChanged += new System.EventHandler(this.cmbCusID_SelectedIndexChanged);
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(293, 287);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(315, 33);
            this.txtNationality.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(293, 182);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 33);
            this.txtAddress.TabIndex = 3;
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(293, 72);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(315, 33);
            this.txtCusName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(293, 434);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 33);
            this.txtEmail.TabIndex = 8;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(293, 383);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(315, 33);
            this.txtContactNumber.TabIndex = 7;
            // 
            // txtNationalID
            // 
            this.txtNationalID.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalID.Location = new System.Drawing.Point(293, 334);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(315, 33);
            this.txtNationalID.TabIndex = 6;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNationality.Location = new System.Drawing.Point(105, 285);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(105, 26);
            this.lblNationality.TabIndex = 70;
            this.lblNationality.Text = "Nationality";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddress.Location = new System.Drawing.Point(105, 182);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 26);
            this.lblAddress.TabIndex = 75;
            this.lblAddress.Text = "Address";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblReligion.Location = new System.Drawing.Point(105, 130);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(80, 26);
            this.lblReligion.TabIndex = 74;
            this.lblReligion.Text = "Religion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(105, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 26);
            this.label10.TabIndex = 73;
            this.label10.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCustomerName.Location = new System.Drawing.Point(105, 79);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(148, 26);
            this.lblCustomerName.TabIndex = 72;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(105, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 71;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(105, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 76;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(105, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 69;
            this.label2.Text = "National ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(105, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 68;
            this.label1.Text = "Gender";
            // 
            // btnCusRegClose
            // 
            this.btnCusRegClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnCusRegClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusRegClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCusRegClose.Location = new System.Drawing.Point(828, 25);
            this.btnCusRegClose.Name = "btnCusRegClose";
            this.btnCusRegClose.Size = new System.Drawing.Size(44, 34);
            this.btnCusRegClose.TabIndex = 0;
            this.btnCusRegClose.Text = "X";
            this.btnCusRegClose.UseVisualStyleBackColor = false;
            this.btnCusRegClose.Click += new System.EventHandler(this.btnCusRegClose_Click);
            // 
            // frmCustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 653);
            this.Controls.Add(this.btnCusRegClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCustomerReg);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCustomerInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.frmCustomerInformation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCusRegClose;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.ComboBox cmbCusID;
    }
}