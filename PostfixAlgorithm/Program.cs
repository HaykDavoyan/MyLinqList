namespace PostfixAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter the Postfix combination: ");
            string combination = Console.ReadLine();

            if (!PostCalc.IsValid(combination))
            {
                Console.WriteLine("Invalid combination. ");
                continue;
            }

            try
            {
                double result = PostCalc.PostfixCalc(combination);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Do you want to continue? Yes/No");
        } while (Console.ReadLine().ToUpper() == "YES");
    }
}
