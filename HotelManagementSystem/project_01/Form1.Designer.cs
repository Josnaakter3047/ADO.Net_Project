
namespace project_01
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custoemrsCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDesignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportForEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesInoformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 5, 0, 10);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(12, 12);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(6, 0, 0, 20);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 30);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomDetailsToolStripMenuItem});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(86, 30);
            this.roomToolStripMenuItem.Text = "Rooms";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // roomDetailsToolStripMenuItem
            // 
            this.roomDetailsToolStripMenuItem.Name = "roomDetailsToolStripMenuItem";
            this.roomDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.roomDetailsToolStripMenuItem.Text = "Room Details";
            this.roomDetailsToolStripMenuItem.Click += new System.EventHandler(this.roomDetailsToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationToolStripMenuItem,
            this.custoemrsCheckOutToolStripMenuItem,
            this.customerDetailsToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.customerToolStripMenuItem.Text = "Customers";
            // 
            // customerRegistrationToolStripMenuItem
            // 
            this.customerRegistrationToolStripMenuItem.Name = "customerRegistrationToolStripMenuItem";
            this.customerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.customerRegistrationToolStripMenuItem.Text = "Customer Registration";
            this.customerRegistrationToolStripMenuItem.Click += new System.EventHandler(this.customerRegistrationToolStripMenuItem_Click);
            // 
            // custoemrsCheckOutToolStripMenuItem
            // 
            this.custoemrsCheckOutToolStripMenuItem.Name = "custoemrsCheckOutToolStripMenuItem";
            this.custoemrsCheckOutToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.custoemrsCheckOutToolStripMenuItem.Text = "Custoemrs Check Out";
            this.custoemrsCheckOutToolStripMenuItem.Click += new System.EventHandler(this.custoemrsCheckOutToolStripMenuItem_Click);
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            this.customerDetailsToolStripMenuItem.Click += new System.EventHandler(this.customerDetailsToolStripMenuItem_Click_1);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addDesignationToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addDesignationToolStripMenuItem
            // 
            this.addDesignationToolStripMenuItem.Name = "addDesignationToolStripMenuItem";
            this.addDesignationToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.addDesignationToolStripMenuItem.Text = "Add Designation";
            this.addDesignationToolStripMenuItem.Click += new System.EventHandler(this.addDesignationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportForEmployeeToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(94, 30);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // reportForEmployeeToolStripMenuItem
            // 
            this.reportForEmployeeToolStripMenuItem.Name = "reportForEmployeeToolStripMenuItem";
            this.reportForEmployeeToolStripMenuItem.Size = new System.Drawing.Size(276, 30);
            this.reportForEmployeeToolStripMenuItem.Text = "Report For Employee";
            this.reportForEmployeeToolStripMenuItem.Click += new System.EventHandler(this.reportForEmployeeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersInformationToolStripMenuItem,
            this.employeesInoformationToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(71, 30);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customersInformationToolStripMenuItem
            // 
            this.customersInformationToolStripMenuItem.Name = "customersInformationToolStripMenuItem";
            this.customersInformationToolStripMenuItem.Size = new System.Drawing.Size(338, 30);
            this.customersInformationToolStripMenuItem.Text = "Customers Information";
            this.customersInformationToolStripMenuItem.Click += new System.EventHandler(this.customersInformationToolStripMenuItem_Click);
            // 
            // employeesInoformationToolStripMenuItem
            // 
            this.employeesInoformationToolStripMenuItem.Name = "employeesInoformationToolStripMenuItem";
            this.employeesInoformationToolStripMenuItem.Size = new System.Drawing.Size(338, 30);
            this.employeesInoformationToolStripMenuItem.Text = "Employees Information Edit";
            this.employeesInoformationToolStripMenuItem.Click += new System.EventHandler(this.employeesInoformationToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1493, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 100, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMax.Location = new System.Drawing.Point(1449, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(39, 38);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "1";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1406, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 38);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHome";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custoemrsCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesInoformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportForEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDesignationToolStripMenuItem;
    }
}

