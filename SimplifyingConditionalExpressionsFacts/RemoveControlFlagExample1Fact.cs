using SimplifyingConditionalExpressions.RemoveControlFlag;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class RemoveControlFlagExample1Fact
    {
        [Fact]
        public void should_get_alert_message_if_people_names_include_don()
        {
            var peopleNames = new[] { "Don", "Kent" };

            var replacedWithBreak = new ReplacedWithBreak();
            replacedWithBreak.CheckSecurity(peopleNames);
            Assert.Equal("Alert", replacedWithBreak.AlertedMessage);
        }

        [Fact]
        public void should_get_alert_message_if_people_names_include_john()
        {
            var peopleNames = new[] { "John", "Kent" };

            var replacedWithBreak = new ReplacedWithBreak();
            replacedWithBreak.CheckSecurity(peopleNames);
            Assert.Equal("Alert", replacedWithBreak.AlertedMessage);
        }

        [Fact]
        public void should_not_get_alert_message_if_people_names_does_include_don_and_john()
        {
            var peopleNames = new[] { "Martin", "Kent" };

            var replacedWithBreak = new ReplacedWithBreak();
            replacedWithBreak.CheckSecurity(peopleNames);
            Assert.Equal(null, replacedWithBreak.AlertedMessage);
        }
    }
}