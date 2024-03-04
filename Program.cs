using System.Globalization;
namespace FuncaoSintaxe { }
class program
{
    // dentro da classe estão as funções. Como o exemplo a baixo o static void = enter point.

    static void Main(string[] args)
    {
        Console.WriteLine("Digite três numeros:");

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        double resultado = Maior(n1, n2, n3);

        Console.WriteLine("Maior = " + resultado);

        // função basica na linguagem C#
    }


    // chamando uma função
    static int Maior(int a, int b, int c)
    {

        int m;

        if (a > b && a > c)
        {
            m = a;
        }
        else if (b > c)
        {
            m = b;


        }
        else
        {
            m = c;
        }
        return m;

    }

}
