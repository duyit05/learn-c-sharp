namespace OOP;

public class Pet
{
    public String Name {get; set;}
    public String Type {get; set;}
    public int Age {get; set;}

    public Pet(string name, string type, int age)
    {
        Name = name;
        Type = type;
        Age = age;
    }

    public void Introduce()
    {
        Console.Write($"Xin chào tôi là {Name} , xuất xứ {Type}, tôi {Age}");
    }
}