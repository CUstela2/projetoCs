using System;
using System.Collections.Generic;

namespace _02._06
{
    static public class Menu
    {
        static public void Apresentar()
        {
            int opcao = 1;
            Aluno aluno = new Aluno();
            Inicializar inicializar = new Inicializar();
            inicializar.CriarTabelaSeNaoExistir();
            inicializar.AdicionarAlunosIniciais(); 
            do
            {
                Console.WriteLine("Iniciando");
                Console.WriteLine("1 - Adicionar Aluno");
                Console.WriteLine("2 - Listar Aluno");
                Console.WriteLine("3 - Atualizar Aluno");
                Console.WriteLine("4 - Remover Aluno");
                Console.WriteLine("5 - Buscar Aluno por Id");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        aluno.AdicionarAluno();
                        break;
                    case 2:
                        aluno.ListarAlunos();
                        break;
                    case 3:
                        aluno.AtualizarAluno();
                        break;
                    case 4:
                        aluno.RemoverAluno();
                        break;
                    case 5:
                        aluno.BuscarAluno();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opcao != 0);
        }
    }
}
