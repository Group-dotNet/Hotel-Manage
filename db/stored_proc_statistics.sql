use hotel



--------- Tim so luong dat phòng trong ngay (có tham so dau vào)----------
go

create proc USP_CountReservationInDay
@date date
AS
BEGIN
	select count(Calendar.created)
	from Reservation, Calendar
	where Reservation.id_reservation=Calendar.id_reservation and Day(Calendar.created)= Day(@date) and MONTH(Calendar.created) = MONTH(@date) and YEAR(Calendar.created) = YEAR(@date)
END


------- Tính số lượng phòng trống ----------
go

create proc USP_CountRoomEmty
BEGIN
	select count(id_room)
	from Room
	where locked='0'
END

--------- Tim so luong phòng dang su dung  bang Reservation_room ----------------]
go

create proc USP_CountRoomUsing
AS
BEGIN
	select count(id_reservation_room)
	from Reservation_room
	where using='1'
END



go
 -- Tinhs số lượng Dịch vụ đã sử dụng trong ngày

create Proc USP_CountServiceUsingInDay
@date date
as
begin
	select SUM(a.number) from Service_ticket as a where Day(a.date_use)= Day(@date) and MONTH(a.date_use) = MONTH(@date) and YEAR(a.date_use) = YEAR(@date)
end


go
-- Tính Số tiền thu trong ngày

create proc USP_CountRevenueInDay
@date date
as
begin
	declare @money_bill money
	select @money_bill = SUM(total_money) from Bill as a join Reservation as b on a.id_reservation = b.id_reservation where status_reservation = 1 and a.confirm = 1 and  Day(a.created)= Day(@date) and MONTH(a.created) = MONTH(@date) and YEAR(a.created) = YEAR(@date)
	declare @money_deposit money
	select @money_deposit = sum(a.deposit) from Deposit as a join Reservation as b on a.id_reservation = b.id_reservation where a.confirm = 1 and b.status_reservation = 2 and a.locked = 0 and  Day(a.created_confirm)= Day(@date) and MONTH(a.created_confirm) = MONTH(@date) and YEAR(a.created_confirm) = YEAR(@date)
	return @money_bill + @money_deposit
end


-- Tính số lượng hóa đơn thanh toán trong ngày
create proc USP_CountBillInDay
@date date
as
begin
	select count(*) = SUM(total_money) from Bill as a join Reservation as b on a.id_reservation = b.id_reservation where status_reservation = 1 and a.confirm = 1 and  Day(a.created)= Day(@date) and MONTH(a.created) = MONTH(@date) and YEAR(a.created) = YEAR(@date) 
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
