# QUẢN LÝ KHÁCH SẠN

## Giới thiệu đề tài
***
> Với mong muốn cải tiến được khả năng quản lý khách sạn hiệu quả và tiết kiếm. **“Group 1”** đề ra giải pháp sử dụng công nghệ thông tin để giúp quản lý chính xác về thời gian cũng như tiết kiệm được việc sử dụng nguồn nhân lực cho việc quản lý.

## Yêu cầu chức năng
***
Xây dựng phần mền quản lý khách sạn gồm có quản lý phòng, đặt phòng, dịch vụ, vật tư và doanh số:
* Quản lý phòng: Hệ thống có thể phát sinh lượng số phòng tùy theo từng khách sạn. Hỗ trợ việc kiểm tra trạng thái phòng! Có thể lưu thông tin người sử dụng phòng. 
* Quản lý đặt phòng: Tính toán giá tiền nhanh và chính xác.Được chạy tự động; nên rất ít khi có sự sai sót về dữ liệu trong hệ thống. Hỗ trợ nhân viên tính tiền cọc tùy theo khách sạn
* Quản lý dịch vụ: Tự động cập nhật số tiền vào phiếu đặt của khách hàng. Có thể phát sinh thêm các loại sản phẩm tùy theo khách sạn. 
* Quản lý vật tư: Hỗ trợ thiết lập vật tư phù hợp với tựng loại phòng của khách sạn
* Quản lý doanh số: Giúp thống kê, report doanh số theo thời gian theo thời gian.

## Quy trình xây dựng phần mềm
***
1. Thiết kế Database
2. Thiết kế Procdure Stored, Trigger.
3. Kiểm thử hệ thống mức cơ bản
4. Viết Module Kết Nối Database cùng các hàm setup datatable
5. Viết Module System gồm (Đăng nhập, đăng xuất, đổi mật khẩu ,chỉnh sửa profile)
6. Viết Module Staff gồm (Thêm, sửa, khóa, thống kê, report, tìm kiếm, ...)
7. Viết Module Customer gồm (Thêm, sửa, khóa, thống kê, report, tìm kiếm, ...)
8. Viết Module Stuff gồm (Thêm, sửa, xóa, thống kê, report, tìm kiếm, ...)
9. Viết Module Service gồm có (Thêm, sửa, xóa, thống kê, report, tìm kiếm, ...)
10. Viết Module Reservation: chia thành các moduel nhỏ hơn.
	* Chức năng tạo phiếu đặt (Tính toán giá tiền, xuất ra tiền cọc, lưu danh sách phòng, lưu thời gian đặt,... )
	* Chức năng chỉnh sửa phiếu đặt (Hủy phòng nếu s/l phòng trong phiếu đặt > 1, Đổi phòng nếu còn phòng trống cùng loại, Đổi thời gian đặt,... )
	* Chức năng Hủy phiếu đặt (Cập nhật trạng thái phòng, trạng thái thời gian đặt, số tiền cọc, ...)
	* Chức Checkout (Tính toán lại phiếu đặt gồm cả giá phòng và tổng giá dịch vụ)
	* Chức năng Tìm kiếm, Report
11. Viết Module Bill gồm có (Checkout nếu phiếu đặt chưa thanh toán, thống kê, report, tìm kiếm, ...)
12. Viết Module Analytic gồm có (Thông kê, report doanh số theo thời gian,... )
13. Viết Module Chức năng khác gồm có (Máy tính: hỗ trợ phép tính phức tạp khi thanh toán hóa đơn, Guide: Hướng đẫn sử dụng phần mền, Bảng giá, ...)
14. Kiểm thử phần mền
15. Đóng gói phần mền

## Thiết kế cơ sở dữ liệu
***
> Bản thiết kế cuối cùng.

![diagrams](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/diagrams.png "diagrams")

## Hướng dẫn cài đặt
***
#### Phần mềm bổ trợ:
> Gitkarken

#### Cấu trúc thư mục:
> Theo mô hình 3 lớp: DTO, DAO, BUS

> Thư mục GUI chứa giao diện Form với mỗi chức năng sẽ tạo 1 thư mục con để phân biệt, ví dụ: Customer, Reservation,…

> Thư mục Resource chứa các file ảnh sử  dụng trong project

#### Cài đặt:
1. **Cài đặt source code**
* Mở Gitkarken 
* Thực hiện `Chọn File` -> `Clone Repo`

![setup1](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/setup1.png "setup1")

* Vị trí lưu code : `C:\Users\ADMIN\Documents\Visual Studio 2015\Projects`
* Tại URL cope đoạn URL sau: `https://github.com/Group-dotNet/app` vào URL

![setup2](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/setup2.png "setup2")

> Đợi nó download về trong 1,2 phút

Chọn “Open Now” bên trên để mở giao diện:

![setup3](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/setup3.png "setup3")

2. **Cài đặt cơ sở dữ liệu và chạy chương trình**
* Vào thư mục `C:\Users\ADMIN\Documents\Visual Studio 2015\Projects\app\db` mở file `*.sql`

* Chay dòng Script viết sẵn theo thứ tự file `SQLQuery1.sql` chạy đầu tiên

* Chạy thử chương trình vào `C:\Users\ADMIN\Documents\Visual Studio 2015\Projects\app` mở file `app.sln`

* Sửa chuỗi kết nối phù hợp tại file `DAO/Connect.cs`
![setup4](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/setup4.png "setup4")

* Bấm “Start” để run

## Hướng dẫn sử dụng
***
* Khi khởi động hệ thống, HT sẽ kiểm tra đã tồn tại tài khoản admin nào trong hệ thống chưa nếu chưa sẽ hiện form tạo **Staff** `GUI/Staff/fAdd_staff.cs`

![image1](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image1.png "image1")

* Phải điển đầy đủ thông tin hệ thông mới chuyển sang login

![image2](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image2.png "image2")

Trong đó:
* “1”: Nếu đăng nhập đúng username và password sẽ chuyển sang form màn hình chính `fMain.cs` ngược lại sẽ báo lỗi.
* “2”. Tắt chương trình


Màn hình chính gồm: **Menu**, **Thông tin hệ thống**, **Báo cáo tổng quan**

![image3](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image3.png "image3")

> Với từng loại tài khoản sẽ được sử dụng 1 số chức năng nhất định

#### Các bước xây dựng hệ thống:
* Bước 1: Tạo 1 tài khoản Staff và 1 tài khoản Admin
* Bước 2: Tạo 1 tài khoản khách hàng đang ở trạng thái không khóa
* Bước 3: Tạo 1 loại phòng
* Bước 4: Tạo 1 vật tư
* Bước 5: Tạo 1 dịch vụ
* Bước 6: Tạo ít nhất 1 phòng trong hệ thống
* Bước 7: Tạo phiếu đặt
* Bước 8: Check out

#### Thực hiện:
> Bước 1: Vào màn hình chính chọn `Manage` -> `Staff`

![image4](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image4.png "image4")

Hiện tại hệ thống đã có 1 tài khoản **Admin** được tại trước khi đăng nhập vào hệ thống.

Bây giờ để tạo thêm 1 tài khoản **Staff** chọn vào hình chữ thập màu xanh lá.

Giao diện tạo tài khoản mới giống như tạo tài khoản **Admin** lúc đầu hệ thống. Yêu cầu nhập đầy đủ thông tin và các **Field**

![image5](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image5.png "image5")

Ngoài ra còn các chức năng:

![image6](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image6.png "image6")

Trong đó:
* "1": Xem chi tiết nhân viên(`GUI/Staff/fStaff_info.cs`)
* "2": Đổi mật khẩu (`fChange_pass.cs`)
* "3": Đổi quyền sử dụng (`Staff hoặc Admin)(GUI/Staff/fChange_role.cs`)
* "4": Load lại dữ liệu
* "5": Thêm Nhân viên (`GUI/Staff/fAdd_Staff.cs`)
* "6": Sửa thông tin nhân viên (`fProfile.cs`)
* "7": Ban tài khoản
* "8": Trở về màn hình chính
* "9": Tìm kiếm và tìm kiếm nâng cao
* "10": Report (in và xuất excel)

> Bước 2: Thêm 1 Khách hàng

Vào màn hình chính chọn `Manage` ->`Customer`

![image7](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image7.png "image7")
Danh sách chức năng, trong đó:
* "1": Xem chi tiết khách hàng(`GUI/Customer/fCustomer_info.cs`)
* "2": Mở khóa tài khoản nếu bị lock (Admin mới được sử dụng)
* "3": Load lại dữ liệu
* "4": Thêm Khách hàng (`GUI/Customer/fAdd_Customer.cs`)
* "5": Sửa thông tin Khách hàng (`GUI/Customer/fEdit_customer.cs`)
* "6": Ban tài khoản khách hàng
* "7": Trở về màn hình chính
* "8": Tìm kiếm và tìm kiếm nâng cao
* "9": Report (in và xuất excel)

> Bước 3: Thêm loại phòng

Vào màn hình chính chọn `Manage` -> `Room` -> `Add Room`

![image8](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image8.png "image8")

Chọn “Add”  sẻ mở ra giao diện chức năng Loại phòng.

![image9](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image9.png "image9")

> Bước 4: Thêm 1 vật tư

Vào màn hình chính chọn `Manage` -> `Stuff`

![image10](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image10.png "image10")

Danh sách chức năng, trong đó:
* "1": Load lại dữ liệu vật tư
* "2": Thêm vật tư (`GUI/Stuff/fAdd_stuff.cs`)
* "3": Sửa vật tư (`GUI/Stuff/fEdit_stuff.cs`)
* "4": Xóa Vật tư 
* "5": Trở về màn hình chính
* "6": Tìm kiếm
* "7": Report

> Bước 5: Thêm 1 dịch vụ

Vào màn hình chính chọn `Manage` -> `Service`

![image11](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image11.png "image11")

Danh sách chức năng:
* "1": Xem chi tiết dịch vụ(`GUI/Service/fService_info.cs`)
* "2": Load lại dữ liệu
* "3": Thêm Dịch vụ (`GUI/Service/fAdd_service.cs`)
* "4": Sửa thông tin Khách hàng (`GUI/ Service /fEdit_service.cs`)
* "5": Xóa dịch vụ
* "6": Trở về màn hình chính
* "7": Tìm kiếm và tìm kiếm nâng cao
* "8": Report (in và xuất excel)

> Bước 6: Tạo phòng

Vào màn hình chính  chọn `Manage` -> `Room`

![image12](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image12.png "image12")

Danh sách chức năng:
* "1": Lấy thông tin phòng (`GUI/Room/fRoom_info.cs`)
* "2": Load lại dữ liệu phòng 
* "3": Thêm phòng và hệ thông (`GUI/Room/fAdd_room.cs`)
* "4": Sửa phòng (`GUI/Room/fEdit_room.cs`)
* "5": Xóa phòng 
* "6": Trở về màn hình chính
* "7": Tìm kiếm
* "8": Report
* "9": Thêm vật tư vào phòng (`GUI/Stuff/fStuff_detail.cs`)
* "10": Thêm dịch vụ vào phòng (`GUI/Service/fService_ticket.cs`)

> Bước 7 :Tạo phiếu đặt

Vào màn hình chính chọn `Manage` -> `Reservation`

![image13](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image13.png "image13")

Danh sách chức năng
* "1": Lấy thông tin của phiếu đặt
* "2": Load lại dữ liệu phiếu đặt
* "3": Thêm phiếu đặt
* "4": Sửa phiếu đặt
* "5": Chuyển trạng thái phiếu đặt sang Canced (hủy)
* "6": Trở về giao diện màn hình chính
* "7": Tìm kiếm
* "8": Report
* "9": Kiểm tra danh sách phòng trong phiếu đặt
* "10": Kiểm tra dịch vụ trong phiếu đặt
* "11": Kiểm tra Lịch trình của phiếu đặt
* "12": Kiểm tra cọc đã đặt của phiếu đặt
* "13": Checkout phiếu đặt

> Lưu ý khi sửa phiếu đặt có 3 tùy chọn để sửa gồm: **Hủy phòng**, **Đổi phòng** và **Thay đổi lịch trình**

![image14](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image14.png "image14")

* Với đổi phòng: Bạn chỉ có thể đổi phòng cùng loại và trống

![image15](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image15.png "image15")

![image16](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image16.png "image16")

* Đối hủy phòng yêu cầu số phòng của phiếu đặt phải lớn hơn 1

![image17](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image10.png "image17")

* Đổi lịch trình: cũng sẽ có 3 tùy chọn Ngay bây giờ, Sớm hơn ngày kết thúc hoặc lâu hơn ngày kết thúc. Khi nhấn ok. Hệ thống sẽ tự động tính toán lại giá trị phiếu đặt. Và yêu cầu khách hàng trả thêm cọc (nếu có).

> **Lưu ý**: Khi mới khởi động giao diện chức năng phiếu đặt sẽ chỉ hiện lên danh sách các phiếu đặt đã thanh toán thành công và giảm dần. Để biết thông tin các phiếu đặt đang sử dụng. Chọn vào bộ lọc chọn : “Unpaild bill”

> Bước 8: Check out

Vào màn hình chính chọn `Manage` -> `Bill`

Tại đây sẽ đưa ra danh sách các hóa đơn đã tạo của phiếu đặt.

![image18](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image18.png "image18")

Danh sách chức năng
* Lấy thông tin của hóa đơn
* Load dữ liệu hóa đơn
* Checkout lại hóa đơn chưa xác nhận
* Trở về giao diện màn hình chính
* Tìm kiếm 
* Report

> Ngoài ra, có thêm chức năng thống kê :

Vào màn hình chính chọn Analytic!

[image19](https://github.com/Group-dotNet/Hotel-Manage/blob/master/doc/image/image19.png "image19")

## Tổng kết
***
Phần mền đạt 8/10 
