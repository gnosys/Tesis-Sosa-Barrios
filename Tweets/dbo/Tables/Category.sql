
CREATE TABLE dbo.Category
	(
	Id int NOT NULL,
	Name nvarchar(MAX) NULL,
	[Level] smallint NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC),
	); 