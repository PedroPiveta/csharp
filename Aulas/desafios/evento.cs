// Faça um algoritmo que leia o tempo de duração de um evento em uma fábrica
// expressa em segundos e mostre-o expresso em horas, minutos e segundos.

using System;
    class Desafio{
        static void Main(){
            double duracao=0;
            double duracaomin=0;
            double duracaohora=0;
            
            Console.WriteLine("Digite o tempo de duração do evento em segundos: ");
            duracao=double.Parse(Console.ReadLine());

            duracaomin=duracao/60;
            duracaohora=duracaomin/60;

            Console.WriteLine("Tempo do evento em minutos: {0}",duracaomin);
            Console.WriteLine("Tempo do evento em horas: {0}",duracaohora);
        }
    }
