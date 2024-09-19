
using Tyuiu.RubanovEO.Sprint1.Task2.V10.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task2.V10.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.That(ds.ConvertMetreToInchs(10), Is.EqualTo(393.7));
        }
    }
}