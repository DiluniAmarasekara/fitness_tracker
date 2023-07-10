namespace fitness_tracker.models
{
    internal class Goal
    {
        private Int64 goalId;

        private String purpose;

        private int age;

        private Double currentHeight;

        private Double currentWeight;

        private Double bmi;

        private Double goalWeight;
        private object v1;
        private string? v2;
        private int v3;
        private double v4;
        private double v5;
        private double v6;
        private double v7;

        public Goal(Int64 goalId, String purpose, int age, Double currentHeight, Double currentWeight, Double bmi, Double goalWeight)
        {
            this.goalId = goalId;
            this.purpose = purpose;
            this.age = age;
            this.currentHeight = currentHeight;
            this.currentWeight = currentWeight;
            this.bmi = bmi;
            this.goalWeight = goalWeight;
        }

        public Int64 getGoalId()
        {
            return goalId;
        }

        public void setGoalId(Int64 goalId)
        {
            this.goalId = goalId;
        }

        public String getPurpose()
        {
            return purpose;
        }

        public void setPurpose(String purpose)
        {
            this.purpose = purpose;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public Double getCurrentHeight()
        {
            return currentHeight;
        }

        public void setCurrentHeight(Double currentHeight)
        {
            this.currentHeight = currentHeight;
        }

        public Double getCurrentWeight()
        {
            return currentWeight;
        }

        public void setCurrentWeight(Double currentWeight)
        {
            this.currentWeight = currentWeight;
        }

        public Double getBmi()
        {
            return bmi;
        }

        public void setBmi(Double bmi)
        {
            this.bmi = bmi;
        }

        public Double getGoalWeight()
        {
            return goalWeight;
        }

        public void setGoalWeight(Double goalWeight)
        {
            this.goalWeight = goalWeight;
        }

    }
}