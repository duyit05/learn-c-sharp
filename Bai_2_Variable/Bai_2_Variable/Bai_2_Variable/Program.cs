using System.Text;

namespace  Bai_2_Variable;

class Program
{
    static void Main(string[] args)
    {
        // Title in terminal
        Console.Title = "Variable";
        // Clear all content pre
        Console.Clear();
        // Change text color
        Console.ForegroundColor = ConsoleColor.Green;
        // Change background color
        Console.BackgroundColor = ConsoleColor.White;

        Console.Write("Enter full name: ");
        string fullName = Console.ReadLine();
        Console.WriteLine("Hello: " + fullName);
        float a, b;
        string input;
        Console.Write("input a: ");
        // type casting
        input = Console.ReadLine();
        a = float.Parse(input);
        a = Convert.ToSingle(input);
        
        Console.Write("input b: ");
        input = Console.ReadLine();
        b = float.Parse(input);
        
        Console.Write("number a = {0} , number b = {1}",a,b);
    }
}