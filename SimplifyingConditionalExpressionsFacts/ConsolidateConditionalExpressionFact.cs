using SimplifyingConditionalExpressions.ConsolidateConditionalExpression;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class ConsolidateConditionalExpressionFact
    {
        [Fact]
        public void should_get_zero_disability_amount_given_seniority_less_than_two()
        {
            var consolidateConditionalExpression = new OrsExample(1, 0, false);
            Assert.Equal(0, consolidateConditionalExpression.DisabilityAmount());
        }

        [Fact]
        public void should_get_zero_disability_amount_given_month_disabled_more_than_12()
        {
            var orsExample = new OrsExample(2, 13, false);
            Assert.Equal(0, orsExample.DisabilityAmount());
        }

        [Fact]
        public void should_get_zero_disability_amount_given_is_part_time()
        {
            var consolidateConditionalExpression = new OrsExample(2, 1, true);
            Assert.Equal(0, consolidateConditionalExpression.DisabilityAmount());
        }

        [Fact]
        public void should_get_ten_disability_amount_given_seniority_greater_than_one_and_disalbed_less_than_13_and_is_not_part_time()
        {
            var consolidateConditionalExpression = new OrsExample(2, 1, false);
            Assert.Equal(10, consolidateConditionalExpression.DisabilityAmount());
        }

        [Fact]
        public void should_get_1_given_is_on_vacation_and_length_of_service_greater_than_10()
        {
            var andsExample = new AndsExample(11, true);
            Assert.Equal(1, andsExample.GetCharge());
        }

        [Fact]
        public void should_get_point_5_given_is_not_on_vacation()
        {
            var andsExample = new AndsExample(11, false);
            Assert.Equal(0.5, andsExample.GetCharge());
        }

        [Fact]
        public void should_get_point_5_given_length_of_service_not_greater_than_10()
        {
            var andsExample = new AndsExample(5, true);
            Assert.Equal(0.5, andsExample.GetCharge());
        }
    }
}