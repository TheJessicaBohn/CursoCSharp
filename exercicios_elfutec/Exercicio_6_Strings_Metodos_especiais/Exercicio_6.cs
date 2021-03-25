using System;

namespace Exercicio_6
{
    class Exercicio_6
    {
        static void Main(string[] args)
        {
            // fazendo uma entrada ser lida e guardada numa varíavel string
            // string entrada1;
            // Console.WriteLine("Digite Algo");
            // entrada1 = Console.ReadLine();

            //  substitíndo a por e e imprimindo o resultado
            // Console.WriteLine(entrada1.Replace("a", "e"));

            // imprimindo o valor do 5º ao 8º caractere
            // string entrada2;
            // Console.WriteLine("Digite Algo novamente");
            // entrada2 = Console.ReadLine();
            // Console.WriteLine(entrada2.Substring(4, 4));
            
            // imprimir o resultado em maiúsculo e minusculo
            // string entrada3;
            // Console.WriteLine("Digite Algo em maiusculo e minusculo");
            // entrada3 = Console.ReadLine();
          
            // Console.WriteLine(entrada3.ToUpper());
            // Console.WriteLine(entrada3.ToLower());

            // //primeira letra maiúscula e resto em minusculo
            // Console.WriteLine(char.ToUpper(entrada3[0]) + entrada3.Substring(1));

            // // com 5 espaços em branco adicionados como prefixo , o resultado:
            // Console.WriteLine(entrada3.PadLeft(10));
            
            // // tirando os espaços em branco do inicio e do final
            // Console.WriteLine(entrada3.Trim());

            // mostrando se começa ou termina
            string entrada4, entrada5;
            Console.WriteLine("primeiro");
            entrada4 = Console.ReadLine();
            Console.WriteLine("segundo");
            entrada5 = Console.ReadLine();

            Console.WriteLine(entrada4.StartsWith(entrada4));
			Console.WriteLine(entrada4.StartsWith(entrada5));
            Console.WriteLine(entrada4.EndsWith(entrada4));
			Console.WriteLine(entrada4.EndsWith(entrada5, true, null));

        }
    }
}
