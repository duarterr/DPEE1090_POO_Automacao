#include <iostream>

// Classe
class Calculadora {
public:
    // Método soma dois números
    int soma(int a, int b) {
        return a + b;
    }

    // Método soma tres números
    int soma(int a, int b, int c) {
        return a + b + c;
    }
};

int main() {
    // Instancia da classe
    Calculadora Calc; // Objeto

    std::cout << Calc.soma(1, 2) << std::endl;
    std::cout << Calc.soma(1, 2, 3) << std::endl;

    return 0;
}