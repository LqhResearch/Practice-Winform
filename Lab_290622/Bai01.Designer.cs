
namespace Lab_290622
{
    partial class Bai01
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
            this.lblCriteria = new System.Windows.Forms.Label();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.btnCriteria = new System.Windows.Forms.Button();
            this.lstImportant = new System.Windows.Forms.ListBox();
            this.grbImportant = new System.Windows.Forms.GroupBox();
            this.grbNoImportant = new System.Windows.Forms.GroupBox();
            this.lstNoImportant = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveRightAll = new System.Windows.Forms.Button();
            this.btnMoveLeftAll = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.grbImportant.SuspendLayout();
            this.grbNoImportant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(74, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TÌM NƠI TRỌ PHÙ HỢP CHO SINH VIÊN";
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(9, 59);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(92, 17);
            this.lblCriteria.TabIndex = 1;
            this.lblCriteria.Text = "Thêm tiêu chí: ";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(107, 55);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(314, 25);
            this.txtCriteria.TabIndex = 2;
            // 
            // btnCriteria
            // 
            this.btnCriteria.Location = new System.Drawing.Point(427, 53);
            this.btnCriteria.Name = "btnCriteria";
            this.btnCriteria.Size = new System.Drawing.Size(75, 28);
            this.btnCriteria.TabIndex = 3;
            this.btnCriteria.Text = "Cập nhật";
            this.btnCriteria.UseVisualStyleBackColor = true;
            this.btnCriteria.Click += new System.EventHandler(this.btnCriteria_Click);
            // 
            // lstImportant
            // 
            this.lstImportant.FormattingEnabled = true;
            this.lstImportant.ItemHeight = 17;
            this.lstImportant.Items.AddRange(new object[] {
            "Gần cửa hàng bách hóa",
            "Gần cửa hàng thức ăn nhanh",
            "Gần trạm xe buýt",
            "Mức độ tiếng ồn của xe cộ",
            "Gần quốc lộ",
            "Khu vực đông dân cư",
            "Gần công viên trẻ em",
            "Gần trường cấp 2",
            "Gần trường đại học"});
            this.lstImportant.Location = new System.Drawing.Point(6, 24);
            this.lstImportant.Name = "lstImportant";
            this.lstImportant.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstImportant.Size = new System.Drawing.Size(180, 191);
            this.lstImportant.TabIndex = 4;
            // 
            // grbImportant
            // 
            this.grbImportant.Controls.Add(this.lstImportant);
            this.grbImportant.Location = new System.Drawing.Point(12, 101);
            this.grbImportant.Name = "grbImportant";
            this.grbImportant.Size = new System.Drawing.Size(192, 220);
            this.grbImportant.TabIndex = 5;
            this.grbImportant.TabStop = false;
            this.grbImportant.Text = "Tiêu chí quan trọng";
            // 
            // grbNoImportant
            // 
            this.grbNoImportant.Controls.Add(this.lstNoImportant);
            this.grbNoImportant.Location = new System.Drawing.Point(310, 101);
            this.grbNoImportant.Name = "grbNoImportant";
            this.grbNoImportant.Size = new System.Drawing.Size(192, 220);
            this.grbNoImportant.TabIndex = 6;
            this.grbNoImportant.TabStop = false;
            this.grbNoImportant.Text = "Tiêu chí không quan trọng";
            // 
            // lstNoImportant
            // 
            this.lstNoImportant.FormattingEnabled = true;
            this.lstNoImportant.ItemHeight = 17;
            this.lstNoImportant.Location = new System.Drawing.Point(6, 24);
            this.lstNoImportant.Name = "lstNoImportant";
            this.lstNoImportant.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstNoImportant.Size = new System.Drawing.Size(180, 191);
            this.lstNoImportant.TabIndex = 4;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(210, 183);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(44, 28);
            this.btnMoveRight.TabIndex = 7;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveRightAll
            // 
            this.btnMoveRightAll.Location = new System.Drawing.Point(210, 217);
            this.btnMoveRightAll.Name = "btnMoveRightAll";
            this.btnMoveRightAll.Size = new System.Drawing.Size(44, 28);
            this.btnMoveRightAll.TabIndex = 8;
            this.btnMoveRightAll.Text = ">>";
            this.btnMoveRightAll.UseVisualStyleBackColor = true;
            this.btnMoveRightAll.Click += new System.EventHandler(this.btnMoveRightAll_Click);
            // 
            // btnMoveLeftAll
            // 
            this.btnMoveLeftAll.Location = new System.Drawing.Point(260, 217);
            this.btnMoveLeftAll.Name = "btnMoveLeftAll";
            this.btnMoveLeftAll.Size = new System.Drawing.Size(44, 28);
            this.btnMoveLeftAll.TabIndex = 10;
            this.btnMoveLeftAll.Text = "<<";
            this.btnMoveLeftAll.UseVisualStyleBackColor = true;
            this.btnMoveLeftAll.Click += new System.EventHandler(this.btnMoveLeftAll_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(260, 183);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(44, 28);
            this.btnMoveLeft.TabIndex = 9;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 331);
            this.Controls.Add(this.btnMoveLeftAll);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRightAll);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.grbNoImportant);
            this.Controls.Add(this.grbImportant);
            this.Controls.Add(this.btnCriteria);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.lblCriteria);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai01";
            this.Text = "Tìm nơi trọ phù hợp cho sinh viên";
            this.grbImportant.ResumeLayout(false);
            this.grbNoImportant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.TextBox txtCriteria;
        private System.Windows.Forms.Button btnCriteria;
        private System.Windows.Forms.ListBox lstImportant;
        private System.Windows.Forms.GroupBox grbImportant;
        private System.Windows.Forms.GroupBox grbNoImportant;
        private System.Windows.Forms.ListBox lstNoImportant;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveRightAll;
        private System.Windows.Forms.Button btnMoveLeftAll;
        private System.Windows.Forms.Button btnMoveLeft;
    }
}

