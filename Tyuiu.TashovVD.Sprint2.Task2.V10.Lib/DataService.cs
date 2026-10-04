using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TashovVD.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x < 6) || (x > 8 && x < 13))
            {
                if (x == 4 && (y >= 3 && y <= 14))
                {
                    return true;
                }
                else if (y >= 3 && y <= 7)
                {
                    return true;
                }
                else if (x == 9 && y >= 8 && y <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           if (x > 5 && x < 9)
            {
                if (y >= 5 && y <= 9)
                {
                    return true;
                }
                else if (x == 8 && y > 9 && y < 13)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            if (y == 8 && x >= 10 && x <= 13)
            {
                return true;
            }
            if (x == 13 && y >= 6 && y <= 8)
            {
                return true;
            }
            if (y == 14 && x >= 2 && x <= 6)
            {
                return true;
            }
            if (y == 11 && ((x >= 3 && x <= 5) || (x >= 8 && x <= 9)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
