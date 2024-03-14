// Classe pai
class Animal {
  constructor(nome, idade) {
    this.nome = nome;
    this.idade = idade;
  }
}

// Subclasse
class Cachorro extends Animal {
    constructor(nome, idade, raca) {
      super(nome, idade);
      this.raca = raca;
    }
  
    apresentacao() {
      console.log(`Olá, eu sou o(a) ${this.nome}, tenho ${this.idade} anos e sou da raca ${this.raca}.`);
    }
  }
  
// Instancia
const cachorro1 = new Cachorro("Toby", 10, "pug");

cachorro1.apresentacao();

// Subclasse
class Elefante extends Animal {
    constructor(nome, idade, peso) {
      super(nome, idade);
      this.peso = peso;
    }
  
    apresentacao() {
      console.log(`Olá, eu sou o(a) ${this.nome}, tenho ${this.idade} anos e peso ${this.peso} kg.`);
    }
  }

// // Instancia
// const elefante1 = new Elefante("Dumbo", 5, 1500);

// elefante1.apresentacao();