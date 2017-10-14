CREATE TABLE [dbo].[BlogPost]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PostName] VARCHAR(MAX) NULL, 
    [PostBody] VARCHAR(MAX) NULL, 
    [HeroImage] VARCHAR(MAX) NULL, 
    [SortOrder] INT NULL
)
