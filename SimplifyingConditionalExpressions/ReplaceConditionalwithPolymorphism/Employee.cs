using System;

namespace SimplifyingConditionalExpressions.ReplaceConditionalwithPolymorphism
{
    public class Employee
    {
        public Employee(int type)
        {
            SetEmployeeType(type);
        }

        private EmployeeType employeeType;
        private const int MonthlySalary = 100;
        private const int Commission = 20;
        private const int Bonus = 50;

        private void SetEmployeeType(int value)
        {
            employeeType = EmployeeType.GetEmployeeType(value);
        }

        public int PayAmount()
        {
            switch (employeeType.GetEmployeeCode())
            {
                case EmployeeType.ENGINEER:
                    return MonthlySalary;
                case EmployeeType.SALESMAN:
                    return MonthlySalary + Commission;
                case EmployeeType.MANAGER:
                    return MonthlySalary + Bonus;
                default:
                    throw new Exception();
            }
        }
    }
}