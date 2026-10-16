using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5_Exercises;
using System;

namespace Lab5_ExercisesTester
{
    [TestClass]
    public class Bai3_RadixTest
    {
        #region Kiểm thử ngoại lệ (Exceptions)

        [TestMethod]
        public void TestRadix_NegativeNumber_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                new Radix(-5);
            });
            Assert.AreEqual("Incorrect Value", ex.Message);
        }

        [TestMethod]
        public void TestRadix_RadixLessThan2_ThrowsArgumentException()
        {
            Radix r = new Radix(10);
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                r.ConvertDecimalToAnother(1);
            });
            Assert.AreEqual("Invalid Radix", ex.Message);
        }

        [TestMethod]
        public void TestRadix_RadixGreaterThan16_ThrowsArgumentException()
        {
            Radix r = new Radix(10);
            var ex = Assert.ThrowsException<ArgumentException>(() =>
            {
                r.ConvertDecimalToAnother(17);
            });
            Assert.AreEqual("Invalid Radix", ex.Message);
        }

        #endregion

        #region Kiểm thử chuyển đổi cơ số (Base Conversion)

        [TestMethod]
        public void TestRadix_ZeroValue_ReturnsZero()
        {
            Radix r = new Radix(0);
            Assert.AreEqual("0", r.ConvertDecimalToAnother(2));
            Assert.AreEqual("0", r.ConvertDecimalToAnother(8));
            Assert.AreEqual("0", r.ConvertDecimalToAnother(16));
        }

        [TestMethod]
        public void TestRadix_DefaultRadix_IsBinary()
        {
            Radix r = new Radix(10);
            // Mặc định radix = 2
            Assert.AreEqual("1010", r.ConvertDecimalToAnother());
        }

        [TestMethod]
        public void TestRadix_BinaryConversion()
        {
            Assert.AreEqual("1", new Radix(1).ConvertDecimalToAnother(2));
            Assert.AreEqual("10", new Radix(2).ConvertDecimalToAnother(2));
            Assert.AreEqual("1010", new Radix(10).ConvertDecimalToAnother(2));
            Assert.AreEqual("1101", new Radix(13).ConvertDecimalToAnother(2));
            Assert.AreEqual("11111111", new Radix(255).ConvertDecimalToAnother(2));
        }

        [TestMethod]
        public void TestRadix_OctalConversion()
        {
            Assert.AreEqual("10", new Radix(8).ConvertDecimalToAnother(8));
            Assert.AreEqual("100", new Radix(64).ConvertDecimalToAnother(8));
            Assert.AreEqual("175", new Radix(125).ConvertDecimalToAnother(8));
        }

        [TestMethod]
        public void TestRadix_HexadecimalConversion()
        {
            Assert.AreEqual("A", new Radix(10).ConvertDecimalToAnother(16));
            Assert.AreEqual("B", new Radix(11).ConvertDecimalToAnother(16));
            Assert.AreEqual("C", new Radix(12).ConvertDecimalToAnother(16));
            Assert.AreEqual("D", new Radix(13).ConvertDecimalToAnother(16));
            Assert.AreEqual("E", new Radix(14).ConvertDecimalToAnother(16));
            Assert.AreEqual("F", new Radix(15).ConvertDecimalToAnother(16));
            Assert.AreEqual("10", new Radix(16).ConvertDecimalToAnother(16));
            Assert.AreEqual("FF", new Radix(255).ConvertDecimalToAnother(16));
            Assert.AreEqual("12C", new Radix(300).ConvertDecimalToAnother(16));
        }

        #endregion
    }
}
