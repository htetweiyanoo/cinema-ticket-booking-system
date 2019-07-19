namespace cinema_ticket_booking_system
{
    partial class LoginForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkLShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radioBtnCustomer = new System.Windows.Forms.RadioButton();
            this.radioBtnStaff = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(263, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "User name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // txtLPassword
            // 
            this.txtLPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLPassword.Location = new System.Drawing.Point(399, 221);
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.Size = new System.Drawing.Size(166, 26);
            this.txtLPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(399, 175);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 26);
            this.txtUsername.TabIndex = 20;
            // 
            // chkLShowPassword
            // 
            this.chkLShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkLShowPassword.AutoSize = true;
            this.chkLShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkLShowPassword.Location = new System.Drawing.Point(605, 224);
            this.chkLShowPassword.Name = "chkLShowPassword";
            this.chkLShowPassword.Size = new System.Drawing.Size(62, 20);
            this.chkLShowPassword.TabIndex = 21;
            this.chkLShowPassword.Text = "show";
            this.chkLShowPassword.UseVisualStyleBackColor = true;
            this.chkLShowPassword.CheckedChanged += new System.EventHandler(this.chkLShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(477, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 34);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radioBtnCustomer
            // 
            this.radioBtnCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnCustomer.AutoSize = true;
            this.radioBtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCustomer.ForeColor = System.Drawing.Color.White;
            this.radioBtnCustomer.Location = new System.Drawing.Point(268, 270);
            this.radioBtnCustomer.Name = "radioBtnCustomer";
            this.radioBtnCustomer.Size = new System.Drawing.Size(91, 20);
            this.radioBtnCustomer.TabIndex = 25;
            this.radioBtnCustomer.TabStop = true;
            this.radioBtnCustomer.Text = "Customer";
            this.radioBtnCustomer.UseVisualStyleBackColor = true;
            // 
            // radioBtnStaff
            // 
            this.radioBtnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnStaff.AutoSize = true;
            this.radioBtnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnStaff.ForeColor = System.Drawing.Color.White;
            this.radioBtnStaff.Location = new System.Drawing.Point(399, 270);
            this.radioBtnStaff.Name = "radioBtnStaff";
            this.radioBtnStaff.Size = new System.Drawing.Size(57, 20);
            this.radioBtnStaff.TabIndex = 26;
            this.radioBtnStaff.TabStop = true;
            this.radioBtnStaff.Text = "Staff";
            this.radioBtnStaff.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(477, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 34);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "<- Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::cinema_ticket_booking_system.Properties.Resources.cinema_camera_23_2147515144;
            this.pictureBox1.Location = new System.Drawing.Point(112, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1022, 512);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.radioBtnStaff);
            this.Controls.Add(this.radioBtnCustomer);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkLShowPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkLShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioBtnCustomer;
        private System.Windows.Forms.RadioButton radioBtnStaff;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}