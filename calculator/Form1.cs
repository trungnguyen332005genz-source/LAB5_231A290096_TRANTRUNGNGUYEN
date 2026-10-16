using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            this.Cal("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            this.Cal("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            this.Cal("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            this.Cal("/");
        }

        private void Cal(string op)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSo1.Text) || string.IsNullOrWhiteSpace(txtSo2.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ hai số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                Calculation c = new Calculation(a, b);
                txtKetQua.Text = c.Execute(op).ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi chia cho 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKetQua.Text = "Lỗi chia cho 0";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
