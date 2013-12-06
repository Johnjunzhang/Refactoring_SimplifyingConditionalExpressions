using System;

namespace SimplifyingConditionalExpressions.DecomposeConditional
{
    public class ChargeCalculator
    {
        private const int SummerStartMonth = 6;
        private const int SummerEndMonth = 9;
        private const double WinterServiceCharge = 100;
        private const double WinterRate = 3;
        private const double SummerRate = 2;

        public double GetCharge(DateTime date, double quantity)
        {
            double charge;
            if (date.Month < SummerStartMonth || date.Month > SummerEndMonth)
                charge = quantity * WinterRate + WinterServiceCharge;
            else charge = quantity * SummerRate;
            return charge;
        }
    }
}