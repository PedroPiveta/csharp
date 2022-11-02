using System;

class Mat{
    public static double pi= 3.14;

    public static int dobro(int n){
        return n*2;
    }
}


class Aula49{
    static void Main(){ 
        //Não preciso criar um objeto para acessar o método estático

        double vpi = Mat.pi;
        int num = 10;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));

    }
}