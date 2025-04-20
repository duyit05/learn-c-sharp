namespace OOP;

public class ExamplePublic
{
    
    // Truy cập moi nơi
    public string Name {get; set;}
    
    public ExamplePublic()
    {
       
    }
    
    public ExamplePublic(String name)
    {
        Name = name;
    }

    public void introduce()
    {
        Console.WriteLine("Example public: " + Name);
    }
}