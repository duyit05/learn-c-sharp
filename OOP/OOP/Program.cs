namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        // Example public
        ExamplePublic examplePublic = new ExamplePublic();
        examplePublic.Name = "Hello";
        Console.Write("example public: ");
        examplePublic.introduce();
        
        // Example private
        ExamplePrivate examplePrivate = new ExamplePrivate("JWT");
        // Không truy cập được
        // Console.Write(examplePrivate.Secret); // ERROR: không truy cập được do không thuộc class
        
        // Cách truy private khi đã có getter và setter giống java
        examplePrivate.SetSecret("New JWT");
        Console.WriteLine("example private: " + examplePrivate.GetSecret());
        Console.Write("show private: ");
        examplePrivate.ShowSecret();
        
        
        // Example protected;
        ExampleProtected exampleProtected = new ExampleProtected();
        DogExtendExampleProtected dogExtendExampleProtected = new DogExtendExampleProtected();
        Console.Write("example protected: ");
        dogExtendExampleProtected.Speak();
        
        // Example internal
        ExampleInternal exampleInternal = new ExampleInternal();
        Console.Write("example internal: ");
        Console.WriteLine(exampleInternal.Kind); // OK: cùng project
        
        // Example Protected and Internal
        ExampleProtectedInternal protectedInternal = new ExampleProtectedInternal();
        CatExtendExampleProtectedInternal catExtendExampleProtectedInternal = new CatExtendExampleProtectedInternal();
        Console.Write("example protected internal: ");
        Console.Write(catExtendExampleProtectedInternal.Category); // OK: cùng project
        
        // Example Private and Protected
        ExamplePrivateProtected examplePrivateProtected = new ExamplePrivateProtected();
        FishExtendExamplePrivateProtected fish = new FishExtendExamplePrivateProtected();
        //Console.WriteLine("example private and protected: " + examplePrivateProtected.Sound); // không được
    }
}