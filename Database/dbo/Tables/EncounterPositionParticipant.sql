CREATE TABLE [dbo].[EncounterPositionParticipant] (
    [EncounterPositionParticipantKey] UNIQUEIDENTIFIER NOT NULL,
    [EncounterPositionKey]            UNIQUEIDENTIFIER NOT NULL,
    [ParticipantKey]                  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_EncounterPositionParticipant_1] PRIMARY KEY CLUSTERED ([EncounterPositionParticipantKey] ASC),
    CONSTRAINT [FK_EncounterPositionParticipant_EncounterPosition] FOREIGN KEY ([EncounterPositionKey]) REFERENCES [dbo].[EncounterPosition] ([EncounterPositionKey]),
    CONSTRAINT [FK_EncounterPositionParticipant_Participant] FOREIGN KEY ([ParticipantKey]) REFERENCES [dbo].[Participant] ([ParticipantKey])
);

