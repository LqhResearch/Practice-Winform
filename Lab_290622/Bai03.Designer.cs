namespace Lab_290622
{
    partial class Bai03
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(37, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "THÔNG TIN SINH VIÊN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 87);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(85, 113);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(200, 25);
            this.txtBirthday.TabIndex = 7;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(12, 116);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(63, 17);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Năm sinh";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(85, 144);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 25);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 147);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 17);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Điện thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(85, 175);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 25);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 178);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 17);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(12, 209);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(63, 17);
            this.lblCourse.TabIndex = 12;
            this.lblCourse.Text = "Khoá học";
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Items.AddRange(new object[] {
            "Đại học CNTT - DA19TTA",
            "Đại học CNTT - DA19TTB",
            "Đại học CNTT - DA20TTA",
            "Đại học CNTT - DA20TTB"});
            this.cboCourse.Location = new System.Drawing.Point(85, 206);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(200, 25);
            this.cboCourse.TabIndex = 13;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(85, 86);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(54, 21);
            this.rdMale.TabIndex = 14;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(145, 86);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(44, 21);
            this.rdFemale.TabIndex = 15;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(75, 237);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 271);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lblBirthday;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCourse;
        public System.Windows.Forms.ComboBox cboCourse;
        public System.Windows.Forms.RadioButton rdMale;
        public System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOK;
    }
}