CREATE PROCEDURE [MINIMAL_API_DEMO].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS begin
	insert into MINIMAL_API_DEMO.[User](FirstName, LastName)
	values(@FirstName, @LastName)
end