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
                return $"{g}/{m}/{n + 1}";

            }
            else if (n > mx) 
            {
                throw new ArgumentException("Неверное значение дня!");
            }
            else
            {
                return $"{g+1}/1/1";
            }


        }
    }
}
