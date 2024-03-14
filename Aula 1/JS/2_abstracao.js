// Classe
class Calculadora {
    // Metodo soma dois numeros
    soma (a, b) {
        return a + b;
    }

    // Metodo multiplica dois numeros
    multiplica (a, b) {
        return a * b;
    }
    
    // // Metodo multiplica dois numeros
    // multiplica (a, b) {
    //     a = a*10;
    //     b = b*100;
        
    //     return (a*b)/1000;
    // }    
  }

// Objetos
let Calc = new Calculadora();

console.log(Calc.soma(1, 2));
console.log(Calc.multiplica(2, 5));
