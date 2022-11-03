using System;
using System.Collections.Generic;
class Aula57{
    static void Main(){

        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros); //copia todos os elementos de carros para carros2
        //carros.Clear(); //limpa a lista

        if(carros.Contains("Golf")){ //retorna true se acha e false se não acha
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2);

        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }

        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca); //retorna a posição do elemento
        Console.WriteLine("Carro {0} esta na posicao {1}",ca,pos);

    }
}