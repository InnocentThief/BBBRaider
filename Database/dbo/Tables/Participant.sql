CREATE TABLE [dbo].[Participant] (
    [ParticipantKey] UNIQUEIDENTIFIER NOT NULL,
    [PlayerKey]      UNIQUEIDENTIFIER NOT NULL,
    [ScheduleKey]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED ([ParticipantKey] ASC),
    CONSTRAINT [FK_Participant_Player] FOREIGN KEY ([PlayerKey]) REFERENCES [dbo].[Player] ([PlayerKey]),
    CONSTRAINT [FK_Participant_Schedule] FOREIGN KEY ([ScheduleKey]) REFERENCES [dbo].[Schedule] ([ScheduleKey])
);

