using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("╔══════════════════╗");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║                BMI                 ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("╚══════════════════╝");

            
            

            Console.WriteLine("請輸入體重(kg):");
            int kg = int.Parse(Console.ReadLine());


            Console.WriteLine("請輸入身高(m):");
            double m = double.Parse(Console.ReadLine());

            double total = kg / (m * m);
            
            if (total > 24)
                Console.WriteLine("BMI是:" + total + "您的BMI大於標準值");
            if (total < 18.5)
                Console.WriteLine("BMI是:" + total + "您的BMI小於標準值");
            else
                
                Console.WriteLine("BMI是:" + total + "您的BMI為標準值");

            Console.ReadLine();
        }
    }
}
