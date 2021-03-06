USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[getMedicines]    Script Date: 16.05.2018 11:25:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getMedicines]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[getMedicines] AS' 
END
GO
ALTER PROCEDURE [dbo].[getMedicines]
AS
BEGIN
    SELECT
	   medicine_id,
	   name,
	   description,
	   unit_price,
	   unit_price_change_date
    FROM Medicines
END
GO
