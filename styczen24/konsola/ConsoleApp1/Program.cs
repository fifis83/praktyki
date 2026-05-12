using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static char checkGender(string pesel)
        {
            return (pesel[9] % 2 == 0) ? 'K' : 'M';
        }

        public static bool checkControlNumber(string pesel)
        {
            int S = 0;
            int M = 0;
            int R = 0;
            int multiplier = 1;
            for (int i = 0; i < 10; i++)
            {
                if((i+1) %4 == 1)
                {
                    multiplier = 1;
                }
                else if((i + 1) % 4 == 2)
                {
                    multiplier = 3;
                }
                else if ((i + 1) % 4 == 3)
                {
                    multiplier = 7;
                }
                else
                {
                    multiplier = 9;
                }
                S += int.Parse(pesel[i].ToString()) * multiplier;
               
            }
            M = S % 10;
            if (M == 0) 
            { 
                R = 0;
            }
            else
            {
                R = 10 - M;
            }
            if (R == int.Parse(pesel[10].ToString())) return true;
            return false;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pesel");
            string peselString = Console.ReadLine();
            
            if(peselString == "")
            {
                peselString = "55030101193";
            }

            if (checkGender(peselString) == 'M')
            {
                Console.WriteLine("Mężczyzna");
            }
            else {
                Console.WriteLine("Kobieta");
            }

            if (checkControlNumber(peselString))
            {
                Console.WriteLine("Zgodność liczby kontrolnej");
            }
            else
            {
                Console.WriteLine("Niezgodność liczby kontrolnej");
            }

        }
    }

    

}
