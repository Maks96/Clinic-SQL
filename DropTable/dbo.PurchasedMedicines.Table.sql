USE [Pharmacy]
GO
ALTER TABLE [dbo].[PurchasedMedicines] DROP CONSTRAINT [FK_purchases_medicines_Purchases]
GO
ALTER TABLE [dbo].[PurchasedMedicines] DROP CONSTRAINT [FK_purchases_medicines_Medicines]
GO
/****** Object:  Table [dbo].[PurchasedMedicines]    Script Date: 16.05.2018 11:18:04 ******/
DROP TABLE [dbo].[PurchasedMedicines]
GO
