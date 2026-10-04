using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TashovVD.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] arr = new bool[6];
            arr[0] = (a > b) | (c == d);
            arr[1] = (a <= d) & (b == c);
            arr[2] = (a == c) || (b < c);
            arr[3] = (c >= d) && (b != c);
            arr[4] = !(a >= c);
            arr[5] = (d != b) ^ (a != a);

            return arr;
        }
    }
}
