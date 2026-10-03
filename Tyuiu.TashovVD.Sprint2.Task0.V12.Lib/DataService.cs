using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TashovVD.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool [] arr = new bool[6];

            arr[0] = x == y + 620;
            arr[1] = x != y + 620;
            arr[2] = y < x;
            arr[3] = y > x;
            arr[4] = x <= y + 620;
            arr[5] = x - 1000 >= y;

            return arr;
        }
    }
}
