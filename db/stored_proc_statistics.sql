use hotel



--------- Tim so luong dat phòng trong ngay (có tham so dau vào)----------
go
-- exec USP_CountReservationInDay '12/19/2017 12:00:00 AM'
create proc USP_CountReservationInDay
@date datetime
AS
BEGIN
	select count(DISTINCT (Calendar.id_reservation))
	from Reservation, Calendar
	where Reservation.id_reservation=Calendar.id_reservation  and Day(Calendar.created)= Day(@date) and MONTH(Calendar.created) = MONTH(@date) and YEAR(Calendar.created) = YEAR(@date)
END

go

-- exec USP_ReservationInDay '12/19/2017 12:00:00 AM'
create proc USP_ReservationInDay
@date datetime
as
begin
	select distinct(a.id_reservation), c.name , a.is_group, a.people, a.username, a.status_reservation 
	from (Reservation as a join Calendar as b on a.id_reservation=b.id_reservation) join Customer as c on a.id_customer = c.id_customer
	where Day(b.created)= Day(@date) and MONTH(b.created) = MONTH(@date) and YEAR(b.created) = YEAR(@date)
end


------- Tính số lượng phòng trống ----------
go

create proc USP_CountRoomEmty
AS
BEGIN
	select count(id_room)
	from Room
	where locked='0'
END

go

create proc USP_RoomEmty
as
begin
	select * from Room as a join Kind_of_room as b on a.id_kind_of_room = b.id where locked = '0';
end
--------- Tim so luong phòng dang su dung  bang Reservation_room ----------------]
go

create proc USP_CountRoomUsing
AS
BEGIN
	select count(id_room)
	from Room
	where locked='1'
END

go

create proc USP_RoomUsing
as
begin
	select * from Room as a join Kind_of_room as b on a.id_kind_of_room = b.id where locked = '1';
end


go
 -- Tinhs số lượng Dịch vụ đã sử dụng trong ngày

create Proc USP_CountServiceUsingInDay
@date datetime
as
begin
	if exists(select * from Service_ticket as a where Day(a.date_use)= Day(@date) and MONTH(a.date_use) = MONTH(@date) and YEAR(a.date_use) = YEAR(@date))
	begin
		declare @count int
		select @count = SUM(a.number) from Service_ticket as a where Day(a.date_use)= Day(@date) and MONTH(a.date_use) = MONTH(@date) and YEAR(a.date_use) = YEAR(@date)
		return @count
	end
	return 0
end

go

create proc USP_ServiceUsingInDay
@date datetime
as
begin
	select a.id_service, a.number, a.date_use, b.name_service, b.price, d.num_floor, d.num_order from ((Service_ticket as a join Service as b on a.id_service = b.id_service) join Reservation_room as c on a.id_reservation_room = c.id_reservation) join Room as d on c.id_room = d.id_room where Day(a.date_use)= Day(@date) and MONTH(a.date_use) = MONTH(@date) and YEAR(a.date_use) = YEAR(@date)
end

-- exec USP_ServiceUsingInDay '12/19/2017 12:00:00 AM'
go
-- Tính Số tiền thu trong ngày


create proc USP_CountRevenueInDay
@date date
as
begin
	declare @money_bill money
	if exists (select * from Bill as a join Reservation as b on a.id_reservation = b.id_reservation where status_reservation = 1 and a.confirm = 1 and  Day(a.created)= Day(@date) and MONTH(a.created) = MONTH(@date) and YEAR(a.created) = YEAR(@date))
	begin
		select @money_bill = SUM(total_money) from Bill as a join Reservation as b on a.id_reservation = b.id_reservation where status_reservation = 1 and a.confirm = 1 and  Day(a.created)= Day(@date) and MONTH(a.created) = MONTH(@date) and YEAR(a.created) = YEAR(@date)
	end
	else
	begin
		set @money_bill = 0.0
	end
	print @money_bill

	declare @money_deposit money
	if exists ( select * from Deposit as a join Reservation as b on a.id_reservation = b.id_reservation where a.confirm = 1 and b.status_reservation = 2 and a.locked = 0 and  Day(a.created_confirm)= Day(@date) and MONTH(a.created_confirm) = MONTH(@date) and YEAR(a.created_confirm) = YEAR(@date))
	begin 
		select @money_deposit = sum(a.deposit) from Deposit as a join Reservation as b on a.id_reservation = b.id_reservation where a.confirm = 1 and b.status_reservation = 2 and a.locked = 0 and  Day(a.created_confirm)= Day(@date) and MONTH(a.created_confirm) = MONTH(@date) and YEAR(a.created_confirm) = YEAR(@date)
	end
	else
	begin
		set @money_deposit = 0.0
	end
	print @money_deposit

	
	return @money_bill + @money_deposit
end

go
-- Tính số lượng hóa đơn thanh toán trong ngày
create proc USP_CountBillInDay
@date datetime
as
begin
	select count(*) from Bill as a join Reservation as b on a.id_reservation = b.id_reservation where status_reservation = 1 and a.confirm = 1 and  Day(a.created)= Day(@date) and MONTH(a.created) = MONTH(@date) and YEAR(a.created) = YEAR(@date) 
end
-- exec USP_BillInDay '12/19/2017 12:00:00 AM'
go

create proc USP_BillInDay
@date datetime
as
begin
	select * from Bill as a join Reservation as b on a.id_reservation = b.id_reservation where status_reservation = 1 and a.confirm = 1 and  Day(a.created)= Day(@date) and MONTH(a.created) = MONTH(@date) and YEAR(a.created) = YEAR(@date) 
end

go

-- Tinh so luong su dung dich vu
create proc USP_CountUsingService
@id_service int 
as
begin
	if exists (select * from service_ticket where id_service = @id_service)
	begin
		declare @conut_service int
		select @conut_service = sum(number) from service_ticket where id_service = @id_service
		return @conut_service
	end
	return 0
end

go
-- So luong phieu dat cua khachhang
create proc USP_CountReservationByCustomer
@id_customer int
as
begin
	select count(*) from reservation where id_customer = @id_customer
end


go

-- Tinh so tien khach hang da tra
-- drop proc USP_GetSpendMoney 7
create proc USP_GetSpendMoney
@id_customer int
as
begin
	if exists(select * from Reservation as a join Bill as b on a.id_reservation = b.id_reservation where a.id_customer = @id_customer)
	begin
		declare @spendmoney money
		select @spendmoney = sum(b.total_money) from Reservation as a join Bill as b on a.id_reservation = b.id_reservation where a.id_customer = @id_customer
		return @spendmoney
	end
	return 0.0
end

go

-- Tinh so luong vat tu trong phong

create proc USP_CountStuffInRoom
@id_kor int
as
begin
	if exists(select * from Stuff_detail where id_kind_of_room = @id_kor)
	begin
		declare @sum_stuff int
		select @sum_stuff = sum(number) from Stuff_detail where id_kind_of_room = @id_kor
		return @sum_stuff
	end
	return 0
end

go

-- TInh so lan su dung phong
create proc USP_CountUsingRoom
@id_room int
as
begin
	select count(*) from Reservation_room where id_room =@id_room and using = 1
end

go

-- Dem so lan dat phong cua nhan vien

create proc USP_CountReservationByStaff
@username varchar(50)
as
begin
	select count(*) from Reservation where username = @username
end	

go 

-- Dem so lan phuc vu phong cua nhan vien

create proc USP_CountRoomOfStaff
@username varchar(50)
as
begin
	select count(*) from Room where username = @username
end

go 

-- Dem so lan thanh toan cua nhan vien
create proc USP_CountCheckOutByStaff
@username nvarchar(50)
as
begin
	select count(*) from Bill where username = @username
end


----------- Tính tong so tien thu duoc bang Bill (không có tham so dau vào) --------------
--go

--create proc USP_TotalMoneyByDate
--AS
--BEGIN
--	select created, SUM(total_money)
--	from Bill
--	group by created
--END

----------- Tinh tong so tien thu duoc bang Bill (không có tham so dau vào) --------------
--go

--create proc USP_TotalMoneyByDate_2
--	@created date
--AS
--BEGIN
--	select @created, SUM(total_money)
--	from Bill
--	where created=@created
--	group by created
--END

------------ Tinh tong so luong cua tung loai vat tu da su dung trong he thong (sap xep theo thu hang giam dan) -------
--go

--create proc USP_AnalyticStuff
--AS
--BEGIN
--	select Stuff.name_stuff, sum(Stuff_detail.number) 
--	from Stuff, Stuff_detail
--	where Stuff.id_stuff=Stuff_detail.id_stuff
--	group by Stuff.name_stuff
--	order by sum(Stuff_detail.number) desc;
--END

-------------- Tinh so luong cua tung loai dich vu da su dung trong he thong (sap xep theo thu hang giam dan)---------
--go

--create proc USP_AnalyticService
--AS
--BEGIN
--	select Service.name_service, sum(Service_ticket.number)
--	from Service, Service_ticket
--	where Service.id_service=Service_ticket.id_service
--	group by Service.name_service
--	order by sum(Service_ticket.number) desc
--END


------------- tim so luong nhân viên (bang staff) ------------------ 
--go

--create proc USP_CountStaff
--AS
--BEGIN
--	select count(username) from Staff
--END

------------- Tim so luong khách hàng dang su dung phòng theo ngay ------------------------------
--go 

--create proc USP_CountCustomerUsing
--@date date
--AS
--BEGIN
--	select count(id_customer)
--	from Reservation, Reservation_room, Room
--	where Reservation.id_reservation=Reservation_room.id_reservation and Reservation_room.id_room=Room.id_room and Room.locked='1' and Reservation.
--	select COUNT(
--END

----------- Tim so luong dat phòng theo thoi gian (không có tham so dau vào)----------
--go

--create proc USP_CountReservationByDate_2
--AS
--BEGIN
--	select created, count(id_calendar)
--	from Reservation, Calendar
--	where Reservation.id_reservation=Calendar.id_reservation
--	group by(created)
--END
