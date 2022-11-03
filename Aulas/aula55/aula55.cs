using System;
using System.Collections.Generic;
class Aula55{
    static void Main(){

        Dictionary <int,string> veiculos = new Dictionary <int,string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Aviao");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        // veiculos.Clear(); //limpa o dicionário      

        veiculos.Remove(20); //remove o item com a chave 20

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        
        int chave=20; //procurar chave
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("Chave {0} existe", chave);
        }else{
            Console.WriteLine("Chave {0} não existe", chave);
        }

        veiculos[15]="Bicicleta"; //alterar valor

        string valor = "Bicicleta"; //procurar valor
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("Valor {0} existe", valor);
            
        }else{
            Console.WriteLine("Valor {0} não existe", valor);
        }

        Dictionary <int,string>.ValueCollection valores = veiculos.Values; //retorna os valores do dicionário

        // foreach(KeyValuePair<int,string> v in veiculos){
        //     Console.WriteLine(v.Value);
        // }

        foreach(string v in valores){
            Console.WriteLine(v);
        }

    }
}