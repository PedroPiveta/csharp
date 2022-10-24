using System;

abstract class Veiculo{ //Não pode instanciar objetos apenas herdada
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado){
        this.ligado=ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }

    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMaxima=120;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}
class Aula39{
    static void Main(){
        Carro carro1 = new Carro();

        carro1.aceleracao(-2);

        Console.WriteLine(carro1.getVelAtual());
    }
}