namespace OOP;

public class DogExtendExampleProtected : ExampleProtected // extend
{
    public void Speak()
    {
        Console.WriteLine(Type); // OK: kế thừa nên dùng được
    }
}