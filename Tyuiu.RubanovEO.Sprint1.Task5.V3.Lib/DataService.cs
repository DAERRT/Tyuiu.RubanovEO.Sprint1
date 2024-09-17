
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RubanovEO.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string a = Convert.ToString(k);
            return Convert.ToInt32(Convert.ToString(a[a.Length-3]));
        }
    }
}
