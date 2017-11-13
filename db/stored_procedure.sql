use hotel

go


--      Strod Procdure of Staff
create proc USP_GetListStaff
as
begin
	select *from Staff
end

create proc USP_GetList_Staff_Service
as
begin
	select * from Account where id_type = 0
end


create proc USP_GetProfile
@username varchar(50)
as
begin
	select * from Staff where username=@username
end

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

create proc USP_GetRole
@username varchar(50)
as
begin
	select id_type from Account where username = @username;
end


create proc USP_CheckUserName
@username varchar(50)
as
begin
	select count(*) from Staff where username = @username
end


create proc USP_BanAccount
@username varchar(50)
as
begin
	update Staff set ban_account = 1 where username = @username
end

exec USP_BanAccount dinhdinh

exec USP_GetRole dinhdinh

exec USP_EditStaff peterdinh018, dinhdinh, 1, '1997-1-1', 'Viet Nam', '019xxxx', 'abc@gmail.com', null

exec USP_GetListStaff




-- Stored procedure room

create proc USP_Get_ListRoom_Floor
@floor int
as
begin
	select * from Room join Kind_of_room on Room.id_kind_of_room = Kind_of_room.id where num_floor = @floor
end

create proc USP_GetMaxFloor
as
begin
	select max(num_floor) from Room
end

create proc USP_InsertRoom
@num_floor int ,
@num_order int ,
@id_kind_of_room int,
@staff varchar(50)
as
begin
	insert into Room values(@num_floor, @num_order, @id_kind_of_room, 'false', @staff)
end 

create proc USP_CheckExistsRoom
@num_floor int,
@num_order int
as
begin
	select count(*) from Room where num_floor = @num_floor and num_order = @num_order
end

create proc USP_DeleteRoom
@id_room int
as
begin
	delete from Room where id_room = @id_room
end

create proc USP_EditeRoom
@id_room int,
@id_type int,
@staff varchar(50)
as
begin
	update Room set  id_kind_of_room = @id_type , username = @staff where id_room  = @id_room
end

create proc USP_GetInfoRoom
@id_room int
as
begin
	select * from Room join Kind_of_room on Room.id_kind_of_room = Kind_of_room.id where id_room = @id_room
end

exec USP_GetInfoRoom 1

exec USP_DeleteRoom 43

exec USP_CheckExistsRoom 1,20


exec USP_InsertRoom 3, 7 , 11 , phuc


exec USP_GetMaxFloor
exec USP_Get_ListRoom_Floor @floor=3



--  strore procedure Kind_of_room

create proc USP_GetList_Kindofroom
as
begin
	select * from Kind_of_room
end


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

create proc USP_DelKindofRoom
@id int
as
begin
	delete from Kind_of_room where id = @id
end

exec USP_DelKindofRoom 13

exec USP_UpdateKindofRoom 13, test2, 2,3

exec USP_InsertKindofRoom test, 123, 1

exec USP_GetList_Kindofroom



-- Stored Procedure Insert Data

