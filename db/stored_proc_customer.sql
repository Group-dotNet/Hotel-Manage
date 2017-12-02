use hotel

Go

create proc USP_GetList
AS
BEGIN
    select * from Customer where id_history = 1 order by id_customer desc
end

GO

create proc USP_GetInfo
@id_customer int 
AS
BEGIN
    select * from Customer where id_customer = @id_customer
END


GO

CREATE PROC USP_InsertCustomer
@name NVARCHAR(100),
@sex bit,
@identity_card VARCHAR(20),
@address nvarchar(200),
@email varchar(80),
@phone varchar(11),
@company nvarchar(50),
@id_history int
as 
BEGIN
    INSERT into Customer VALUEs(@name, @sex, @identity_card, @address, @email, @phone, @company, 0)
end

go

CREATE PROC USP_EditCustomer
@id_customer int,
@name NVARCHAR(100),
@sex bit,
@identity_card VARCHAR(20),
@address nvarchar(200),
@email varchar(80),
@phone varchar(11),
@company nvarchar(50)
as
BEGIN
    update Customer set name=@name, sex= @sex, identity_card = @identity_card, address = @address, email = @email, phone = @phone, company = @company where id_customer = @id_customer
END 

GO

CREATE PROC USP_SearchCustomer
@keyword NVARCHAR(200),
@type INT
as
 BEGIN
    if(@type = 0)  select * from Customer WHERE id_customer like '%' + @keyword +'%' or name like '%' + @keyword + '%' or identity_card like '%' + @keyword + '%' or address like '%' + @keyword + '%' or email like '%' + @keyword + '%' or  phone like '%' + @keyword + '%' or  company like '%' + @keyword + '%'
    if(@type = 1)  select * from Customer where id_customer like '%' + @keyword +'%'
    if(@type = 2)  select * from Customer where name like '%' + @keyword + '%'
    if(@type = 3) 
        BEGIN
            DECLARE @logic bit
            if (@keyword = 'Men' or @keyword = 'men') 
                set @logic = 1
            if (@keyword = 'Woman' or @keyword = 'woman') 
                set @logic = 0
            select * from Customer WHERE sex = @logic
        END
    if(@type = 4)  SELECT * from Customer WHERE identity_card like '%' + @keyword + '%'
    if(@type = 5)  SELECT * from Customer WHERE address like '%' + @keyword + '%'
    if(@type = 6)  select * from Customer WHERE email like '%' + @keyword + '%'
    if(@type = 7)  SELECT * from Customer WHERE phone like '%' + @keyword + '%'
    if(@type = 8)  SELECT * from Customer where company like '%' + @keyword + '%'
 END


 go 


CREATE PROC USP_GetMoneyCustomer
@id_customer int 
AS
BEGIN
    select count(total_money) from Bill WHERE id_bill in (select id_reservation from Reservation where id_customer = @id_customer)
END 

GO

CREATE PROC USP_GetCustomerBan
AS
BEGIN 
    SELECT * from Customer where id_history = 1
END

go

Create Proc USP_UnLockCustomer
@id_customer int
as
begin
	Update Customer set id_history = 0 where id_customer = @id_customer
end

go

create proc USP_LockCustomer
@id_customer int
as
begin
	Update Customer set id_history = 1 where id_customer = @id_customer
end