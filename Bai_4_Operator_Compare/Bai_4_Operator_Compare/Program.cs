namespace Bai_4_Operator_Compare;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 6;
        Console.WriteLine($"{a} > {b} is {a > b}");
        Console.WriteLine($"{a} < {b} is {a < b}");
        Console.WriteLine($"{a} = {b} is {a == b}");
        Console.WriteLine($"{a} >= {b} is {a >= b}");
        Console.WriteLine($"{a} <= {b} is {a <= b}");
        Console.WriteLine($"{a} != {b} is {a != b}");

        bool result;
        bool result1;
        bool result2;

        bool z = true;
        bool x = false;

        result = z && x;
        result1 = z || x;

        Console.Write(result);
        Console.Write(result1);

    }
}
