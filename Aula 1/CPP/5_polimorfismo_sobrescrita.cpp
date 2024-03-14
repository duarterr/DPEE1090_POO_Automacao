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

    // Metodo
    void fazBarulho() {
        std::cout << "O animal " << nome << " faz barulho" << std::endl;
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
    
    // Metodo
    void fazBarulho() {
        std::cout << "O cachorro " << nome << " late" << std::endl;
    }   
};

// Subclasse
class Gato : public Animal
{
public:
    // Atributos
    std::string raca;

    // Construtor
    Gato(std::string nome, int idade, std::string raca) : Animal(nome, idade), raca(raca) {}
    
    // Metodo
    void fazBarulho() {
        std::cout << "O gato " << nome << " mia" << std::endl;
    }   
};

int main()
{
    // Instancia da classe
    Animal animal1("Fifi", 12);
    animal1.fazBarulho();

    // Instancia da classe
    Cachorro cachorro1("Toby", 10, "pug");
    cachorro1.fazBarulho();

    // Instancia da classe
    Gato gato1("Mingau", 2, "persa");
    gato1.fazBarulho();

    return 0;
}
