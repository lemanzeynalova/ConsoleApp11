namespace ConsoleApp11
{
    internal class Program
    {
        static bool SadəMiMürəkkəb(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Ədədi daxil edin: ");
            int eded = int.Parse(Console.ReadLine());
            bool netice = SadəMiMürəkkəb(eded);
            Console.WriteLine(netice ? "Sadə" : "Mürəkkəb");
        }
    }
}