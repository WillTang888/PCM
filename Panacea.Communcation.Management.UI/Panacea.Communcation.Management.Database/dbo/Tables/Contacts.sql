CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[FkOrganisationId] INT NULL, 
    [Title] NVARCHAR(MAX) NOT NULL, 
    [FirstName] NVARCHAR(MAX) NOT NULL, 
    [LastName] NVARCHAR(MAX) NOT NULL, 
    [JobTitle] NVARCHAR(MAX) NOT NULL, 
    [Email] NVARCHAR(MAX) NOT NULL, 
    [Phone] NVARCHAR(MAX) NULL, 
    [Mobile] NVARCHAR(MAX) NULL, 
    [Address1] NVARCHAR(MAX) NULL, 
    [Address2] NVARCHAR(MAX) NULL, 
    [Address3] NVARCHAR(MAX) NULL, 
    [City] NVARCHAR(MAX) NULL, 
    [County] NVARCHAR(MAX) NULL, 
    [Postcode] NVARCHAR(MAX) NULL, 
    [Country] INT NULL, 
    [FkRefStatusId] INT NOT NULL DEFAULT 1,
	CONSTRAINT [FK_Contacts_Organisations] FOREIGN KEY ([FkOrganisationId]) REFERENCES [Organisations]([Id]),
    CONSTRAINT [FK_Contacts_RefStatus] FOREIGN KEY ([FkRefStatusId]) REFERENCES [RefStatus]([Id])
  
)
