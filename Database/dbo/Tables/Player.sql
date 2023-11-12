CREATE TABLE [dbo].[Player] (
    [PlayerKey] UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (50)    NOT NULL,
    CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED ([PlayerKey] ASC)
);

