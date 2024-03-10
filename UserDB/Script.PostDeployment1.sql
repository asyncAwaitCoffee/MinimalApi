if not exists (select 1 from MINIMAL_API_DEMO.[User])
begin
	insert into [MINIMAL_API_DEMO].[User](FirstName, LastName)
	values ('Tom', 'Bom-bom'),
	('John', 'Smith'),
	('Kate', 'Pepper')
end
GO