
using Tyuiu.RubanovEO.Sprint1.Task6.V10.Lib;

namespace Tyuiu.RubanovEO.Sprint1.Task6.V10.Test
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
            Assert.That(ds.DeleteMiddleLetter("My dog name is lorem"), Is.EqualTo("My dg name is loem"));
        }
    }
}