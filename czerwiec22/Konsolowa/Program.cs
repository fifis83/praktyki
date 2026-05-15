namespace czerwiec22;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jaką liczbę chcesz wyszukać?");
        int userNum = int.Parse(Console.ReadLine());
        int[] arr = generateRandomArray(51,userNum);
        for (int i = 0; i < arr.Length-1; i++)
        {
            Console.Write($"{arr[i]},");
        }
        int foundIndex = search(arr,userNum);
        if (foundIndex == -1)
        {
            Console.WriteLine($"Nie znaleziono liczby {userNum}");
        }
        else
        {
            Console.WriteLine($"Znaleziono liczbę {userNum} pod indexem {foundIndex}");
        }
    }

    static int[] generateRandomArray(int length,int numToFind)
    {
        int[] arr = new int[length+1];
        Random rand = new Random();
        for (int i = 0; i < length; i++)
        {
            arr[i] = rand.Next(1,101);
        }
        arr[length] = numToFind;
        return arr;
    }

    static int search(int [] arr,int x)
    {
        int index;
        for (index = 0; index < arr.Length; index++)
        {
            if(arr[index]==x) break;
        }
        return index==arr.Length-1?-1:index;
    }
}
