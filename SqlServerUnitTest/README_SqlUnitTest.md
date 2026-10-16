# Hướng Dẫn & Phân Tích Chi Tiết SQL Server Unit Test (Trang 10 - 18)

## 1. Giới thiệu tổng quan
Trong phần SQL Server Unit Test của tài liệu hướng dẫn:
- Mục tiêu là kiểm thử các đối tượng cơ sở dữ liệu (đặc biệt là **Stored Procedures**) trực tiếp bên trong Visual Studio thông qua **SQL Server Database Project** (SSDT) và **SQL Server Test Configuration**.
- Ví dụ thực tế trong bài sử dụng Stored Procedure `dbo.sp_Top3Authors` từ CSDL `Bookstore`.

---

## 2. 8 Loại Assertion Conditions trong Visual Studio SQL Server Unit Test
Tài liệu (Trang 16) chỉ rõ 8 loại điều kiện kiểm thử trong dropdown `Test Conditions`:

1. **Row Count**:
   - **Mục đích**: Kiểm tra số lượng dòng trả về trong Result Set có đúng kỳ vọng hay không.
   - **Ví dụ trong bài (Trang 16)**: Stored Procedure `sp_Top3Authors` trả về top 3 tác giả, do đó thiết lập thuộc tính `Row Count = 3`. Nếu số dòng khác 3 thì test case sẽ FAILED.

2. **Data Checksum**:
   - **Mục đích**: Kiểm tra giá trị mã băm (checksum) của toàn bộ dữ liệu trả về so với giá trị mong đợi.
   - **Cách thực hiện (Trang 17)**: Bấm nút `Configuration...`, bấm `Retrieve` để Visual Studio tự động thực thi SP và sinh mã checksum mong đợi (ví dụ: `-771168943`). Nếu dữ liệu trong bảng tác giả bị thay đổi, checksum sẽ khác và test sẽ cảnh báo lỗi.

3. **Scalar Value**:
   - **Mục đích**: Kiểm tra giá trị cụ thể tại một ô (tọa độ dòng và cột) trong Result Set.
   - **Ví dụ trong bài (Trang 18)**: Thiết lập `Row number = 1`, `Column number = 5` (cột Phone của dòng 1), giá trị kỳ vọng `Expected value = 0984461466`.

4. **Empty ResultSet**:
   - **Mục đích**: Kiểm tra Result Set trả về phải là rỗng (0 dòng). Thường dùng cho các truy vấn tìm kiếm dữ liệu không tồn tại hoặc các câu lệnh DELETE/UPDATE không trả dữ liệu.

5. **Not Empty ResultSet**:
   - **Mục đích**: Kiểm tra Result Set trả về không được rỗng (phải có ít nhất 1 dòng dữ liệu).

6. **Execution Time**:
   - **Mục đích**: Kiểm tra hiệu năng (Performance/Non-functional test). Test sẽ FAIL nếu thời gian thực thi của Stored Procedure vượt quá ngưỡng thời gian quy định (Execution time limit).

7. **Expected Schema**:
   - **Mục đích**: Kiểm thử cấu trúc lược đồ (tên cột, thứ tự cột, kiểu dữ liệu cột) của Result Set trả về có khớp với định nghĩa yêu cầu hay không.

8. **Inconclusive**:
   - **Mục đích**: Đánh dấu test case chưa hoàn thiện hoặc chưa đưa ra kết luận (mặc định được sinh ra khi tạo mới). Cần xóa bỏ hoặc thay thế bằng các assertion cụ thể.

---

## 3. Mã kiểm thử T-SQL cho Stored Procedure sp_Top3Authors
Đoạn mã test T-SQL trong pane kiểm thử (Trang 15):
```sql
-- database unit test for dbo.sp_Top3Authors
DECLARE @RC AS INT;

SELECT @RC = 0;

EXECUTE @RC = [dbo].[sp_Top3Authors] ;

-- Đã xóa dòng: SELECT @RC AS RC; theo hướng dẫn tại Trang 15 để chỉ nhận 1 Result Set chính từ Stored Procedure
```

---

## 4. Cách nạp CSDL và chạy trên máy tính cá nhân
1. Mở SQL Server Management Studio (SSMS) hoặc Visual Studio -> SQL Server Object Explorer.
2. Mở và thực thi file script `Bookstore_DbTest.sql` đi kèm để tạo CSDL `Bookstore`, các bảng `Category`, `Author`, `Book`, `BookAuthor`, chèn dữ liệu mẫu và tạo 2 Stored Procedure:
   - `dbo.sp_CountAuthors`
   - `dbo.sp_Top3Authors`
3. Trong Visual Studio: Nhấp chuột phải vào Solution -> Add New Project -> SQL Server Database Project (`DbTest`) -> Import Database -> chọn CSDL `Bookstore`.
4. Trong SQL Server Object Explorer: Chuột phải vào `dbo.sp_Top3Authors` -> Chọn `Create Unit Tests...` -> Thiết lập cấu hình kết nối CSDL và thêm các Test Condition: `Row Count (3)`, `Scalar Value (dòng 1, cột 5 là 0984461466)`, `Data Checksum`.
