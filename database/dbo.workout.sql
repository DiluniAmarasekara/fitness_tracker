CREATE TABLE [dbo].[workout] (
    [workout_id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [from_date]    DATETIME2 (7) NULL,
    [to_date]      DATETIME2 (7) NULL,
    [workout_name] VARCHAR (255) NULL,
    [goal_id]      BIGINT        NULL,
    CONSTRAINT [PK_workout_0] PRIMARY KEY CLUSTERED ([workout_id] ASC),
    CONSTRAINT [FK_workout_goal_0] FOREIGN KEY ([goal_id]) REFERENCES [dbo].[goal] ([goal_id])
);

