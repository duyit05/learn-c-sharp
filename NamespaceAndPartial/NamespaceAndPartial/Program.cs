using System;
using MyNameSpace;
using xyz = MyNameSpace.Abc;
namespace NamespaceAndPartial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class1.XinChao();
            xyz.Class1.XinChao();
        }
    }
}