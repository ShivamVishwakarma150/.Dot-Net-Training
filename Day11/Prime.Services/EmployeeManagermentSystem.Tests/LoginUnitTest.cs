
namespace EmployeeManagermentSystem.Tests
{
    public class Tests
    {
        Employee _employee;
        [SetUp]
        public void Setup()
        {
            _employee = new Employee();
        }

        [Test]
        public void TestEmployeeDetails()
        {
            var result = _employee.GetEmployee("Vikash");
            Assert.IsInstanceOf(typeof(Employee), result);
        }
    }
}