using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming1_Exercise1_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double xKoordinatenP1;
            double yKoordinatenP1;
            double xKoordinatenP2;
            double yKoordinatenP2;
            string userInput;
            double avstånd;
            
            Console.WriteLine("Beräkna avståndet mellan två punkter.");

            Console.Write("Ange x-koordinaten för p1: ");
            userInput = Console.ReadLine();
            xKoordinatenP1 = Convert.ToDouble(userInput);

            Console.Write("Ange y-koordinaten för p1: ");
            userInput = Console.ReadLine();
            yKoordinatenP1 = Convert.ToDouble(userInput);

            Console.Write("Ange x-koordinaten för p2: ");
            userInput = Console.ReadLine();
            xKoordinatenP2 = Convert.ToDouble(userInput);

            Console.Write("Ange y-koordinaten för p2: ");
            userInput = Console.ReadLine();
            yKoordinatenP2 = Convert.ToDouble(userInput);

            avstånd = Math.Sqrt(Math.Pow(xKoordinatenP2 - xKoordinatenP1, 2) + Math.Pow(yKoordinatenP2 - yKoordinatenP1, 2) * 1.0);

            Console.WriteLine($"Avståndet är: {avstånd}");
            Console.ReadKey();

        }
    }
}
