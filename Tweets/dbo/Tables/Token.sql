CREATE TABLE [dbo].[Token]
(
	Id int NOT NULL,
	[Text] nvarchar(MAX) NULL,
	idPipe int not null,
	idTweet int not null,
	CONSTRAINT [PK_Token] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT FK_Token_Tweet FOREIGN KEY (idTweet) 
    REFERENCES Tweet (Id) 
    ON DELETE CASCADE
    ON UPDATE CASCADE,
	CONSTRAINT FK_Token_Pipe FOREIGN KEY (idPipe) 
    REFERENCES Pipe (Id) 
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
