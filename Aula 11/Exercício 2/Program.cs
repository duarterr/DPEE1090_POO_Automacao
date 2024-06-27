using System;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando instâncias de carros convencionais
            List<Car> conventionalCars = new List<Car>
            {
                new Car("Corolla", Color.WHITE, 2020),
                new Car("Civic", Color.RED, 2021),
                new Car("Fiesta", Color.BLUE, 2019),
                new Car("Accord", Color.BLACK, 2022),
                new Car("Fusion", Color.WHITE, 2020)
            };

            // Criando instâncias de carros autônomos
            List<AutonomousCar> autonomousCars = new List<AutonomousCar>
            {
                new AutonomousCar("Model S", Color.BLACK, 2022),
                new AutonomousCar("ID.4", Color.BLUE, 2023),
                new AutonomousCar("e-Tron", Color.BLACK, 2021),
                new AutonomousCar("XC90", Color.WHITE, 2020),
                new AutonomousCar("Taycan", Color.RED, 2023)
            };

            // Iterando pela lista de carros convencionais
            Console.WriteLine("Carros Convencionais:");
            foreach (var car in conventionalCars)
            {
                car.ShowInfo(); // Mostra informações do carro convencional
                car.Start();    // Inicia o carro convencional
                car.Stop();     // Para o carro convencional
                Console.WriteLine(); // Espaçamento entre os carros
            }

            Console.WriteLine();

            // Iterando pela lista de carros autônomos
            Console.WriteLine("Carros Autônomos:");
            foreach (var autonomousCar in autonomousCars)
            {
                autonomousCar.ShowInfo(); // Mostra informações do carro autônomo
                autonomousCar.Start();    // Inicia o carro autônomo
                autonomousCar.DefineRoute(); // Define a rota para o carro autônomo
                autonomousCar.Navigate();    // Navega com o carro autônomo
                autonomousCar.Stop();     // Para o carro autônomo
                Console.WriteLine(); // Espaçamento entre os carros
            }
        }
    }
}
