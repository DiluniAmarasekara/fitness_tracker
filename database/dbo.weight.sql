CREATE TABLE [dbo].[weight] (
    [weight_id]		BIGINT	IDENTITY (1, 1) NOT NULL,
    [log_date]		DATETIME2 (7) NULL,
    [log_weight]	FLOAT (53)    NULL,
    [goal_id]		BIGINT        NULL,
    CONSTRAINT [PK_weight_4] PRIMARY KEY CLUSTERED ([weight_id] ASC),
    CONSTRAINT [FK_weight_goal_4] FOREIGN KEY ([goal_id]) REFERENCES [dbo].[goal] ([goal_id])
);

