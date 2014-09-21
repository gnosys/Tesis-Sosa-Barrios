
CREATE TABLE dbo.Pipe
(
	Id int NOT NULL,
	FiltersConfiguration nvarchar(MAX) NULL,
	Metric1 decimal (18,2) NOT NULL,
	CONSTRAINT [PK_Pipe] PRIMARY KEY CLUSTERED ([Id] ASC),
); 