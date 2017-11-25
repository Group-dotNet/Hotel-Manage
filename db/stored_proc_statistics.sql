use hotel

----------- tim so luong nhân viên (bang staff) ------------------ 
go

create proc USP_CountStaff
AS
BEGIN
	select count(username) from Staff
END

----------- Tim so luong khách hàng dang su dung phòng ------------------------------
go 

create proc USP_CountCustomerUsing
AS
BEGIN
	select count(id_customer)
	from Reservation, Reservation_room, Room
	where Reservation.id_reservation=Reservation_room.id_reservation and Reservation_room.id_room=Room.id_room and Room.locked='1'
END

--------- Tim so luong dat phòng theo thoi gian (có tham so dau vào)----------
go

create proc USP_CountReservationByDate
	@created datetime
AS
BEGIN
	select @created, count(Calendar.created)
	from Reservation, Calendar
	where Reservation.id_reservation=Calendar.id_reservation and Calendar.created=@created
END

--------- Tim so luong dat phòng theo thoi gian (không có tham so dau vào)----------
go

create proc USP_CountReservationByDate_2
AS
BEGIN
	select created, count(id_calendar)
	from Reservation, Calendar
	where Reservation.id_reservation=Calendar.id_reservation
	group by(created)
END

------- Tim so luong phòng hien có (chua su dung) bang room theo num_floor----------
go

create proc USP_CountReservationUsing
AS
BEGIN
	select num_floor, count(id_room)
	from Room
	where locked='0'
	group by num_floor
END

--------- Tim so luong phòng dang su dung bang Reservation_room ----------------]
go

create proc USP_CountRoomUsing
AS
BEGIN
	select count(id_reservation_room)
	from Reservation_room
	where using='1'
END

--------- Tính tong so tien thu duoc bang Bill (không có tham so dau vào) --------------
go

create proc USP_TotalMoneyByDate
AS
BEGIN
	select created, SUM(total_money)
	from Bill
	group by created
END

--------- Tinh tong so tien thu duoc bang Bill (không có tham so dau vào) --------------
go

create proc USP_TotalMoneyByDate_2
	@created date
AS
BEGIN
	select @created, SUM(total_money)
	from Bill
	where created=@created
	group by created
END

---------- Tinh tong so luong cua tung loai vat tu da su dung trong he thong (sap xep theo thu hang giam dan) -------
go

create proc USP_AnalyticStuff
AS
BEGIN
	select Stuff.name_stuff, sum(Stuff_detail.number) 
	from Stuff, Stuff_detail
	where Stuff.id_stuff=Stuff_detail.id_stuff
	group by Stuff.name_stuff
	order by sum(Stuff_detail.number) desc;
END

------------ Tinh so luong cua tung loai dich vu da su dung trong he thong (sap xep theo thu hang giam dan)---------
go

create proc USP_AnalyticService
AS
BEGIN
	select Service.name_service, sum(Service_ticket.number)
	from Service, Service_ticket
	where Service.id_service=Service_ticket.id_service
	group by Service.name_service
	order by sum(Service_ticket.number) desc
END

