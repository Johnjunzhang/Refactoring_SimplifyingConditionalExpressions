namespace SimplifyingConditionalExpressions.ReplaceNestedConditionalwithGuardClauses
{
    public class ReplaceNestedConditionalwithGuardClauses
    {
        private readonly bool isDead;
        private readonly bool isSeparated;
        private readonly bool isRetired;

        public ReplaceNestedConditionalwithGuardClauses(bool isDead, bool isSeparated, bool isRetired)
        {
            this.isDead = isDead;
            this.isRetired = isRetired;
            this.isSeparated = isSeparated;
        }

        public double GetPayAmount()
        {
            double result;
            if (isDead) result = DeadAmount();
            else
            {
                if (isSeparated) result = SeparatedAmount();
                else
                {
                    if (isRetired) result = RetiredAmount();
                    else result = NormalPayAmount();
                }
            }
            return result;
        }

        private static double NormalPayAmount()
        {
            return 100;
        }

        private static double RetiredAmount()
        {
            return 200;
        }

        private static double SeparatedAmount()
        {
            return 300;
        }

        private static double DeadAmount()
        {
            return 400;
        }
    }
}