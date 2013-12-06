namespace SimplifyingConditionalExpressions.ConsolidateConditionalExpression
{
    public class AndsExample
    {
        private readonly decimal lengthOfService;
        private readonly bool onVacation;

        public AndsExample(decimal lengthOfService, bool onVacation)
        {
            this.lengthOfService = lengthOfService;
            this.onVacation = onVacation;
        }

        public double GetCharge()
        {
            if (OnVacation())
                if (LengthOfService() > 10)
                    return 1;
            return 0.5;
        }

        private decimal LengthOfService()
        {
            return lengthOfService;
        }

        private bool OnVacation()
        {
            return onVacation;
        }
    }
}