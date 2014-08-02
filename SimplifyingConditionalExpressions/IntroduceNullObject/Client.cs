namespace SimplifyingConditionalExpressions.IntroduceNullObject
{
    public class Client
    {
        private readonly Site site;
        
        public Client(Site site)
        {
            this.site = site;
        }

        private Customer Customer
        {
            get { return site.GetCustomer(); }
        }

        public string GetStatement()
        {
            var plan = Customer == null ? "Basic Plan" : Customer.GetPlan();
            var customerName = Customer == null ? "occupant" : Customer.GetName();
            var weeksDelinquent = Customer == null ? 0 : Customer.GetWeeksDelinquentInLastYear();

            return string.Format("{0} {1} {2}", plan, customerName, weeksDelinquent);
        }
    }
}