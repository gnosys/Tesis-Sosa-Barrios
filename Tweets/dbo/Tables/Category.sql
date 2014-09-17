
CREATE TABLE dbo.Category
	(
	Id int NOT NULL,
	Name nvarchar(MAX) NULL
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC),
	); 