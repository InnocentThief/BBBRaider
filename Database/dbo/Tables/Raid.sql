CREATE TABLE [dbo].[Raid] (
    [RaidKey] UNIQUEIDENTIFIER NOT NULL,
    [Name]    NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Raid] PRIMARY KEY CLUSTERED ([RaidKey] ASC)
);



