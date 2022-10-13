using System;
public class Jogador{  // se não por nada na class ela é sempre public
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi removido",nome);
    }
}
class Aula29{
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o nome do jogador 1:");
        nome1=Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Victor");
        
        Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
    }

}