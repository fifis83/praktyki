namespace styczen25;

class Program
{
    static void Main(string[] args)
    {
        Table table = new Table(21);
        table.Print();
        int index = table.IndexOf(10);
        if(index != -1) Console.WriteLine($"Liczba 10 znaleziona pod indexem {index}");
        Console.WriteLine("Razem Nieprazystych: "+table.PrintOdd());
        Console.WriteLine($"Średnia wszystkich elementów: {table.Average()}");

    }
}
