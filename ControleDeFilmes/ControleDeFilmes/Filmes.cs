using System;
using System.Collections.Generic;
using System.Globalization;

namespace ControleDeFilmes
{
    class Filmes
    {
        public string Nome;
        public string DataLancament;
        public string Direcao;
        public double Orcamento;
        public string Avaliacao;


        List<Filmes> listaFilmes = new List<Filmes>();

        public void AdicionarFilme()
        {

            int op;
            Filmes addfilme = new Filmes();

            Console.WriteLine("=====Adicionar Filme=====");
            Console.WriteLine("1 - Cães de Aluguel");
            Console.WriteLine("2 - A Noviça Rebelde");
            Console.WriteLine("3 - A Forma da Água");
            Console.WriteLine("4 - Vingadores: Guerra Infinita");
            Console.WriteLine("5 - Forrest Gump: O Contador de Histórias");
            Console.WriteLine("6 - Que Horas Ela Volta?");
            Console.WriteLine("7 - Star Wars: O Despertar da Força");
            Console.WriteLine("8 - O Sexto Sentido");
            Console.WriteLine("9 - Intocáveis");
            Console.WriteLine("10 - Curtindo a Vida Adoidado");
            Console.WriteLine("11 - Procurando Nemo");
            Console.WriteLine("12 - O Silêncio dos Inocentes");




            Console.WriteLine("Digite o número do filme que deseja adicionar a sua lista:");
            op = Convert.ToInt16(Console.ReadLine());


            switch (op)
            {
                case 1:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Cães de Aluguel");
                    addfilme.DataLancament = ("4 de junho de 1993");
                    addfilme.Orcamento = 1200000;
                    addfilme.Direcao = ("Quentin Tarantino");
                    addfilme.Avaliacao = ("4,4");
                    listaFilmes.Add(addfilme);

                    break;
                case 2:
                    addfilme = new Filmes();
                    addfilme.Nome = ("A Noviça Rebelde");
                    addfilme.DataLancament = ("3 de maio de 1965");
                    addfilme.Orcamento = 8200000;
                    addfilme.Direcao = ("Robert Wise");
                    addfilme.Avaliacao = ("4,5");
                    listaFilmes.Add(addfilme);


                    break;
                case 3:
                    addfilme = new Filmes();
                    addfilme.Nome = ("A Forma da Água");
                    addfilme.DataLancament = ("1 de fevereiro de 2018");
                    addfilme.Orcamento = 20000000;
                    addfilme.Direcao = ("Guillermo del Toro");
                    addfilme.Avaliacao = ("4,1");
                    listaFilmes.Add(addfilme);

                    break;
                case 4:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Vingadores: Guerra Infinita");
                    addfilme.DataLancament = ("26 de abril de 2018");
                    addfilme.Orcamento = 2048000000;
                    addfilme.Direcao = ("Anthony Russo, Joe Russo");
                    addfilme.Avaliacao = ("4,7");
                    listaFilmes.Add(addfilme);

                    break;
                case 5:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Forrest Gump: O Contador de Histórias");
                    addfilme.DataLancament = ("7 de dezembro de 1994");
                    addfilme.Orcamento = 55000000;
                    addfilme.Direcao = ("Robert Zemeckis");
                    addfilme.Avaliacao = ("4,7");
                    listaFilmes.Add(addfilme);

                    break;
                case 6:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Que Horas Ela Volta?");
                    addfilme.DataLancament = ("27 de Agosto de 2015");
                    addfilme.Orcamento = 1060000;
                    addfilme.Direcao = ("Anna Muylaert");
                    addfilme.Avaliacao = ("4,4");
                    listaFilmes.Add(addfilme);

                    break;
                case 7:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Star Wars: O Despertar da Força");
                    addfilme.DataLancament = ("17 de dezembro de 2015");
                    addfilme.Orcamento = 2066000000;
                    addfilme.Direcao = ("J. J. Abrams");
                    addfilme.Avaliacao = ("4,6");
                    listaFilmes.Add(addfilme);

                    break;
                case 8:
                    addfilme = new Filmes();
                    addfilme.Nome = ("O Sexto Sentido");
                    addfilme.DataLancament = ("22 de outubro de 1999");
                    addfilme.Orcamento = 672800000;
                    addfilme.Direcao = ("M. Night Shyamalan");
                    addfilme.Avaliacao = ("4,6");
                    listaFilmes.Add(addfilme);

                    break;
                case 9:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Intocáveis");
                    addfilme.DataLancament = ("31 de agosto de 2012");
                    addfilme.Orcamento = 25000000;
                    addfilme.Direcao = ("Olivier Nakache, Éric Toledano");
                    addfilme.Avaliacao = ("4,7");
                    listaFilmes.Add(addfilme);

                    break;
                case 10:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Curtindo a Vida Adoidado");
                    addfilme.DataLancament = ("19 de dezembro de 1986");
                    addfilme.Orcamento = 70100000;
                    addfilme.Direcao = ("John Hughes");
                    addfilme.Avaliacao = ("4,5");
                    listaFilmes.Add(addfilme);

                    break;
                case 11:
                    addfilme = new Filmes();
                    addfilme.Nome = ("Procurando Nemo");
                    addfilme.DataLancament = ("4 de julho de 2003");
                    addfilme.Orcamento = 940300000;
                    addfilme.Direcao = ("Andrew Stanton, Lee Unkrich");
                    addfilme.Avaliacao = ("4,6");
                    listaFilmes.Add(addfilme);

                    break;
                case 12:
                    addfilme = new Filmes();
                    addfilme.Nome = ("O Silêncio dos Inocentes");
                    addfilme.DataLancament = ("17 de maio de 1991");
                    addfilme.Orcamento = 19000000;
                    addfilme.Direcao = ("Jonathan Demme");
                    addfilme.Avaliacao = ("4,6");
                    listaFilmes.Add(addfilme);

                    break;

                default:
                    Console.WriteLine("Opção invalida...");
                    Console.WriteLine("Aperte alguma tecla para voltar...");
                    Console.ReadKey();
                    break;
            }

        }

        
        public void ListarFilmes()
        {
            if(listaFilmes.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
            }

            for (int x = 0; x < listaFilmes.Count; x++)
            {
                Console.WriteLine("Nome: {0}", listaFilmes[x].Nome);
                Console.WriteLine("Data: {0}", listaFilmes[x].DataLancament);
                Console.WriteLine("Direcao: {0}", listaFilmes[x].Direcao);
                Console.WriteLine("Orcamento: ${0}", listaFilmes[x].Orcamento.ToString("F2"));
                Console.WriteLine("Nota: {0}", listaFilmes[x].Avaliacao);



                Console.WriteLine("________________________________________\n");
            }

            Console.WriteLine("Aperte alguma tecla para voltar...");
            Console.ReadKey();
        }
    }

}
