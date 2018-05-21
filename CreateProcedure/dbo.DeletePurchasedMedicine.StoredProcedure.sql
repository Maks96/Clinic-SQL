USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[DeletePurchasedMedicine]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletePurchasedMedicine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeletePurchasedMedicine] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[DeletePurchasedMedicine]
	@purchase_id int,
	@medicine_id int
AS
BEGIN
	DELETE FROM PurchasedMedicines
	WHERE purchase_id = @purchase_id AND medicine_id = @medicine_id
END

GO
