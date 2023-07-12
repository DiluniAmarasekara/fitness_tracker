namespace fitness_tracker.models
{
    internal class Weight
    {
        private Int64 weightId;
        private DateTime logDate;
        private double logWeight;

        public Weight(Int64 weightId, DateTime logDate, double logWeight)
        {
            this.weightId = weightId;
            this.logDate = logDate;
            this.logWeight = logWeight;
        }
        public Int64 getweightId()
        {
            return weightId;
        }

        public void setweightId(Int64 weightId)
        {
            this.weightId = weightId;
        }

        public DateTime getLogDate()
        {
            return logDate;
        }

        public void setLogDate(DateTime logDate)
        {
            this.logDate = logDate;
        }

        public double getLogWeight()
        {
            return logWeight;
        }

        public void setLogWeight(double logWeight)
        {
            this.logWeight = logWeight;
        }
    }
}