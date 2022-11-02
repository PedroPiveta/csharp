using System;

namespace Calc1{ //serve para organizar o código
    class Area{
    public static double Quad(double bas, double alt){
        if(bas==0 || alt==0){
            throw new Exception("Base ou altura não podem ser zero");
        }
        return bas*alt;
        }
    }
}

namespace Calc2{ //pode ter o mesmo nome de classe, mas não pode ter o mesmo nome de namespace
    class Area{
    public static double Quad(double bas, double alt){
        if(bas==0 || alt==0){
            throw new Exception("Base ou altura não podem ser zero");
        }
        return bas*alt;
        }
    }
}

class Aula54{
    static void Main(){


        double area=0;
        int n1, n2, res;
        res=n1=n2=0;

        n1=10;
        n2=0;

        try{
            area=Calc1.Area.Quad(n1, n2);
            Console.WriteLine("Área: {0}", area);
        }catch(Exception e){ 
            Console.WriteLine("ERRO: {0}", e.Message);
        }finally{ // é executado sempre, mesmo que não ocorra exceção
            Console.WriteLine("Fim do processo");
        }


    }
}