namespace OOP;

public class CatExtendExampleProtectedInternal : ExampleProtectedInternal 
{
    public void show()
    {
        Console.WriteLine(Category); // OK: kế thừa và cùng project
    }
}