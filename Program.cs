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

        Console.WriteLine("---------------");
        Console.WriteLine("Select a option: ");

        short res = short.Parse(Console.ReadLine());

        switch(res) {
            case 1: soma(); break;
            case 2: subtrai(); break;
            case 3: multiplication(); break;
            case 4: division(); break;
            case 5: System.Environment.Exit(0); break;
            default: menu(); break;
        }

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

        Console.ReadKey();
        menu();
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

        Console.ReadKey();
        menu();
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

        Console.ReadKey();
        menu();
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

        Console.ReadKey();
        menu();
    }
}
