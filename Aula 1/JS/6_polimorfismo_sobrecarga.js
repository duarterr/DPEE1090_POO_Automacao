// NOTA: JS não permite duas funções com mesmo nome na mesma classe, 
// então implementação do polimorfismo de sobrecarga não é tão simples
// como em C++ por exemplo.

// Classe
class Calculadora {   
    // Metodo soma tres numeros
    soma (a, b, c) {
        if (c === undefined)
            return a + b;
        else 
            return a + b + c;
    }
}

// Objetos
let Calc = new Calculadora();

console.log(Calc.soma(1, 2));
console.log(Calc.soma(1, 2, 3));