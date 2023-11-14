namespace BananaConverter
{
    internal class Program
    {
        // Const cannot be changed. The value is set at compiling, not runtime.
        const double standardBananaSize = 18;

        // Static void Main is run at program startup. string[] args is used to
        // intercept cli commands.
        static void Main(string[] args)
        {
            // Small method that sets up the color and size.
            SetupGui();

            // Writes out the commandline interface (CLI) commands.
            // Foreach is one of the loops together with For, While and Do While
            foreach (var arg in args) Console.WriteLine(arg);

            // Infinite loop (while(true)) There should ALWAYS be an exit
            // strategy when using infinite loops.
            while (true)
            {
                BananaConverter();
                Console.WriteLine("Try again (Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    //Environment.Exit(0);
                    break;
                }
            }
        }

        private static void SetupGui()
        {
            Console.SetWindowSize(30, 10);
            Console.SetBufferSize(30, 10);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        /// <summary>
        /// Our main method in the bananaconverter.
        /// </summary>
        static void BananaConverter()
        {
            Console.WriteLine("Convert Banana to cm.");
            Console.Write("How many Bananas?");

            double amountBanana = GetInput();
            double result = ConvertToCm(amountBanana);
            ShowResult(amountBanana, result);
        }

        /// <summary>
        /// Gets User input, converts to double and returns it.
        /// </summary>
        /// <returns></returns>
        static double GetInput()
        {
            double amount;
            // TryParse returns a bool. True if it can parse the string value,
            // otherwise false. Since WHILE runs if true we false
            // the method with logical NOT operator (!), so it becomes
            // true if not possible to convert, thus continuing the loop.
            while (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Error succesfully failed.");
            }
            return amount;
        }

        /// <summary>
        /// Simple calculation that multiplies amount of banana with standard banana size.
        /// </summary>
        /// <param name="banana"></param>
        /// <returns>size in cm.</returns>
        static double ConvertToCm(double banana)
        {
            return banana * standardBananaSize;
        }

        /// <summary>
        /// Prints out the result in console.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="result"></param>
        static void ShowResult(double amount, double result)
        {
            //String interpolation examples
            //string s1 = amount + " banana equals " + result +
            //    " cm. with a standard size of banana equal " + standardBananaSize;
            //Console.WriteLine("{0} banana equals {1} cm. with a standard size of banana equal {2}", 
            //    amount, result, standardBananaSize);
            string s2 = $"{amount} banana equals {result} cm. " +
                $"with a standard size of banana equal {standardBananaSize}";
            Console.WriteLine(s2);
            //    Console.WriteLine(amount + " banana equals " + result +
            //        " cm. with a standard size of banana equal " + standardBananaSize);

        }
    }
}