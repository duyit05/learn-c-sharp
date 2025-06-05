using System;
using System.Net;

namespace VirtualMethodAbstractInterface
{
    class Product
    {
        protected double Price { get; set; }
        // virtual phương thức ảo có the bị ghi đè 
        public virtual void ProductInfo() => Console.WriteLine($"Price: {Price}");
            
        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 5000;
            
        // override ghi de phuong thuoc o lop co so
        public override void ProductInfo()
        {
            Console.WriteLine("IPHONE");
                 
            // base truy cap vao phuong thuc o lop co so
            base.ProductInfo();
        }
    }
    
    // abstract
    abstract class Animal {
        protected string Sound { get; set; }
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Gau Gau");
        }
    }
    
    // INTERFACE
    interface IHinhHoc
    {
        double TinhChuVi();
        double TinhDienTich();
    }

    class HinhChuNhat : IHinhHoc
    {
        public double A { get; set; }
        public double B { get; set; }

        public HinhChuNhat(double _a, double _b)
        {
            A = _a;
            B = _b;
        }

        public double TinhChuVi()
        {
            return 2 * (A + B);
        }

        public double TinhDienTich()
        {
            return A * B;
        }
    }

    class HinhTron : IHinhHoc
    {
        public double r { get; set; }
        
        public HinhTron(double _r) => r = _r;
        
        public double TinhChuVi()
        {
            return 2 * r * Math.PI;
        }

        public double TinhDienTich()
        {
            return Math.PI * r * r;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Iphone iphone = new Iphone();
            iphone.ProductInfo();
            
            Console.WriteLine("================ ABSTRACT ================");
            Dog dog = new Dog();
            dog.MakeSound();
            
            Console.WriteLine("================ INTERFACE ================");
            HinhChuNhat hinh = new HinhChuNhat(4,5);
            Console.WriteLine($"Dien tich: {hinh.TinhDienTich()}");
            Console.WriteLine($"Chu vi: {hinh.TinhChuVi()}");

            HinhTron hinhTron = new HinhTron(1);
            Console.WriteLine($"Chu vi: {hinhTron.TinhChuVi()} , Dien tich: {hinhTron.TinhDienTich()}");
        }
    }
}


