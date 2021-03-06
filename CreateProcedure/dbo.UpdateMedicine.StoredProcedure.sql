USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[UpdateMedicine]    Script Date: 21.05.2018 21:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateMedicine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateMedicine] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateMedicine]
     @medicineId int,
     @name VARCHAR(128),
	@description VARCHAR(512),
	@unit_price MONEY
AS
DECLARE @oldval MONEY
BEGIN
    UPDATE Medicines
    SET name = @name, description = @description
    WHERE medicine_id = @medicineId;

    SELECT @oldval = unit_price FROM Medicines
    WHERE medicine_id = @medicineId;

    UPDATE Medicines
    SET unit_price = @unit_price, unit_price_change_date = GETDATE()
    WHERE medicine_id = @medicineId AND @unit_price <> @oldval;

END

GO
