using LeapYearCalculatorLib;
namespace LeapYearCalculatorLib.Test
{
    public class LeapYearTest
    {
        LeapYear leapyear;

        [SetUp]
        public void Setup()
        {
            leapyear = new LeapYear();
        }

        [TestCase(2005)]
        [TestCase(2004)]
        [TestCase(2000)]
        public void UnitUnderTest_Scenario_ExpectedOutcome_LeapYear(int value)
        {
            int result = leapyear.IsLeap(value);
            
            Assert.That(result == 1, "Leap Year", leapyear);
        }

        [TestCase(2005)]
        [TestCase(2004)]
        [TestCase(2000)]
        public void UnitUnderTest_Scenario_ExpectedOutcome_NotLeapYear(int value)
        {
            int result = leapyear.IsLeap(value);

            Assert.That(result == 0, "Not Leap Year", leapyear);
          
        }

        [TestCase(2004)]
        [TestCase(1677)]
        [TestCase(2005)]
        public void UnitUnderTest_Scenario_ExpectedOutcome_ViolateYear(int value)
        {
            int result = leapyear.IsLeap(value);

            Assert.That(!(result == -1), "Rule Violated", leapyear);
        }
    }
}