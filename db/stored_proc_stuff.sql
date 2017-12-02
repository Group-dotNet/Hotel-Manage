use hotel

go 


CREATE PROC USP_GetListStuff
as
BEGIN 
    select * from Stuff where locked = 0 order by id_stuff desc
END


go

create proc USP_GetListStuffLock
as
begin
	select * from Stuff where locked = 1 order by id_stuff desc
end

GO

CREATE PROC USP_GetInfoStuff
@id_stuff INT
as
BEGIN 
    SELECT * from Stuff WHERE id_stuff = @id_stuff
END

GO

create PROC USP_InsertStuff
@name NVARCHAR (100)
as
BEGIN
    insert into Stuff VALUES(@name, 0)
end

go 

CREATE PROC USP_UpdateStuff
@id_stuff int, 
@name NVARCHAR (100)
AS
BEGIN
    update Stuff set name_stuff = @name WHERE id_stuff = @id_stuff
END

GO

CREATE PROC USP_LockStuff
@id_stuff int
AS
BEGIN 
	update Stuff set locked = 1 where id_stuff = @id_stuff
END

go

CREATE PROC USP_SearchStuff
@keyword NVARCHAR(200),
@type INT
as
BEGIN
    if(@type = 0) select  * from Stuff WHERE  id_stuff like '%' + @keyword + '%' or  name_stuff like '%' + @keyword + '%' and locked = 0
    if(@type = 1) SELECT * from Stuff WHERE id_stuff like '%' + @keyword + '%' and locked = 0
    if(@type = 2) SELECT * from Stuff WHERE name_stuff like '%' + @keyword + '%' and locked = 0
end

