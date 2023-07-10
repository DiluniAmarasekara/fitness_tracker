using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fitness_tracker.models
{
    internal class WorkoutSchedule
    {
        private Int64 workoutId;

        private string workoutName;

        private DateTime fromDate;

        private DateTime toDate;

        private Int64 goalId;

        public WorkoutSchedule(Int64 workoutId, string workoutName, DateTime fromDate, DateTime toDate, Int64 goalId)
        {
            this.workoutId = workoutId;
            this.workoutName = workoutName;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.goalId = goalId;
        }

        public Int64 getWorkoutId()
        {
            return workoutId;
        }

        public void setWorkoutId(Int64 workoutId)
        {
            this.workoutId = workoutId;
        }

        public string getWorkoutName()
        {
            return workoutName;
        }

        public void setWorkoutName(string workoutName)
        {
            this.workoutName = workoutName;
        }

        public DateTime getFromDate()
        {
            return fromDate;
        }

        public void setFromDate(DateTime fromDate)
        {
            this.fromDate = fromDate;
        }

        public DateTime getToDate()
        {
            return toDate;
        }

        public void setToDate(DateTime toDate)
        {
            this.toDate = toDate;
        }

        public Int64 getGoalId()
        {
            return goalId;
        }

        public void setGoalId(Int64 goalId)
        {
            this.goalId = goalId;
        }
    }
}