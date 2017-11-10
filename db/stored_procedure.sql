use hotel

go
--      Strod Procdure of Staff
create proc USP_GetListStaff
as
begin
	select *from Staff
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
	if(exists(select * from staff where username = @username))
		return 1
	else
		return 0
end

exec USP_CheckUserName dinhdinh

exec USP_GetRole dinhdinh

exec USP_EditStaff peterdinh018, dinhdinh, 1, '1997-1-1', 'Viet Nam', '019xxxx', 'abc@gmail.com', null

exec USP_GetListStaff