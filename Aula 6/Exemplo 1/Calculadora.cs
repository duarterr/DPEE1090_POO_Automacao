using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Calculadora
    {
        public static double Pi = 3.1415;
        
        // Implementação 1
        public static double Circunferencia1(double raio)
        {
            return 2*Pi* raio;
        }

        // Implementação 2
        public static double Circunferencia2(double raio)
        {
            double dTheta = Pi / 1000000;
            double circ = 0;

            for (double theta = 0; theta <= (2 * Pi); theta += dTheta)
                circ += raio * dTheta;

            return circ;
        }
        
        public static double Volume(double raio)
        {
            return (4.0 / 3.0) * Pi * Math.Pow(raio, 3);
        }
    }
}
