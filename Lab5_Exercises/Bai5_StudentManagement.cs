using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5_Exercises
{
    /// <summary>
    /// Lớp biểu diễn thông tin học viên.
    /// Gồm: mã số học viên, họ tên, quê quán, điểm 3 môn học chính.
    /// </summary>
    public class HocVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public double DiemMon1 { get; set; }
        public double DiemMon2 { get; set; }
        public double DiemMon3 { get; set; }

        public HocVien(string maSo, string hoTen, string queQuan, double diemMon1, double diemMon2, double diemMon3)
        {
            if (string.IsNullOrWhiteSpace(maSo))
                throw new ArgumentException("Mã số học viên không được để trống.", nameof(maSo));

            if (diemMon1 < 0 || diemMon1 > 10 || diemMon2 < 0 || diemMon2 > 10 || diemMon3 < 0 || diemMon3 > 10)
                throw new ArgumentOutOfRangeException("Điểm của các môn học phải nằm trong thang điểm từ 0.0 đến 10.0.");

            this.MaSo = maSo;
            this.HoTen = hoTen ?? string.Empty;
            this.QueQuan = queQuan ?? string.Empty;
            this.DiemMon1 = diemMon1;
            this.DiemMon2 = diemMon2;
            this.DiemMon3 = diemMon3;
        }

        /// <summary>
        /// Tính điểm trung bình của ba môn học chính (làm tròn 2 chữ số thập phân).
        /// </summary>
        public double TinhDiemTrungBinh()
        {
            return Math.Round((DiemMon1 + DiemMon2 + DiemMon3) / 3.0, 2);
        }

        /// <summary>
        /// Đánh giá điều kiện nhận học bổng:
        /// Điểm trung bình ba môn chính từ 8.0 trở lên và không có môn nào trong ba môn chính điểm dưới 5.
        /// </summary>
        public bool XetHocBong()
        {
            double dtb = (DiemMon1 + DiemMon2 + DiemMon3) / 3.0;
            // Chuẩn làm tròn 2 chữ số hoặc so sánh trực tiếp
            return Math.Round(dtb, 2) >= 8.0 && DiemMon1 >= 5.0 && DiemMon2 >= 5.0 && DiemMon3 >= 5.0;
        }
    }

    /// <summary>
    /// Lớp quản lý trung tâm gia sư: danh sách học viên và xét học bổng.
    /// </summary>
    public class QuanLyHocVien
    {
        private List<HocVien> danhSach = new List<HocVien>();

        public IReadOnlyList<HocVien> DanhSach => danhSach.AsReadOnly();

        public void ThemHocVien(HocVien hv)
        {
            if (hv == null)
                throw new ArgumentNullException(nameof(hv), "Học viên không được null.");

            if (danhSach.Any(x => x.MaSo.Equals(hv.MaSo, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException($"Học viên với mã số '{hv.MaSo}' đã tồn tại trong danh sách.");

            danhSach.Add(hv);
        }

        /// <summary>
        /// Xác định và trả về danh sách các học viên thỏa mãn điều kiện nhận học bổng khuyến khích.
        /// </summary>
        public List<HocVien> LayDanhSachHocBong()
        {
            return danhSach.Where(hv => hv.XetHocBong()).ToList();
        }
    }
}
