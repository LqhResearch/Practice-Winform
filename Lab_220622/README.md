# :desktop_computer: Thực hành ngày 22/06/2022

## :pushpin: Bài 1
- Tạo lớp `Student` gồm các một số thuộc tính như sau: Mã sinh viên (SID), tên sinh viên (tenSV), mã khoa (khoa), điểm trung bình (diemTB).
- Phạm vi truy xuất của các thuộc tính này được chọn là **private**.
- Cài đặt 2 hàm khởi tạo cho lớp `Student` với cấu trúc như sau **public Student()** và hàm khởi tạo sao chép public **Student(Student st)**.
- Cài đặt các hàm get và set cho các thuộc tính của Student.
- Thiết kế hàm **public Student Nhap()** dùng để nhập thông tin của một sinh viên.
- Thiết kế hàm **public void Show()** để hiển thị thông tin của một sinh viên.

## :pushpin: Bài 2
- Xây dựng lớp `PhanSo` gồm có các thuộc tính tuSo, mauSo.
- Phương thức: 
	- Hàm khởi tạo không tham số **public PhanSo()**.
	- Hàm khởi tạo với 2 tham số là tử số và mẫu số: **public PhanSo(int, int)**.
	- Viết phương thức get và set cho thuộc tính tuSo và mauSo.
	- Viết hàm nhập và xuất phân số.
	- Viết các phương thức để thực hiện cộng, trừ, nhân và chia 2 phân số.

## :pushpin: Bài 3
- Một đơn vị sản xuất gồm có các nhân sự phụ trách các công việc khác nhau. Mỗi một nhân sự cần quản lý các thông tin như sau: Họ tên, tuổi, giới tính, địa chỉ.
- Nhân sự có thể là công nhân, kỹ sư và nhân viên. Mỗi công nhân có thêm thuộc tính riêng  bậc (có giá trị từ 1 đến 10). Mỗi kỹ sư có thêm thuộc tính riêng ngành đào tạo. Mỗi nhân viên có thêm thuộc tính riêng công việc.
- Tạo lớp `NhanSu` gồm có các thuộc tính như Họ tên, tuổi, giới tính, địa chỉ.
- Cài đặt các hàm set và get cho các thuộc tính.
- Cài đặt hàm **Show()** để hiển thị thông tin của mỗi nhân sự, hàm này bổ sung vào như mô tả.
- Cài đặt lớp `CongNhan`, `KySu` và `NhanVien` với các thuộc tính bổ sung vào như mô tả.
- Viết hàm để hiển thị thông tin của Công nhân, Kỹ sư và Nhân viên.