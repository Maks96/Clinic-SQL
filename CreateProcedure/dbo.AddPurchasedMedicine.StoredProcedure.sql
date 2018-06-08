create procedure [dbo].[AddMedicineToPurchase]
@id int,
@name varchar(128),
@amount int
as
begin
	DECLARE @succeed INT = 1 ,@failure INT = 0
	BEGIN TRAN tran_AddMedicineToPurchase
	begin try
		insert into PurchasedMedicines
		values
		(
			@id,
			(select medicine_id from Medicines where name = @name),
			@amount,
			(select (@amount * unit_price) from Medicines where medicine_id = (select medicine_id from Medicines where name = @name))
		)
		
		COMMIT TRAN tran_AddMedicineToPurchase
		SELECT @succeed
	end try
	begin catch
		ROLLBACK TRAN tran_AddMedicineToPurchase

		SELECT @failure;
	end catch
end;