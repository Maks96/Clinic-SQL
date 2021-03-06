USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[getOverallPriceForPurchase]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getOverallPriceForPurchase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[getOverallPriceForPurchase] AS' 
END
GO
-- Alter Procedure getOverallPriceForPurchase
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[getOverallPriceForPurchase]
	-- Add the parameters for the stored procedure here
	@purchase_id int
	
AS
BEGIN
	SELECT SUM(amount * unit_price) AS overall_price FROM PurchasedMedicines
	WHERE purchase_id = @purchase_id;
END

GO
