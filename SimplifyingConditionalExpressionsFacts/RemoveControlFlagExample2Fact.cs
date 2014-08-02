using SimplifyingConditionalExpressions.RemoveControlFlag;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class RemoveControlFlagExample2Fact
    {
        [Fact]
        public void should_get_alert_message_if_people_names_include_don()
        {
            var peopleNames = new[] { "Don", "Kent" };

            var usingReturn = new UsingReturn();
            var alertMessage = usingReturn.CheckSecurity(peopleNames);
            Assert.Equal("AlertDon", alertMessage);
        }

        [Fact]
        public void should_get_alert_message_if_people_names_include_john()
        {
            var peopleNames = new[] { "John", "Kent" };

            var usingReturn = new UsingReturn();
            var alertMessage = usingReturn.CheckSecurity(peopleNames);
            Assert.Equal("AlertJohn", alertMessage);
        }

        [Fact]
        public void should_alert_first_matched_people()
        {
            var peopleNames = new[] { "John", "Don" };

            var usingReturn = new UsingReturn();
            var alertMessage = usingReturn.CheckSecurity(peopleNames);
            Assert.Equal("AlertJohn", alertMessage);
        }

        [Fact]
        public void should_not_get_alert_message_if_people_names_does_include_don_and_john()
        {
            var peopleNames = new[] { "Martin", "Kent" };

            var usingReturn = new UsingReturn();
            var alertMessage = usingReturn.CheckSecurity(peopleNames);
            Assert.Equal("", alertMessage);
        }
    }
}