namespace SimplifyingConditionalExpressions.ReplaceNestedConditionalwithGuardClauses
{
    public class ReversingTheConditions
    {
        private readonly double capital;
        private readonly double intRate;
        private readonly double duration;
        private readonly double income;
        private const double AdjFactor = 2;

        public ReversingTheConditions(double capital, double intRate, double duration, double income)
        {
            this.capital = capital;
            this.income = income;
            this.duration = duration;
            this.intRate = intRate;
        }

        public double GetAdjustedCapital()
        {
            var result = 0.0;
            if (capital > 0.0)
            {
                if (intRate > 0.0 && duration > 0.0)
                {
                    result = (income / duration) * AdjFactor;
                }
            }
            return result;
        }
    }
}