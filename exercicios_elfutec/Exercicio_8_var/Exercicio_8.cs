using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos implicitos com var

            //Tipo integer
            var inteiro = 1;
            Console.WriteLine(inteiro);

            //Tipo string;
            var texto = "tipo string";
            Console.WriteLine(texto);

            //coleção de string
            var dados= new[] {nome, idade, cidade};
            Console.WriteLine(colecaos);

            //for

            for (var indice = 0; indice <= 3; indice++)
            Console.WriteLine(String.Format("Indice 'indice' :{0}", indice.GetType().ToString()));

            //foreach
            foreach(var dado in dados)
            Console.WriteLine(String.Format(" Tipo de 'dado' :{0}", dado.GetType().ToString()));

            //consulta de LINQ

        }
    }
}
