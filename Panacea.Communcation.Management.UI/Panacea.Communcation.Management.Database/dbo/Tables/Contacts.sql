CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FkOrganisationId] INT NULL, 
    [Title] VARCHAR(MAX) NOT NULL, 
    [FirstName] VARCHAR(MAX) NOT NULL, 
    [LastName] VARCHAR(MAX) NOT NULL, 
    [JobTitle] VARCHAR(MAX) NOT NULL, 
    [Email] VARCHAR(MAX) NOT NULL, 
    [Phone] VARCHAR(MAX) NULL, 
    [Mobile] VARCHAR(MAX) NULL, 
    [Address1] VARCHAR(MAX) NULL, 
    [Address2] VARCHAR(MAX) NULL, 
    [Address3] VARCHAR(MAX) NULL, 
    [City] VARCHAR(MAX) NULL, 
    [County] VARCHAR(MAX) NULL, 
    [Postcode] VARCHAR(MAX) NULL, 
    [Country] VARCHAR(MAX) NULL, 
    [FkRefStatusId] INT NOT NULL DEFAULT 1,
	[DateAdded] DATETIME NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Contacts_Organisations] FOREIGN KEY ([FkOrganisationId]) REFERENCES [Organisations]([Id]),
    CONSTRAINT [FK_Contacts_RefStatus] FOREIGN KEY ([FkRefStatusId]) REFERENCES [RefStatus]([Id])
  
)
