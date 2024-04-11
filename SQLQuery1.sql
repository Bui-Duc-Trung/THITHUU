create database NET1021_Final
go
use NET1021_Final
go
create table Sinhvien(
ten nvarchar(50),
nganh nvarchar(50),
gioitinh bit)
go
insert into Sinhvien values 
(N'Khánh', N'Ứng dụng PM', 1),
(N'Dũng', N'Công nghệ thông tin', 0),
(N'Tiến', N'Đồ Họa', 0),
(N'Hằng', N'Marketing', 1),
(N'Tạch', N'Ứng dụng PM', 0)

