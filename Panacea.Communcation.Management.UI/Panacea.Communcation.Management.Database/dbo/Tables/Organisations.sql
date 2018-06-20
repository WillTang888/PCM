CREATE TABLE [dbo].[Organisations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(MAX) NOT NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [Phone] VARCHAR(MAX) NULL, 
    [Address1] VARCHAR(MAX) NULL, 
    [Address2] VARCHAR(MAX) NULL, 
    [Address3] VARCHAR(MAX) NULL, 
    [City] VARCHAR(MAX) NULL, 
    [County] VARCHAR(MAX) NULL, 
    [Postcode] VARCHAR(MAX) NULL, 
    [Country] VARCHAR(MAX) NULL, 
    [FkRefStatusId] INT NOT NULL DEFAULT 1,
    [DateAdded] DATETIME NOT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Website] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Organisations_RefStatus] FOREIGN KEY ([FkRefStatusId]) REFERENCES [RefStatus]([Id])
)
