using System;
class Exercicio03
{
    static void Main()
    {

        string nome, endereco, estado, cep, num, prof;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite seu endereço: ");
        endereco = Console.ReadLine();
        Console.Write("Digite seu estado: ");
        estado = Console.ReadLine();
        Console.Write("Digite seu CEP: ");
        cep = Console.ReadLine();
        Console.Write("Digite seu número de telefone: ");
        num = Console.ReadLine();
        Console.Write("Digite sua profissão: ");
        prof = Console.ReadLine();

        Console.Write("Nome: {0}\nEndereço: {1}\nEstado: {2}\nCEP: {3}\nNúmero telefone: {4}\nProfissão: {5}",nome, endereco, estado, cep, num, prof);
    }
}