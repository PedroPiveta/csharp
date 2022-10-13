using System;
class Ex10{
    static void Main(){
        double custo, fim;
        double porcento=0.28;
        double imposto=0.45;

        Console.WriteLine("Entre com o preço de custo do carro: ");
        custo=double.Parse(Console.ReadLine());

        fim=((custo*porcento)+custo)+((custo*imposto)+custo);

        Console.WriteLine("Preço de custo: {0:c}\n Percentual distribuidor: {1:p}\n Percentual imposto: {2:p}\n Preço final: {3:c}", custo, porcento, imposto, fim);
        
        
    }
}