using System;

class Area{
    public static double Quad(double bas, double alt){
        if(bas==0 || alt==0){
            throw new Exception("Base ou altura não podem ser zero");
        }
        return bas*alt;
    }
}
class Aula53{
    static void Main(){


        double area=0;
        int n1, n2, res;
        res=n1=n2=0;

        n1=10;
        n2=0;

        try{
            area=Area.Quad(n1, n2);
            Console.WriteLine("Área: {0}", area);
        }catch(Exception e){ 
            Console.WriteLine("ERRO: {0}", e.Message);
        }finally{ // é executado sempre, mesmo que não ocorra exceção
            Console.WriteLine("Fim do processo");
        }


    }
}