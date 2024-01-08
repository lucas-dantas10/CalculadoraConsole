using System.Globalization;

namespace CalculadoraConsole;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o 1° número: ");
        double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o 2° número: ");
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Qual operação matématica vai ser utilizada?");
        Console.Write("[1] Adição [2] Subtração [3] Multiplicação [4] Divisão : ");
        int choice = int.Parse(Console.ReadLine());

        Calculator op = new Calculator();
        op.N1 = n1;
        op.N2 = n2;

        Dictionary<int, Func<double>> operations = new Dictionary<int, Func<double>>
        {
            { 1, op.Sum },
            { 2, op.Subtraction },
            { 3, op.Multiplication },
            { 4, op.Division }
        };

        if (operations.TryGetValue(choice, out var operation))
        {
            op.Calcule(operation);
        }
        else
        {
            Console.WriteLine("Escolha inválida.");
        }
    }
}