﻿CREATE TABLE [dbo].[Enquiry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FkContactId] INT NOT NULL, 
    [FkOrganisationId] INT NOT NULL, 
    [Summary] VARCHAR(MAX) NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL, 
    [InternalNotes] VARCHAR(MAX) NULL, 
    [Response] VARCHAR(MAX) NULL, 
    [Responder] VARCHAR(MAX) NULL, 
    [ReturnedDate] DATETIME NULL, 
    [FkRefResponseMethodId] INT NULL, 
    [FkRefOutcomeId] INT NULL, 
    [FkRefEnquiryStatusId] INT NOT NULL, 
    [FkUserId] VARCHAR(MAX) NOT NULL, 
    [FkTeamId] INT NOT NULL, 
    [FkEnquiryTypeId] INT NULL, 
    [Date] DATETIME NULL, 
    [DeadlineDate] DATETIME NOT NULL, 
    [FkRelatedProjectId] INT NULL, 
    [FkRelatedReleaseId] INT NULL, 
    [FkRefStatusId] INT NULL DEFAULT 1, 
    CONSTRAINT [FK_Enquiry_Contacts] FOREIGN KEY ([FkContactId]) REFERENCES [Contacts]([Id]), 
    CONSTRAINT [FK_Enquiry_Organisations] FOREIGN KEY ([FkOrganisationId]) REFERENCES [Organisations]([Id]), 
    CONSTRAINT [FK_Enquiry_RefResponseMethod] FOREIGN KEY ([FkRefResponseMethodId]) REFERENCES [RefResponseMethod]([Id]), 
    CONSTRAINT [FK_Enquiry_RefOutcome] FOREIGN KEY ([FkRefOutcomeId]) REFERENCES [RefOutcome]([Id]), 
    CONSTRAINT [FK_Enquiry_RefEnquiryStatus] FOREIGN KEY ([FkRefEnquiryStatusId]) REFERENCES [RefEnquiryStatus]([Id]),
	CONSTRAINT [FK_Enquiry_Team] FOREIGN KEY ([FkTeamId]) REFERENCES [Team]([Id]),
	CONSTRAINT [FK_Enquiry_EnquiryType] FOREIGN KEY ([FkEnquiryTypeId]) REFERENCES [RefEnquiryType]([Id]), 
    CONSTRAINT [FK_Enquiry_RefStatus] FOREIGN KEY ([FkRefStatusId]) REFERENCES [RefStatus]([Id])
)