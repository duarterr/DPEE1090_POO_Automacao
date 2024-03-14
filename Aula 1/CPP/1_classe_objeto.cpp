#include <iostream>
#include <string>

// Classe
class Animal {
public:
  // Atributos
  std::string nome;
  int idade;

  // Metodo
  void fazBarulho() {
    std::cout << "O animal " << nome << " faz barulho" << std::endl;
  }
};

int main() {
  // Instancias da classe
  Animal animal1("Toby", 10);
  Animal animal2("Rex", 5);

  std::cout << animal1.nome << std::endl;
  std::cout << animal1.idade << std::endl;

  std::cout << animal2.nome << std::endl;
  std::cout << animal2.idade << std::endl;

  animal1.fazBarulho();

  animal1.idade = 20;
  std::cout << animal1.idade << std::endl;
  std::cout << animal2.idade << std::endl;
  
  return 0;
}
