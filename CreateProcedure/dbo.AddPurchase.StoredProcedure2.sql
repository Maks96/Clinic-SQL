create procedure AddPurchase
@pesel varchar(11)
as
begin
	DECLARE @succeed INT = 1 ,@failure INT = 0
	BEGIN TRAN tran_AddPurchase
	begin try
		insert into Purchases
		values
		(
			GETDATE(),
			@pesel
		)
		
		COMMIT TRAN tran_AddPurchase
		SELECT @succeed
	end try
	begin catch
		ROLLBACK TRAN tran_AddPurchase

		SELECT @failure;
	end catch
end;

drop procedure AddPurchase

execute AddPurchase '123';