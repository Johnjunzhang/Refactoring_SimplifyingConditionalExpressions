namespace SimplifyingConditionalExpressions.IntroduceNullObject
{
    public class Site
    {
        private readonly Customer customer;

        public Site(Customer customer)
        {
            this.customer = customer;
        }

        public Customer GetCustomer()
        {
            return customer;
        }
    }
}