CREATE TABLE [dbo].[EncounterPosition] (
    [EncounterPositionKey] UNIQUEIDENTIFIER NOT NULL,
    [Name]                 NVARCHAR (50)    NOT NULL,
    [SortOrder]            INT              NOT NULL,
    [Description]          TEXT             NOT NULL,
    [EncounterKey]         UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_EncounterPosition] PRIMARY KEY CLUSTERED ([EncounterPositionKey] ASC),
    CONSTRAINT [FK_EncounterPosition_Encounter] FOREIGN KEY ([EncounterKey]) REFERENCES [dbo].[Encounter] ([EncounterKey])
);



