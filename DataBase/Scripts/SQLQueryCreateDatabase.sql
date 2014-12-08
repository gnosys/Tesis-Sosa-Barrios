/*
Deployment script for Tweets

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
PRINT N'Creating [dbo].[Category]...';


GO
CREATE TABLE [dbo].[Category] (
    [Id]    INT            NOT NULL,
    [Name]  NVARCHAR (MAX) NULL,
    [Level] SMALLINT       NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Token]...';


GO
CREATE TABLE [dbo].[Token] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Text]    NVARCHAR (MAX) NULL,
    [idPipe]  VARCHAR (MAX)  NOT NULL,
    [idTweet] INT            NOT NULL,
    CONSTRAINT [PK_Token] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Tweet]...';


GO
CREATE TABLE [dbo].[Tweet] (
    [Id]        INT            NOT NULL,
    [Tweet_Id]  NVARCHAR (50)  NULL,
    [Author]    NVARCHAR (50)  NULL,
    [Entity_Id] NVARCHAR (50)  NULL,
    [Category]  NVARCHAR (MAX) NULL,
    [Text]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Tweet] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[TweetLevelCategory]...';


GO
CREATE TABLE [dbo].[TweetLevelCategory] (
    [Id]         INT NOT NULL,
    [IdTweet]    INT NOT NULL,
    [IdCategory] INT NOT NULL,
    CONSTRAINT [PK_TweetLevelCategory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_TweetLevelCategory] UNIQUE NONCLUSTERED ([IdTweet] ASC, [IdCategory] ASC)
);


GO
PRINT N'Creating FK_Token_Tweet...';


GO
ALTER TABLE [dbo].[Token] WITH NOCHECK
    ADD CONSTRAINT [FK_Token_Tweet] FOREIGN KEY ([idTweet]) REFERENCES [dbo].[Tweet] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE;


GO
PRINT N'Creating FK_TweetLevelCategory_Tweet...';


GO
ALTER TABLE [dbo].[TweetLevelCategory] WITH NOCHECK
    ADD CONSTRAINT [FK_TweetLevelCategory_Tweet] FOREIGN KEY ([IdTweet]) REFERENCES [dbo].[Tweet] ([Id]);


GO
PRINT N'Creating FK_TweetLevelCategory_Category...';


GO
ALTER TABLE [dbo].[TweetLevelCategory] WITH NOCHECK
    ADD CONSTRAINT [FK_TweetLevelCategory_Category] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Category] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Token] WITH CHECK CHECK CONSTRAINT [FK_Token_Tweet];

ALTER TABLE [dbo].[TweetLevelCategory] WITH CHECK CHECK CONSTRAINT [FK_TweetLevelCategory_Tweet];

ALTER TABLE [dbo].[TweetLevelCategory] WITH CHECK CHECK CONSTRAINT [FK_TweetLevelCategory_Category];


GO
PRINT N'Update complete.'
GO
