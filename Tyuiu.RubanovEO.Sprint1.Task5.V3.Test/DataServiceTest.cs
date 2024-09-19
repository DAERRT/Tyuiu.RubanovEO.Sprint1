
using Tyuiu.RubanovEO.Sprint1.Task5.V3.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task5.V3.Test
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
            Assert.That(ds.Calculate(11311), Is.EqualTo(3));
        }
    }
}