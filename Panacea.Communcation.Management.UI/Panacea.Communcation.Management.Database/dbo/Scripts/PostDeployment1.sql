/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT [RefStatus] ON

MERGE INTO [RefStatus] AS Target
USING (VALUES 
(1, 'Active'), 
(2, 'Deleted')
)
AS Source (ID, Description)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ID, Description)
VALUES (ID, Description);

SET IDENTITY_INSERT [RefStatus] OFF

--------------------------------------------------------------------------------------

SET IDENTITY_INSERT [RefResponseMethod] ON

MERGE INTO [RefResponseMethod] AS Target
USING (VALUES 
(1, 'Phone'), 
(2, 'Email'),
(3, 'Letter')
)
AS Source (ID, Description)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ID, Description)
VALUES (ID, Description);

SET IDENTITY_INSERT [RefResponseMethod] OFF

--------------------------------------------------------------------------------------

SET IDENTITY_INSERT [RefOutcome] ON

MERGE INTO [RefOutcome] AS Target
USING (VALUES 
(1, 'Information Provided'), 
(2, 'Interview'),
(3, 'Article'),
(4, 'Filming'),
(5, 'Spiked'),
(6, 'Declined'),
(7, 'Passed to other Organisation'),
(8, 'We did not meet deadline'),
(9, 'Officer did not meet deadline'),
(10, 'Other'),
(11, 'Statement'),
(12, 'Broadcast'),
(13, 'Expired')
)
AS Source (ID, Description)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ID, Description)
VALUES (ID, Description);

SET IDENTITY_INSERT [RefOutcome] OFF

--------------------------------------------------------------------------------------

SET IDENTITY_INSERT [RefEnquiryStatus] ON

MERGE INTO [RefEnquiryStatus] AS Target
USING (VALUES 
(1, 'Outstanding'), 
(2, 'Complete')
)
AS Source (ID, Description)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ID, Description)
VALUES (ID, Description);

SET IDENTITY_INSERT [RefEnquiryStatus] OFF

--------------------------------------------------------------------------------------

SET IDENTITY_INSERT [Team] ON

MERGE INTO [Team] AS Target
USING (VALUES 
(1, 'Communications', 'Communications Team'), 
(2, 'Team 2', 'Team 2')
)
AS Source (ID, Name, Description)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ID, Name, Description)
VALUES (ID, Name, Description);

SET IDENTITY_INSERT [Team] OFF

--------------------------------------------------------------------------------------

SET IDENTITY_INSERT [RefEnquiryType] ON

MERGE INTO [RefEnquiryType] AS Target
USING (VALUES 
(1, 'Enquiry Type AAA'), 
(2, 'Enquiry Type BBB'),
(3, 'Enquiry Type BBB')
)
AS Source (ID, Description)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (ID, Description)
VALUES (ID, Description);

SET IDENTITY_INSERT [RefEnquiryType] OFF

