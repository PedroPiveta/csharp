using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe derivada 1");
    }
}

class Derivada2:Base{
    public Derivada2(){
        Console.WriteLine("Construtor da classe derivada 2");
    }
}



class Aula38{
    static void Main(){ 
        Derivada2 derivada2 = new Derivada2();
    }
}