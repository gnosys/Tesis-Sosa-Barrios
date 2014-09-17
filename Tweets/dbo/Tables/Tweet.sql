CREATE TABLE [dbo].[Tweet] (
	Id int NOT NULL,
	Tweet_Id nvarchar(50) NULL,
	Author nvarchar(50) NULL,
	Entity_Id nvarchar(50) NULL,
	Category nvarchar(MAX) NULL,
	Text nvarchar(MAX) NULL,
	Id_Category int NULL,
    CONSTRAINT [PK_Tweet] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT FK_Tweet_Category FOREIGN KEY (Id_Category) 
    REFERENCES Category (Id) 
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

