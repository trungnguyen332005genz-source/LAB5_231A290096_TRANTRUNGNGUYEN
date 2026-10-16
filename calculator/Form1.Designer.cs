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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            
            // Tab 1: Calculator
            this.tabCalculator = new System.Windows.Forms.TabPage();
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

            // Tab 2: Bai 1 - Power
            this.tabBai1 = new System.Windows.Forms.TabPage();
            this.lblBai1Title = new System.Windows.Forms.Label();
            this.lblPowerX = new System.Windows.Forms.Label();
            this.txtPowerX = new System.Windows.Forms.TextBox();
            this.lblPowerN = new System.Windows.Forms.Label();
            this.txtPowerN = new System.Windows.Forms.TextBox();
            this.btnCalcPower = new System.Windows.Forms.Button();
            this.btnComparePowerBug = new System.Windows.Forms.Button();
            this.lblPowerResult = new System.Windows.Forms.Label();
            this.txtPowerResult = new System.Windows.Forms.TextBox();

            // Tab 3: Bai 2 - Polynomial
            this.tabBai2 = new System.Windows.Forms.TabPage();
            this.lblBai2Title = new System.Windows.Forms.Label();
            this.lblPolyN = new System.Windows.Forms.Label();
            this.txtPolyN = new System.Windows.Forms.TextBox();
            this.lblPolyA = new System.Windows.Forms.Label();
            this.txtPolyA = new System.Windows.Forms.TextBox();
            this.lblPolyX = new System.Windows.Forms.Label();
            this.txtPolyX = new System.Windows.Forms.TextBox();
            this.btnCalcPoly = new System.Windows.Forms.Button();
            this.lblPolyResult = new System.Windows.Forms.Label();
            this.txtPolyResult = new System.Windows.Forms.TextBox();

            // Tab 4: Bai 3 - Radix
            this.tabBai3 = new System.Windows.Forms.TabPage();
            this.lblBai3Title = new System.Windows.Forms.Label();
            this.lblRadixNum = new System.Windows.Forms.Label();
            this.txtRadixNum = new System.Windows.Forms.TextBox();
            this.lblRadixBase = new System.Windows.Forms.Label();
            this.cboRadixBase = new System.Windows.Forms.ComboBox();
            this.btnConvertRadix = new System.Windows.Forms.Button();
            this.lblRadixResult = new System.Windows.Forms.Label();
            this.txtRadixResult = new System.Windows.Forms.TextBox();

            // Tab 5: Bai 4 - Geometry
            this.tabBai4 = new System.Windows.Forms.TabPage();
            this.lblBai4Title = new System.Windows.Forms.Label();
            this.grpRect1 = new System.Windows.Forms.GroupBox();
            this.lblR1TL = new System.Windows.Forms.Label();
            this.txtR1TLX = new System.Windows.Forms.TextBox();
            this.txtR1TLY = new System.Windows.Forms.TextBox();
            this.lblR1BR = new System.Windows.Forms.Label();
            this.txtR1BRX = new System.Windows.Forms.TextBox();
            this.txtR1BRY = new System.Windows.Forms.TextBox();
            this.grpRect2 = new System.Windows.Forms.GroupBox();
            this.lblR2TL = new System.Windows.Forms.Label();
            this.txtR2TLX = new System.Windows.Forms.TextBox();
            this.txtR2TLY = new System.Windows.Forms.TextBox();
            this.lblR2BR = new System.Windows.Forms.Label();
            this.txtR2BRX = new System.Windows.Forms.TextBox();
            this.txtR2BRY = new System.Windows.Forms.TextBox();
            this.btnCalcArea = new System.Windows.Forms.Button();
            this.btnCheckIntersect = new System.Windows.Forms.Button();
            this.txtGeomResult = new System.Windows.Forms.TextBox();

            // Tab 6: Bai 5 - Student Management
            this.tabBai5 = new System.Windows.Forms.TabPage();
            this.lblBai5Title = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblM1 = new System.Windows.Forms.Label();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.lblM2 = new System.Windows.Forms.Label();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.lblM3 = new System.Windows.Forms.Label();
            this.txtM3 = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnLoadSample = new System.Windows.Forms.Button();
            this.btnFilterScholarship = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();

            this.tabControlMain.SuspendLayout();
            this.tabCalculator.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.tabBai1.SuspendLayout();
            this.tabBai2.SuspendLayout();
            this.tabBai3.SuspendLayout();
            this.tabBai4.SuspendLayout();
            this.grpRect1.SuspendLayout();
            this.grpRect2.SuspendLayout();
            this.tabBai5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabCalculator);
            this.tabControlMain.Controls.Add(this.tabBai1);
            this.tabControlMain.Controls.Add(this.tabBai2);
            this.tabControlMain.Controls.Add(this.tabBai3);
            this.tabControlMain.Controls.Add(this.tabBai4);
            this.tabControlMain.Controls.Add(this.tabBai5);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 521);
            this.tabControlMain.TabIndex = 0;

            // ==========================================
            // TAB 1: CALCULATOR
            // ==========================================
            this.tabCalculator.Controls.Add(this.btnChia);
            this.tabCalculator.Controls.Add(this.btnNhan);
            this.tabCalculator.Controls.Add(this.btnTru);
            this.tabCalculator.Controls.Add(this.btnCong);
            this.tabCalculator.Controls.Add(this.grpBox);
            this.tabCalculator.Controls.Add(this.lblTitle);
            this.tabCalculator.Location = new System.Drawing.Point(4, 25);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(776, 492);
            this.tabCalculator.Text = "Phần 2: Calculator";
            this.tabCalculator.UseVisualStyleBackColor = true;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(190, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 28);
            this.lblTitle.Text = "CHƯƠNG TRÌNH TÍNH TOÁN ĐƠN GIẢN";

            this.grpBox.Controls.Add(this.lblSo1);
            this.grpBox.Controls.Add(this.txtSo1);
            this.grpBox.Controls.Add(this.lblSo2);
            this.grpBox.Controls.Add(this.txtSo2);
            this.grpBox.Controls.Add(this.lblKetQua);
            this.grpBox.Controls.Add(this.txtKetQua);
            this.grpBox.Location = new System.Drawing.Point(150, 75);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(480, 180);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Tính toán đơn giản";

            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(35, 40);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(79, 17);
            this.lblSo1.Text = "Số thứ nhất:";

            this.txtSo1.Location = new System.Drawing.Point(140, 37);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(295, 24);
            this.txtSo1.TabIndex = 1;

            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(35, 85);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(71, 17);
            this.lblSo2.Text = "Số thứ hai:";

            this.txtSo2.Location = new System.Drawing.Point(140, 82);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(295, 24);
            this.txtSo2.TabIndex = 3;

            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(35, 130);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(56, 17);
            this.lblKetQua.Text = "Kết quả:";

            this.txtKetQua.Location = new System.Drawing.Point(140, 127);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(295, 24);
            this.txtKetQua.TabIndex = 5;

            this.btnCong.Location = new System.Drawing.Point(210, 275);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 32);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);

            this.btnTru.Location = new System.Drawing.Point(300, 275);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 32);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);

            this.btnNhan.Location = new System.Drawing.Point(390, 275);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 32);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);

            this.btnChia.Location = new System.Drawing.Point(480, 275);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 32);
            this.btnChia.TabIndex = 5;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);

            // ==========================================
            // TAB 2: BAI 1 - POWER
            // ==========================================
            this.tabBai1.Controls.Add(this.txtPowerResult);
            this.tabBai1.Controls.Add(this.lblPowerResult);
            this.tabBai1.Controls.Add(this.btnComparePowerBug);
            this.tabBai1.Controls.Add(this.btnCalcPower);
            this.tabBai1.Controls.Add(this.txtPowerN);
            this.tabBai1.Controls.Add(this.lblPowerN);
            this.tabBai1.Controls.Add(this.txtPowerX);
            this.tabBai1.Controls.Add(this.lblPowerX);
            this.tabBai1.Controls.Add(this.lblBai1Title);
            this.tabBai1.Location = new System.Drawing.Point(4, 25);
            this.tabBai1.Name = "tabBai1";
            this.tabBai1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBai1.Size = new System.Drawing.Size(776, 492);
            this.tabBai1.Text = "Bài 1: Lũy thừa (Power)";
            this.tabBai1.UseVisualStyleBackColor = true;

            this.lblBai1Title.AutoSize = true;
            this.lblBai1Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBai1Title.ForeColor = System.Drawing.Color.Navy;
            this.lblBai1Title.Location = new System.Drawing.Point(40, 25);
            this.lblBai1Title.Name = "lblBai1Title";
            this.lblBai1Title.Size = new System.Drawing.Size(530, 25);
            this.lblBai1Title.Text = "BÀI 1: TÍNH LŨY THỪA x^n BẰNG ĐỆ QUY (x: SỐ THỰC, n: SỐ NGUYÊN)";

            this.lblPowerX.AutoSize = true;
            this.lblPowerX.Location = new System.Drawing.Point(45, 80);
            this.lblPowerX.Name = "lblPowerX";
            this.lblPowerX.Size = new System.Drawing.Size(109, 17);
            this.lblPowerX.Text = "Cơ số thực x:";

            this.txtPowerX.Location = new System.Drawing.Point(170, 77);
            this.txtPowerX.Name = "txtPowerX";
            this.txtPowerX.Size = new System.Drawing.Size(200, 24);
            this.txtPowerX.TabIndex = 1;
            this.txtPowerX.Text = "2";

            this.lblPowerN.AutoSize = true;
            this.lblPowerN.Location = new System.Drawing.Point(45, 125);
            this.lblPowerN.Name = "lblPowerN";
            this.lblPowerN.Size = new System.Drawing.Size(117, 17);
            this.lblPowerN.Text = "Số mũ nguyên n:";

            this.txtPowerN.Location = new System.Drawing.Point(170, 122);
            this.txtPowerN.Name = "txtPowerN";
            this.txtPowerN.Size = new System.Drawing.Size(200, 24);
            this.txtPowerN.TabIndex = 2;
            this.txtPowerN.Text = "3";

            this.btnCalcPower.Location = new System.Drawing.Point(45, 175);
            this.btnCalcPower.Name = "btnCalcPower";
            this.btnCalcPower.Size = new System.Drawing.Size(180, 35);
            this.btnCalcPower.TabIndex = 3;
            this.btnCalcPower.Text = "Tính lũy thừa x^n";
            this.btnCalcPower.UseVisualStyleBackColor = true;
            this.btnCalcPower.Click += new System.EventHandler(this.btnCalcPower_Click);

            this.btnComparePowerBug.Location = new System.Drawing.Point(240, 175);
            this.btnComparePowerBug.Name = "btnComparePowerBug";
            this.btnComparePowerBug.Size = new System.Drawing.Size(250, 35);
            this.btnComparePowerBug.TabIndex = 4;
            this.btnComparePowerBug.Text = "So sánh Code chuẩn vs Code PDF";
            this.btnComparePowerBug.UseVisualStyleBackColor = true;
            this.btnComparePowerBug.Click += new System.EventHandler(this.btnComparePowerBug_Click);

            this.lblPowerResult.AutoSize = true;
            this.lblPowerResult.Location = new System.Drawing.Point(45, 230);
            this.lblPowerResult.Name = "lblPowerResult";
            this.lblPowerResult.Size = new System.Drawing.Size(56, 17);
            this.lblPowerResult.Text = "Kết quả:";

            this.txtPowerResult.Location = new System.Drawing.Point(45, 255);
            this.txtPowerResult.Multiline = true;
            this.txtPowerResult.Name = "txtPowerResult";
            this.txtPowerResult.ReadOnly = true;
            this.txtPowerResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPowerResult.Size = new System.Drawing.Size(680, 180);
            this.txtPowerResult.TabIndex = 5;

            // ==========================================
            // TAB 3: BAI 2 - POLYNOMIAL
            // ==========================================
            this.tabBai2.Controls.Add(this.txtPolyResult);
            this.tabBai2.Controls.Add(this.lblPolyResult);
            this.tabBai2.Controls.Add(this.btnCalcPoly);
            this.tabBai2.Controls.Add(this.txtPolyX);
            this.tabBai2.Controls.Add(this.lblPolyX);
            this.tabBai2.Controls.Add(this.txtPolyA);
            this.tabBai2.Controls.Add(this.lblPolyA);
            this.tabBai2.Controls.Add(this.txtPolyN);
            this.tabBai2.Controls.Add(this.lblPolyN);
            this.tabBai2.Controls.Add(this.lblBai2Title);
            this.tabBai2.Location = new System.Drawing.Point(4, 25);
            this.tabBai2.Name = "tabBai2";
            this.tabBai2.Padding = new System.Windows.Forms.Padding(3);
            this.tabBai2.Size = new System.Drawing.Size(776, 492);
            this.tabBai2.Text = "Bài 2: Đa thức (Polynomial)";
            this.tabBai2.UseVisualStyleBackColor = true;

            this.lblBai2Title.AutoSize = true;
            this.lblBai2Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBai2Title.ForeColor = System.Drawing.Color.Navy;
            this.lblBai2Title.Location = new System.Drawing.Point(40, 25);
            this.lblBai2Title.Name = "lblBai2Title";
            this.lblBai2Title.Size = new System.Drawing.Size(550, 25);
            this.lblBai2Title.Text = "BÀI 2: TÍNH GIÁ TRỊ ĐA THỨC BẬC n: P(x) = a0 + a1*x + ... + an*x^n";

            this.lblPolyN.AutoSize = true;
            this.lblPolyN.Location = new System.Drawing.Point(45, 75);
            this.lblPolyN.Name = "lblPolyN";
            this.lblPolyN.Size = new System.Drawing.Size(126, 17);
            this.lblPolyN.Text = "Bậc đa thức (n):";

            this.txtPolyN.Location = new System.Drawing.Point(230, 72);
            this.txtPolyN.Name = "txtPolyN";
            this.txtPolyN.Size = new System.Drawing.Size(120, 24);
            this.txtPolyN.TabIndex = 1;
            this.txtPolyN.Text = "2";

            this.lblPolyA.AutoSize = true;
            this.lblPolyA.Location = new System.Drawing.Point(45, 115);
            this.lblPolyA.Name = "lblPolyA";
            this.lblPolyA.Size = new System.Drawing.Size(175, 17);
            this.lblPolyA.Text = "Hệ số a0, a1, ..., an (cách phẩy):";

            this.txtPolyA.Location = new System.Drawing.Point(230, 112);
            this.txtPolyA.Name = "txtPolyA";
            this.txtPolyA.Size = new System.Drawing.Size(300, 24);
            this.txtPolyA.TabIndex = 2;
            this.txtPolyA.Text = "1, 2, 3";

            this.lblPolyX.AutoSize = true;
            this.lblPolyX.Location = new System.Drawing.Point(45, 155);
            this.lblPolyX.Name = "lblPolyX";
            this.lblPolyX.Size = new System.Drawing.Size(107, 17);
            this.lblPolyX.Text = "Giá trị biến x:";

            this.txtPolyX.Location = new System.Drawing.Point(230, 152);
            this.txtPolyX.Name = "txtPolyX";
            this.txtPolyX.Size = new System.Drawing.Size(120, 24);
            this.txtPolyX.TabIndex = 3;
            this.txtPolyX.Text = "2";

            this.btnCalcPoly.Location = new System.Drawing.Point(45, 195);
            this.btnCalcPoly.Name = "btnCalcPoly";
            this.btnCalcPoly.Size = new System.Drawing.Size(180, 35);
            this.btnCalcPoly.TabIndex = 4;
            this.btnCalcPoly.Text = "Tính giá trị đa thức P(x)";
            this.btnCalcPoly.UseVisualStyleBackColor = true;
            this.btnCalcPoly.Click += new System.EventHandler(this.btnCalcPoly_Click);

            this.lblPolyResult.AutoSize = true;
            this.lblPolyResult.Location = new System.Drawing.Point(45, 245);
            this.lblPolyResult.Name = "lblPolyResult";
            this.lblPolyResult.Size = new System.Drawing.Size(56, 17);
            this.lblPolyResult.Text = "Kết quả:";

            this.txtPolyResult.Location = new System.Drawing.Point(45, 270);
            this.txtPolyResult.Multiline = true;
            this.txtPolyResult.Name = "txtPolyResult";
            this.txtPolyResult.ReadOnly = true;
            this.txtPolyResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolyResult.Size = new System.Drawing.Size(680, 170);
            this.txtPolyResult.TabIndex = 5;

            // ==========================================
            // TAB 4: BAI 3 - RADIX
            // ==========================================
            this.tabBai3.Controls.Add(this.txtRadixResult);
            this.tabBai3.Controls.Add(this.lblRadixResult);
            this.tabBai3.Controls.Add(this.btnConvertRadix);
            this.tabBai3.Controls.Add(this.cboRadixBase);
            this.tabBai3.Controls.Add(this.lblRadixBase);
            this.tabBai3.Controls.Add(this.txtRadixNum);
            this.tabBai3.Controls.Add(this.lblRadixNum);
            this.tabBai3.Controls.Add(this.lblBai3Title);
            this.tabBai3.Location = new System.Drawing.Point(4, 25);
            this.tabBai3.Name = "tabBai3";
            this.tabBai3.Padding = new System.Windows.Forms.Padding(3);
            this.tabBai3.Size = new System.Drawing.Size(776, 492);
            this.tabBai3.Text = "Bài 3: Đổi cơ số (Radix)";
            this.tabBai3.UseVisualStyleBackColor = true;

            this.lblBai3Title.AutoSize = true;
            this.lblBai3Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBai3Title.ForeColor = System.Drawing.Color.Navy;
            this.lblBai3Title.Location = new System.Drawing.Point(40, 25);
            this.lblBai3Title.Name = "lblBai3Title";
            this.lblBai3Title.Size = new System.Drawing.Size(535, 25);
            this.lblBai3Title.Text = "BÀI 3: CHUYỂN ĐỔI SỐ NGUYÊN HỆ 10 SANG CƠ SỐ k (2 <= k <= 16)";

            this.lblRadixNum.AutoSize = true;
            this.lblRadixNum.Location = new System.Drawing.Point(45, 80);
            this.lblRadixNum.Name = "lblRadixNum";
            this.lblRadixNum.Size = new System.Drawing.Size(155, 17);
            this.lblRadixNum.Text = "Số nguyên hệ 10 (>= 0):";

            this.txtRadixNum.Location = new System.Drawing.Point(220, 77);
            this.txtRadixNum.Name = "txtRadixNum";
            this.txtRadixNum.Size = new System.Drawing.Size(200, 24);
            this.txtRadixNum.TabIndex = 1;
            this.txtRadixNum.Text = "255";

            this.lblRadixBase.AutoSize = true;
            this.lblRadixBase.Location = new System.Drawing.Point(45, 125);
            this.lblRadixBase.Name = "lblRadixBase";
            this.lblRadixBase.Size = new System.Drawing.Size(161, 17);
            this.lblRadixBase.Text = "Cơ số đích k (2 đến 16):";

            this.cboRadixBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRadixBase.FormattingEnabled = true;
            this.cboRadixBase.Location = new System.Drawing.Point(220, 122);
            this.cboRadixBase.Name = "cboRadixBase";
            this.cboRadixBase.Size = new System.Drawing.Size(200, 24);
            this.cboRadixBase.TabIndex = 2;

            this.btnConvertRadix.Location = new System.Drawing.Point(45, 175);
            this.btnConvertRadix.Name = "btnConvertRadix";
            this.btnConvertRadix.Size = new System.Drawing.Size(180, 35);
            this.btnConvertRadix.TabIndex = 3;
            this.btnConvertRadix.Text = "Chuyển đổi cơ số";
            this.btnConvertRadix.UseVisualStyleBackColor = true;
            this.btnConvertRadix.Click += new System.EventHandler(this.btnConvertRadix_Click);

            this.lblRadixResult.AutoSize = true;
            this.lblRadixResult.Location = new System.Drawing.Point(45, 230);
            this.lblRadixResult.Name = "lblRadixResult";
            this.lblRadixResult.Size = new System.Drawing.Size(56, 17);
            this.lblRadixResult.Text = "Kết quả:";

            this.txtRadixResult.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.txtRadixResult.Location = new System.Drawing.Point(45, 255);
            this.txtRadixResult.Name = "txtRadixResult";
            this.txtRadixResult.ReadOnly = true;
            this.txtRadixResult.Size = new System.Drawing.Size(500, 25);
            this.txtRadixResult.TabIndex = 4;

            // ==========================================
            // TAB 4: BAI 4 - GEOMETRY
            // ==========================================
            this.tabBai4.Controls.Add(this.txtGeomResult);
            this.tabBai4.Controls.Add(this.btnCheckIntersect);
            this.tabBai4.Controls.Add(this.btnCalcArea);
            this.tabBai4.Controls.Add(this.grpRect2);
            this.tabBai4.Controls.Add(this.grpRect1);
            this.tabBai4.Controls.Add(this.lblBai4Title);
            this.tabBai4.Location = new System.Drawing.Point(4, 25);
            this.tabBai4.Name = "tabBai4";
            this.tabBai4.Padding = new System.Windows.Forms.Padding(3);
            this.tabBai4.Size = new System.Drawing.Size(776, 492);
            this.tabBai4.Text = "Bài 4: Hình chữ nhật";
            this.tabBai4.UseVisualStyleBackColor = true;

            this.lblBai4Title.AutoSize = true;
            this.lblBai4Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBai4Title.ForeColor = System.Drawing.Color.Navy;
            this.lblBai4Title.Location = new System.Drawing.Point(40, 20);
            this.lblBai4Title.Name = "lblBai4Title";
            this.lblBai4Title.Size = new System.Drawing.Size(585, 25);
            this.lblBai4Title.Text = "BÀI 4: HÌNH CHỮ NHẬT 2D (TÍNH DIỆN TÍCH & KIỂM TRA GIAO NHAU)";

            // Group Rect 1
            this.grpRect1.Controls.Add(this.txtR1BRY);
            this.grpRect1.Controls.Add(this.txtR1BRX);
            this.grpRect1.Controls.Add(this.lblR1BR);
            this.grpRect1.Controls.Add(this.txtR1TLY);
            this.grpRect1.Controls.Add(this.txtR1TLX);
            this.grpRect1.Controls.Add(this.lblR1TL);
            this.grpRect1.Location = new System.Drawing.Point(40, 60);
            this.grpRect1.Name = "grpRect1";
            this.grpRect1.Size = new System.Drawing.Size(330, 120);
            this.grpRect1.TabIndex = 1;
            this.grpRect1.TabStop = false;
            this.grpRect1.Text = "Hình chữ nhật 1";

            this.lblR1TL.AutoSize = true;
            this.lblR1TL.Location = new System.Drawing.Point(15, 35);
            this.lblR1TL.Name = "lblR1TL";
            this.lblR1TL.Size = new System.Drawing.Size(95, 17);
            this.lblR1TL.TabIndex = 0;
            this.lblR1TL.Text = "TopLeft (X, Y):";

            this.txtR1TLX.Location = new System.Drawing.Point(130, 32);
            this.txtR1TLX.Name = "txtR1TLX";
            this.txtR1TLX.Size = new System.Drawing.Size(65, 24);
            this.txtR1TLX.TabIndex = 1;
            this.txtR1TLX.Text = "0";

            this.txtR1TLY.Location = new System.Drawing.Point(210, 32);
            this.txtR1TLY.Name = "txtR1TLY";
            this.txtR1TLY.Size = new System.Drawing.Size(65, 24);
            this.txtR1TLY.TabIndex = 2;
            this.txtR1TLY.Text = "4";

            this.lblR1BR.AutoSize = true;
            this.lblR1BR.Location = new System.Drawing.Point(15, 75);
            this.lblR1BR.Name = "lblR1BR";
            this.lblR1BR.Size = new System.Drawing.Size(117, 17);
            this.lblR1BR.TabIndex = 3;
            this.lblR1BR.Text = "BottomRight (X, Y):";

            this.txtR1BRX.Location = new System.Drawing.Point(130, 72);
            this.txtR1BRX.Name = "txtR1BRX";
            this.txtR1BRX.Size = new System.Drawing.Size(65, 24);
            this.txtR1BRX.TabIndex = 4;
            this.txtR1BRX.Text = "4";

            this.txtR1BRY.Location = new System.Drawing.Point(210, 72);
            this.txtR1BRY.Name = "txtR1BRY";
            this.txtR1BRY.Size = new System.Drawing.Size(65, 24);
            this.txtR1BRY.TabIndex = 5;
            this.txtR1BRY.Text = "0";

            // Group Rect 2
            this.grpRect2.Controls.Add(this.txtR2BRY);
            this.grpRect2.Controls.Add(this.txtR2BRX);
            this.grpRect2.Controls.Add(this.lblR2BR);
            this.grpRect2.Controls.Add(this.txtR2TLY);
            this.grpRect2.Controls.Add(this.txtR2TLX);
            this.grpRect2.Controls.Add(this.lblR2TL);
            this.grpRect2.Location = new System.Drawing.Point(390, 60);
            this.grpRect2.Name = "grpRect2";
            this.grpRect2.Size = new System.Drawing.Size(330, 120);
            this.grpRect2.TabIndex = 2;
            this.grpRect2.TabStop = false;
            this.grpRect2.Text = "Hình chữ nhật 2";

            this.lblR2TL.AutoSize = true;
            this.lblR2TL.Location = new System.Drawing.Point(15, 35);
            this.lblR2TL.Name = "lblR2TL";
            this.lblR2TL.Size = new System.Drawing.Size(95, 17);
            this.lblR2TL.TabIndex = 0;
            this.lblR2TL.Text = "TopLeft (X, Y):";

            this.txtR2TLX.Location = new System.Drawing.Point(130, 32);
            this.txtR2TLX.Name = "txtR2TLX";
            this.txtR2TLX.Size = new System.Drawing.Size(65, 24);
            this.txtR2TLX.TabIndex = 1;
            this.txtR2TLX.Text = "2";

            this.txtR2TLY.Location = new System.Drawing.Point(210, 32);
            this.txtR2TLY.Name = "txtR2TLY";
            this.txtR2TLY.Size = new System.Drawing.Size(65, 24);
            this.txtR2TLY.TabIndex = 2;
            this.txtR2TLY.Text = "5";

            this.lblR2BR.AutoSize = true;
            this.lblR2BR.Location = new System.Drawing.Point(15, 75);
            this.lblR2BR.Name = "lblR2BR";
            this.lblR2BR.Size = new System.Drawing.Size(117, 17);
            this.lblR2BR.TabIndex = 3;
            this.lblR2BR.Text = "BottomRight (X, Y):";

            this.txtR2BRX.Location = new System.Drawing.Point(130, 72);
            this.txtR2BRX.Name = "txtR2BRX";
            this.txtR2BRX.Size = new System.Drawing.Size(65, 24);
            this.txtR2BRX.TabIndex = 4;
            this.txtR2BRX.Text = "6";

            this.txtR2BRY.Location = new System.Drawing.Point(210, 72);
            this.txtR2BRY.Name = "txtR2BRY";
            this.txtR2BRY.Size = new System.Drawing.Size(65, 24);
            this.txtR2BRY.TabIndex = 5;
            this.txtR2BRY.Text = "2";

            this.btnCalcArea.Location = new System.Drawing.Point(40, 195);
            this.btnCalcArea.Name = "btnCalcArea";
            this.btnCalcArea.Size = new System.Drawing.Size(180, 35);
            this.btnCalcArea.TabIndex = 3;
            this.btnCalcArea.Text = "Tính diện tích";
            this.btnCalcArea.UseVisualStyleBackColor = true;
            this.btnCalcArea.Click += new System.EventHandler(this.btnCalcArea_Click);

            this.btnCheckIntersect.Location = new System.Drawing.Point(240, 195);
            this.btnCheckIntersect.Name = "btnCheckIntersect";
            this.btnCheckIntersect.Size = new System.Drawing.Size(220, 35);
            this.btnCheckIntersect.TabIndex = 4;
            this.btnCheckIntersect.Text = "Kiểm tra hai HCN giao nhau";
            this.btnCheckIntersect.UseVisualStyleBackColor = true;
            this.btnCheckIntersect.Click += new System.EventHandler(this.btnCheckIntersect_Click);

            this.txtGeomResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGeomResult.Location = new System.Drawing.Point(40, 245);
            this.txtGeomResult.Multiline = true;
            this.txtGeomResult.Name = "txtGeomResult";
            this.txtGeomResult.ReadOnly = true;
            this.txtGeomResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeomResult.Size = new System.Drawing.Size(680, 200);
            this.txtGeomResult.TabIndex = 5;

            // ==========================================
            // TAB 6: BAI 5 - STUDENT MANAGEMENT
            // ==========================================
            this.tabBai5.Controls.Add(this.dgvStudents);
            this.tabBai5.Controls.Add(this.btnFilterScholarship);
            this.tabBai5.Controls.Add(this.btnLoadSample);
            this.tabBai5.Controls.Add(this.btnAddStudent);
            this.tabBai5.Controls.Add(this.txtM3);
            this.tabBai5.Controls.Add(this.lblM3);
            this.tabBai5.Controls.Add(this.txtM2);
            this.tabBai5.Controls.Add(this.lblM2);
            this.tabBai5.Controls.Add(this.txtM1);
            this.tabBai5.Controls.Add(this.lblM1);
            this.tabBai5.Controls.Add(this.txtQueQuan);
            this.tabBai5.Controls.Add(this.lblQueQuan);
            this.tabBai5.Controls.Add(this.txtHoTen);
            this.tabBai5.Controls.Add(this.lblHoTen);
            this.tabBai5.Controls.Add(this.txtMaSo);
            this.tabBai5.Controls.Add(this.lblMaSo);
            this.tabBai5.Controls.Add(this.lblBai5Title);
            this.tabBai5.Location = new System.Drawing.Point(4, 25);
            this.tabBai5.Name = "tabBai5";
            this.tabBai5.Padding = new System.Windows.Forms.Padding(3);
            this.tabBai5.Size = new System.Drawing.Size(776, 492);
            this.tabBai5.Text = "Bài 5: Quản lý học viên";
            this.tabBai5.UseVisualStyleBackColor = true;

            this.lblBai5Title.AutoSize = true;
            this.lblBai5Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBai5Title.ForeColor = System.Drawing.Color.Navy;
            this.lblBai5Title.Location = new System.Drawing.Point(30, 15);
            this.lblBai5Title.Name = "lblBai5Title";
            this.lblBai5Title.Size = new System.Drawing.Size(635, 25);
            this.lblBai5Title.Text = "BÀI 5: QUẢN LÝ HỌC VIÊN & XÉT HỌC BỔNG (ĐTB >= 8.0 & KHÔNG MÔN NÀO < 5.0)";

            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(30, 55);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(50, 17);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";

            this.txtMaSo.Location = new System.Drawing.Point(85, 52);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(90, 24);
            this.txtMaSo.TabIndex = 1;

            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(190, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 17);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";

            this.txtHoTen.Location = new System.Drawing.Point(245, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 24);
            this.txtHoTen.TabIndex = 3;

            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(440, 55);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(68, 17);
            this.lblQueQuan.TabIndex = 4;
            this.lblQueQuan.Text = "Quê quán:";

            this.txtQueQuan.Location = new System.Drawing.Point(515, 52);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(180, 24);
            this.txtQueQuan.TabIndex = 5;

            this.lblM1.AutoSize = true;
            this.lblM1.Location = new System.Drawing.Point(30, 95);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(81, 17);
            this.lblM1.TabIndex = 6;
            this.lblM1.Text = "Điểm Môn 1:";

            this.txtM1.Location = new System.Drawing.Point(115, 92);
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(60, 24);
            this.txtM1.TabIndex = 7;

            this.lblM2.AutoSize = true;
            this.lblM2.Location = new System.Drawing.Point(195, 95);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(81, 17);
            this.lblM2.TabIndex = 8;
            this.lblM2.Text = "Điểm Môn 2:";

            this.txtM2.Location = new System.Drawing.Point(280, 92);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(60, 24);
            this.txtM2.TabIndex = 9;

            this.lblM3.AutoSize = true;
            this.lblM3.Location = new System.Drawing.Point(360, 95);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(81, 17);
            this.lblM3.TabIndex = 10;
            this.lblM3.Text = "Điểm Môn 3:";

            this.txtM3.Location = new System.Drawing.Point(445, 92);
            this.txtM3.Name = "txtM3";
            this.txtM3.Size = new System.Drawing.Size(60, 24);
            this.txtM3.TabIndex = 11;

            this.btnAddStudent.Location = new System.Drawing.Point(30, 130);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(140, 32);
            this.btnAddStudent.TabIndex = 12;
            this.btnAddStudent.Text = "Thêm học viên";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            this.btnLoadSample.Location = new System.Drawing.Point(185, 130);
            this.btnLoadSample.Name = "btnLoadSample";
            this.btnLoadSample.Size = new System.Drawing.Size(160, 32);
            this.btnLoadSample.TabIndex = 13;
            this.btnLoadSample.Text = "Nạp dữ liệu mẫu";
            this.btnLoadSample.UseVisualStyleBackColor = true;
            this.btnLoadSample.Click += new System.EventHandler(this.btnLoadSample_Click);

            this.btnFilterScholarship.BackColor = System.Drawing.Color.LightGreen;
            this.btnFilterScholarship.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterScholarship.Location = new System.Drawing.Point(360, 130);
            this.btnFilterScholarship.Name = "btnFilterScholarship";
            this.btnFilterScholarship.Size = new System.Drawing.Size(220, 32);
            this.btnFilterScholarship.TabIndex = 14;
            this.btnFilterScholarship.Text = "Lọc DS Nhận Học Bổng";
            this.btnFilterScholarship.UseVisualStyleBackColor = false;
            this.btnFilterScholarship.Click += new System.EventHandler(this.btnFilterScholarship_Click);

            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(30, 175);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(710, 290);
            this.dgvStudents.TabIndex = 15;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 05 - Unit Test & Ứng Dụng Thực Hành - Trần Trung Nguyên (231A290096)";
            this.tabControlMain.ResumeLayout(false);
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.tabBai1.ResumeLayout(false);
            this.tabBai1.PerformLayout();
            this.tabBai2.ResumeLayout(false);
            this.tabBai2.PerformLayout();
            this.tabBai3.ResumeLayout(false);
            this.tabBai3.PerformLayout();
            this.tabBai4.ResumeLayout(false);
            this.tabBai4.PerformLayout();
            this.grpRect1.ResumeLayout(false);
            this.grpRect1.PerformLayout();
            this.grpRect2.ResumeLayout(false);
            this.grpRect2.PerformLayout();
            this.tabBai5.ResumeLayout(false);
            this.tabBai5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        
        // Tab 1
        private System.Windows.Forms.TabPage tabCalculator;
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

        // Tab 2
        private System.Windows.Forms.TabPage tabBai1;
        private System.Windows.Forms.Label lblBai1Title;
        private System.Windows.Forms.Label lblPowerX;
        private System.Windows.Forms.TextBox txtPowerX;
        private System.Windows.Forms.Label lblPowerN;
        private System.Windows.Forms.TextBox txtPowerN;
        private System.Windows.Forms.Button btnCalcPower;
        private System.Windows.Forms.Button btnComparePowerBug;
        private System.Windows.Forms.Label lblPowerResult;
        private System.Windows.Forms.TextBox txtPowerResult;

        // Tab 3
        private System.Windows.Forms.TabPage tabBai2;
        private System.Windows.Forms.Label lblBai2Title;
        private System.Windows.Forms.Label lblPolyN;
        private System.Windows.Forms.TextBox txtPolyN;
        private System.Windows.Forms.Label lblPolyA;
        private System.Windows.Forms.TextBox txtPolyA;
        private System.Windows.Forms.Label lblPolyX;
        private System.Windows.Forms.TextBox txtPolyX;
        private System.Windows.Forms.Button btnCalcPoly;
        private System.Windows.Forms.Label lblPolyResult;
        private System.Windows.Forms.TextBox txtPolyResult;

        // Tab 4
        private System.Windows.Forms.TabPage tabBai3;
        private System.Windows.Forms.Label lblBai3Title;
        private System.Windows.Forms.Label lblRadixNum;
        private System.Windows.Forms.TextBox txtRadixNum;
        private System.Windows.Forms.Label lblRadixBase;
        private System.Windows.Forms.ComboBox cboRadixBase;
        private System.Windows.Forms.Button btnConvertRadix;
        private System.Windows.Forms.Label lblRadixResult;
        private System.Windows.Forms.TextBox txtRadixResult;

        // Tab 5
        private System.Windows.Forms.TabPage tabBai4;
        private System.Windows.Forms.Label lblBai4Title;
        private System.Windows.Forms.GroupBox grpRect1;
        private System.Windows.Forms.Label lblR1TL;
        private System.Windows.Forms.TextBox txtR1TLX;
        private System.Windows.Forms.TextBox txtR1TLY;
        private System.Windows.Forms.Label lblR1BR;
        private System.Windows.Forms.TextBox txtR1BRX;
        private System.Windows.Forms.TextBox txtR1BRY;
        private System.Windows.Forms.GroupBox grpRect2;
        private System.Windows.Forms.Label lblR2TL;
        private System.Windows.Forms.TextBox txtR2TLX;
        private System.Windows.Forms.TextBox txtR2TLY;
        private System.Windows.Forms.Label lblR2BR;
        private System.Windows.Forms.TextBox txtR2BRX;
        private System.Windows.Forms.TextBox txtR2BRY;
        private System.Windows.Forms.Button btnCalcArea;
        private System.Windows.Forms.Button btnCheckIntersect;
        private System.Windows.Forms.TextBox txtGeomResult;

        // Tab 6
        private System.Windows.Forms.TabPage tabBai5;
        private System.Windows.Forms.Label lblBai5Title;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.TextBox txtM3;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnLoadSample;
        private System.Windows.Forms.Button btnFilterScholarship;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}
