using System;

namespace Katas.CleanCode
{
    public class CalcPmManager
    {
        public double GetPromotion(int numberOfArticles, double unitPrice, int dayOfWeek)
        {
            if (numberOfArticles < 0)
            {
                throw new ArgumentException();
            }

            if (numberOfArticles < 3)
            {
                return 0;
            }

            if (numberOfArticles < 11)
            {
                return (numberOfArticles / 3) * unitPrice;
            }

            var sundayDiscount = 0.0;

            if (dayOfWeek == (int)DayOfWeek.Sunday)
            {
                sundayDiscount = numberOfArticles * unitPrice * 0.1;
            }

            //50 percent off for rest
            return sundayDiscount + numberOfArticles * unitPrice / 2;
        }
    }
}
