
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

-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Author, , Name>
-- Create Date: <Create Date, , >
-- Description: <Description, , >
-- =============================================
CREATE PROCEDURE order_validate_number
(
	@Number varchar(255),
	@NumberO nvarchar(255) output,
	@errorIdDB int output,
	@ErrorFromDB VARCHAR(255) output
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON
	SET @NumberO = NULL;
	SET @errorIdDB = 0;
	SET @ErrorFromDB = '';

    -- Insert statements for procedure here
    SELECT @NumberO = Number --, @Status = Status
	FROM Users 
	WHERE Number = @Number AND Status = 1;

	IF @NumberO IS NULL
	BEGIN
		SET @errorIdDB = ERROR_NUMBER(); -- or any appropriate error code
		SET @ErrorFromDB = 'No user found with the provided credentials.';
	END
END
GO
-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
-- =======================================================
-- Create Stored Procedure Template for Azure SQL Database
-- =======================================================
/****** Object:  StoredProcedure [dbo].[order_validate_product]    Script Date: 3/17/2024 7:58:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      <Author, , Name>
-- Create Date: <Create Date, , >
-- Description: <Description, , >
-- =============================================
ALTER PROCEDURE [dbo].[order_validate_product]
    -- Add the parameters for the stored procedure her
(
	@IdProducto int,
	@Cantidad int,
	@Existe bit output,
	@errorIdDB int output,
	@ErrorFromDB VARCHAR(255) output
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON
	SET @Existe = 0;
	SET @errorIdDB = 0;
	SET @ErrorFromDB = '';

	SELECT @IdProducto = idProducto, @Cantidad = Cantidad
	FROM Productos
	WHERE idProducto = @IdProducto AND Cantidad <= @Cantidad;

 IF @@ROWCOUNT > 0
    BEGIN
        SET @Existe = 1;
    END
    ELSE
    BEGIN
        -- No rows were returned, set @Existe to 0 and capture error information
        SET @Existe = 0;
        SET @errorIdDB = ERROR_NUMBER();
        SET @ErrorFromDB = ERROR_MESSAGE();
    END
END
