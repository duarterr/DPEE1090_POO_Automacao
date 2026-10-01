using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar uma lista de alunos
            List<Aluno> alunos = new List<Aluno>();

            // Adicionar alunos à lista
            alunos.Add(new Aluno("João"));
            alunos.Add(new Aluno("Maria"));
            alunos.Add(new Aluno("Pedro"));
            alunos.Add(new Aluno("Ana"));


            // Exibir os nomes dos alunos na lista
            Console.WriteLine("Lista de Alunos:");
            foreach (Aluno aluno in alunos)
                Console.WriteLine(aluno);

            // Remover um aluno da lista
            // O código acima usa uma expressão lambda para especificar um predicado.
            // `a => a.Nome == "Pedro"` é uma expressão lambda que toma um objeto `a` da lista (do tipo `Aluno`)
            // e retorna `true` se o nome do aluno for "Pedro". 
            // `RemoveAll` usa esse predicado para encontrar e remover todos os elementos que satisfazem a condição.
            alunos.RemoveAll(a => a.Nome == "Pedro");

            // Exibir os nomes dos alunos na lista após a remoção
            Console.WriteLine("\nLista de Alunos após a remoção:");
            foreach (Aluno aluno in alunos)
                Console.WriteLine(aluno);

            // Verificar se um aluno está na lista
            string alunoProcurado = "Ana";
            Aluno encontrado = alunos.Find(a => a.Nome == alunoProcurado);

            if (encontrado != null)
                Console.WriteLine($"\n{alunoProcurado} está na lista: {encontrado}");
            else
                Console.WriteLine($"\n{alunoProcurado} não está na lista.");

            // Obter o número de alunos na lista
            int numeroDeAlunos = alunos.Count;
            Console.WriteLine($"\nNúmero de alunos na lista: {numeroDeAlunos}");
        }
    }
}