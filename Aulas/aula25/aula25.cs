using System;
class Aula25{
    static void Main(){
        int num=80;
        dobrar1(ref num);
        Console.WriteLine(num);
    }

    //passagem por referência
    static void dobrar1(ref int valor){
        valor*=2;
    }
    //passagem por valor
    static void dobrar2(int valor){
        valor*=2;
    }
}