CREATE TABLE [dbo].[cheat_meal] (
    [cheat_id]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [date_of_cheat] DATETIME2 (7) NULL,
    [meal]          VARCHAR (255) NULL,
    [workout_id]    BIGINT        NULL,
    CONSTRAINT [PK_cheat_meal_1] PRIMARY KEY CLUSTERED ([cheat_id] ASC),
    CONSTRAINT [FK_cheat_meal_workout_1] FOREIGN KEY ([workout_id]) REFERENCES [dbo].[workout] ([workout_id])
);

