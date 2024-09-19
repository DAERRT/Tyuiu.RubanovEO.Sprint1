
using Tyuiu.RubanovEO.Sprint1.Task7.V7.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task7.V7.Test
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
            Assert.That(ds.Calculate(2,2), Is.EqualTo(-22.831));
        }
    }
}