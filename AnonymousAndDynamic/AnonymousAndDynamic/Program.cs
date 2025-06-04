using System;

namespace AnonymousAndDynamic
{
    internal class Program
    {

        class Student
        {
            public string Name { get; set; }

            public void Hello() => Console.WriteLine(Name);
        }
        static void PrintInfo(dynamic obj)
        {
            obj.Name = "Duy";
            obj.Hello();

        }
        public static void Main(string[] args)
        {
            
            // biến anonymous -> kiểu vô danh chỉ để đọc không thể gán giá trị 
            // sử dụng từ khóa new  {properties = value, properties = value}
            var Product = new
            {
                Name = "Iphone 10",
                Price = 1000,
                DateProduct = 2025
            };
            Console.WriteLine(Product.Name);
            Console.WriteLine(Product.Price);
            Console.WriteLine(Product.DateProduct);
            
            Console.WriteLine("================================");
            
            // dynamic không cần thiết phải gán giá trị, có thể được gắn với bất kì đối tượng nào,
            // kiểu dữ liệu của dynamic được xác định tại thời điểm thực thi tức là thời điểm chạy chương trình 
            Student student = new Student();
            PrintInfo(student);
        }
    }
}