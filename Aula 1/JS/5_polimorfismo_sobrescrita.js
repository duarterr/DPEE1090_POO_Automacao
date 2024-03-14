// Classe pai
class Animal {
    constructor(nome, idade) {
        this.nome = nome;
        this.idade = idade;
    }

    fazBarulho() {
        console.log(`O animal ${this.nome} faz barulho`);
    }
}

// Subclasse
class Cachorro extends Animal {
    constructor(nome, idade, raca) {
        super(nome, idade);
        this.raca = raca;
    }

    fazBarulho() {
        console.log(`O cachorro ${this.nome} faz auau`);
    }
}

// Instancia
const animal1 = new Animal("Rex", 5);
const cachorro1 = new Cachorro("Toby", 10, "pug");

animal1.fazBarulho();
cachorro1.fazBarulho();

// // Subclasse
// class Gato extends Animal {
//     constructor(nome, idade, raca) {
//         super(nome, idade);
//         this.raca = raca;
//     }

//     fazBarulho() {
//         console.log(`O gato ${this.nome} faz miau`);
//     }
// }

// const gato1 = new Gato("Mingau", 2, "persa");
// gato1.fazBarulho();
