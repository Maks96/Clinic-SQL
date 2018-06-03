create procedure [dbo].[DeleteMedicineFromPurchase]
@id int,
@name varchar(128),
@amount int
as
begin
	DECLARE @succeed INT = 1 ,@failure INT = 0
	BEGIN TRAN tran_DeleteMedicineFromPurchase
	begin try
		delete from PurchasedMedicines
		where purchase_id = @id
		and 
		medicine_id = (select medicine_id from Medicines where name = @name)
		and
		amount = @amount

		if (@@ROWCOUNT > 0)
		begin
		select @succeed;
		end
		else
		begin
		select @failure;
		end
		COMMIT TRAN tran_DeleteMedicineFromPurchase
	end try
	begin catch
		ROLLBACK TRAN tran_DeleteMedicineFromPurchase

		SELECT @failure;
	end catch
end;