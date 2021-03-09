using System;

namespace Exercicio_4
{
    class Exercicio_4
    {
        static void Main(string[] args)
        {   
            //Utilizando metodos IsNullOrWhiteSpace e IsNullOrEmpty
            string entrada;
            Console.WriteLine("Escreva algo ou nada:");
            entrada = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(entrada) ||  String.IsNullOrEmpty(entrada) ){
                Console.WriteLine("Nulo ou espaços em branco ou vazio");
            }
            else
            {
                Console.WriteLine(entrada);
            }

            // imprimindo decimo caractere
            for( int i = entrada.Length; i >=0 ; i++){
                Console.WriteLine(entrada[9]);
                break;
            }
            
        }
    }
}
