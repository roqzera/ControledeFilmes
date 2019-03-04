using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFilmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Filmes filme = new Filmes();
            int opp = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("=======Menu Principal========");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Adicionar Filme");
                Console.WriteLine("2 - Listar Filmes");
                Console.Write("Entre com a opção desejada: ");
                opp = Convert.ToInt16(Console.ReadLine());

                switch(opp)
                {
                    case 0:
                        Console.WriteLine("Bye...");
                        break;

                    case 1:
                        Console.Clear();

                        filme.AdicionarFilme();
                        break;

                    case 2:
                        Console.Clear();

                        filme.ListarFilmes();
                        break;

                }

            }while (opp != 0);

        }
    }
}
