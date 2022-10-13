using System;
class aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main(){
        
        int ds=(int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}
 // DiasSemana ds = (DiasSemana)0; = Domingo

 // int ds=(int)DiasSemana.Sexta; = 5