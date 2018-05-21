USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[AddPurchase]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddPurchase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddPurchase] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddPurchase]
	@date DATETIME,
	@pesel VARCHAR(11)
AS
DECLARE @temp TABLE(purchase_id int)
BEGIN
	INSERT INTO [dbo].[Purchases]
           ([date]
           ,[employee_pesel])
    OUTPUT inserted.purchase_id INTO @temp
     VALUES
           (@date,
		  @pesel)

    SELECT purchase_id FROM @temp
END

GO
