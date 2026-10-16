using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5_Exercises;
using System;
using System.Collections.Generic;

namespace Lab5_ExercisesTester
{
    [TestClass]
    public class Bai5_StudentManagementTest
    {
        private const double Delta = 1e-2;

        #region Kiểm thử khởi tạo học viên và ngoại lệ dữ liệu

        [TestMethod]
        public void TestHocVien_ValidInfo_CreatesInstance()
        {
            HocVien hv = new HocVien("HV01", "Trần Trung Nguyên", "TP.HCM", 8.5, 8.0, 9.0);
            Assert.AreEqual("HV01", hv.MaSo);
            Assert.AreEqual("Trần Trung Nguyên", hv.HoTen);
            Assert.AreEqual("TP.HCM", hv.QueQuan);
            Assert.AreEqual(8.5, hv.DiemMon1);
            Assert.AreEqual(8.0, hv.DiemMon2);
            Assert.AreEqual(9.0, hv.DiemMon3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHocVien_EmptyMaSo_ThrowsArgumentException()
        {
            new HocVien("", "Nguyễn Văn A", "Đồng Nai", 8.0, 8.0, 8.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHocVien_NegativeScore_ThrowsArgumentOutOfRangeException()
        {
            new HocVien("HV02", "Lê Văn B", "Hà Nội", -1.0, 8.0, 8.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHocVien_ScoreGreaterThanTen_ThrowsArgumentOutOfRangeException()
        {
            new HocVien("HV03", "Trần Thị C", "Cần Thơ", 10.5, 8.0, 8.0);
        }

        #endregion

        #region Kiểm thử tính điểm trung bình

        [TestMethod]
        public void TestTinhDiemTrungBinh_CalculatesCorrectAverage()
        {
            HocVien hv = new HocVien("HV01", "Trần Trung Nguyên", "TP.HCM", 8.0, 8.5, 9.0);
            // (8.0 + 8.5 + 9.0) / 3 = 8.5
            Assert.AreEqual(8.5, hv.TinhDiemTrungBinh(), Delta);
        }

        #endregion

        #region Kiểm thử xét học bổng (ĐTB >= 8.0 và không môn nào < 5.0)

        [TestMethod]
        public void TestXetHocBong_EligibleStudent_ReturnsTrue()
        {
            // ĐTB = 8.5 >= 8.0, các môn >= 5 -> ĐẠT
            HocVien hv = new HocVien("HV01", "Nguyễn Văn A", "Bình Dương", 8.5, 8.5, 8.5);
            Assert.IsTrue(hv.XetHocBong());
        }

        [TestMethod]
        public void TestXetHocBong_BoundaryEligible_AverageExactlyEight_ReturnsTrue()
        {
            // Điểm biên: ĐTB đúng bằng 8.0, không môn nào < 5 -> ĐẠT
            HocVien hv = new HocVien("HV02", "Lê Văn B", "Long An", 8.0, 8.0, 8.0);
            Assert.IsTrue(hv.XetHocBong());
        }

        [TestMethod]
        public void TestXetHocBong_BoundaryEligible_SubjectScoreExactlyFive_ReturnsTrue()
        {
            // Điểm biên: Có môn đúng bằng 5.0 (không phải dưới 5.0) và ĐTB = (10 + 9 + 5)/3 = 8.0 -> ĐẠT
            HocVien hv = new HocVien("HV03", "Phạm Văn C", "Tiền Giang", 10.0, 9.0, 5.0);
            Assert.IsTrue(hv.XetHocBong());
        }

        [TestMethod]
        public void TestXetHocBong_SubjectScoreUnderFive_ReturnsFalse()
        {
            // ĐTB rất cao (10 + 10 + 4.9)/3 = 8.3 >= 8.0 nhưng môn 3 = 4.9 (< 5.0) -> KHÔNG ĐẠT
            HocVien hv = new HocVien("HV04", "Hoàng Văn D", "Vũng Tàu", 10.0, 10.0, 4.9);
            Assert.IsFalse(hv.XetHocBong());
        }

        [TestMethod]
        public void TestXetHocBong_AverageUnderEight_ReturnsFalse()
        {
            // Không môn nào < 5, nhưng ĐTB = (7.8 + 7.8 + 7.8)/3 = 7.8 (< 8.0) -> KHÔNG ĐẠT
            HocVien hv = new HocVien("HV05", "Đỗ Thị E", "Bến Tre", 7.8, 7.8, 7.8);
            Assert.IsFalse(hv.XetHocBong());
        }

        [TestMethod]
        public void TestXetHocBong_BothConditionsFail_ReturnsFalse()
        {
            // Cả 2 điều kiện đều hỏng
            HocVien hv = new HocVien("HV06", "Vũ Văn F", "Tây Ninh", 4.0, 4.0, 4.0);
            Assert.IsFalse(hv.XetHocBong());
        }

        #endregion

        #region Kiểm thử lớp quản lý học viên QuanLyHocVien

        [TestMethod]
        public void TestQuanLyHocVien_EmptyList_ReturnsEmptyScholarshipList()
        {
            QuanLyHocVien ql = new QuanLyHocVien();
            var danhSachHB = ql.LayDanhSachHocBong();
            Assert.AreEqual(0, danhSachHB.Count);
        }

        [TestMethod]
        public void TestQuanLyHocVien_AddStudentAndFilterScholarship()
        {
            QuanLyHocVien ql = new QuanLyHocVien();

            HocVien hv1 = new HocVien("HV01", "Nguyễn Văn A", "TP.HCM", 8.5, 9.0, 8.0); // Đạt: ĐTB = 8.5
            HocVien hv2 = new HocVien("HV02", "Trần Thị B", "Đồng Nai", 7.0, 8.0, 7.5); // Không đạt: ĐTB = 7.5 < 8.0
            HocVien hv3 = new HocVien("HV03", "Lê Văn C", "Long An", 10.0, 10.0, 4.5);  // Không đạt: có môn < 5
            HocVien hv4 = new HocVien("HV04", "Phạm Thị D", "Bình Dương", 9.0, 8.5, 8.5); // Đạt: ĐTB = 8.67

            ql.ThemHocVien(hv1);
            ql.ThemHocVien(hv2);
            ql.ThemHocVien(hv3);
            ql.ThemHocVien(hv4);

            Assert.AreEqual(4, ql.DanhSach.Count);

            List<HocVien> dsHocBong = ql.LayDanhSachHocBong();
            Assert.AreEqual(2, dsHocBong.Count);
            Assert.IsTrue(dsHocBong.Exists(hv => hv.MaSo == "HV01"));
            Assert.IsTrue(dsHocBong.Exists(hv => hv.MaSo == "HV04"));
            Assert.IsFalse(dsHocBong.Exists(hv => hv.MaSo == "HV02"));
            Assert.IsFalse(dsHocBong.Exists(hv => hv.MaSo == "HV03"));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestQuanLyHocVien_DuplicateMaSo_ThrowsInvalidOperationException()
        {
            QuanLyHocVien ql = new QuanLyHocVien();
            ql.ThemHocVien(new HocVien("HV01", "Nguyễn Văn A", "TP.HCM", 8.0, 8.0, 8.0));
            ql.ThemHocVien(new HocVien("HV01", "Nguyễn Văn B", "Cần Thơ", 9.0, 9.0, 9.0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestQuanLyHocVien_AddNullStudent_ThrowsArgumentNullException()
        {
            QuanLyHocVien ql = new QuanLyHocVien();
            ql.ThemHocVien(null!);
        }

        #endregion
    }
}
