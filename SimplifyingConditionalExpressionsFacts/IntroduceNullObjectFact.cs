using SimplifyingConditionalExpressions.IntroduceNullObject;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class IntroduceNullObjectFact
    {
        [Fact]
        public void should_get_basic_statment_given_does_not_have_customer()
        {
            var site = new Site(null);
            var client = new Client(site);
            Assert.Equal("Basic Plan occupant 0", client.GetStatement());
        }

        [Fact]
        public void should_get_customer_statment_given_has_customer()
        {
            var site = new Site(new Customer());
            var client = new Client(site);
            Assert.Equal("Real Plan Name 100", client.GetStatement());
        }
    }
}