namespace OOP;

public class FishExtendExamplePrivateProtected : ExamplePrivateProtected
{
    public void Bark()
    {
        Console.WriteLine(Sound); // OK: kế thừa & cùng project
    }
}