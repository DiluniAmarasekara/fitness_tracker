INSERT INTO [dbo].[goal](
	age, bmi, current_height, current_weight, goal_weight, purpose)
	VALUES (30, 24.1, 5.3, 63, 52, 'Weight loss');

INSERT INTO [dbo].[workout](
	from_date, to_date, workout_name, goal_id)
	VALUES ('2023-07-01 01:06:44.456', '2023-07-11 01:06:44.456', 'Early july', 1);

INSERT INTO [dbo].[exercise](
	exercise_name, reps)
	VALUES ('Back squat', 10), ('Barbell row', 10), ('RDL', 10), ('Lunges', 10),
	('Overhead press', 10), ('Hip thrust', 10), ('Lat pulldown', 10), ('Kettlebell swing', 10);


