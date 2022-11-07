class Program
{
     static void Main(string[] args)
    {
        menu();
    }

    static void menu(){
        Console.WriteLine("What to do first? ");
        Console.WriteLine("1 - SUN");
        Console.WriteLine("2 - SUBTRACT");
        Console.WriteLine("3 - MULTIPLICATE");
        Console.WriteLine("4 - DIVIDE");


    }
    static void soma(){
        Console.Clear();
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");


        float resultado = v1 + v2;
       // Console.WriteLine("O resultado da soma é: " + resultado);
        Console.WriteLine($"O resultado da soma é {resultado}");
        //Console.WriteLine($"O resultado da soma é {v1 + v2}");
    }
    static void subtrai(){
        Console.Clear();
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 - v2;

        Console.WriteLine($"O resultado da subtração é {resultado}");
    }
    static void multiplication(){
        Console.Clear();
        Console.WriteLine("First value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second Value: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 * v2;

        Console.WriteLine($"THe result of the multiplication is {result}");
    }
    static void division(){
        Console.Clear();
        Console.WriteLine("First value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second Value: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 / v2;

        Console.WriteLine($"The result of the divison is {result}");
    }
}