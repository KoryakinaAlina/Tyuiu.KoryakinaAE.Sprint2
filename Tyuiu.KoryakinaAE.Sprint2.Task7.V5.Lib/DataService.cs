using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KoryakinaAE.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x >= 0 && x <= 1)
            {
                return y >= x * x && y <= Math.Exp(-x);
            }
            else if (x >= -1  && x < 0)
            {
                return y >= x * x && y <= Math.Exp(x);
            }
            return false;
        }
    }
}
