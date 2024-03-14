// Classe
class Animal {
    constructor(nome, idade) {
      this.nome = nome;
      this.idade = idade;
    }

    fazBarulho () {
        console.log (`O animal ${this.nome} faz barulho`);
    }
  }

// Objetos
let animal1 = new Animal("Toby", 10);
let animal2 = new Animal("Rex", 5);

console.log(animal1);
console.log(animal2);

//animal1.idade = 35;
// console.log(animal1);
// console.log(animal2);

//animal1.fazBarulho ();