
using Tyuiu.RubanovEO.Sprint1.Task3.V13.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task3.V13.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.That(ds.MultiplyOfDigits(139), Is.EqualTo(27));
        }
    }
}