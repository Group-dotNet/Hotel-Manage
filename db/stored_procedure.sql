use hotel

go


--      Strod Procdure of Staff
create proc USP_GetListStaff
as
begin
	select *from Staff
end

GO

create proc USP_GetList_Staff_Service
as
begin
	select * from Account where id_type = 0
end

GO

create proc USP_GetProfile
@username varchar(50)
as
begin
	select * from Staff where username=@username
end

GO

create proc USP_EditStaff
@username varchar (50),
@displayname nvarchar(100),
@sex bit,
@birthday date,
@address nvarchar(200),
@phone varchar(11),
@email varchar(50),
@image nvarchar(1000)
as
begin
	update staff set displayname = @displayname, sex = @sex, birthday = @birthday, address = @address, phone = @phone, email = @email, image = @image where username = @username;
end

GO

create proc USP_GetRole
@username varchar(50)
as
begin
	select id_type from Account where username = @username;
end

GO

create proc USP_CheckUserName
@username varchar(50)
as
begin
	select count(*) from Staff where username = @username
end

GO

create proc USP_BanAccount
@username varchar(50)
as
begin
	update Account set ban_account = 1 where username = @username
end



--select *from Account

--exec USP_BanAccount dinhdinh

--exec USP_GetRole dinhdinh

--exec USP_EditStaff peterdinh018, dinhdinh, 1, '1997-1-1', 'Viet Nam', '019xxxx', 'abc@gmail.com', null

--exec USP_GetListStaff


go

-- Stored procedure room

create proc USP_Get_ListRoom_Floor
@floor int
as
begin
	select * from Room join Kind_of_room on Room.id_kind_of_room = Kind_of_room.id where num_floor = @floor
end

go

create proc USP_GetMaxFloor
as
begin
	declare @num_floor int
	if(exists(select * from Room))
	begin
		select @num_floor = max(num_floor) from Room
		return @num_floor
	end
	else
	begin
		return 0
	end
end
-- exec USP_GetMaxFloor

go

create proc USP_InsertRoom
@num_floor int ,
@num_order int ,
@id_kind_of_room int,
@staff varchar(50)
as
begin
	insert into Room values(@num_floor, @num_order, @id_kind_of_room, 'false', @staff)
end 

go

create proc USP_CheckExistsRoom
@num_floor int,
@num_order int
as
begin
	select count(*) from Room where num_floor = @num_floor and num_order = @num_order
end

go

create proc USP_DeleteRoom
@id_room int
as
begin
	delete from Room where id_room = @id_room
end

go


create proc USP_EditeRoom
@id_room int,
@id_type int,
@staff varchar(50)
as
begin
	if(exists(select * from Room where id_room = @id_room and locked = 0))
	begin
		update Room set  id_kind_of_room = @id_type , username = @staff where id_room  = @id_room
	end
	else
	begin
		rollback
	end
end

go

create proc USP_GetInfoRoom
@id_room int
as
begin
	select * from Room join Kind_of_room on Room.id_kind_of_room = Kind_of_room.id where id_room = @id_room
end

go


create proc USP_CheckUsingRoom
@id_room int
as
begin
	declare @check bit
	if(exists(select * from Room where id_room = @id_room and locked = 0))
		begin
			set @check = 1
		end
	else
		begin
			set  @check = 0
		end
end

go


--exec USP_GetInfoRoom 1

--exec USP_DeleteRoom 43

--exec USP_CheckExistsRoom 1,20

--exec USP_InsertRoom 3, 7 , 11 , phuc

--exec USP_GetMaxFloor

--exec USP_Get_ListRoom_Floor @floor=3



--  strore procedure Kind_of_room

create proc USP_GetList_Kindofroom
as
begin
	select * from Kind_of_room
end

go

create proc USP_InsertKindofRoom
@name nvarchar(100),
@price money,
@people int
as
begin
	if(@price > 0 and @people > 0)
		begin
			insert into Kind_of_room values(@name, @price, @people)
		end
end

go

create proc USP_UpdateKindofRoom
@id int ,
@name nvarchar(100),
@price money,
@people int
as
begin
	if(@price > 0 and @people > 0)
		begin
			update Kind_of_room set name = @name, price = @price, people = @people where id=@id
		end
end

go

create proc USP_DelKindofRoom
@id int
as
begin
	delete from Kind_of_room where id = @id
end

go

--exec USP_DelKindofRoom 13

--exec USP_UpdateKindofRoom 13, test2, 2,3

--exec USP_InsertKindofRoom test, 123, 1

--exec USP_GetList_Kindofroom

go

-- Stored Procedure Calendar 
 
create proc USP_GetInfoCalendarLaster
@id_reservation int
as
begin
	select top 1 *from Calendar where id_reservation = @id_reservation  order by id_reservation desc
end

go

create proc USP_GetListCalendar 
as 
begin 
  select * from Calendar join Reservation on Calendar.id_reservation = Reservation.id_reservation 
end 

go

create proc UPS_GetListCalendarReservation
@id_reservation int
as
begin
	select * from Calendar where id_reservation = @id_reservation;
end

go


create proc USP_GetCalendarReservationUsing
@id_reservation int 
as
begin
	select * from Calendar where id_reservation = @id_reservation and status = 1
end

go

create proc USP_GetListCalendarReservation
@id_reservation int
as
begin
	select * from Calendar where id_reservation = @id_reservation
end
go
 
 
create proc USP_GetInfoCalendar 
@id_calendar int  
as 
begin 
  select * from Calendar join Reservation on Calendar.id_reservation = Reservation.id_reservation where id_calendar = @id_calendar  
end 



go
 
create proc USP_DelCalendar 
@id_calendar int 
as 
begin 
  delete from Calendar where id_calendar = @id_calendar 
end 
 
go
 
create proc USP_InsertCalendar 
@id_reservation int, 
@date_start date, 
@date_end date, 
@created date 
as 
begin 
  if(exists(select * from Reservation where id_reservation = @id_reservation)) 
  begin 
    if(@date_end > @date_start) 
    begin 
      insert into Calendar values(@id_reservation, @date_start, @date_end, @created, 1) 
    end 
  end 
end 

go
 
create proc USP_EditCalendar 
@id_calendar int, 
@id_reservation int, 
@date_start date, 
@date_end date, 
@status bit 
as 
begin 
  if(exists(select * from Calendar where id_calendar = @id_calendar)) 
  begin 
    if(exists(select * from Reservation where id_reservation = @id_reservation)) 
    begin 
      if(@date_start  < @date_end) 
      update Calendar set id_reservation = @id_reservation, start_date = @date_start, end_date = @date_end, status = @status
    end 
  end 
end 

 go

CREATE PROC USP_ChangeCalendar
@id_reservation INT,
@end_date DATETIME
as
BEGIN 
	DECLARE @start_date DATETIME
	select @start_date = start_date from Calendar where id_reservation = @id_reservation and status = 1
	if(@end_date > @start_date)
	BEGIN 
		update Calendar set status = 2 where id_reservation = @id_reservation and STATUS = 1
		INSERT into Calendar VALUES (@id_reservation, @start_date, @end_date, GETDATE(), 1)
		
	END
END 

go

-- stored proc  service_ticket


create proc USP_InsertServiceTikcket
@id_reservation_room int ,
@id_service int,
@number int,
@date_use date
as 
BEGIN
	declare @id_reservation int
	declare @id_room int
	select @id_reservation = id_reservation, @id_room = id_room from Reservation_room where id_reservation_room = @id_reservation_room
	if(exists(select * from Reservation where id_reservation = @id_reservation and status_reservation = 1))
	BEGIN
		if(exists(select * from Room where id_room = @id_room and room.locked = 1))
		BEGIN
			if(exists(select * from Service where id_service = @id_service))
			BEGIN
				if(exists(select * from service_ticket where id_service = @id_service and id_reservation_room = @id_reservation_room))
				BEGIN
					DECLARE @number_present int 
					select @number_present = number from service_ticket where id_service = @id_service and id_reservation_room = id_reservation_room
					DECLARE @number_tran int
					set @number_tran = @number_present + @number
					if(@number_tran > 0)
					BEGIN
						update service_ticket set number = @number_tran where id_service = @id_service and id_reservation_room = @id_reservation_room
					END
					ELSE
					BEGIN
						delete service_ticket where  id_service = @id_service and id_reservation_room = @id_reservation_room
					END
				END
				ELSE
				BEGIN
					INSERT into service_ticket VALUES (@id_reservation_room,  @id_service, @number, @date_use)
				END
			END
		END
	END
end

go

create Proc  USP_GetListServiceReservation
@id_reservation int
as
begin
	select * from (Service_ticket as a join Service as b on a.id_service = b.id_service) join Reservation_room as c on a.id_reservation_room = c.id_reservation_room where c.id_reservation = @id_reservation order by c.id_room  asc
end

GO

CREATE PROC USP_Get_ListServiceTicket
AS
BEGIN
	SELECT * from ((service_ticket as a JOIN Reservation_room as b on a.id_reservation_room = b.id_reservation_room) join service as c on a.id_service = c.id_service)
end

GO

create PROC USP_Get_ListServiceTicket_Room
@id_room int
AS
BEGIN
	SELECT * from ((service_ticket as a JOIN Reservation_room as b on a.id_reservation_room = b.id_reservation_room) join service as c on a.id_service = c.id_service) where b.id_room = @id_room
end

GO

-- exec USP_Get_ListServiceTicket_Room 2

-- Stored Procedure Stuff_detail

create proc USP_InsertStuff_Detail
@id_stuff int ,
@id_kind_of_room int,
@number INT
as
BEGIN
	if(exists(select * from Stuff where id_stuff = @id_stuff))
	BEGIN
		if(exists(select * from Kind_of_room where id = @id_kind_of_room))
		BEGIN
			if(exists(select * from Stuff_detail where id_stuff = @id_stuff and id_kind_of_room = @id_kind_of_room))
			BEGIN
				DECLARE @number_persent INT
				select @number_persent = number from Stuff_detail where id_stuff = @id_stuff and id_kind_of_room = @id_kind_of_room
				DECLARE @number_tran int
				set @number_tran = @number_persent - @number
				if(@number_tran > 0)
				BEGIN
					update Stuff_detail SET number = @number_tran where id_stuff = @id_stuff and id_kind_of_room = @id_kind_of_room
				END
				ELSE
				BEGIN 
					delete from Stuff_detail WHERE id_stuff = @id_stuff and id_kind_of_room = @id_kind_of_room
				END
			END
			ELSE
			BEGIN
				insert into Stuff_detail values(@id_stuff, @id_kind_of_room, @number)
			END
		END
	END
end

GO

create proc USP_GetListStuffDetail_Room
@id_kind_of_room int
AS
BEGIN
	SELECT * from (Stuff_detail as a JOIN Stuff as b on a.id_stuff = b.id_stuff) join Kind_of_room as c on a.id_kind_of_room = c.id where id_kind_of_room = @id_kind_of_room
END

-- exec USP_GetListStuffDetail_Room

GO

-- stored proc reservation room

create proc USP_GetListReservationRoom
@id_reservation int
as
begin
	select * from Reservation_room where id_reservation = @id_reservation
end

go

create proc USP_GetInfoReservationRoom
@id_room int 
as
begin
	select * from Reservation_room where id_room = @id_room
end

go

create proc USP_GetListReservationRoomUsing
@id_reservation int
as
begin
	select * from (Reservation_room as a join Room as b on a.id_room = b.id_room) join Kind_of_room as c on b.id_kind_of_room = c.id where id_reservation = @id_reservation and a.using = 1
end

go

-- exec USP_InsertReservationRoom 13, 1
create proc USP_InsertReservationRoom
@id_reservation int,
@id_room int
as
begin
	if(exists(select * from Room where id_room = @id_room and Room.locked = 0))
	begin
		insert into Reservation_room values (@id_reservation, @id_room, 1)
		update Room set locked = 1 where id_room = @id_room
	end
end

go
-- exec USP_GetHistory 14
create proc USP_GetHistory
@id_reservation int 
as 
begin
	select * from Reservation_room as a join Room as b on a.id_room = b.id_room where id_reservation = @id_reservation
end
-- exec USP_GetListReservationRoomUsing 3

-- Stored Procedure Insert Data

-- select * from reservation_room
-- select * from Stuff_detail

-- drop database hotel

-- exec USP_GetCalendarReservation 3

-- exec USP_GetCalendarReservation @id_reservation=3

-- exec USP_GetListReservationRoomUsing 14

go

-- stored proc Desposit


create proc USP_InsertDeposit
@id_reservation int,
@deposit money,
@confirm bit
as
begin
	declare @created_confirm datetime
	set @created_confirm = GETDATE()
	declare @locked bit
	set @locked = 0
	declare @note nvarchar(1000)
	set @note = convert(varchar(20),getdate(),120) +  ': Insert deposit'
	if(@confirm = 1)
		begin
			DECLARE @NewLineChar AS CHAR(2) = CHAR(13) + CHAR(10)
			declare @note2 nvarchar(1000)
			select @note2 = note from deposit where id_reservation = @id_reservation and locked = 0 
			set @note2 = @note2 + @NewLineChar + convert(varchar(20),getdate(),120) + ': Cancel deposit'
			update Deposit set locked = 1 , note = @note2 where id_reservation = @id_reservation and locked = 0
			insert into Deposit values (@id_reservation, @deposit, @confirm , @created_confirm , @locked , @note)
			update Reservation set status_reservation = 2 where id_reservation = @id_reservation
		end
	else
		begin
			rollback
		end
end

go

create proc UPS_CountDeposit
@id_reservation int
as
begin
	select count(*) from Deposit where id_reservation = @id_reservation;
end

go

create proc USP_CheckDepositPrev
@id_reservation int
as
begin
	select top 1 * from Deposit where id_reservation =  @id_reservation and locked = 1  order by id_deposit desc
end

go


create proc USP_CheckConfirm
@id_reservation int
as
begin
	select * from Deposit where id_reservation = @id_reservation and locked = 0
end

go


create proc USP_GetListDeposit
@id_reservation int
as
begin
	select * from Deposit where id_reservation = @id_reservation order by id_deposit desc
end

go


create proc USP_NotPaidDeposit
@id_reservation int
as
begin
	if(exists (select * from Reservation where id_reservation = @id_reservation and locked = 0))
	begin
	DECLARE @note NVARCHAR(1000)
	DECLARE @NewLineChar AS CHAR(2) = CHAR(13) + CHAR(10)
	SELECT @note = note FROM Reservation WHERE id_reservation = @id_reservation
	set @note = @note + @NewLineChar + convert(varchar(20),getdate(),120) + ': Not Paid Deposit'
	Update Reservation set status_reservation = 3 , note = @note where id_reservation = @id_reservation
	update Calendar set status = 0  where id_reservation = @id_reservation;
	update Reservation_room set using = 0 where id_reservation = @id_reservation
	update Room set locked = 0 where id_room in (select id_room from Reservation_room where id_reservation = @id_reservation)
	end
	else
	begin
		rollback
	end
end

go
-- stored proc Bill

create proc USP_GetListBill
as
begin
	select * from Bill as a join Reservation as b on a.id_reservation = b.id_reservation 
end

go

create proc USP_GetInfoBill
@id_bill int
as
begin
	select * from Bill as a join Reservation as b on a.id_reservation = b.id_reservation  where id_bill = @id_bill
end


go


create proc USP_InsertBill
@id_reservation int,
@username nvarchar(100)
as
begin
	declare @id_bill int
	declare @created datetime
	set @created = GETDATE()
	if(not exists(select * from Bill where id_reservation = @id_reservation))
	begin
		Declare @note NVARCHAR(1000)
		set @note = convert(varchar(20),getdate(),120) + ': Insert Bill in system'
		insert into Bill values(@created, 0, @id_reservation, @username, 0, @note)
		select @id_bill = @@IDENTITY
	end
	else
	begin
		select @id_bill = id_bill from Bill where id_reservation = @id_reservation
	end
	return @id_bill
end

go

create proc USP_CheckConfirm_Bill
@id_bill int
as
begin
	if(exists(select * from Bill where id_bill = @id_bill and confirm = 1)) 
		return 1
	else
		return 0
end

go

create proc USP_UpdateBill
@id_bill int,
@total_money money,
@username nvarchar(100)
as
begin
	if(exists(select * from Bill where id_bill = @id_bill and confirm = 0)) 
	begin
		declare @return int
		declare @created datetime
		set @created = GETDATE()
		DECLARE @NewLineChar AS CHAR(2) = CHAR(13) + CHAR(10)
		Declare @note NVARCHAR(1000)
		select @note = note from Bill where id_bill = @id_bill
		set @note = @note + @NewLineChar + convert(varchar(20),getdate(),120) + ': Confirm bill'

		update Bill set total_money = @total_money , username = @username,  confirm = 1 , note = @note where id_bill = @id_bill 

		declare @id_reservation int
		select @id_reservation = id_reservation from Bill where id_bill = @id_bill
		update Reservation set status_reservation = 1 where id_reservation = @id_reservation

		update Room set locked = 0 where id_room in (select id_room from Reservation_room where id_reservation = @id_reservation and using = 1)
		return 1
	end
	return 0
end

-- stored swap room

create proc USP_GetListRoomCancelByReservation
@id_reservation int
as
begin
	select * from Log_swap_room as a join Reservation_room as b on a.id_reservation_room = b.id_reservation_room where b.id_reservation = @id_reservation and a.id_room_new = 0
end

