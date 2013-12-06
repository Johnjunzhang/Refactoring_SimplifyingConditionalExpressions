namespace SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments
{
    public class ConsolidateDuplicateConditionalFragments
    {
        private readonly double price;
        private double total;
        private readonly bool isSpecialDeal;

        public ConsolidateDuplicateConditionalFragments(bool isSpecialDeal, double price)
        {
            this.isSpecialDeal = isSpecialDeal;
            this.price = price;
        }

        public double DisabilityAmount()
        {
            if (IsSpecialDeal())
            {
                total = price * 0.95;
                Send();
            }
            else
            {
                total = price * 0.98;
                Send();
            }
            return total;
        }

        private void Send()
        {
            total += 1;
        }

        private bool IsSpecialDeal()
        {
            return isSpecialDeal;
        }
    }
}
