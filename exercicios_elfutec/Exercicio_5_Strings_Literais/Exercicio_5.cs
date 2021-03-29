using System;

namespace Exercicio_5
{
    class  Exercicio_5
    {
        static void Main(string[] args)
        {
            string expectativa = "Expectativa de vida do pais '2012'";
            Console.WriteLine(expectativa);

            // utilizando caracteres de escape 
            string colunas = " Pais | \t Expectativa de vida geral";
            string linhas =  " \n Japão \t\t|\t 88 \n Andorra \t|\t 84.2 \n Singapura \t|\t 84 \n Hong Kong  \t|\t 83.8 \n San Marino \t|\t 83.5 \n Islândia \t|\t 83.3 \n Itália \t|\t 83.1 \n Suécia \t|\t 83";

            Console.WriteLine(colunas);
            Console.WriteLine(linhas);

            // sem caracteres de escape, vê-se que gera erro ao compilar

            string linha_1 = "Linha 1 - \"Linha 1\"";
            string linha_2 = "Linha 1 - \"Linha 2\"";

            Console.WriteLine(linha_1);
            Console.WriteLine(linha_2);


        }
    }
}
