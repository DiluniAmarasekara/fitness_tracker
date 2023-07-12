CREATE TABLE [dbo].[workout_exercise] (
    [workout_id]  BIGINT NOT NULL,
    [exercise_id] BIGINT NOT NULL,
    CONSTRAINT [PK_workout_exercise_2] PRIMARY KEY CLUSTERED ([workout_id] ASC, [exercise_id] ASC),
    CONSTRAINT [FK_workout_exercise_exercise_2] FOREIGN KEY ([exercise_id]) REFERENCES [dbo].[exercise] ([exercise_id]),
    CONSTRAINT [FK_workout_exercise_workout_2] FOREIGN KEY ([workout_id]) REFERENCES [dbo].[workout] ([workout_id])
);

