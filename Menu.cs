using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02._06
{
    static public class Menu
    {
        static public void Apresentar()
        {
            // Retangulo retangulo = new Retangulo();
            // Console.WriteLine("Digite a altura");
            // retangulo.Altura = double.Parse(Console.ReadLine());
            // Console.WriteLine("Digite a largura");
            // retangulo.Largura = double.Parse(Console.ReadLine());
            // Console.WriteLine(retangulo.Area().ToString("F2"));
            // Console.WriteLine(retangulo.Perimetro().ToString("F2"));
            // Console.WriteLine(retangulo.Diagonal().ToString("F2"));

            // Funcionario funcionario = new Funcionario();
            // Console.WriteLine("digite o nome do funcionario");
            // funcionario.Nome = Console.ReadLine();
            // Console.WriteLine("digite o salario do funcionario");
            // funcionario.Salario = double.Parse(Console.ReadLine());
            // Console.WriteLine("digite o valor do imposto");
            // funcionario.Imposto = double.Parse(Console.ReadLine());
            // Console.WriteLine("dados do funcionario: " + funcionario.ToString());
            // Console.WriteLine("digite a porcentagem para aumento de salario");
            // double porcentagem = double.Parse(Console.ReadLine());
            // funcionario.AumentarSalario(porcentagem);

            // Console.WriteLine("dados atualizados: " + funcionario.Atualizados());
            int opcao = 1;

            Aluno aluno = new Aluno();

            var alunos = new Dados { Nome = "Viniciu", Idade = 17, Curso = "DevSistemas" };
            var alunos2 = new Dados { Nome = "Leonardo", Idade = 18, Curso = "DevSistemas" };
            var alunos3 = new Dados { Nome = "Sara", Idade = 18, Curso = "DevSistemas" };

            var dados = new List<Dados> { alunos, alunos2, alunos3 };

            aluno.Dados.AddRange(dados);

            // while (opcao != 0)
            do
            {


                Console.WriteLine("Iniciando");

                Console.WriteLine("1 - Adicionar Aluno");
                Console.WriteLine("2 - Listar Aluno");
                Console.WriteLine("3 - Atualizar Aluno");
                Console.WriteLine("4 - Remover Aluno");
                Console.WriteLine("5 - Buscar Aluno por id");
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
                        Console.WriteLine("saindo...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;
                }
                Console.WriteLine(" ");

            } while (opcao != 0);
        }
    }
}