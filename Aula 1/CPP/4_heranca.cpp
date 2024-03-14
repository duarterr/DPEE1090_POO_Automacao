#include <iostream>
#include <string>

// Classe pai
class Animal
{
public:
    // Atributos
    std::string nome;
    int idade;

    // Construtor
    Animal(std::string nome, int idade)
    {
        this->nome = nome;
        this->idade = idade;
    }
};

// Subclasse
class Cachorro : public Animal
{
public:
    // Atributos
    std::string raca;

    // Construtor
    Cachorro(std::string nome, int idade, std::string raca) : Animal(nome, idade), raca(raca) {}

    void apresentacao()
    {
        std::cout << "Olá, eu sou o(a) " << nome << ", tenho " << idade << " anos e sou da raça " << raca << "." << std::endl;
    }
};

// Subclasse
class Elefante : public Animal {
public:
    int peso;

    Elefante(std::string nome, int idade, int peso) : Animal(nome, idade), peso(peso) {}

    void apresentacao() {
        std::cout << "Olá, eu sou o(a) " << nome << ", tenho " << idade << " anos e peso " << peso << " kg." << std::endl;
    }
};

int main()
{
    // Instancia da classe
    Cachorro cachorro1("Toby", 10, "pug");
    cachorro1.apresentacao();

    Elefante elefante1 = Elefante("Dumbo", 5, 1500);
     elefante1.apresentacao();

    return 0;
}
