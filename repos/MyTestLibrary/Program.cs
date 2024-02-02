            double a, root;
            do
            {
                Console.Write("Enter a number: ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a < 0)
                    Console.WriteLine("Please enter a positive number!");
            } while (a < 0);
            root = ClassLibrary1.Class1.MyRoot(a);
        