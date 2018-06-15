CREATE TABLE [dbo].[Organisations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Email] NVARCHAR(MAX) NULL, 
    [Phone] NVARCHAR(MAX) NULL, 
    [Address1] NVARCHAR(MAX) NULL, 
    [Address2] NVARCHAR(MAX) NULL, 
    [Address3] NVARCHAR(MAX) NULL, 
    [City] NVARCHAR(MAX) NULL, 
    [County] NVARCHAR(MAX) NULL, 
    [Postcode] NVARCHAR(MAX) NULL, 
    [Country] NVARCHAR(MAX) NULL, 
    [FkRefStatusId] INT NOT NULL DEFAULT 1,
    CONSTRAINT [FK_Organisations_RefStatus] FOREIGN KEY ([FkRefStatusId]) REFERENCES [RefStatus]([Id])
)
