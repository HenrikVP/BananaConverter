namespace BananaConverter
{
    internal class Program
    {
        const double standardBananaSize = 18;

        static void Main(string[] args)
        {
            while (true)
            {
                StartHere();
                Console.WriteLine("Try again (Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    break;
                }
            }
            
        }

        static void StartHere()
        {
            Console.WriteLine("Convert Banana to cm.");
            Console.Write("How many Bananas?");

            double amountBanana = GetInput();
            double result = ConvertToCm(amountBanana);
            ShowResult(amountBanana, result);
        }

        static double GetInput()
        {
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount)) 
            {
                Console.WriteLine("Error. Try again.");
            }
            return amount;
        }

        static double ConvertToCm(double banana)
        {
            return banana * standardBananaSize;
        }

        static void ShowResult(double amount, double result)
        {
            Console.WriteLine(amount + " banana equals " + result + 
                " cm. with a standard size of banana equal " + standardBananaSize);
        }
    }
}