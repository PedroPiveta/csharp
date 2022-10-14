using System;

class Veiculo{ //Base
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{
    public string nome;
    public Carro(string nome, int vm):base(vm){ //Derivada de Veículo
        this.nome=nome;
        ligado=true;
    }
}
class Aula36{
    static void Main(){
        
        Carro carro=new Carro("Insano",120);

        Console.WriteLine("Nome:{0}",carro.nome);
        Console.WriteLine("Vel. máxima:{0}",carro.getVelMax());
        Console.WriteLine("Ligado:{0}",carro.getLigado());

    }
}