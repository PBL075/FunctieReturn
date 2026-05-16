using System;

namespace functia_test2
{
    class Program
    {
        static void Main()
        {
            double m1 = i("Mate", 8, 8);
            double m2 = i("Romana", 7, 10);
            double m3 = i("Ed.Fizica", 10, 10);

            double mediaGenerala = (m1 + m2 + m3) / 3;
            Console.WriteLine("MEDIA GENERALA ESTE: " + mediaGenerala);
            
        } 

        static double i(string lectia, double nota1, double nota2)
        {
            double media = (nota1 + nota2) / 2;
            Console.WriteLine("Lectia: " + lectia);
            Console.WriteLine("Media: " + media);
            return media;
        }
    }
}