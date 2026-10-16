using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lab5_Exercises;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private QuanLyHocVien quanLyHocVien = new QuanLyHocVien();

        public Form1()
        {
            InitializeComponent();
            InitAdditionalControls();
        }

        private void InitAdditionalControls()
        {
            // Nạp danh sách cơ số cho Tab 3 (Radix)
            for (int i = 2; i <= 16; i++)
            {
                string label = i switch
                {
                    2 => "2 (Hệ nhị phân - Binary)",
                    8 => "8 (Hệ bát phân - Octal)",
                    10 => "10 (Hệ thập phân - Decimal)",
                    16 => "16 (Hệ thập lục phân - Hex)",
                    _ => $"{i}"
                };
                cboRadixBase.Items.Add(new { Text = label, Value = i });
            }
            cboRadixBase.DisplayMember = "Text";
            cboRadixBase.ValueMember = "Value";
            cboRadixBase.SelectedIndex = 0; // Mặc định hệ 2

            // Cấu hình bảng hiển thị sinh viên cho Tab 5
            dgvStudents.ColumnCount = 8;
            dgvStudents.Columns[0].Name = "Mã số";
            dgvStudents.Columns[1].Name = "Họ tên";
            dgvStudents.Columns[2].Name = "Quê quán";
            dgvStudents.Columns[3].Name = "Môn 1";
            dgvStudents.Columns[4].Name = "Môn 2";
            dgvStudents.Columns[5].Name = "Môn 3";
            dgvStudents.Columns[6].Name = "Điểm TB";
            dgvStudents.Columns[7].Name = "Học bổng";

            dgvStudents.Columns[0].Width = 75;
            dgvStudents.Columns[1].Width = 140;
            dgvStudents.Columns[2].Width = 100;
            dgvStudents.Columns[3].Width = 65;
            dgvStudents.Columns[4].Width = 65;
            dgvStudents.Columns[5].Width = 65;
            dgvStudents.Columns[6].Width = 75;
            dgvStudents.Columns[7].Width = 100;
        }

        #region TAB 1: CALCULATOR
        private void btnCong_Click(object sender, EventArgs e) => this.Cal("+");
        private void btnTru_Click(object sender, EventArgs e) => this.Cal("-");
        private void btnNhan_Click(object sender, EventArgs e) => this.Cal("*");
        private void btnChia_Click(object sender, EventArgs e) => this.Cal("/");

        private void Cal(string op)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSo1.Text) || string.IsNullOrWhiteSpace(txtSo2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ hai số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                Calculation c = new Calculation(a, b);
                txtKetQua.Text = c.Execute(op).ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi chia cho 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKetQua.Text = "Lỗi chia cho 0";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TAB 2: BÀI 1 - LŨY THỪA POWER
        private void btnCalcPower_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtPowerX.Text.Trim());
                int n = int.Parse(txtPowerN.Text.Trim());

                double result = Bai1_Power.Power(x, n);
                txtPowerResult.Text = $"=== KẾT QUẢ TÍNH TOÁN THEO ĐẶC TẢ TOÁN HỌC ===" + Environment.NewLine +
                                      $"Lũy thừa ({x})^{n} = {result}" + Environment.NewLine + Environment.NewLine +
                                      $"Giải thích công thức đệ quy áp dụng:" + Environment.NewLine +
                                      (n == 0 ? "• n = 0 => Kết quả luôn là 1.0" :
                                       n > 0  ? $"• n > 0 => Áp dụng x^(n-1) * x = {result}" :
                                                $"• n < 0 => Áp dụng x^(n+1) / x = {result}");
            }
            catch (DivideByZeroException ex)
            {
                txtPowerResult.Text = $"LỖI: {ex.Message}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nhập liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComparePowerBug_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtPowerX.Text.Trim());
                int n = int.Parse(txtPowerN.Text.Trim());

                double correctVal = Bai1_Power.Power(x, n);
                double pdfCodeVal = Bai1_Power.Power_OriginalFromPdf(x, n);

                bool isSame = Math.Abs(correctVal - pdfCodeVal) < 1e-9;

                txtPowerResult.Text = $"=== SO SÁNH GIỮA CODE CHUẨN VÀ CODE MẪU IN TRONG ĐỀ PDF ===" + Environment.NewLine +
                                      $"Tham số kiểm thử: x = {x}, n = {n}" + Environment.NewLine +
                                      $"1. Kết quả theo hàm chuẩn (x * Power(x, n-1)):  {correctVal}" + Environment.NewLine +
                                      $"2. Kết quả theo code mẫu PDF (n * Power(x, n-1)): {pdfCodeVal}" + Environment.NewLine + Environment.NewLine +
                                      (isSame ? "==> Hai kết quả trùng nhau trong trường hợp này (thường khi n <= 1)." :
                                                "==> PHÁT HIỆN LỖI (DEFECT) TRONG CODE ĐỀ BÀI:" + Environment.NewLine +
                                                "• Công thức ghi: x^n = x^(n-1) * x (nhân với cơ số x)" + Environment.NewLine +
                                                "• Đoạn code trong PDF lại gõ nhầm: 'return n * Power(x, n - 1)' (nhân với số mũ n, biến thành giai thừa!)" + Environment.NewLine +
                                                "• Bộ Unit Test đã bắt chính xác lỗi này!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TAB 3: BÀI 2 - ĐA THỨC POLYNOMIAL
        private void btnCalcPoly_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtPolyN.Text.Trim());
                string[] parts = txtPolyA.Text.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> a = parts.Select(int.Parse).ToList();
                double x = double.Parse(txtPolyX.Text.Trim());

                Polynomial p = new Polynomial(n, a);
                int result = p.Cal(x);

                string polyString = "P(x) = ";
                for (int i = 0; i <= n; i++)
                {
                    if (i == 0) polyString += $"{a[i]}";
                    else polyString += $" + ({a[i]} * x^{i})";
                }

                txtPolyResult.Text = $"=== TÍNH GIÁ TRỊ ĐA THỨC ===" + Environment.NewLine +
                                     $"{polyString}" + Environment.NewLine +
                                     $"Với x = {x}" + Environment.NewLine +
                                     $"Giá trị tính được: P({x}) = {result}";
            }
            catch (ArgumentException ex)
            {
                txtPolyResult.Text = $"NGOẠI LỆ ĐẶC TẢ: {ex.Message}" + Environment.NewLine +
                                     "(Đề bài yêu cầu: Nếu nhập không đủ n+1 hệ số hoặc n âm thì ném ArgumentException với nội dung 'Invalid Data')";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region TAB 4: BÀI 3 - ĐỔI CƠ SỐ RADIX
        private void btnConvertRadix_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtRadixNum.Text.Trim());
                int radix = cboRadixBase.SelectedIndex >= 0 ? cboRadixBase.SelectedIndex + 2 : 2;

                Radix r = new Radix(number);
                string converted = r.ConvertDecimalToAnother(radix);

                txtRadixResult.Text = converted;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ngoại lệ: {ex.Message}", "Lỗi tham số", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadixResult.Text = $"Lỗi: {ex.Message}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region TAB 5: BÀI 4 - HÌNH CHỮ NHẬT GEOMETRY
        private void btnCalcArea_Click(object sender, EventArgs e)
        {
            try
            {
                var (hcn1, hcn2) = ParseRectangles();

                double s1 = hcn1.TinhDienTich();
                double s2 = hcn2.TinhDienTich();

                txtGeomResult.Text = $"=== DIỆN TÍCH HÌNH CHỮ NHẬT ===" + Environment.NewLine +
                                     $"• HCN 1: Rộng = {hcn1.BottomRight.X - hcn1.TopLeft.X}, Cao = {hcn1.TopLeft.Y - hcn1.BottomRight.Y} => Diện tích = {s1}" + Environment.NewLine +
                                     $"• HCN 2: Rộng = {hcn2.BottomRight.X - hcn2.TopLeft.X}, Cao = {hcn2.TopLeft.Y - hcn2.BottomRight.Y} => Diện tích = {s2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCheckIntersect_Click(object sender, EventArgs e)
        {
            try
            {
                var (hcn1, hcn2) = ParseRectangles();

                bool intersect = hcn1.KiemTraGiaoNhau(hcn2);

                txtGeomResult.Text = $"=== KIỂM TRA GIAO NHAU CỦA 2 HÌNH CHỮ NHẬT ===" + Environment.NewLine +
                                     $"• HCN 1: TopLeft({hcn1.TopLeft.X}, {hcn1.TopLeft.Y}) -> BottomRight({hcn1.BottomRight.X}, {hcn1.BottomRight.Y})" + Environment.NewLine +
                                     $"• HCN 2: TopLeft({hcn2.TopLeft.X}, {hcn2.TopLeft.Y}) -> BottomRight({hcn2.BottomRight.X}, {hcn2.BottomRight.Y})" + Environment.NewLine + Environment.NewLine +
                                     (intersect ? "==> KẾT LUẬN: HAI HÌNH CHỮ NHẬT CÓ GIAO NHAU (INTERSECT = TRUE)" :
                                                  "==> KẾT LUẬN: HAI HÌNH CHỮ NHẬT KHÔNG GIAO NHAU (INTERSECT = FALSE)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private (HinhChuNhat, HinhChuNhat) ParseRectangles()
        {
            double r1tlx = double.Parse(txtR1TLX.Text.Trim());
            double r1tly = double.Parse(txtR1TLY.Text.Trim());
            double r1brx = double.Parse(txtR1BRX.Text.Trim());
            double r1bry = double.Parse(txtR1BRY.Text.Trim());

            double r2tlx = double.Parse(txtR2TLX.Text.Trim());
            double r2tly = double.Parse(txtR2TLY.Text.Trim());
            double r2brx = double.Parse(txtR2BRX.Text.Trim());
            double r2bry = double.Parse(txtR2BRY.Text.Trim());

            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(r1tlx, r1tly), new Diem(r1brx, r1bry));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(r2tlx, r2tly), new Diem(r2brx, r2bry));

            return (hcn1, hcn2);
        }
        #endregion

        #region TAB 6: BÀI 5 - QUẢN LÝ HỌC VIÊN
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string maSo = txtMaSo.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string queQuan = txtQueQuan.Text.Trim();

                double m1 = double.Parse(txtM1.Text.Trim());
                double m2 = double.Parse(txtM2.Text.Trim());
                double m3 = double.Parse(txtM3.Text.Trim());

                HocVien hv = new HocVien(maSo, hoTen, queQuan, m1, m2, m3);
                quanLyHocVien.ThemHocVien(hv);

                HienThiDanhSachHocVien();

                txtMaSo.Clear();
                txtHoTen.Clear();
                txtQueQuan.Clear();
                txtM1.Clear();
                txtM2.Clear();
                txtM3.Clear();
                txtMaSo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadSample_Click(object sender, EventArgs e)
        {
            quanLyHocVien = new QuanLyHocVien();
            quanLyHocVien.ThemHocVien(new HocVien("HV01", "Trần Trung Nguyên", "TP.HCM", 8.5, 9.0, 8.5)); // Đạt HB (ĐTB = 8.67)
            quanLyHocVien.ThemHocVien(new HocVien("HV02", "Lê Văn Hùng", "Hà Nội", 7.5, 8.0, 7.5));       // Rớt HB (ĐTB = 7.67 < 8.0)
            quanLyHocVien.ThemHocVien(new HocVien("HV03", "Nguyễn Thị Mai", "Đà Nẵng", 10.0, 9.5, 4.5));   // Rớt HB (có môn 4.5 < 5.0)
            quanLyHocVien.ThemHocVien(new HocVien("HV04", "Phạm Quốc Tuấn", "Cần Thơ", 8.0, 8.0, 8.0));   // Đạt HB (Điểm biên ĐTB = 8.0)
            quanLyHocVien.ThemHocVien(new HocVien("HV05", "Vũ Minh Tâm", "Hải Phòng", 10.0, 9.0, 5.0));   // Đạt HB (Môn biên 5.0, ĐTB = 8.0)

            HienThiDanhSachHocVien();
            MessageBox.Show("Đã nạp thành công 5 học viên mẫu đại diện cho mọi trường hợp kiểm thử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilterScholarship_Click(object sender, EventArgs e)
        {
            var dsHocBong = quanLyHocVien.LayDanhSachHocBong();
            dgvStudents.Rows.Clear();

            foreach (var hv in dsHocBong)
            {
                int index = dgvStudents.Rows.Add(
                    hv.MaSo,
                    hv.HoTen,
                    hv.QueQuan,
                    hv.DiemMon1,
                    hv.DiemMon2,
                    hv.DiemMon3,
                    hv.TinhDiemTrungBinh(),
                    "ĐẠT HỌC BỔNG"
                );
                dgvStudents.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                dgvStudents.Rows[index].DefaultCellStyle.Font = new Font(dgvStudents.Font, FontStyle.Bold);
            }

            MessageBox.Show($"Tìm thấy {dsHocBong.Count} học viên đủ điều kiện nhận học bổng khuyến khích!", "Kết quả xét học bổng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HienThiDanhSachHocVien()
        {
            dgvStudents.Rows.Clear();
            foreach (var hv in quanLyHocVien.DanhSach)
            {
                bool datHB = hv.XetHocBong();
                int index = dgvStudents.Rows.Add(
                    hv.MaSo,
                    hv.HoTen,
                    hv.QueQuan,
                    hv.DiemMon1,
                    hv.DiemMon2,
                    hv.DiemMon3,
                    hv.TinhDiemTrungBinh(),
                    datHB ? "Đạt" : "Không đạt"
                );

                if (datHB)
                {
                    dgvStudents.Rows[index].Cells[7].Style.ForeColor = Color.DarkGreen;
                    dgvStudents.Rows[index].Cells[7].Style.Font = new Font(dgvStudents.Font, FontStyle.Bold);
                }
                else
                {
                    dgvStudents.Rows[index].Cells[7].Style.ForeColor = Color.Red;
                }
            }
        }
        #endregion
    }
}
