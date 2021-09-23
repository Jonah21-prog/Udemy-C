using System;

namespace PrimerioProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo !");

            bool completo = false;
            char genero = 'F';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 1234645123;
            long n4 = 123123123889;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            //operadores de atribuição:
            int a = 10;
            int b = 10;
            int c = 10;
            int d = 10;
            int e = 10;

            a += 2;
            Console.WriteLine(a);

            b -= 2;
            Console.WriteLine(b);

            c *= 2;
            Console.WriteLine(c);

            d /= 2;
            Console.WriteLine(d);

            e %= 3;
            Console.WriteLine(e);
        }
    }
}
