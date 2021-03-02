using System;

namespace Exercicio_2
{
    class Exercicio_2
    {
        static void Main(string[] args)
        {
            int variavel_numerica;
            float variavel_numerica_float = 2.5f;
            const float pi = 3.14f;

            string um = "Jéssica Bohn";
            string dois = "André Darcie";
            string tres = "Medsytem, Soitic";

            variavel_numerica = 5;
            Console.WriteLine(variavel_numerica);
            Console.WriteLine("Valor de Pi:" + pi);

            Console.WriteLine("1- " + um + " e " + dois + " são colegas de trabalho e trabalham na " + tres);
            Console.WriteLine("2- " + um + " é uma desenvolvedora C# na " + tres);
            Console.WriteLine("3- " + dois + " é o coordenador da equipe cloud na " + tres);
            Console.WriteLine("4- " + dois + " é mais velho de empresa na " + tres + " do que " + um);
            Console.WriteLine("5- " +"Foi na " + tres + " que " + dois + " conheceu " + um );
            Console.WriteLine("6- " + dois + " e " + um + " trabalham na mesma equipe");



        }
    }
}
