using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    class Triangle {
        public double SideA;
        public double SideB;
        public double SideC;

        public double CalculateArea() {
            double p = (SideA + SideB + SideC) / 2.0;
            double root = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return root;
        }
    }
}
