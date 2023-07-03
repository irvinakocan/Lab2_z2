using System;

namespace Lab2_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli broj n:");
            string unos = Console.ReadLine();
            int n = Int32.Parse(unos);

            int x = n - 1, y = n - 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 2*n - 1; j++)
                {
                    if(j >= x && j <= y)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine("");
                x--;
                y++;
            }
        }
    }
}