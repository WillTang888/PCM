CREATE TABLE [dbo].[Groups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(MAX) NOT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [DateAdded] DATETIME NOT NULL, 
    [DateModified] DATETIME NOT NULL
)
