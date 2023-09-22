using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {

            double sideXA, sideXB, sideXC, sideYA, sideYB, sideYC;

            Console.WriteLine("Ente com as medidas do triângulo X: ");

            sideXA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sideXB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sideXC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Ente com as medidas do triângulo Y: ");

            sideYA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sideYB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sideYC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (sideXA + sideXB + sideXC) / 2.0;
            double areaX = Math.Sqrt(p * (p - sideXA) * (p - sideXB) * (p - sideXC));

            p = (sideYA + sideYB + sideYC) / 2.0;
            double areaY = Math.Sqrt(p * (p - sideYA) * (p - sideYB) * (p - sideYC));


            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Mario Area: X");
            } else {
                Console.WriteLine("MArio Area: Y");
            }
        }
    }
}
