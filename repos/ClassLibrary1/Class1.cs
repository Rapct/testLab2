namespace ClassLibrary1
{
    public class Class1
    {
        public static double MyRoot(double number)
        {
            double root;
            root = Math.Sqrt(number);
            Console.WriteLine("The square root of " + number + " is " +
            root);
            return root;
        }
    }
}
