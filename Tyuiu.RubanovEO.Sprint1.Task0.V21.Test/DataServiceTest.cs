
using Tyuiu.RubanovEO.Sprint1.Task0.V21.Lib;


namespace Tyuiu.RubanovEO.Sprint1.Task0.V21.Test
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
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}