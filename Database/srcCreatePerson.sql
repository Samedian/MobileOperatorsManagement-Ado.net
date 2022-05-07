USE [Samarth]
GO

CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[PersonName] [varchar](20) NULL,
	[MobileOperatorId] [int] NULL,
) 
GO
ALTER TABLE [dbo].[Person]
ADD PRIMARY KEY (PersonID);

ALTER TABLE [dbo].[Person]  WITH CHECK ADD FOREIGN KEY([MobileOperatorId])
REFERENCES [dbo].[MobileOperatorDetail] ([MobileOperId])
GO


