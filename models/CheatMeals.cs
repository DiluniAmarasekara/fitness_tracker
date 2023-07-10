using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace fitness_tracker.models
{
    internal class CheatMeals
    {
        private Int64 cheatId;

        private DateTime dateOfCheat;

        private string calories;

        private Int64 workoutId;

        public CheatMeals(Int64 cheatId, DateTime dateOfCheat, string calories, Int64 workoutId)
        {
            this.cheatId = cheatId;
            this.dateOfCheat = dateOfCheat;
            this.calories = calories;
            this.workoutId = workoutId;
        }

        public Int64 getCheatId()
        {
            return cheatId;
        }

        public void setCheatId(Int64 cheatId)
        {
            this.cheatId = cheatId;
        }

        public DateTime getDateOfCheat()
        {
            return dateOfCheat;
        }

        public void setDateOfCheat(DateTime dateOfCheat)
        {
            this.dateOfCheat = dateOfCheat;
        }

        public string getCalories()
        {
            return calories;
        }

        public void setCalories(string calories)
        {
            this.calories = calories;
        }

        public Int64 getWorkout()
        {
            return workoutId;
        }

        public void setWorkout(Int64 workoutId)
        {
            this.workoutId = workoutId;
        }

    }
}