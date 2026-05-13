using System;
namespace egzamint;
class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Ile wygenerować losowań?");
        string result = Console.ReadLine();
        int nrOfDraws = int.Parse(result);
        
        generateRandomNumbers(out int[,] draws,out int[] nrOfOccurences,nrOfDraws);
        printNumbers(draws,nrOfOccurences);
    }

    static void generateRandomNumbers(out int[,] draws,out int[] nrOfOccurences,int nrOfDraws)
    {
        draws = new int[nrOfDraws,6];
        nrOfOccurences = new int[49];
        Array.Fill(nrOfOccurences,0);


        Random rand = new Random();

        for (int i = 0; i < nrOfDraws; i++)
        {
            List<int> usedNumbers = new List<int>();
            for (int j = 0; j < 6; j++)
            {
                int newNumber;
                do
                {
                    newNumber = rand.Next(1,50);
                }
                while(usedNumbers.Contains(newNumber));
                
                draws[i,j] = newNumber;
                usedNumbers.Add(newNumber);
                nrOfOccurences[newNumber-1]++;
            }
        }
    } 

    static void printNumbers(int[,] draws, int[] nrOfOccurences)
    {
            Console.WriteLine("Zestawy wylosowanych liczb");
        for (int i = 0; i < draws.GetLength(0); i++)
        {
            Console.Write($"Losowanie {i+1}: ");
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"{draws[i,j]} ");
            }
            Console.WriteLine("");
        }

        for (int i = 0; i < 49; i++)
        {
            Console.WriteLine($"Wystąpienia liczby {i+1}: {nrOfOccurences[i]}");
        }
    }
}
