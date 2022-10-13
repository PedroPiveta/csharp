using System;
class Tabuada{
    static void Main(){
        int num,res=0;
        
        Console.WriteLine("Entre com o número cuja tabuada será calculada");
        num=int.Parse(Console.ReadLine());

        Console.WriteLine(num);
        for(int i=0; i<11; i++){
            res=num*i;
            Console.WriteLine(num + " X " + i + " = " + res);
        }
    } 
}