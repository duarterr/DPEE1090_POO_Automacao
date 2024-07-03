using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Atuador MyAtuador = new Atuador();
            Sensor MySensor = new Sensor();
            Controlador MyControlador = new Controlador();

            // Demonstração
            MyAtuador.Operar();
            MySensor.Operar();
            MyControlador.Operar();
        }
    }
}