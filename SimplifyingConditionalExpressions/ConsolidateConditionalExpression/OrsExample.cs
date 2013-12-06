namespace SimplifyingConditionalExpressions.ConsolidateConditionalExpression
{
    public class OrsExample
    {
        private readonly decimal seniority;
        private readonly decimal monthsDisabled;
        private readonly bool isPartTime;
        private const double Disabilityamount = 10;

        public OrsExample(decimal seniority, decimal monthsDisabled, bool isPartTime)
        {
            this.seniority = seniority;
            this.isPartTime = isPartTime;
            this.monthsDisabled = monthsDisabled;
        }

        public double DisabilityAmount()
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;
            return Disabilityamount;
        }
    }
}
