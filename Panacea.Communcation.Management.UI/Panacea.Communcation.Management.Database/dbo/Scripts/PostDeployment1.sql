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
