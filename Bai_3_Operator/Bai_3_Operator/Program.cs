
namespace Bai_3_Operator;

class Program
{
     static void Main(string[] args)
     {
          float a = 5;
          int b = 4;
          Console.WriteLine("a + b = {0}" , a + b);
          Console.WriteLine("a - b = {0}" , a - b);
          Console.WriteLine("a * b = {0}" , a * b);
          Console.WriteLine("a / b = {0}" , a / b);
          Console.WriteLine("a % b = {0}" , a % b);

          float result = a + b * 2;
          Console.WriteLine("result: " + result); // = 13
          float result2 = 6 / 2 + 3 * 2;
          Console.WriteLine("result2: " + result2); // = 9
          
          

     }
}