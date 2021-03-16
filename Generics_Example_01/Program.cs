using System;
using Generics_Example_01.Entities;

namespace Generics_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintService print = new PrintService();

                Console.Write("How many values? : ");
                int values = int.Parse(Console.ReadLine());


                for (int i = 0; i < values; i++)
                {
                    print.AddValue(Console.ReadLine());
                }

                print.Print();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }  


            Console.ReadKey();
        }
    }
}
