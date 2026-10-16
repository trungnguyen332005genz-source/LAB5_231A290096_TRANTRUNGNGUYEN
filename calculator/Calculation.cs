using System;

namespace Calculator
{
    public class Calculation
    {
        private int a;
        private int b;

        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Execute(string CalSymbol)
        {
            int result = 0;
            switch (CalSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    if (this.b == 0)
                        throw new DivideByZeroException("Không thể chia cho số 0.");
                    // Theo yêu cầu trang 1 và test case TestDivRound trang 5-6:
                    // Phép chia yêu cầu kết quả phải làm tròn về số nguyên gần nhất (ví dụ 1.2 -> 1, 1.5 -> 2, 5/3 -> 2)
                    result = (int)Math.Round((double)this.a / this.b, MidpointRounding.AwayFromZero);
                    break;
                default:
                    throw new NotSupportedException($"Toán tử '{CalSymbol}' không được hỗ trợ.");
            }
            return result;
        }
    }
}
