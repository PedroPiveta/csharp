using System;
class Aula52{
    static void Main(){

        int n1, n2, res;
        res=n1=n2=0;

        n1=10;
        n2=0;

        try{
            res=n1/n2;
            Console.WriteLine("Divisão: {0}/{1}={2}", n1, n2, res);
        }catch(Exception e){ //DivideByZeroException pode ser usada já que é a exceção que ocorre
            Console.WriteLine("ERRO: {0}", e.Message);
            Console.WriteLine("Ex: {0}", e.GetType());
        }


    }
}