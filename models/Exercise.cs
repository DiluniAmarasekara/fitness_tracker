namespace fitness_tracker.models
{
    internal class Exercise
    {
        private Int64 exerciseId;

        private string exerciseName;

        private int reps;

        public Exercise(Int64 exerciseId, string exerciseName, int reps)
        {
            this.exerciseId = exerciseId;
            this.exerciseName = exerciseName;
            this.reps = reps;
        }
        public Int64 getExerciseId()
        {
            return exerciseId;
        }

        public void setExerciseId(Int64 exerciseId)
        {
            this.exerciseId = exerciseId;
        }

        public string getExerciseName()
        {
            return exerciseName;
        }

        public void setExerciseName(string exerciseName)
        {
            this.exerciseName = exerciseName;
        }

        public int getReps()
        {
            return reps;
        }

        public void setReps(int reps)
        {
            this.reps = reps;
        }
    }
}