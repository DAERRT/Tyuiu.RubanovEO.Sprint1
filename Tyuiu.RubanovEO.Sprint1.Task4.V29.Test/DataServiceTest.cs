
using Tyuiu.RubanovEO.Sprint1.Task4.V29.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task4.V29.Test
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
            Assert.That(ds.Calculate(2,3), Is.EqualTo(0.045));
        }
    }
}