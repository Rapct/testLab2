// Mengtian Lin, CPS3330 * 2 Lab #2.
namespace TestRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, root;
            do
            {
                Console.Write("Enter a number: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a < 0)
                    Console.WriteLine("Please enter a positive number!");
            } while (a < 0);
            root = Root.Root.MyRoot(a);
        }
    }
}
