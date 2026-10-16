using System;
using System.Collections.Generic;

namespace Lab5_Exercises
{
    /// <summary>
    /// Bài 2: Đa thức bậc n tại giá trị x.
    /// Hệ số a_i (0 <= i <= n) ứng với x^i.
    /// Nếu không đủ n + 1 hệ số hoặc n âm thì ném ArgumentException("Invalid Data").
    /// </summary>
    public class Polynomial
    {
        private int n;
        private List<int> a;

        public int Degree => n;
        public IReadOnlyList<int> Coefficients => a.AsReadOnly();

        public Polynomial(int n, List<int> a)
        {
            if (n < 0 || a == null || a.Count != n + 1)
                throw new ArgumentException("Invalid Data");

            this.n = n;
            this.a = new List<int>(a);
        }

        public int Cal(double x)
        {
            int result = 0;
            for (int i = 0; i <= this.n; i++)
            {
                result += (int)(a[i] * Math.Pow(x, i));
            }
            return result;
        }
    }
}
