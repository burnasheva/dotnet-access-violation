using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public unsafe void AccessViolation()
        {
            var array = new byte[1];

            fixed (byte* start = array)
            {
                byte* ptr = start;
                ptr += 1000000000;
                *ptr = 0;

            }
        }
    }
}
