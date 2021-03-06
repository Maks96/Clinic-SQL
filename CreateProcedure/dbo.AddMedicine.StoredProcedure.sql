USE [Pharmacy];
GO

/****** Object:  StoredProcedure [dbo].[AddMedicine]    Script Date: 21.05.2018 21:13:32 ******/

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
IF NOT EXISTS
(
    SELECT *
    FROM sys.objects
    WHERE object_id = OBJECT_ID(N'[dbo].[AddMedicine]')
          AND type IN(N'P', N'PC')
)
    BEGIN
        EXEC dbo.sp_executesql
             @statement = N'CREATE PROCEDURE [dbo].[AddMedicine] AS';
    END;
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AddMedicine]
	-- Add the parameters for the stored procedure here
@name                   VARCHAR(128),
@description            VARCHAR(512),
@unit_price             MONEY
AS
     DECLARE @succeed INT= 1, @failure INT= 0;
         BEGIN             
             BEGIN TRAN tran_AddMedicine;
             BEGIN TRY
                 INSERT INTO [dbo].[Medicines]
				([name],
				 [description],
				 [unit_price],
				 [unit_price_change_date]
				)
                 VALUES
				(@name,
				 @description,
				 @unit_price,
				 getdate()
				);
                 COMMIT TRAN tran_AddMedicine;
                 SELECT @succeed;
             END TRY
             BEGIN CATCH
                 ROLLBACK TRAN tran_AddMedicine;
                 SELECT @failure;
             END CATCH;
         END;
GO
