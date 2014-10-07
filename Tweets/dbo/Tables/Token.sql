CREATE TABLE [dbo].[Token]
(
	Id int IDENTITY(1,1) NOT NULL,
	[Text] nvarchar(MAX) NULL,
	idPipe varchar(max) not null,
	idTweet int not null,
	CONSTRAINT [PK_Token] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT FK_Token_Tweet FOREIGN KEY (idTweet) 
    REFERENCES Tweet (Id) 
    ON DELETE CASCADE
    ON UPDATE CASCADE
)
