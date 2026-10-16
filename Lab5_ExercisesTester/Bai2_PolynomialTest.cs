using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5_Exercises;
using System;
using System.Collections.Generic;

namespace Lab5_ExercisesTester
{
    [TestClass]
    public class Bai2_PolynomialTest
    {
        #region Kiểm thử các trường hợp ngoại lệ (Exceptions)

        [TestMethod]
        public void TestPolynomial_NegativeDegree_ThrowsArgumentException()
        {
            // n < 0: ném ArgumentException với nội dung "Invalid Data"
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                new Polynomial(-1, new List<int>());
            });
            Assert.AreEqual("Invalid Data", ex.Message);
        }

        [TestMethod]
        public void TestPolynomial_NotEnoughCoefficients_ThrowsArgumentException()
        {
            // n = 2 cần 3 hệ số, nhưng chỉ truyền 2 hệ số
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                new Polynomial(2, new List<int> { 1, 2 });
            });
            Assert.AreEqual("Invalid Data", ex.Message);
        }

        [TestMethod]
        public void TestPolynomial_TooManyCoefficients_ThrowsArgumentException()
        {
            // n = 1 chỉ cần 2 hệ số, nhưng truyền 4 hệ số
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                new Polynomial(1, new List<int> { 1, 2, 3, 4 });
            });
            Assert.AreEqual("Invalid Data", ex.Message);
        }

        [TestMethod]
        public void TestPolynomial_NullCoefficients_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                new Polynomial(2, null!);
            });
            Assert.AreEqual("Invalid Data", ex.Message);
        }

        #endregion

        #region Kiểm thử tính toán giá trị đa thức Cal(x)

        [TestMethod]
        public void TestPolynomial_DegreeZero_CalculatesConstant()
        {
            // P(x) = 7 (n = 0, a0 = 7)
            Polynomial p = new Polynomial(0, new List<int> { 7 });
            Assert.AreEqual(7, p.Cal(0));
            Assert.AreEqual(7, p.Cal(5));
            Assert.AreEqual(7, p.Cal(-3));
        }

        [TestMethod]
        public void TestPolynomial_DegreeOne_CalculatesLinear()
        {
            // P(x) = 2 + 3x (n = 1, a0 = 2, a1 = 3)
            Polynomial p = new Polynomial(1, new List<int> { 2, 3 });
            // P(2) = 2 + 3*2 = 8
            Assert.AreEqual(8, p.Cal(2));
            // P(0) = 2
            Assert.AreEqual(2, p.Cal(0));
            // P(-1) = 2 + 3*(-1) = -1
            Assert.AreEqual(-1, p.Cal(-1));
        }

        [TestMethod]
        public void TestPolynomial_DegreeTwo_CalculatesQuadratic()
        {
            // P(x) = 1 - 2x + 3x^2 (n = 2, a0 = 1, a1 = -2, a2 = 3)
            Polynomial p = new Polynomial(2, new List<int> { 1, -2, 3 });
            // P(2) = 1 - 4 + 12 = 9
            Assert.AreEqual(9, p.Cal(2));
            // P(-2) = 1 - 2*(-2) + 3*(-2)^2 = 1 + 4 + 12 = 17
            Assert.AreEqual(17, p.Cal(-2));
            // P(0) = 1
            Assert.AreEqual(1, p.Cal(0));
        }

        [TestMethod]
        public void TestPolynomial_DegreeThree_CalculatesCubic()
        {
            // P(x) = 5 + 0x + 2x^2 + 1x^3 (n = 3, a = [5, 0, 2, 1])
            Polynomial p = new Polynomial(3, new List<int> { 5, 0, 2, 1 });
            // P(3) = 5 + 0 + 2*(9) + 1*(27) = 5 + 18 + 27 = 50
            Assert.AreEqual(50, p.Cal(3));
        }

        #endregion
    }
}
