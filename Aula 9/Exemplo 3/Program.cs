using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar uma lista de alunos
            List<string> alunos = new List<string>();

            // Adicionar alunos à lista
            alunos.Add("João");
            alunos.Add("Maria");
            alunos.Add("Pedro");
            alunos.Add("Ana");

            // Exibir os nomes dos alunos na lista
            Console.WriteLine("Lista de Alunos:");
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Remover um aluno da lista
            alunos.Remove("Pedro");

            // Exibir os nomes dos alunos na lista após a remoção
            Console.WriteLine("\nLista de Alunos após a remoção:");
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Verificar se um aluno está na lista
            string alunoProcurado = "Ana";
            if (alunos.Contains(alunoProcurado))
                Console.WriteLine($"\n{alunoProcurado} está na lista.");        
            else
                Console.WriteLine($"\n{alunoProcurado} não está na lista.");

            // Obter o número de alunos na lista
            int numeroDeAlunos = alunos.Count;
            Console.WriteLine($"\nNúmero de alunos na lista: {numeroDeAlunos}");
        }
    }
}