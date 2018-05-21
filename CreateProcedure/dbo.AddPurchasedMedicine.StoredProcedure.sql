USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[AddPurchasedMedicine]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddPurchasedMedicine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddPurchasedMedicine] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddPurchasedMedicine]
	@purchase_id int,
	@medicine_id int,
	@amount int
AS
BEGIN
	INSERT INTO [dbo].[PurchasedMedicines]
           ([purchase_id]
           ,[medicine_id]
           ,[amount]
           ,[unit_price])
     SELECT
            @purchase_id,
		  @medicine_id,
		  @amount,
		  unit_price
		  FROM Medicines
		  WHERE medicine_id = @medicine_id
END

GO
