# BÁO CÁO BÀI TẬP THỰC HÀNH LAB 05: KIỂM THỬ ĐƠN VỊ (UNIT TEST VỚI MSTEST & SQL SERVER)

- **Mã số sinh viên:** 231A290096
- **Họ và tên:** TRẦN TRUNG NGUYÊN
- **Môn học:** Kiểm thử phần mềm
- **Môi trường phát triển:** Microsoft Visual Studio 2022 / .NET 8.0 / C#

---

## MỤC LỤC
1. [Tổng quan cấu trúc dự án](#1-tổng-quan-cấu-trúc-dự-án)
2. [Phần 1: Calculator & CalculatorTester](#2-phần-1-calculator--calculatortester)
   - [2.1. Ứng dụng Calculator (Windows Forms C#)](#21-ứng-dụng-calculator-windows-forms-c)
   - [2.2. Lớp Calculation](#22-lớp-calculation)
   - [2.3. Project kiểm thử CalculatorTester](#23-project-kiểm-thử-calculatortester)
   - [2.4. Data-Driven Unit Test (TestData.csv)](#24-data-driven-unit-test-testdatacsv)
3. [Phần 2: SQL Server Unit Test (Trang 10 - 18)](#3-phần-2-sql-server-unit-test-trang-10---18)
   - [3.1. Phân tích 8 loại Assertion Conditions](#31-phân-tích-8-loại-assertion-conditions)
   - [3.2. CSDL mẫu Bookstore & Stored Procedures](#32-csdl-mẫu-bookstore--stored-procedures)
4. [Phần 3: Các bài tập thực hành (Trang 19 - 21)](#4-phần-3-các-bài-tập-thực-hành-trang-19---21)
   - [Bài 1: Lũy thừa x^n bằng đệ quy (Power)](#bài-1-lũy-thừa-xn-bằng-đệ-quy-power)
   - [Bài 2: Tính giá trị đa thức bậc n (Polynomial)](#bài-2-tính-giá-trị-đa-thức-bậc-n-polynomial)
   - [Bài 3: Chuyển đổi cơ số 10 sang cơ số k (Radix)](#bài-3-chuyển-đổi-cơ-số-10-sang-cơ-số-k-radix)
   - [Bài 4: Điểm và Hình Chữ Nhật (Geometry)](#bài-4-điểm-và-hình-chữ-nhật-geometry)
   - [Bài 5: Quản lý học viên & Xét học bổng (Student Management)](#bài-5-quản-lý-học-viên--xét-học-bổng-student-management)
5. [Hướng dẫn mở và chạy kiểm thử trong Visual Studio 2022](#5-hướng-dẫn-mở-và-chạy-kiểm-thử-trong-visual-studio-2022)

---

## 1. Tổng quan cấu trúc dự án

```
E:\Lab 05 Unit Test\
├── LAB05_UNIT_TEST.sln              # Solution chính chứa toàn bộ các dự án
├── Calculator\                       # Dự án Windows Forms C# Calculator
│   ├── Calculation.cs               # Lớp xử lý nghiệp vụ các phép toán (+, -, *, /)
│   ├── Form1.cs                     # Giao diện và sự kiện bấm nút
│   └── Form1.Designer.cs
├── CalculatorTester\                 # Dự án MSTest kiểm thử Calculator
│   ├── UnitTest1.cs                 # Các test case cơ bản và Data-Driven test
│   └── Data\
│       └── TestData.csv             # Bộ dữ liệu kiểm thử (Copy Always to Output)
├── Lab5_Exercises\                   # Class Library chứa 5 bài tập thực hành
│   ├── Bai1_Power.cs                # Bài 1: Tính x^n
│   ├── Bai2_Polynomial.cs           # Bài 2: Đa thức bậc n
│   ├── Bai3_Radix.cs                # Bài 3: Đổi cơ số
│   ├── Bai4_Geometry.cs             # Bài 4: Điểm và Hình chữ nhật
│   └── Bai5_StudentManagement.cs    # Bài 5: Học viên và Xét học bổng
├── Lab5_ExercisesTester\             # Dự án MSTest kiểm thử 5 bài tập thực hành
│   ├── Bai1_PowerTest.cs            # Kiểm thử Bài 1 (bao gồm phát hiện bug code mẫu)
│   ├── Bai2_PolynomialTest.cs       # Kiểm thử Bài 2 (tính toán & ngoại lệ Invalid Data)
│   ├── Bai3_RadixTest.cs            # Kiểm thử Bài 3 (chuyển đổi hệ 2..16 & ngoại lệ)
│   ├── Bai4_GeometryTest.cs         # Kiểm thử Bài 4 (diện tích & giao nhau)
│   └── Bai5_StudentManagementTest.cs# Kiểm thử Bài 5 (học bổng & quản lý học viên)
└── SqlServerUnitTest\
    ├── Bookstore_DbTest.sql         # Script tạo CSDL Bookstore và Stored Procedures
    └── README_SqlUnitTest.md        # Tài liệu phân tích chuyên sâu 8 loại Assertion Conditions
```

---

## 2. Phần 1: Calculator & CalculatorTester

### 2.1. Ứng dụng Calculator (Windows Forms C#)
Giao diện được thiết kế trực quan và thẩm mỹ theo đúng mô tả tại Trang 1 của tài liệu:
- Tiêu đề: **CHƯƠNG TRÌNH TÍNH TOÁN ĐƠN GIẢN**
- GroupBox: **Tính toán đơn giản**
- 2 ô TextBox nhập hai số nguyên: `Số thứ nhất`, `Số thứ hai`
- 1 ô TextBox hiển thị: `Kết quả` (chế độ ReadOnly)
- 4 nút chức năng: `Cộng`, `Trừ`, `Nhân`, `Chia`

### 2.2. Lớp Calculation
- Thuộc tính private `a`, `b` lưu 2 toán hạng nguyên.
- Phương thức `Execute(string CalSymbol)`:
  - Toán tử `+`: thực hiện `a + b`.
  - Toán tử `-`: thực hiện `a - b`.
  - Toán tử `*`: thực hiện `a * b`.
  - Toán tử `/`:
    - Nếu `b == 0`: ném `DivideByZeroException("Không thể chia cho số 0.")`.
    - Làm tròn số nguyên gần nhất: `(int)Math.Round((double)a / b, MidpointRounding.AwayFromZero)`. Đáp ứng yêu cầu đề bài (ví dụ `5 / 3 = 1.666...` làm tròn thành `2`).

### 2.3. Project kiểm thử CalculatorTester
Bao gồm các test case theo tài liệu:
- `TestAddOperator()`: `10 + 5 = 15`.
- `TestSubOperator()`: `10 - 5 = 5`.
- `TestMulOperator()`: `10 * 5 = 50`.
- `TestDivOperator()`: `10 / 5 = 2`.
- `TestDivByZero()`: kiểm tra ném `DivideByZeroException` khi chia cho 0.
- `TestDivRound()`: kiểm tra phép chia có làm tròn `5 / 3 = 2`.

### 2.4. Data-Driven Unit Test (TestData.csv)
Tập tin dữ liệu `Data/TestData.csv`:
```csv
a,b,expected
3,4,7
-7,6,-1
-3,-7,-10
-5,5,0
```
Được kiểm thử bằng 2 phương pháp:
1. `TestWithDataSource_DataRows`: Dùng thuộc tính `[DataTestMethod]` và các `[DataRow]` tương ứng.
2. `TestWithDataSource_FromCsvFile`: Đọc trực tiếp từ file `TestData.csv` được copy ra thư mục thực thi `bin` (như trang 8-9 của tài liệu).

---

## 3. Phần 2: SQL Server Unit Test (Trang 10 - 18)

### 3.1. Phân tích 8 loại Assertion Conditions
Tài liệu hướng dẫn kiểm thử Stored Procedure `dbo.sp_Top3Authors` sử dụng các điều kiện kiểm thử:
1. **Row Count**: Đảm bảo số lượng dòng trả về đúng 3 dòng (`Row Count = 3`).
2. **Data Checksum**: Kiểm tra toàn bộ nội dung dữ liệu trả về thông qua mã băm checksum sinh bởi Visual Studio.
3. **Scalar Value**: Kiểm tra giá trị cụ thể tại một ô (Ví dụ: dòng 1 cột 5 có số điện thoại là `"0984461466"`).
4. **Empty ResultSet**: Kiểm tra tập kết quả trả về phải rỗng.
5. **Not Empty ResultSet**: Kiểm tra tập kết quả trả về không được rỗng.
6. **Execution Time**: Giám sát hiệu năng, fail nếu thời gian chạy vượt ngưỡng cho phép.
7. **Expected Schema**: So khớp cấu trúc cột và kiểu dữ liệu.
8. **Inconclusive**: Đánh dấu trạng thái chưa hoàn thiện bài test.

### 3.2. CSDL mẫu Bookstore & Stored Procedures
Tập tin `SqlServerUnitTest/Bookstore_DbTest.sql` đã hiện thực hóa đầy đủ:
- Bảng: `Author`, `Book`, `Category`, `BookAuthor`.
- Dữ liệu mẫu tác giả khớp ảnh chụp Trang 17:
  - Id 1: Thành Dương - Hậu Giang - `0984461466`
  - Id 2: Lê Nguyên - TP.HCM - `0984461467`
  - Id 3: Nam Võ - Long An - `0984461468`
- Stored Procedures: `dbo.sp_CountAuthors` và `dbo.sp_Top3Authors`.

---

## 4. Phần 3: Các bài tập thực hành (Trang 19 - 21)

### Bài 1: Lũy thừa x^n bằng đệ quy (Power)
- **Đặc tả toán học:**
  - $n = 0 \implies x^0 = 1$
  - $n > 0 \implies x^n = x^{n-1} \times x$
  - $n < 0 \implies x^n = \frac{x^{n+1}}{x}$
- **Phân tích lỗi đoạn mã trong PDF:**
  - Trong khung code mẫu PDF có in: `return n * Power(x, n - 1);` -> Đây là lỗi logic (tính giai thừa thay vì lũy thừa).
  - Dự án đã triển khai hàm chuẩn `Power` theo đúng đặc tả toán học, đồng thời viết test case `TestPower_DetectPdfBug_OriginalCodeFailsSpecification` chứng minh lỗi này theo góc độ kiểm thử phần mềm.
- **Bộ Unit Test:** Kiểm thử số mũ 0, mũ dương, mũ âm, số thực, và ngoại lệ chia cho 0 khi $x = 0, n < 0$.

### Bài 2: Tính giá trị đa thức bậc n (Polynomial)
- **Đặc tả:** Nhập vào $n$ là bậc đa thức và $n+1$ số nguyên $a_i$ ($0 \le i \le n$).
- **Xử lý ngoại lệ:** Nếu không đủ $n+1$ hệ số hoặc $n < 0$, ném ngoại lệ `ArgumentException("Invalid Data")`.
- **Phương thức tính:** $Cal(x) = \sum_{i=0}^n a_i x^i$.
- **Bộ Unit Test:** Kiểm thử ném ngoại lệ khi $n < 0$, thiếu hệ số, thừa hệ số, danh sách null; kiểm thử tính toán cho bậc 0, bậc 1, bậc 2, bậc 3.

### Bài 3: Chuyển đổi cơ số 10 sang cơ số k (Radix)
- **Đặc tả:** Chuyển đổi số nguyên không âm cơ số 10 sang cơ số $k$ ($2 \le k \le 16$).
- **Xử lý ngoại lệ:**
  - $number < 0 \implies$ ném `ArgumentException("Incorrect Value")`.
  - $radix < 2$ hoặc $radix > 16 \implies$ ném `ArgumentException("Invalid Radix")`.
- **Bộ Unit Test:** Kiểm thử số 0, mặc định $k=2$ (nhị phân), hệ bát phân $k=8$, hệ thập lục phân $k=16$ (chuyển đổi chính xác các ký tự A, B, C, D, E, F).

### Bài 4: Điểm và Hình Chữ Nhật (Geometry)
- **Đặc tả:** Lớp `Diem(X, Y)` và lớp `HinhChuNhat(TopLeft, BottomRight)`.
- **Chức năng:**
  1. `TinhDienTich()`: tính diện tích $|X_2 - X_1| \times |Y_1 - Y_2|$.
  2. `KiemTraGiaoNhau()`: kiểm tra 2 hình chữ nhật có giao nhau hay không (bao gồm cắt nhau, lồng nhau, chạm cạnh, chạm đỉnh).
- **Bộ Unit Test:** Kiểm thử tính hợp lệ tọa độ Top-Left và Bottom-Right, tính diện tích hình chữ nhật thường, hình vuông, tọa độ âm; kiểm thử giao nhau trong mọi trường hợp (giao nhau, lồng nhau, tiếp xúc biên, rời nhau ngang, rời nhau dọc).

### Bài 5: Quản lý học viên & Xét học bổng (Student Management)
- **Đặc tả:**
  - Học viên gồm: Mã số, Họ tên, Quê quán, Điểm 3 môn chính.
  - Điểm trung bình: $(Điểm_1 + Điểm_2 + Điểm_3) / 3$.
  - Tiêu chuẩn học bổng: Điểm trung bình $\ge 8.0$ và không có môn nào dưới $5.0$.
- **Lớp quản lý:** `QuanLyHocVien` hỗ trợ thêm học viên, kiểm tra trùng mã số, và phương thức `LayDanhSachHocBong()`.
- **Bộ Unit Test:** Kiểm thử khởi tạo dữ liệu, kiểm tra điểm hợp lệ trong khoảng $[0, 10]$, kiểm thử điểm trung bình, kiểm thử giá trị biên (ĐTB đúng 8.0, môn đúng 5.0, môn 4.9 bị loại, ĐTB 7.99 bị loại), kiểm thử lọc danh sách học bổng khi rỗng và khi có nhiều học viên.

---

## 5. Hướng dẫn mở và chạy kiểm thử trong Visual Studio 2022

### Cách 1: Sử dụng Visual Studio 2022
1. Mở file `LAB05_UNIT_TEST.sln` bằng Visual Studio 2022.
2. Trên thanh menu, chọn **Test** -> **Windows** -> **Test Explorer** (hoặc nhấn `Ctrl + E, T`).
3. Nhấp vào nút **Run All Tests In View** (hoặc phím tắt `Ctrl + R, A`).
4. Toàn bộ **60 test cases** sẽ hiển thị màu xanh lá cây (**Passed**).

### Cách 2: Sử dụng dòng lệnh .NET CLI
Mở terminal tại thư mục gốc và chạy:
```powershell
dotnet test LAB05_UNIT_TEST.sln
```
**Kết quả thực tế:**
- `CalculatorTester`: **11 Passed**, 0 Failed, 0 Skipped.
- `Lab5_ExercisesTester`: **49 Passed**, 0 Failed, 0 Skipped.
- **Tổng cộng: 60/60 bài test ĐẠT (100% Passed).**
