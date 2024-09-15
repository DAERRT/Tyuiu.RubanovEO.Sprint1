
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RubanovEO.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double number)
        {
            string a = Convert.ToString(number);
            double b = 1;
            for (var i = 0; i < a.Length; i++)
            {
                b *= Convert.ToDouble(Convert.ToString(a[i]));
            }
            return Math.Round(b, 3);
        }
    }
}
