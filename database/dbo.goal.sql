CREATE TABLE [dbo].[goal] (
    [goal_id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [age]            INT           NULL,
    [bmi]            FLOAT (53)    NULL,
    [current_height] FLOAT (53)    NULL,
    [current_weight] FLOAT (53)    NULL,
    [goal_weight]    FLOAT (53)    NULL,
    [purpose]        VARCHAR (255) NULL,
    CONSTRAINT [PK_goal_5] PRIMARY KEY CLUSTERED ([goal_id] ASC)
);

