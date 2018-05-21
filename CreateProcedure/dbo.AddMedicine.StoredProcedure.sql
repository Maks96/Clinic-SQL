USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[AddMedicine]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddMedicine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddMedicine] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddMedicine]
	-- Add the parameters for the stored procedure here
	@name VARCHAR(128),
	@description VARCHAR(512),
	@unit_price MONEY,
	@unit_price_change_date DATETIME
AS
DECLARE @temp TABLE(employye_id int)
BEGIN
	INSERT INTO [dbo].[Medicines]
           ([name]
           ,[description]
           ,[unit_price]
           ,[unit_price_change_date])
     VALUES
           (@name ,
		  @description,
		  @unit_price ,
		  @unit_price_change_date)
END

GO
