using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5_Exercises;
using System;

namespace Lab5_ExercisesTester
{
    [TestClass]
    public class Bai4_GeometryTest
    {
        private const double Delta = 1e-9;

        #region Kiểm thử khởi tạo và ngoại lệ

        [TestMethod]
        public void TestHinhChuNhat_ValidCoordinates_CreatesInstance()
        {
            Diem tl = new Diem(1.0, 5.0);
            Diem br = new Diem(6.0, 1.0);
            HinhChuNhat hcn = new HinhChuNhat(tl, br);

            Assert.IsNotNull(hcn);
            Assert.AreEqual(1.0, hcn.TopLeft.X);
            Assert.AreEqual(5.0, hcn.TopLeft.Y);
            Assert.AreEqual(6.0, hcn.BottomRight.X);
            Assert.AreEqual(1.0, hcn.BottomRight.Y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHinhChuNhat_InvalidXOrder_ThrowsArgumentException()
        {
            // TopLeft.X (10) > BottomRight.X (5) -> lỗi
            Diem tl = new Diem(10.0, 5.0);
            Diem br = new Diem(5.0, 1.0);
            new HinhChuNhat(tl, br);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHinhChuNhat_InvalidYOrder_ThrowsArgumentException()
        {
            // TopLeft.Y (1) < BottomRight.Y (5) -> lỗi vì Top phải có Y lớn hơn Bottom
            Diem tl = new Diem(1.0, 1.0);
            Diem br = new Diem(5.0, 5.0);
            new HinhChuNhat(tl, br);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestHinhChuNhat_NullPoints_ThrowsArgumentNullException()
        {
            new HinhChuNhat(null!, new Diem(1.0, 1.0));
        }

        #endregion

        #region Kiểm thử tính diện tích

        [TestMethod]
        public void TestTinhDienTich_StandardRectangle()
        {
            // TopLeft (0, 5), BottomRight (4, 0) -> Rộng = 4, Cao = 5 -> Diện tích = 20
            HinhChuNhat hcn = new HinhChuNhat(new Diem(0, 5), new Diem(4, 0));
            Assert.AreEqual(20.0, hcn.TinhDienTich(), Delta);
        }

        [TestMethod]
        public void TestTinhDienTich_Square()
        {
            // TopLeft (1, 4), BottomRight (4, 1) -> Rộng = 3, Cao = 3 -> Diện tích = 9
            HinhChuNhat hcn = new HinhChuNhat(new Diem(1, 4), new Diem(4, 1));
            Assert.AreEqual(9.0, hcn.TinhDienTich(), Delta);
        }

        [TestMethod]
        public void TestTinhDienTich_NegativeCoordinates()
        {
            // TopLeft (-5, 2), BottomRight (-1, -3) -> Rộng = 4, Cao = 5 -> Diện tích = 20
            HinhChuNhat hcn = new HinhChuNhat(new Diem(-5, 2), new Diem(-1, -3));
            Assert.AreEqual(20.0, hcn.TinhDienTich(), Delta);
        }

        #endregion

        #region Kiểm thử kiểm tra hai hình chữ nhật giao nhau

        [TestMethod]
        public void TestKiemTraGiaoNhau_IntersectingPartial()
        {
            // HCN1: (0, 4) đến (4, 0)
            // HCN2: (2, 5) đến (6, 2)
            // Cắt nhau tại phần hình chữ nhật [2, 4] x [2, 4]
            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(0, 4), new Diem(4, 0));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(2, 5), new Diem(6, 2));

            Assert.IsTrue(hcn1.KiemTraGiaoNhau(hcn2));
            Assert.IsTrue(hcn2.KiemTraGiaoNhau(hcn1));
        }

        [TestMethod]
        public void TestKiemTraGiaoNhau_ContainedInside()
        {
            // HCN2 nằm hoàn toàn trong HCN1
            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(0, 10), new Diem(10, 0));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(2, 8), new Diem(8, 2));

            Assert.IsTrue(hcn1.KiemTraGiaoNhau(hcn2));
            Assert.IsTrue(hcn2.KiemTraGiaoNhau(hcn1));
        }

        [TestMethod]
        public void TestKiemTraGiaoNhau_TouchEdge()
        {
            // Tiếp xúc tại cạnh X = 4
            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(0, 4), new Diem(4, 0));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(4, 4), new Diem(8, 0));

            Assert.IsTrue(hcn1.KiemTraGiaoNhau(hcn2, tiepXucLaGiao: true));
            Assert.IsFalse(hcn1.KiemTraGiaoNhau(hcn2, tiepXucLaGiao: false));
        }

        [TestMethod]
        public void TestKiemTraGiaoNhau_TouchCorner()
        {
            // Tiếp xúc tại một đỉnh (4, 0)
            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(0, 4), new Diem(4, 0));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(4, 0), new Diem(8, -4));

            Assert.IsTrue(hcn1.KiemTraGiaoNhau(hcn2, tiepXucLaGiao: true));
            Assert.IsFalse(hcn1.KiemTraGiaoNhau(hcn2, tiepXucLaGiao: false));
        }

        [TestMethod]
        public void TestKiemTraGiaoNhau_SeparateHorizontal_NoIntersection()
        {
            // Rời nhau theo phương ngang
            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(0, 4), new Diem(3, 0));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(5, 4), new Diem(8, 0));

            Assert.IsFalse(hcn1.KiemTraGiaoNhau(hcn2));
            Assert.IsFalse(hcn2.KiemTraGiaoNhau(hcn1));
        }

        [TestMethod]
        public void TestKiemTraGiaoNhau_SeparateVertical_NoIntersection()
        {
            // Rời nhau theo phương đứng
            HinhChuNhat hcn1 = new HinhChuNhat(new Diem(0, 4), new Diem(4, 0));
            HinhChuNhat hcn2 = new HinhChuNhat(new Diem(0, 10), new Diem(4, 6));

            Assert.IsFalse(hcn1.KiemTraGiaoNhau(hcn2));
            Assert.IsFalse(hcn2.KiemTraGiaoNhau(hcn1));
        }

        #endregion
    }
}
