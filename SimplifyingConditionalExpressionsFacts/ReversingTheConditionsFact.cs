using SimplifyingConditionalExpressions.ReplaceNestedConditionalwithGuardClauses;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class ReversingTheConditionsFact
    {
        [Fact]
        public void should_get_zero_adjusted_capital_given_capital_is_less_than_zero()
        {
            var reversingTheConditions = new ReversingTheConditions(-1, 10, 10, 10);
            Assert.Equal(0, reversingTheConditions.GetAdjustedCapital());
        }

        [Fact]
        public void should_get_zero_adjusted_capital_given_init_rate_is_less_than_zero()
        {
            var reversingTheConditions = new ReversingTheConditions(10, -1, 10, 10);
            Assert.Equal(0, reversingTheConditions.GetAdjustedCapital());
        }

        [Fact]
        public void should_get_zero_adjusted_capital_given_duration_is_less_than_zero()
        {
            var reversingTheConditions = new ReversingTheConditions(10, 10, -1, 10);
            Assert.Equal(0, reversingTheConditions.GetAdjustedCapital());
        }

        [Fact]
        public void should_get_adjusted_capital_given_duration_and_capital_and_init_rate_all_are_greater_than_zero()
        {
            var reversingTheConditions = new ReversingTheConditions(10, 10, 5, 10);
            Assert.Equal(4, reversingTheConditions.GetAdjustedCapital());
        }
    }
}