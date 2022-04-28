CREATE TABLE [dbo].[file]
(
	[Idfile] BIGINT NOT NULL PRIMARY KEY, 
    [idproject] VARCHAR(50) NULL, 
    [srcimagetarget] VARCHAR(50) NULL, 
    [newimagetarget] VARCHAR(50) NULL
)
