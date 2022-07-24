
namespace Lab_270622
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
            this.lblNumM = new System.Windows.Forms.Label();
            this.txtNumM = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNumN = new System.Windows.Forms.TextBox();
            this.lblNumN = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // lblNumM
            // 
            this.lblNumM.AutoSize = true;
            this.lblNumM.Location = new System.Drawing.Point(17, 60);
            this.lblNumM.Name = "lblNumM";
            this.lblNumM.Size = new System.Drawing.Size(45, 17);
            this.lblNumM.TabIndex = 1;
            this.lblNumM.Text = "Số m: ";
            // 
            // txtNumM
            // 
            this.txtNumM.Location = new System.Drawing.Point(83, 57);
            this.txtNumM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumM.Name = "txtNumM";
            this.txtNumM.Size = new System.Drawing.Size(226, 25);
            this.txtNumM.TabIndex = 2;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(27, 155);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(50, 30);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(83, 155);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(50, 30);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(139, 155);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(50, 30);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(195, 155);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 30);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(251, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNumN
            // 
            this.txtNumN.Location = new System.Drawing.Point(83, 90);
            this.txtNumN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumN.Name = "txtNumN";
            this.txtNumN.Size = new System.Drawing.Size(226, 25);
            this.txtNumN.TabIndex = 9;
            // 
            // lblNumN
            // 
            this.lblNumN.AutoSize = true;
            this.lblNumN.Location = new System.Drawing.Point(17, 93);
            this.lblNumN.Name = "lblNumN";
            this.lblNumN.Size = new System.Drawing.Size(45, 17);
            this.lblNumN.TabIndex = 8;
            this.lblNumN.Text = "Số m: ";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(83, 123);
            this.txtAns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.Size = new System.Drawing.Size(226, 25);
            this.txtAns.TabIndex = 11;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(17, 126);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(60, 17);
            this.lblAns.TabIndex = 10;
            this.lblAns.Text = "Kết quả: ";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(333, 203);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.txtNumN);
            this.Controls.Add(this.lblNumN);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtNumM);
            this.Controls.Add(this.lblNumM);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bai01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính toán cơ bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumM;
        private System.Windows.Forms.TextBox txtNumM;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNumN;
        private System.Windows.Forms.Label lblNumN;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblAns;
    }
}

