CREATE TABLE [dbo].[Tweet] (
    [Id]        INT            NOT NULL,
    [Tweet_Id]  NVARCHAR (50)  NULL,
    [Author]    NVARCHAR (50)  NULL,
    [Entity_Id] NVARCHAR (50)  NULL,
    [Category]  NVARCHAR (MAX) NULL,
    [Text]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Tweet] PRIMARY KEY CLUSTERED ([Id] ASC)
);

