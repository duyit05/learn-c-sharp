namespace OOP;

public class ExamplePrivate
{
    // Chỉ dùng trong class này
    // Nếu muốn dùng ở hàm main thì phải viet getter setter thủ công
    private string Secret {get; set;}
    
    
    public ExamplePrivate(String secret)
    {
        Secret = secret;
    }

    public String GetSecret()
    {
        return Secret;
    }

    public void SetSecret(String secret)
    {
        Secret = secret;
    }
    public void ShowSecret()
    {
        Console.WriteLine(Secret);
    }
}