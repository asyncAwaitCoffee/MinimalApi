﻿CREATE TABLE [MINIMAL_API_DEMO].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(25) NOT NULL, 
    [LastName] NVARCHAR(25) NOT NULL
)
