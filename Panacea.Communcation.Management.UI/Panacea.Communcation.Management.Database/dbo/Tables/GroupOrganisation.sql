CREATE TABLE [dbo].[GroupOrganisation]
(
	[FkGroupId] INT NOT NULL, 
    [FkOrganisationId] INT NOT NULL, 
	PRIMARY KEY([FkGroupId],[FkOrganisationId]),
    CONSTRAINT [FK_GroupOrganisation_Groups] FOREIGN KEY ([FkGroupId]) REFERENCES [Groups]([Id]), 
    CONSTRAINT [FK_GroupOrganisation_Organisations] FOREIGN KEY ([FkOrganisationId]) REFERENCES [Organisations]([Id])
)
