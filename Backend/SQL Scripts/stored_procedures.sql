
---STORED PROCEDURES
--CREAR USUARIOS
--CREAR USUARIOS
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[insertar_usuario]
	(
		@Name varchar(255),
		@Number varchar(255),
		@Email varchar(255),
		@Password varchar(255),
		@TypeU char,
		@Status bit,
		@IdUser int output,
		@errorIdDB int output,
		@ErrorFromDB VARCHAR(255) output
	)
AS
BEGIN

	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert Into Users(Name,Number,Email,Password,TypeU, Status)	
	Values(@Name,@Number,@Email,@Password,@TypeU,@Status)

        -- Capture the auto-generated ID and assign it to the @IdUser variable
    SET @IdUser = SCOPE_IDENTITY();

        -- Set error-related output parameters to default values
    SET @errorIdDB = ERROR_NUMBER();
    SET @ErrorFromDB = ERROR_MESSAGE();
END 


--LOGIN
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter PROCEDURE [dbo].[login]
	(
	 @Number nvarchar(50),
	 @Password nvarchar(50),
	 @Name nvarchar(255) output,
	 @Status bit output,
	 @TypeU bit output,
	 @errorIdDB int output,
	 @ErrorFromDB VARCHAR(255) output
	)
AS
BEGIN
	SET NOCOUNT ON;

	-- Initialize output parameters
	SET @Name = NULL;
	SET @errorIdDB = 0;
	SET @ErrorFromDB = '';

	-- Retrieve the name if the number, password, and status are fine
	SELECT @Name = Name --, @Status = Status
	FROM Users 
	WHERE Number = @Number AND Password = @Password AND Status = 1;

	-- Check if no records found
	IF @Name IS NULL
	BEGIN
		SET @errorIdDB = ERROR_NUMBER(); -- or any appropriate error code
		SET @ErrorFromDB = 'No user found with the provided credentials.';
	END
	--IF @Status = 0
	--BEGIN
	--	SET @errorIdDB = ERROR_NUMBER(); -- or any appropriate error code
	--	SET @ErrorFromDB = 'The user is not active';
	--END
	
END
GO