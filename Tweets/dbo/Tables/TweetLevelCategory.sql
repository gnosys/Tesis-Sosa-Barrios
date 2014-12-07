CREATE TABLE [dbo].[TweetLevelCategory] (
	Id int NOT NULL,
	IdTweet int NOT NULL,
	IdCategory int NOT NULL,
    CONSTRAINT [PK_TweetLevelCategory] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT FK_TweetLevelCategory_Tweet FOREIGN KEY (IdTweet) 
    REFERENCES Tweet (Id) 
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
	CONSTRAINT FK_TweetLevelCategory_Category FOREIGN KEY (IdCategory) 
    REFERENCES Category (Id) 
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
	CONSTRAINT UQ_TweetLevelCategory UNIQUE (IdTweet,IdCategory)

);

