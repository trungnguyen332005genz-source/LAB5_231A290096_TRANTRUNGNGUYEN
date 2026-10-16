namespace Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblSo1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(55, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHƯƠNG TRÌNH TÍNH TOÁN ĐƠN GIẢN";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblSo1);
            this.grpBox.Controls.Add(this.txtSo1);
            this.grpBox.Controls.Add(this.lblSo2);
            this.grpBox.Controls.Add(this.txtSo2);
            this.grpBox.Controls.Add(this.lblKetQua);
            this.grpBox.Controls.Add(this.txtKetQua);
            this.grpBox.Location = new System.Drawing.Point(40, 60);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(400, 160);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Tính toán đơn giản";
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(25, 35);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(71, 15);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số thứ nhất:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(120, 32);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(250, 23);
            this.txtSo1.TabIndex = 1;
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(25, 75);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(64, 15);
            this.lblSo2.TabIndex = 2;
            this.lblSo2.Text = "Số thứ hai:";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(120, 72);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(250, 23);
            this.txtSo2.TabIndex = 3;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(25, 115);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(50, 15);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(120, 112);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(250, 23);
            this.txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(90, 235);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(65, 30);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(170, 235);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(65, 30);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(250, 235);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(65, 30);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(330, 235);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(65, 30);
            this.btnChia.TabIndex = 5;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 290);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}
