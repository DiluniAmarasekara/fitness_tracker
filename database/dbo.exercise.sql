CREATE TABLE [dbo].[exercise] (
    [exercise_id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [exercise_name] VARCHAR (255) NULL,
    [reps]          INT           NULL,
    CONSTRAINT [PK_exercise_3] PRIMARY KEY CLUSTERED ([exercise_id] ASC)
);

