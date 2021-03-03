using System;

namespace Exercicio_3
{
    class Exercicio_3
    {
        static void Main(string[] args)
        {
            int variavel_inteira = 10;
            float variavel_float;
            // typecast implícito
            variavel_float = variavel_inteira;
            System.Console.WriteLine(variavel_float);
            // type explicíto
            variavel_float = 5.5f;
            variavel_inteira = (int)variavel_float;
            System.Console.WriteLine(variavel_inteira);
            // classe convert
            int var_inteira = 15;
            float  var_float = System.Convert.ToInt32(var_inteira);
            System.Console.WriteLine(var_float);

            var_float = 23.15f;
            var_inteira = System.Convert.ToInt32(var_float);
            System.Console.WriteLine(var_inteira);

            



        }
    }
}
