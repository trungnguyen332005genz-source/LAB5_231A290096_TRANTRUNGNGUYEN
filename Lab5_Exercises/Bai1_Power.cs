using System;

namespace Lab5_Exercises
{
    /// <summary>
    /// Bài 1: Tính lũy thừa x^n bằng đệ quy (x là số thực, n là số nguyên bất kỳ)
    /// Đặc tả:
    /// x^n = 1                      nếu n = 0
    /// x^n = x^(n-1) * x            nếu n > 0
    /// x^n = x^(n+1) / x            nếu n < 0
    /// </summary>
    public static class Bai1_Power
    {
        /// <summary>
        /// Hàm tính x^n đệ quy chuẩn theo đúng đặc tả toán học của đề bài.
        /// </summary>
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return x * Power(x, n - 1);
            else
            {
                if (x == 0.0)
                    throw new DivideByZeroException("Không thể tính lũy thừa số mũ âm của 0 (chia cho 0).");
                return Power(x, n + 1) / x;
            }
        }

        /// <summary>
        /// Hàm chép nguyên văn đoạn code in trong đề bài PDF (có bug tại nhánh n > 0: 'n * Power' thay vì 'x * Power').
        /// Dùng để kiểm thử phát hiện lỗi so với đặc tả.
        /// </summary>
        public static double Power_OriginalFromPdf(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power_OriginalFromPdf(x, n - 1);
            else
                return Power_OriginalFromPdf(x, n + 1) / x;
        }
    }
}
