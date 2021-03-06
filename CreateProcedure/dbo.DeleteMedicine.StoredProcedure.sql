USE [Pharmacy]
GO
/****** Object:  StoredProcedure [dbo].[DeleteMedicine]    Script Date: 06.06.2018 19:09:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteMedicine]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteMedicine] AS' 
END
GO
ALTER PROCEDURE [dbo].[DeleteMedicine] @medicine_name VARCHAR(128)
AS
     DECLARE @succeed INT= 1, @failure INT= 0;
         BEGIN
             BEGIN TRAN tran_DeleteMedicine;
             BEGIN TRY
			  DELETE FROM PurchasedMedicines
			  WHERE medicine_id = (select medicine_id from Medicines where name= @medicine_name)

                 DELETE FROM Medicines
                 WHERE medicine_id = (select medicine_id from Medicines where name = @medicine_name)
                       AND name = @medicine_name;

                 IF(@@ROWCOUNT > 0)
                     BEGIN
                         SELECT @succeed;
                     END;
                     ELSE
                     BEGIN
                         SELECT @failure;
                     END;
                 COMMIT TRAN tran_DeleteMedicine;
             END TRY
             BEGIN CATCH
                 ROLLBACK TRAN tran_DeleteMedicine;
                 SELECT @failure;
             END CATCH;
         END;
GO
