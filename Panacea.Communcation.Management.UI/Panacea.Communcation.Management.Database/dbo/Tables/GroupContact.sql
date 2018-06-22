CREATE TABLE [dbo].[GroupContact]
(
	[FkGroupId] INT NOT NULL, 
    [FkContactId] INT NOT NULL, 
	PRIMARY KEY([FkGroupId],[FkContactId]),
    CONSTRAINT [FK_GroupContact_Groups] FOREIGN KEY ([FkGroupId]) REFERENCES [Groups]([Id]), 
    CONSTRAINT [FK_GroupContact_Contacts] FOREIGN KEY ([FkContactId]) REFERENCES [Contacts]([Id])
)
