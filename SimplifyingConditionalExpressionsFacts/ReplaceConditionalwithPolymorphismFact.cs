using SimplifyingConditionalExpressions.ReplaceConditionalwithPolymorphism;
using Xunit;

namespace SimplifyingConditionalExpressionsFacts
{
    public class ReplaceConditionalwithPolymorphismFact
    {
        [Fact]
        public void should_get_pay_amount_for_engineer_given_type_is_engineer()
        {
            var employee = new Employee(EmployeeType.ENGINEER);
            Assert.Equal(100, employee.PayAmount());
        }

        [Fact]
        public void should_get_pay_amount_for_sales_man_given_type_is_sales_man()
        {
            var employee = new Employee(EmployeeType.SALESMAN);
            Assert.Equal(120, employee.PayAmount());
        }

        [Fact]
        public void should_get_pay_amount_for_manager_given_type_is_manager()
        {
            var employee = new Employee(EmployeeType.MANAGER);
            Assert.Equal(150, employee.PayAmount());
        }
    }
}