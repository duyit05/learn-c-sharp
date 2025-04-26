namespace Struct;

class Program
{
    // struct
    public struct ProductStruct
    {
        // trường dữ liệu
        public string Name;

        public double Price;
        // phương thức

        public string GetInfo()
        {
            return $"Tên sản phẩm {Name}, giá: {Price}";
        }

        public string Info
        {
            get
            {
                return $"{Name} , {Price}";
            }
        }

        // constructor
        public ProductStruct(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    
    public class ProductClass
    {
        public string Name;
        public double Price;

        public ProductClass(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Info
        {
            get
            {
                return $"{Name} , {Price}";
            }
        }

        public string GetInfo()
        {
            return $"Tên sản phẩm {Name}, giá: {Price}";
        }
    }

    enum  HocLuc
    {
        KÉM = 10,           
        TRUNG_BÌNH = 123,    
        KHÁ = 333,          
        GIỎI = 223     
    }

    static void Main()
    {
        
        // ví dụ về struct
        ProductStruct product1;
        product1.Name = "Iphone";
        product1.Price = 10000;

        ProductStruct product2 = new ProductStruct();
        product2.Name = "Nokia";
        product2.Price = 20000;
        
        // struct là kiểu tham trị, trong phép gán hay truyền giữ liệu giữa các phương thức
        // sao chép về giá trị chứ không tham chiếu đối tượng
        
        // 2 biến này là 2 biến độc lập nhau
        product2 = product1;
        // khi set Name mới cho product2 thì chỉ có product2 thay đổi tên còn product1 vẫn giữ nguyên 
        product2.Name = "Iphone test X";
        Console.WriteLine("Product struct 1: " + product1.GetInfo());
        Console.WriteLine("Product struct 2: " + product2.GetInfo());
        Console.WriteLine(product2.Info);
        
        Console.WriteLine("=============================================");
        
        // ví dụ về class
        ProductClass productClass1 = new ProductClass("Samsung" , 50000);
        ProductClass productClass2 = new ProductClass("HoNo", 60000);
        
        productClass2 = productClass1;
        
        // khi gán Name mới cho productClass2 thì Name của cả 2 product sẽ bị thay đổi vì cùng tham chiếu đến 1 đối tượng
        productClass2.Name = "Iphone test";
        Console.WriteLine("Product class 1: " + productClass1.GetInfo());
        Console.WriteLine("Product class 2: " + productClass2.GetInfo());
        Console.WriteLine(productClass2.Info);
        
        
        Console.WriteLine("=================== ENUM ==================");
        // ví dụ về kiểu Unum
        HocLuc hocLuc;
        hocLuc = HocLuc.KHÁ;
        
        // ép kiểu enum sang số
        int number = (int)hocLuc;
        Console.WriteLine("Ép kiểu từ enum sang số: " + number);

        // ép kiểu từ số sang enum
        hocLuc = (HocLuc)(333);
        Console.WriteLine("Ép kiểu từ số sang enum: " + hocLuc);
        
        switch (hocLuc)
        {
            case HocLuc.KÉM:
                Console.WriteLine("Học lực kém");
                break;
            case HocLuc.TRUNG_BÌNH:
                Console.WriteLine("Học lực trung bình");
                break;
            case HocLuc.KHÁ:
                Console.WriteLine("Học lực khá");
                break;
            case HocLuc.GIỎI:
                Console.WriteLine("Học lực giỏi");
                break;
        }
    }
}