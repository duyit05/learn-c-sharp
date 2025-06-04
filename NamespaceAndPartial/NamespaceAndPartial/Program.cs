using MyNameSpace;
using static System.Console;

namespace NamespaceAndPartial

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // truy cập theo namespace
            Class1.XinChao();
            MyNameSpace.Abc.Class1.XinChao();
            WriteLine("===========================");
            // cách phân chia theo partial
            Product product = new Product();
            product.Name = "Iphone";
            product.Price = 10000;
            product.Description = "Iphone VIP";
            WriteLine(product.GetInfo());
        }
    }
}