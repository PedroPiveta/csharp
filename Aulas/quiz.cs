using System;
class Quiz{
    static void Main(){
        char ans;

        Console.WriteLine("HTML é uma linguagem de: ");
        Console.WriteLine("a) Programação");
        Console.WriteLine("b) Marcação");
        Console.WriteLine("c) Estilo");
        Console.WriteLine("d) Banco de dados");
        Console.Write("Resposta: ");

        ans = Convert.ToChar(Console.ReadLine());
        try{
            while(ans != 'b'){
            Console.WriteLine("Resposta errada!");
            Console.Write("Resposta: ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        Console.WriteLine("Resposta correta!");
        } catch {
            Console.WriteLine("Resposta inválida!");
        }
    }
        
}