using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = Menu();
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            while (escolha.ToUpper() != "X")
            {
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor deve ser decimal!");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.nome))//Se o nome for nulo ou vazio...
                            {
                                Console.WriteLine($"ALUNOS:{a.nome} - NOTA:{ a.nota}");
                            }
                        }
                        break;
                    case "3":
                        decimal media = 0;
                        decimal soma = 0;
                        var numAlunos = 0;

                        for (var i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].nome))
                            {
                                soma += alunos[i].nota;
                                numAlunos++;
                            }
                        }

                        Conceito conceitoGeral;

                        media = soma / numAlunos;
                        if (media < 3)
                        {
                            conceitoGeral = Conceito.E;
                            break;
                        }
                        else if (media < 4 && media > 3)
                        {
                            conceitoGeral = Conceito.D;
                            break;
                        }
                        else if (media < 6 && media > 4)
                        {
                            conceitoGeral = Conceito.C;
                            break;
                        }
                        else if (media < 8 && media > 6)
                        {
                            conceitoGeral = Conceito.B;
                            break;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                            break;
                        }
                        Console.WriteLine($"MÉDIA: {media} - CONCEITO: {conceitoGeral}");
                    default:
                        throw new ArgumentOutOfRangeException(); //A opção escolhia está fora dos tópicos informados.
                }
                escolha = Menu();
            }
        }

        private static string Menu()
        {
            Console.WriteLine();
            Console.WriteLine("INFORME A OPÇÃO DESEJADA:");
            Console.WriteLine("1 - Inserir aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string escolha = Console.ReadLine();
            return escolha;
        }
    }

}
