using SimplifyingConditionalExpressions.ReplaceNestedConditionalwithGuardClauses;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class ReplaceNestedConditionalwithGuardClausesFact
    {
        [Fact]
        public void should_get_dead_amount_pay_given_is_dead()
        {
            var replaceNestedConditionalwithGuardClauses = new ReplaceNestedConditionalwithGuardClauses(true, false, false);
            Assert.Equal(400, replaceNestedConditionalwithGuardClauses.GetPayAmount());
        }

        [Fact]
        public void should_get_separated_amount_pay_given_is_separated_and_not_dead()
        {
            var replaceNestedConditionalwithGuardClauses = new ReplaceNestedConditionalwithGuardClauses(false, true, false);
            Assert.Equal(300, replaceNestedConditionalwithGuardClauses.GetPayAmount());
        }

        [Fact]
        public void should_get_separated_amount_pay_given_is_retired_and_not_dead_and_not_seperated()
        {
            var replaceNestedConditionalwithGuardClauses = new ReplaceNestedConditionalwithGuardClauses(false, false, true);
            Assert.Equal(200, replaceNestedConditionalwithGuardClauses.GetPayAmount());
        }

        [Fact]
        public void should_get_normal_amount_pay_given_is_not_retired_and_not_dead_and_not_seperated()
        {
            var replaceNestedConditionalwithGuardClauses = new ReplaceNestedConditionalwithGuardClauses(false, false, false);
            Assert.Equal(100, replaceNestedConditionalwithGuardClauses.GetPayAmount());
        }
    }
}