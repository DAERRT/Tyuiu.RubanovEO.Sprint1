
using Tyuiu.RubanovEO.Sprint1.Task1.V8.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task1.V8.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            Assert.That(ds.Calculate(10, 5), Is.EqualTo(1.57));
        }
    }
}