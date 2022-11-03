using System;
using System.Collections.Generic;
class Aula59{
    static void Main(){

        //string[] vs = {"Carro","Moto","Navio","Aviao"}; pode usar elementos ja existentes
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); //Adiciona elementos no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v="Patinete";
        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo {0} encontrado",v);
        }else{
            Console.WriteLine("Veiculo {0} não encontrado",v);
        }
        // veiculos.Clear(); //limpa a fila
        // Console.WriteLine("Primeiro veiculo: {0}",veiculos.Dequeue()); //retorna e depois remove o primeirop da fila
        // Console.WriteLine("Primeiro veiculo: {0}",veiculos.Dequeue());
        // Console.WriteLine("Primeiro veiculo: {0}",veiculos.Peek()); //retorna o primeiro elemento da fila sem retirá-lo
        foreach(string veic in veiculos){
            Console.WriteLine("Veiculo: {0}",veic);
        }
        Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);

        while(veiculos.Count > 0){
            Console.WriteLine("Veiculo: {0}",veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho da fila: {0}",veiculos.Count);

    }
}