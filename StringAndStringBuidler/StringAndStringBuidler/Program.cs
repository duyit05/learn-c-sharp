using System.Text;

namespace StringAndStringBuilder;

class Program
{
    static void Main(string[] args)
    {
        string notification = "****Nguyen Van Duy, xin chao cac ban";
        notification = notification.Trim('*');
        int length = notification.Length;

       
        Console.WriteLine(notification);
        for (int i = 0; i < length; i++)
        {
            char c = notification[i];
            Console.WriteLine($"chi so {i} la ky tu: {c}");
        }

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Xin");
        stringBuilder.Append(" chao cac ban");
        stringBuilder.Replace("Xin chao", "Cho mung");

        String result = stringBuilder.ToString();
        Console.WriteLine(result);
    }
}