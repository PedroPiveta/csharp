using System;
class Ex6{
    static void Main(){
        double bas, alt;
        double res;
        
        Console.WriteLine("Entre com a base do retângulo: ");
        bas=double.Parse(Console.ReadLine());
        Console.WriteLine("Entre com a altura do retângulo: ");
        alt=double.Parse(Console.ReadLine());

        res=bas*alt;

        Console.WriteLine("A area é igual a: {0}", res);
    }
}