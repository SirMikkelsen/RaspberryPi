CREATE TABLE [dbo].[Measurements] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [Timestamp]   DATETIME NOT NULL,
    [Measurement] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

