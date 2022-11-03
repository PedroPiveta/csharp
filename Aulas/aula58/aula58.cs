using System;
using System.Collections.Generic;
class Aula58{
    static void Main(){

        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //carros2.AddRange(carros); //copia todos os elementos de carros para carros2
        //carros.Clear(); //limpa a lista

        if(carros.Contains("Golf")){ //retorna true se acha e false se não acha
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2);

        carros.Insert(1,"Cruze");

        int pos2 = carros.LastIndexOf("HRV"); //retorna a posição do elemento

        //carros.Remove("Argo");
        //carros.RemoveAt(0);

        // carros.Reverse();
        carros.Sort(); //ordena por ordem alfabetica

        int tamanho = carros.Count; //retorna o tamanho da lista
        carros.Capacity=15; //aumenta a capacidade da lista
        int capa = carros.Capacity; //retorna a capacidade da lista

        Console.WriteLine("Tamanho da lista: {0}",tamanho);
        Console.WriteLine("Capacidade: {0}",capa);

        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }

        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca); //retorna a posição do elemento
        Console.WriteLine("Carro {0} esta na posicao {1}",ca,pos);
        Console.WriteLine("Ultimo HRV esta na posicao {0}",pos2);

    }
}