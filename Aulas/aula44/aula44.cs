using System;

struct Carro{ // Uma variável de um tipo struct contém diretamente os dados da estrutura, enquanto uma variável de um tipo de classe contém uma referência aos dados
    public string marca;
    public string modelo;

    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor: {0}", this.cor);
    }
}


class Aula44{
    static void Main(){

    Carro c1 = new Carro("Ford","Ka","Vermelho");
    Carro c2 = new Carro("GM","Celta","Preto");

    // c1.marca = "Fiat";
    // c1.modelo = "Uno";
    // c1.cor = "Azul";
    
    //Carro c2; Não funciona pois não foi inicializado

    c1.info();
    c2.info();
    }
}