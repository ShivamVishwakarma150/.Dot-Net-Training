namespace Prime.Services.Test
{
    [TestFixture] // Attribute is used for denoting a class that contains unit test
    public class Tests
    {
        private PrimeServices _primeServices;
        [SetUp]
        public void Setup()
        {
            _primeServices= new PrimeServices();
        }

        [Test] // Attribute used for indicating the method is a test method.
        public void Test1()
        {
            var result = _primeServices.IsPrime(3);
            Assert.IsFalse(result,"1 Should not be prime");
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeServices.IsPrime(value);
            Assert.IsFalse(result, value + " Should not be prime");
        }

        [TestCase(3)]
        [TestCase(7)]
        [TestCase(6)]
        public void IsPrime_ValuesArePrime_ReturnTrue(int value)
        {
            var result = _primeServices.IsPrime(value);
            Assert.IsTrue(result, value + " is Prime");
            Assert.IsFalse(result, value + " is not Prime");
        }


    }
}