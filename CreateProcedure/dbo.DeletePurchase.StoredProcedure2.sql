create procedure [dbo].[DeletePurchase]
@pesel varchar(11),
@date varchar(50)
as
begin
	DECLARE @succeed INT = 1 ,@failure INT = 0
	BEGIN TRAN tran_DeletePurchase
	begin try
		delete from Purchases
		where employee_pesel = @pesel
		and 
		date = convert(datetime, @date)

		if (@@ROWCOUNT > 0)
		begin
		select @succeed;
		end
		else
		begin
		select @failure;
		end
		COMMIT TRAN tran_DeletePurchase
	end try
	begin catch
		ROLLBACK TRAN tran_DeletePurchase

		SELECT @failure;
	end catch
end;