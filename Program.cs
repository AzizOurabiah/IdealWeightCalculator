using System;

namespace IdealWeightCalculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightCalculator wc = new WeightCalculator()
            {
                Height = 180,
                Sex = 'm'                
            };
            double weight = wc.GetIdealBodyWeight();

            Console.WriteLine($"The ideal body is : {weight}", weight);

            if(weight == 172.5)
            {
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test succedes !");
            }
            else
            {
                //Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test failes !");
            }
            Console.ReadKey();
        }
    }
}
