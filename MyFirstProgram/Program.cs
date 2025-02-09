using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Find the hypotenuse
        Console.WriteLine("Enter Triangle side A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Triangle side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt((a * a) + (b * b));
        Console.WriteLine("The hypotenuse of this triangle is: " + c);
    }
}
