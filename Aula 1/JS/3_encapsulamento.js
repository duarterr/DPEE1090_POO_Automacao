// Classe
class Animal {
    #idade;
    
    constructor(nome, idade) {
      this.nome = nome;
      this.#idade = idade;
    }

    fazBarulho () {
      console.log (`O animal ${this.nome} faz barulho`);
    }

    getIdade(){
        return this.#idade;
    } 
  }

// Objeto
let animal1 = new Animal("Toby", 10);

console.log(animal1);
//console.log(animal1.idade);
//console.log(animal1.getIdade());
