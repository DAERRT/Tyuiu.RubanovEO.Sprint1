
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RubanovEO.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task2V10
    {
        public double ConvertMetreToInchs(int value)
        {
            var a = value * 39.37;

            return Math.Round(a, 3);
        }
    }
}
