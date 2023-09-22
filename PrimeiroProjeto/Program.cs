using System;
using System.Globalization;

namespace PrimeiroProjeto {
    class Program {
        static void Main(string[] args) {

            Triangle triangleX, triangleY;

            triangleX = new Triangle();
            triangleY = new Triangle();

            Console.WriteLine("Ente com as medidas do triângulo X: ");

            triangleX.SideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleX.SideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleX.SideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Ente com as medidas do triângulo Y: ");

            triangleY.SideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleY.SideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleY.SideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (triangleX.SideA + triangleX.SideB + triangleX.SideC) / 2.0;
            double areaX = Math.Sqrt(p * (p - triangleX.SideA) * (p - triangleX.SideB) * (p - triangleX.SideC));

            p = (triangleY.SideA + triangleY.SideB + triangleY.SideC) / 2.0;
            double areaY = Math.Sqrt(p * (p - triangleY.SideA) * (p - triangleY.SideB) * (p - triangleY.SideC));


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
