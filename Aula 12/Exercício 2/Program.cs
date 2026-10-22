using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        // Método principal do programa, ponto de entrada da aplicação
        static void Main(string[] args)
        {
            SistemaMonitoramento sistema = new SistemaMonitoramento();
            sistema.IniciarMonitoramento();
        }
    }
}
