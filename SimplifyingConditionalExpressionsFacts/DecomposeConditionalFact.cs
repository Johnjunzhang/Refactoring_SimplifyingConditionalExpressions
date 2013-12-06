using System;
using SimplifyingConditionalExpressions.DecomposeConditional;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class DecomposeConditionalFact
    {
        [Fact]
        public void should_get_summer_charge_given_date_is_in_summer()
        {
            var chargeCalculator = new ChargeCalculator();
            var charge = chargeCalculator.GetCharge(new DateTime(2011, 7, 1), 100);
            Assert.Equal(200, charge);
        }

        [Fact]
        public void should_get_winter_charge_given_date_is_not_in_summer()
        {
            var chargeCalculator = new ChargeCalculator();
            var charge = chargeCalculator.GetCharge(new DateTime(2011, 11, 1), 100);
            Assert.Equal(400, charge);
        }
    }
}