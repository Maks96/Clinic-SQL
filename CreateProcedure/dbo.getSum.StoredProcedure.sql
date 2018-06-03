create procedure getSum
@id int
as
select sum(price_sum) from PurchasedMedicines
where purchase_id = @id
group by purchase_id
