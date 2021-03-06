USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateEmployee]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateEmployee] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateEmployee]
     @pesel VARCHAR(11),
	@first_name VARCHAR(128),
	@last_name VARCHAR(128),
	@address VARCHAR(256),
	@telephone_number VARCHAR(16),
	@city VARCHAR(64)
AS
BEGIN
    UPDATE Employees
    SET first_name = @first_name, last_name = @last_name, address = @address, telephone_number = @telephone_number, city = @city
    WHERE pesel = @pesel;
END

GO
