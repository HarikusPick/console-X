using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Konsol_Yildiz_X_Cizdirme
{
    class Ucgen_Cizme
    {
        static void Main(string[] args)
        {
            int kenarUzunlugu;
            Console.WriteLine("Uzunluk : ");
            kenarUzunlugu = Convert.ToInt32(Console.ReadLine());
            int ortaNokta = kenarUzunlugu - 1;
            int taban = kenarUzunlugu * 2 - 1;

            for (int i = kenarUzunlugu; i > 0; i--)
            {

                for (int k = 0; k < taban; k++)
                {
                    if ((i + k == ortaNokta || k - i == ortaNokta))
                    {

                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }


            for (int i = 0; i < kenarUzunlugu; i++)
            {

                for (int k = 0; k < taban; k++)
                {
                    if ((i + k == ortaNokta || k - i == ortaNokta))
                    {

                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

