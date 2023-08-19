using System;

namespace drawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 0;
            Console.Write("Uzunluk ölçüsü giriniz: ");
            lenght = int.Parse(Console.ReadLine());

            int i, j, k;
            for (i = 1; i <= lenght; i++)
            {
                for (j = 1; j <= i - lenght; j++)
                {
                    //Console.WriteLine("*");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
