using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5_Exercises;
using System;

namespace Lab5_ExercisesTester
{
    [TestClass]
    public class Bai1_PowerTest
    {
        private const double Delta = 1e-9;

        #region Kiểm thử hàm Power chuẩn theo đặc tả toán học

        [TestMethod]
        public void TestPower_ExponentZero_ReturnsOne()
        {
            // x^0 = 1 với mọi x
            Assert.AreEqual(1.0, Bai1_Power.Power(2.0, 0), Delta);
            Assert.AreEqual(1.0, Bai1_Power.Power(-5.5, 0), Delta);
            Assert.AreEqual(1.0, Bai1_Power.Power(0.0, 0), Delta);
            Assert.AreEqual(1.0, Bai1_Power.Power(100.0, 0), Delta);
        }

        [TestMethod]
        public void TestPower_PositiveExponent_CalculatesCorrectly()
        {
            // 2^3 = 8
            Assert.AreEqual(8.0, Bai1_Power.Power(2.0, 3), Delta);

            // (-2)^3 = -8 (số âm mũ lẻ)
            Assert.AreEqual(-8.0, Bai1_Power.Power(-2.0, 3), Delta);

            // (-2)^4 = 16 (số âm mũ chẵn)
            Assert.AreEqual(16.0, Bai1_Power.Power(-2.0, 4), Delta);

            // Số thực: 1.5^2 = 2.25
            Assert.AreEqual(2.25, Bai1_Power.Power(1.5, 2), Delta);

            // 10^1 = 10
            Assert.AreEqual(10.0, Bai1_Power.Power(10.0, 1), Delta);
        }

        [TestMethod]
        public void TestPower_NegativeExponent_CalculatesCorrectly()
        {
            // 2^(-1) = 0.5
            Assert.AreEqual(0.5, Bai1_Power.Power(2.0, -1), Delta);

            // 2^(-2) = 0.25
            Assert.AreEqual(0.25, Bai1_Power.Power(2.0, -2), Delta);

            // (-2)^(-3) = -0.125
            Assert.AreEqual(-0.125, Bai1_Power.Power(-2.0, -3), Delta);

            // 4^(-2) = 0.0625
            Assert.AreEqual(0.0625, Bai1_Power.Power(4.0, -2), Delta);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestPower_ZeroBaseNegativeExponent_ThrowsDivideByZeroException()
        {
            // 0^(-1) = 1/0 -> phải ném ngoại lệ DivideByZeroException
            Bai1_Power.Power(0.0, -1);
        }

        #endregion

        #region Kiểm thử phát hiện lỗi trong đoạn code in tại PDF (Defect Testing)

        [TestMethod]
        public void TestPower_DetectPdfBug_OriginalCodeFailsSpecification()
        {
            // Trong đề PDF có dòng: 'return n * Power(x, n - 1)' (thay vì x * Power)
            // Khi tính 2^3:
            // Hàm chuẩn ra 8.0
            double expectedCorrect = 8.0;
            double actualStandard = Bai1_Power.Power(2.0, 3);
            Assert.AreEqual(expectedCorrect, actualStandard, Delta);

            // Đoạn code gốc trong đề PDF tính: 3 * 2 * 1 = 6 (tính ra giai thừa thay vì lũy thừa)
            double actualPdfCode = Bai1_Power.Power_OriginalFromPdf(2.0, 3);
            Assert.AreNotEqual(expectedCorrect, actualPdfCode, "Phát hiện lỗi: code gốc trong PDF trả về sai kết quả so với đặc tả x^n.");
        }

        #endregion
    }
}
