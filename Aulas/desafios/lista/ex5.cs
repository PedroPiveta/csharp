using System;
class Ex5{
    static void Main(){
        int num;
        
        Console.WriteLine("Escreve um número: ");
        num=int.Parse(Console.ReadLine());
        num-=1;

        Console.WriteLine(num);
    }
}