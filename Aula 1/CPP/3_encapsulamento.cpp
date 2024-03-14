#include <iostream>
#include <string>

class Animal
{
private:
    int idade;

public:
    std::string nome;

    Animal(std::string nome, int idade)
    {
        this->nome = nome;
        this->idade = idade;
    }

    int getIdade()
    {
        return idade;
    }
};

int main()
{
    Animal animal1("Toby", 10);

    //std::cout << animal1.idade << std::endl;
    std::cout << animal1.getIdade() << std::endl;

    return 0;
}
