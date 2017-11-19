use hotel

go

create proc USP_GetListReservation
as 
begin
	select * from Reservation
end	


go 

create proc USP_GetInfoReservation
@id_reservation int
as
begin
	select * from (Reservation as a join Customer as b on a.id_customer = b.id_customer) join Staff as c on a.username = c.username where id_reservation = @id_reservation
end

exec USP_GetInfoReservation @id_reservation= 1
go

CREATE PROC USP_InsertReservation
@id_customer int,
@status_reservation int,
@is_group bit,
@people int,
@username VARCHAR(50),
@locked bit,
@note NVARCHAR(1000),
@start_date datetime,
@end_date datetime,
@created  datetime,
@status int,
@id_room INT
AS
BEGIN 
	set @status_reservation = 2
	set @locked = 0
	set @note = GETDATE() + ': Insert Reservation is system'
	INSERT into Reservation VALUES(@id_customer, @status_reservation, @is_group, @people, @username, @locked, @note)
	DECLARE @id_reservation INT
	select @id_reservation = @@IDENTITY

	set @start_date = GETDATE()
	set @created = GETDATE()
	set @status = 0

	if(@end_date > @start_date)
	BEGIN
		INSERT into Calendar VALUES (@id_reservation, @start_date, @end_date, @created, @status );
	END

	-- Xu ly insert danh sach phong 
	
	-- Xu lu locked cac phong trong danh sach 

END


go

CREATE PROC USP_CancelReservation
@id_reservation INT
as
BEGIN
	DECLARE @note NVARCHAR(1000);
	SELECT @note = note FROM Reservation WHERE id_reservation = @id_reservation
	@note = @note + '\n' + GETDATE() + ': Cancel reservation'
	Update Reservation set status_reservation = 0, locked = 1 , note = @note where id_reservation = @id_reservation
	update Calendar set status = 0  where id_reservation = @id_reservation;
	update Reservation_room set using = 0 where id_reservation = @id_reservation
	update Room set locked = 0 where id_room in (select id_room from Reservation_room where id_reservation = @id_reservation)
END

select * from Reservation
select * from Calendar
SELECT * from Reservation_room
SELECT * from Room
SELECT GETDATE()

SELECT * from sys.tables