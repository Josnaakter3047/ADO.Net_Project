
namespace project_01
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.panLogIn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWorng = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.picLogIn = new System.Windows.Forms.PictureBox();
            this.btnlogIn = new System.Windows.Forms.Button();
            this.panLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panLogIn
            // 
            this.panLogIn.Controls.Add(this.btnlogIn);
            this.panLogIn.Controls.Add(this.label3);
            this.panLogIn.Controls.Add(this.lblWorng);
            this.panLogIn.Controls.Add(this.label2);
            this.panLogIn.Controls.Add(this.label1);
            this.panLogIn.Controls.Add(this.txtPassword);
            this.panLogIn.Controls.Add(this.txtUserName);
            this.panLogIn.Controls.Add(this.picLogIn);
            this.panLogIn.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panLogIn.Location = new System.Drawing.Point(464, 87);
            this.panLogIn.Name = "panLogIn";
            this.panLogIn.Size = new System.Drawing.Size(658, 535);
            this.panLogIn.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(156, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "*Type \"josna\" for user name and \"pass\" for password*";
            // 
            // lblWorng
            // 
            this.lblWorng.AutoSize = true;
            this.lblWorng.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorng.ForeColor = System.Drawing.Color.Red;
            this.lblWorng.Location = new System.Drawing.Point(244, 400);
            this.lblWorng.Name = "lblWorng";
            this.lblWorng.Size = new System.Drawing.Size(158, 18);
            this.lblWorng.TabIndex = 13;
            this.lblWorng.Text = "Wrong user or password";
            this.lblWorng.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(247, 264);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 33);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "pass";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(247, 210);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 33);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "josna";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picLogIn
            // 
            this.picLogIn.BackColor = System.Drawing.Color.MistyRose;
            this.picLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogIn.BackgroundImage")));
            this.picLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogIn.Location = new System.Drawing.Point(237, 21);
            this.picLogIn.Name = "picLogIn";
            this.picLogIn.Size = new System.Drawing.Size(185, 157);
            this.picLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogIn.TabIndex = 6;
            this.picLogIn.TabStop = false;
            // 
            // btnlogIn
            // 
            this.btnlogIn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogIn.Location = new System.Drawing.Point(257, 333);
            this.btnlogIn.Name = "btnlogIn";
            this.btnlogIn.Size = new System.Drawing.Size(103, 34);
            this.btnlogIn.TabIndex = 14;
            this.btnlogIn.Text = "LOG IN";
            this.btnlogIn.UseVisualStyleBackColor = true;
            this.btnlogIn.Click += new System.EventHandler(this.btnlogIn_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1346, 652);
            this.Controls.Add(this.panLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.panLogIn.ResumeLayout(false);
            this.panLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLogIn;
        private System.Windows.Forms.Button btnlogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWorng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox picLogIn;
    }
}