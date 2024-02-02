// Mengtian Lin, CPS3330 * 2 Lab #2.
namespace Root
{
    public class Root
    {
        /// <summary>
        /// this method calculates the root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double MyRoot(double number)
        {
            double root;
            root = Math.Sqrt(number);
            Console.WriteLine("The square root of " + number + " is " + root);
            return root;
        }
    }
}
