using System;
using static System.Console;
namespace Generic
{
    internal class Program
    {
        // ví dụ về generic về hàm
        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        
        // ví dụ generic về object
        class Product <T>
        {
           T ID;

            public void SetId(T _id)
            {
                this.ID = _id;
            }

            public void PrintInfo()
            {
                WriteLine($"ID = {this.ID}");
            }
        }
        public static void Main(string[] args)
        {
            string a = "A";
            string b = "B";
            WriteLine($"Befor swap ==> a = {a}, b = {b}");
            Swap(ref a, ref b);
            WriteLine($"After swap ===> a = {a}, b = {b}");
            
            WriteLine("==================================");
            Product<int> product1 = new Product<int>();
            product1.SetId(123);
            product1.PrintInfo();

            Product<string> product2 = new Product<string>();
            product2.SetId("ABC");
            product2.PrintInfo();

        }
    }
}