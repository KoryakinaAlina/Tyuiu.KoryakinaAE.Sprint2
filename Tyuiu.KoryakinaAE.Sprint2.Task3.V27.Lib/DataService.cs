using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KoryakinaAE.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            double res = new double();
            if (x > 0)
            {
                double wait = (x + 1) / (Math.Sin(Math.Pow(x, 2)) + x - 0.5);
                res = x * Math.Pow(wait, x);
            }
            else
            {
                if (x == 0)
                {
                    res = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 4 / Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                }
                else
                {
                    if ((-31 < x) && (x < 0))
                    {
                        res = Math.Pow(1 + 1 / Math.Pow(x, 2), 2);
                    }
                    else
                    {
                        if (x < -31)
                        {
                            res = x + Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3) - (2 / x);
                        }
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
