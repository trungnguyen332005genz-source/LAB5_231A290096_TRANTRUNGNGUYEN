using System;

namespace Lab5_Exercises
{
    /// <summary>
    /// Lớp Diem trong không gian 2D với hoành độ (X) và tung độ (Y).
    /// </summary>
    public class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Diem(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    /// <summary>
    /// Lớp HinhChuNhat xác định bởi điểm trên bên trái (TopLeft) và điểm dưới bên phải (BottomRight).
    /// </summary>
    public class HinhChuNhat
    {
        public Diem TopLeft { get; set; }
        public Diem BottomRight { get; set; }

        public HinhChuNhat(Diem topLeft, Diem bottomRight)
        {
            if (topLeft == null || bottomRight == null)
                throw new ArgumentNullException("Tọa độ điểm không được để trống.");

            // Kiểm tra tính hợp lệ: điểm trên bên trái phải có X <= X_phải và Y >= Y_dưới
            if (topLeft.X > bottomRight.X || topLeft.Y < bottomRight.Y)
                throw new ArgumentException("Điểm trên bên trái (TopLeft) phải có X <= BottomRight.X và Y >= BottomRight.Y.");

            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        /// <summary>
        /// Tính diện tích hình chữ nhật: Chiều rộng * Chiều cao
        /// </summary>
        public double TinhDienTich()
        {
            double chieuRong = BottomRight.X - TopLeft.X;
            double chieuCao = TopLeft.Y - BottomRight.Y;
            return chieuRong * chieuCao;
        }

        /// <summary>
        /// Kiểm tra hai hình chữ nhật có giao nhau hay không.
        /// </summary>
        /// <param name="other">Hình chữ nhật cần kiểm tra</param>
        /// <param name="tiepXucLaGiao">Quy ước nếu chạm mép/đỉnh có tính là giao hay không (mặc định true)</param>
        public bool KiemTraGiaoNhau(HinhChuNhat other, bool tiepXucLaGiao = true)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            if (tiepXucLaGiao)
            {
                // Không giao nhau nếu 1 hình hoàn toàn nằm ngoài hình kia (nghiêm ngặt)
                if (this.BottomRight.X < other.TopLeft.X || other.BottomRight.X < this.TopLeft.X)
                    return false;
                if (this.BottomRight.Y > other.TopLeft.Y || other.BottomRight.Y > this.TopLeft.Y)
                    return false;
                return true;
            }
            else
            {
                // Không tính tiếp xúc biên
                if (this.BottomRight.X <= other.TopLeft.X || other.BottomRight.X <= this.TopLeft.X)
                    return false;
                if (this.BottomRight.Y >= other.TopLeft.Y || other.BottomRight.Y >= this.TopLeft.Y)
                    return false;
                return true;
            }
        }
    }
}
