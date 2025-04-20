namespace SwitchCase;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.Write("enter a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("enter b: ");
        b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Hay chon lenh");
        Console.WriteLine("(1) tinh tong");
        Console.WriteLine("(2) tinh hieu");
        Console.WriteLine("(3) tinh thong");
        Console.WriteLine("(4) tinh chia");

        char c = Console.ReadKey().KeyChar;
        switch (c)
        {
            case '1':
                Console.WriteLine($"Tong la: {a + b}");
                break;
            case '2':
                Console.WriteLine($"Hieu la: {a - b}");
                break;
            case '3':
                Console.WriteLine($"Tich la : {a * b}");
                break;
            case '4':
                Console.WriteLine($"Thuong la: {a / b}");
                break;
            default:
                Console.WriteLine("Sai");
                break;
        }
    }
}