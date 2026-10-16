using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.IO;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal = null!;

        public TestContext TestContext { get; set; } = null!;

        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(15, cal.Execute("+"));
        }

        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(5, cal.Execute("-"));
        }

        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(50, cal.Execute("*"));
        }

        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(2, cal.Execute("/"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }

        // Thêm 1 test case kiểm tra làm tròn trong kết quả phép chia (Trang 5-6)
        [TestMethod]
        public void TestDivRound()
        {
            Calculation c = new Calculation(5, 3);
            Assert.AreEqual(2, c.Execute("/"));
        }

        // DATA-DRIVEN UNIT TEST (Trang 8-9)
        // Kiểm thử phép tính cộng với các bộ dữ liệu trong bảng TestData.csv
        [DataTestMethod]
        [DataRow(3, 4, 7)]
        [DataRow(-7, 6, -1)]
        [DataRow(-3, -7, -10)]
        [DataRow(-5, 5, 0)]
        public void TestWithDataSource_DataRows(int a, int b, int expected)
        {
            Calculation c = new Calculation(a, b);
            int actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        // Đọc trực tiếp từ file Data/TestData.csv được Copy to Output Directory
        [TestMethod]
        public void TestWithDataSource_FromCsvFile()
        {
            string csvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TestData.csv");
            Assert.IsTrue(File.Exists(csvPath), $"Tập tin TestData.csv không tồn tại tại: {csvPath}");

            string[] lines = File.ReadAllLines(csvPath);
            // Bỏ qua dòng tiêu đề a,b,expected
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;

                string[] cols = line.Split(',');
                int a = int.Parse(cols[0]);
                int b = int.Parse(cols[1]);
                int expected = int.Parse(cols[2]);

                Calculation c = new Calculation(a, b);
                int actual = c.Execute("+");
                Assert.AreEqual(expected, actual, $"Dòng {i + 1} kiểm tra {a} + {b} = {expected} không khớp!");
            }
        }
    }
}
