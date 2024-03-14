#include <iostream>

// Classe
class Calculadora {
public:
    // Método soma dois números
    int soma(int a, int b) {
        return a + b;
    }

    // // Método multiplica dois números
    // int multiplica(int a, int b) {
    //     return a * b;
    // }
    
    // Método multiplica dois números - Jeito 2
    int multiplica (int a, int b) {
        a = a*10;
        b = b*100;

        return (a*b)/1000;
    }
};

int main() {
    // Instancia da classe
    Calculadora Calc; // Objeto

    std::cout << Calc.soma(1, 2) << std::endl;
    std::cout << Calc.multiplica(2, 5) << std::endl;

    return 0;
}