CREATE TABLE [dbo].[Encounter] (
    [EncounterKey] UNIQUEIDENTIFIER NOT NULL,
    [Name]         NVARCHAR (50)    NOT NULL,
    [SortOrder]    INT              NOT NULL,
    [RaidKey]      UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Encounter] PRIMARY KEY CLUSTERED ([EncounterKey] ASC),
    CONSTRAINT [FK_Encounter_Raid] FOREIGN KEY ([RaidKey]) REFERENCES [dbo].[Raid] ([RaidKey])
);



