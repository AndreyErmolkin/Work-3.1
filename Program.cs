using System;

namespace HomeWork3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введиту сумму кредита");
            var summ = Console.ReadLine();
            var s = double.Parse(summ);
            Console.WriteLine("Введите значение %");
            var prosent = Console.ReadLine();
            var p = float.Parse(prosent);
            int m;

            for (m = 1; m <= 12; m++)
            {
                double y = (p / 12) / 100;

                if (m <= 12) ;
                {
                    double l = Math.Pow((1 + y), 12);
                    double summ2 =  (s * (y + (y / l - 1)));

                    Console.WriteLine("Сумма за месяц" + m + ":" + summ2);
                    if (m > 12) ;
                
                
                    double summ3 = summ2 * 12;
                    Console.WriteLine("Сумма за год:" + summ3);

                
                                                           
                }
            }

        }
    }
}