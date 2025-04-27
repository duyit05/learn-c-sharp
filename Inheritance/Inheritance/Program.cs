using System;

namespace Inheritance
{
    internal class Program
    {
        // "sealed" dùng để niêm phong lớp cha lại, không cho kế thừa
        class Animal
        {
            public Animal()
            {
                Console.WriteLine("Khởi tạo animal");
            }

            public Animal(string abc)
            {
                Console.WriteLine($"Khoi tao Animal (2) - {abc}");
            }
            public int Legs { get; set; }
            public float Weight { get; set; }

            public void ShowLegs()
            {
                Console.WriteLine($"Legs: {Legs}");
            }
        }

        class Cat : Animal
        {
            public string Food;

            public Cat(string s) : base(s)
            {
                this.Legs = 4;
                this.Food = "Mouse";
                Console.WriteLine("Khởi tạo lớp Cat");
            }

            public void Eat()
            {
                Console.WriteLine(Food);
            }
            
            // từ khóa "new" dùng để khai báo lại method trong lớp cha
            public new void ShowLegs()
            {
                Console.WriteLine($"Mèo có số chân là: {Legs}");
            }

            public void ShowInfo ()
            {
                // từ khóa "base" dùng để truy cập vào method của lớp cha
                base.ShowLegs();
                ShowLegs();
            }
            
        }

        public static void Main(string[] args)
        {
            Cat cat = new Cat("ABC");
            
        }
    }
}