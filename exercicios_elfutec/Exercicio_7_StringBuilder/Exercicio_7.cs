using System;
using System.Text;

namespace Exercicio_7
{
    class Exercicio_7
    {
        static void Main(string[] args)
        {
           // crie um objeto do tipo StringBuilder e com a entrada do usuario crie uma quebra de linha 5 vezes

           	StringBuilder sb = new StringBuilder();
            Console.WriteLine("Palavra1");
            sb.Append(Console.ReadLine());
            sb.AppendLine();
            Console.WriteLine("Palavra2");
            sb.Append(Console.ReadLine());
            sb.AppendLine();
            Console.WriteLine("Palavra3");
            sb.Append(Console.ReadLine());
            sb.AppendLine();
            Console.WriteLine("Palavra4");
            sb.Append(Console.ReadLine());
            sb.AppendLine();
            Console.WriteLine("Palavra5");
            sb.Append(Console.ReadLine());
            sb.AppendLine();
                      
            // Adicionar uma linha com o texto "fim de leitura"
            sb.Append("Fim de Leitura");


            // imprimir todo o conteudo
             Console.WriteLine(sb.ToString());

            // limpar o conteúdo do objeto
            sb.Clear();

            // Adicionar uma linha com o texto "novo conteúdo", e imprimir de novo
            sb.Append("Novo Conteudo");
            Console.WriteLine(sb.ToString());
        }
    }
}
