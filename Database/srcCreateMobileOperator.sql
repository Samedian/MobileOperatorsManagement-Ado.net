USE [Samarth]
GO

CREATE TABLE [dbo].[MobileOperatorDetail](
	[MobileOperId] [int] IDENTITY(1,1) NOT NULL,
	[MobileOperName] [varchar](20) NULL,
	[Rating] [decimal](18, 0) NULL,
) 

GO

ALTER TABLE [dbo].[MobileOperatorDetail]  
ADD PRIMARY KEY([MobileOperId]);
GO 
ALTER TABLE [dbo].[MobileOperatorDetail]  
ADD UNIQUE ([MobileOperName]);
GO 
ALTER TABLE [dbo].[MobileOperatorDetail]  WITH CHECK ADD CHECK  (([Rating]<=(5)))
GO


