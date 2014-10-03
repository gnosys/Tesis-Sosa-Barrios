CREATE TABLE [dbo].[Tweet] (
	Id int NOT NULL,
	Tweet_Id nvarchar(50) NULL,
	Author nvarchar(50) NULL,
	Entity_Id nvarchar(50) NULL,
	Category nvarchar(MAX) NULL,
	Text nvarchar(MAX) NULL,
    CONSTRAINT [PK_Tweet] PRIMARY KEY CLUSTERED ([Id] ASC),
);

