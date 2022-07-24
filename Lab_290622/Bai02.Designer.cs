namespace Lab_290622
{
    partial class Bai02
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
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lsvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(191, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.btnDelete);
            this.grbInfo.Controls.Add(this.dtpBirthday);
            this.grbInfo.Controls.Add(this.btnExit);
            this.grbInfo.Controls.Add(this.btnEdit);
            this.grbInfo.Controls.Add(this.lblName);
            this.grbInfo.Controls.Add(this.btnAdd);
            this.grbInfo.Controls.Add(this.txtAddress);
            this.grbInfo.Controls.Add(this.txtName);
            this.grbInfo.Controls.Add(this.lblAddress);
            this.grbInfo.Controls.Add(this.lblBirthday);
            this.grbInfo.Controls.Add(this.txtPhone);
            this.grbInfo.Controls.Add(this.lblPhone);
            this.grbInfo.Location = new System.Drawing.Point(12, 37);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(581, 125);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin chi tiết";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(415, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(85, 57);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 25);
            this.dtpBirthday.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(496, 87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(334, 87);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ tên: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(253, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(371, 56);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 25);
            this.txtAddress.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(291, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Địa chỉ: ";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(6, 61);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(73, 17);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Ngày sinh: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(371, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 25);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(291, 29);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 17);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Điện thoại: ";
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvList.FullRowSelect = true;
            this.lsvList.HideSelection = false;
            this.lsvList.Location = new System.Drawing.Point(12, 168);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(581, 181);
            this.lsvList.TabIndex = 2;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ và tên";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày sinh";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điện thoại";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 220;
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 361);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}