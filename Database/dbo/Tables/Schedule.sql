CREATE TABLE [dbo].[Schedule] (
    [ScheduleKey]         UNIQUEIDENTIFIER NOT NULL,
    [Date]                DATETIME         NOT NULL,
    [Duration]            INT              NULL,
    [RaidLeaderPlayerKey] UNIQUEIDENTIFIER NOT NULL,
    [RaidKey]             UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED ([ScheduleKey] ASC),
    CONSTRAINT [FK_Schedule_Player] FOREIGN KEY ([RaidLeaderPlayerKey]) REFERENCES [dbo].[Player] ([PlayerKey]),
    CONSTRAINT [FK_Schedule_Raid] FOREIGN KEY ([RaidKey]) REFERENCES [dbo].[Raid] ([RaidKey])
);

