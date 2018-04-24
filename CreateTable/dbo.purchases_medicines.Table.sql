USE [Pharmacy]
GO
/****** Object:  Table [dbo].[Purchases_Medicines]    Script Date: 24.04.2018 15:36:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases_Medicines](
	[purchase_id] [int] NOT NULL,
	[medicine_id] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[price_sum] [money] NOT NULL,
 CONSTRAINT [PK_purchases_medicines] PRIMARY KEY CLUSTERED 
(
	[purchase_id] ASC,
	[medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Purchases_Medicines]  WITH CHECK ADD  CONSTRAINT [FK_purchases_medicines_Medicines] FOREIGN KEY([medicine_id])
REFERENCES [dbo].[Medicines] ([medicine_id])
GO
ALTER TABLE [dbo].[Purchases_Medicines] CHECK CONSTRAINT [FK_purchases_medicines_Medicines]
GO
ALTER TABLE [dbo].[Purchases_Medicines]  WITH CHECK ADD  CONSTRAINT [FK_purchases_medicines_Purchases] FOREIGN KEY([purchase_id])
REFERENCES [dbo].[Purchases] ([purchase_id])
GO
ALTER TABLE [dbo].[Purchases_Medicines] CHECK CONSTRAINT [FK_purchases_medicines_Purchases]
GO
