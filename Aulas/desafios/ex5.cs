// Um cliente de uma loja está comprando cinco
// produtos. Crie um algoritmo que solicite o preço de cada um desses produtos e,
// em seguida, exiba o subtotal da venda, o valor do imposto e o valor total
// (subtotal da venda mais o valor do imposto). Suponha que a alíquota do imposto
// seja de 6% sobre o subtotal da venda.
using System;
class Exercicio05{
    static void Main(){
        double[] produto=new double[5];
        double sub=0;
        double imposto=0.06;
        double total=0;

        Console.Write("Digite o valor do primeiro produto: ");
        produto[0]=double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo produto: ");
        produto[1]=double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro produto: ");
        produto[2]=double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do quarto produto: ");
        produto[3]=double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do quinto produto: ");
        produto[4]=double.Parse(Console.ReadLine());


        Console.WriteLine("O subtotal é de: {0:c}",sub=produto[0]+produto[1]+produto[2]+produto[3]+produto[4]);
        Console.WriteLine("A taxa de imposto é de: {0:p}",imposto);
        Console.WriteLine("O total é de: {0:c}",total=sub+(sub*imposto));
        


    }
}