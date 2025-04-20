namespace BranchIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input number a: ");
            float a = float.Parse(Console.ReadLine());
            if (a < 5.0)
            {
                Console.Write("Hoc luc yeu");
            }
            else if (a >= 5.0 && a <= 6.5)
            {
                Console.Write("Hoc luc trung binh");
            }
            else if (a >= 6.5 && a <= 8.0)
            {
                Console.Write("Hoc luc kha");
            }
            else if (a >= 8.0 && a <= 10)
            {
                Console.Write("Hoc luc gioi");
            }
            else
            {
                Console.Write("Hoc luc kem");
            }
        }
    }
}