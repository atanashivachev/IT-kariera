using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugCode_PriceChangeAlert
{
    class Program
    {
        static void Main()
        {
            int rowsOfPrices = int.Parse(Console.ReadLine());
            double borderOfSignificance = double.Parse(Console.ReadLine());
            double firstPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < rowsOfPrices - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double priceDifference = Proc(firstPrice, price);

                bool isSignificantDifference = detectDifference(priceDifference, borderOfSignificance);

                string message = StatusMessage(price, firstPrice, priceDifference, isSignificantDifference);
                Console.WriteLine(message);

                firstPrice = price;
            }
        }

        private static string StatusMessage(double price, double firstPrice, double priceDifference, bool isSignificantDifference)

        {
            string message = null;

            if (priceDifference == 0)
            {
                message = string.Format("NO CHANGE: {0}", price);
            }

            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, price, priceDifference);
            }

            else if (isSignificantDifference && (priceDifference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, price, priceDifference);
            }

            else if (isSignificantDifference && (priceDifference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, price, priceDifference);
            }

            return message;
        }

        private static bool detectDifference(double priceChange, double borderOfSignificance)
        {
            if (Math.Abs(priceChange) >= borderOfSignificance)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double firstPrice, double price)
        {
            double r = (price - firstPrice) / firstPrice;
            return r;
        }

        /* code before:
          static void Main()
    {
        int n = int.Parse(Console.ReadLine());



        double granica = double. Parse(Console.ReadLine());


        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++) {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(last, c); bool isSignificantDifference = imaliDif(div, granica);



            string message = Get(c, last, div, isSignificantDifference);
            Console.WriteLine(message);

            last = c; }             }

    private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)






    {   string to = "";
        if (razlika == 0)
                                                            {
                                                                to = string.Format("NO CHANGE: {0}", c);
                                                            }
        else if (!etherTrueOrFalse){
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);}
        else if (etherTrueOrFalse && (razlika > 0))
{
to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
}
        else if (etherTrueOrFalse && (razlika < 0))
to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        return to;}
        private static bool imaliDif(double granica, double isDiff)
        {
        if (Math.Abs(granica) >= isDiff)
        {
        return true;
        }
        return false;
        }

private static double Proc(double l, double c)
{
double r = (c - l) / l;
return r;
}
         */
    }
}
