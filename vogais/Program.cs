using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string vogais;
            int espaco;
            int vogal;

            Console.Write("Digite uma frase: ");
            vogais = Console.ReadLine().ToLower();

                                   
            char[] fraseInserida = vogais.ToCharArray();

            int qntvogais = 0;
            int qntespaco = 0;
            for (int i = 0; i < fraseInserida.Length; i++)
            {
                if (fraseInserida[i].ToString() == "a")
                    qntvogais++;
                if (fraseInserida[i].ToString() == "e")
                    qntvogais++;
                if (fraseInserida[i].ToString() == "i")
                    qntvogais++;
                if (fraseInserida[i].ToString() == "o")
                    qntvogais++;
                if (fraseInserida[i].ToString() == "u")
                    qntvogais++;
                if (fraseInserida[i].ToString() == " ")
                    qntespaco++;
            }

            Console.WriteLine("Quantidade vogais: " + qntvogais);
            Console.WriteLine("Quantidade espaço: " + qntespaco);

            Console.ReadLine();


        }
    }
}
