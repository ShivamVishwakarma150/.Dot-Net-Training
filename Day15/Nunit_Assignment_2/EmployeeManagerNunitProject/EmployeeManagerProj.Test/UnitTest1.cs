using NUnit.Framework;

namespace EmployeeManagerProj.Test
{
    public class Tests
    {
        EmployeeManager em;
        [SetUp]
        public void Setup()
        {
            em = new EmployeeManager();
        }


        [Test]
        public void TestCase_For_HeadCount_EqualsToZero()
        {
           
            Assert.That(em.HeadCount == 0, "Employee Object = "+em.HeadCount, em);
        }


        [Test]
        public void TestCase_For_HeadCount_EqualsToOne()
        {
            Employee e = new Employee();
            em.AddEmployee(e);
            Assert.That(em.HeadCount==1, "Employee Object = "+em.HeadCount, em);
        }
    }
}