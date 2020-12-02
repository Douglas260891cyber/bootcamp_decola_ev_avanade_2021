using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = Menu();

            while (escolha != "4")
            {
                switch (escolha)
                {
                    case "1":
                    string nome = Console.ReadLine(); 
                     
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(); //A opção escolhia está fora dos tópicos informados.
                }
            }
             Menu();
        }

        private static string Menu()
        {
            Console.WriteLine("INFORME A OPÇÃO DESEJADA:");
            Console.WriteLine("1 - Inserir aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            string escolha = Console.ReadLine();
            return escolha;
        }
    }
}
