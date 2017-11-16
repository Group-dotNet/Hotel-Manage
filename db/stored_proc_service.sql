USE hotel

go 


CREATE PROC GetListService
as
BEGIN
    SELECT * from service
end

GO

create proc GetInfoService
@id_service INT
AS
BEGIN
    select * from Service where id_service = @id_service
END


go

create PROC InsertService
@name_service NVARCHAR(100),
@price money,
@unit INT
AS
BEGIN
    INSERT into Service VALUES(@name_service , @price, @unit)
END

GO

CREATE PROC EditService
@id_service int,
@name_service NVARCHAR(100),
@price money,
@unit INT
AS
BEGIN
    update Service SET name_service = @name_service , price = @price , unit = @unit WHERE id_service = @id_service
END

GO

CREATE PROC DelService
@id_service INT
AS
BEGIN
    DELETE from Service where id_service = @id_service
END

GO

CREATE PROC SearchService
@keyword NVARCHAR(200),
@type INT
as
BEGIN
    if(@type = 0) select * from Service WHERE  id_service like '%' + @keyword + '%' or  name_service like '%' + @keyword + '%' or price like '%' + @keyword + '%' or unit like '%' + @keyword + '%'
    if(@type = 1) SELECT * from Service WHERE id_stuff like '%' + @keyword + '%'
    if(@type = 2) SELECT * from Service WHERE name_stuff like '%' + @keyword + '%'
    if(@type = 3) SELECT * from Service WHERE price like '%' + @keyword + '%'
    if(@type = 4) SELECT * from Service WHERE unit like '%' + @keyword + '%'
end

SELECT * from service