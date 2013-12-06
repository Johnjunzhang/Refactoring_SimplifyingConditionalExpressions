using System;

namespace SimplifyingConditionalExpressions.ReplaceConditionalwithPolymorphism
{
    public abstract class EmployeeType
    {
        public abstract int GetEmployeeCode();

        public static EmployeeType GetEmployeeType(int value)
        {
            switch (value)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN:
                    return new SalesMan();
                case MANAGER:
                    return new Manager();
                default:
                    throw new Exception();
            }
        }

        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;
    }
}