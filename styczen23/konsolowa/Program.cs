namespace styczen23;

class Program
{
    static void Main(string[] args)
    {
        string aStr = "";
        int a;
        string bStr = "";
        int b;
        do
        {
            Console.WriteLine("Wprowadź liczbę a:");
            aStr = Console.ReadLine();
        }
        while (!int.TryParse(aStr.Trim(),out a));
        
        do
        {
            Console.WriteLine("Wprowadź liczbę b:");
            bStr = Console.ReadLine();
        }
        while (!int.TryParse(bStr.Trim(),out b));

        int GCD = findGreatestCommonDivisor(a,b);
        Console.WriteLine($"Największy wspólny dzielnik liczb {a} i {b} to: {GCD}");

    }

    static int findGreatestCommonDivisor(int a, int b)
    {
        while (a != b)
        {
            if (a > b) a = a-b;
            else b = b-a;
        } 
        return a;
    }
}
