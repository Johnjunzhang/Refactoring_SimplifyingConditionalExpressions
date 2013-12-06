using SimplifyingConditionalExpressions.ConsolidateDuplicateConditionalFragments;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class ConsolidateDuplicateConditionalFragmentsFact
    {
        [Fact]
        public void should_get_disability_amount_given_is_special_deal()
        {
            var consolidateDuplicateConditionalFragments = new ConsolidateDuplicateConditionalFragments(true, 10);
            Assert.Equal(10.5, consolidateDuplicateConditionalFragments.DisabilityAmount());
        }

        [Fact]
        public void should_get_disability_amount_given_is_not_special_deal()
        {
            var consolidateDuplicateConditionalFragments = new ConsolidateDuplicateConditionalFragments(false, 10);
            Assert.Equal(10.8, consolidateDuplicateConditionalFragments.DisabilityAmount());
        }
    }
}