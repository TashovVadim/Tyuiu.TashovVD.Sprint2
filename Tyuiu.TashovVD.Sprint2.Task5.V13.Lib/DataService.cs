using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TashovVD.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int mx;

            switch (m) 
            {
                case 4:
                case 5:
                case 6:
                case 9:
                case 11:
                    mx = 30;
                    break;
                case 2:
                    mx = 28;
                    break;
                case 8:
                    mx = 29;
                    break;
                default:
                    mx = 31;
                    break;
            }

            if (n < mx)
            {
                return $"{n + 1:D2}.{m:D2}.{g}";

            }
            else if ((m == 12) && (n == mx))
            {
                return $"1.1.{g+1}";
            }
            else if ((m < 12) && (n == mx))
            {
                return $"1.{m+1:D2}.{g}";
            }
            else
            {
                throw new ArgumentException("Неверное значение даты!");
            }


        }
    }
}
