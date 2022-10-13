//Ler valor em Celsiu e converter pra Fahrenheit

using System;
class Ex12{
    static void Main(){
        double cel, fahr;

        Console.WriteLine("Entre com a temperatura em graus Celsius: ");
        cel=double.Parse(Console.ReadLine());

        fahr=(1.8*cel)+32;

        Console.WriteLine("Em Fahrenheit: {0}°",fahr);

    }
}