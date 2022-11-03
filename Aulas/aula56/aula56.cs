using System;
using System.Collections.Generic;
class Aula56{
    static void Main(){
        
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");

        LinkedListNode<string> no;

        no=transp.FindLast("Navio").Next; //vai apontar para o próximo = avião
        transp.AddAfter(no,"Patinete");

        no=transp.FindLast("Navio");
        transp.AddBefore(no,"Patins");

        // transp.Clear(); //limpa a lista

        if(transp.Find("Carro")==null){ //retorn null se não encontrar
            Console.WriteLine("Elemento Não encontrado");
        }else{
            Console.WriteLine("Elemento Encontrado");
        }

        //transp.Remove("Navio");
        transp.RemoveFirst();
        transp.RemoveLast();

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);
        }

    }
}