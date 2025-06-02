using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02._06
{
  


        public class Aluno
        {
            public List<Dados> Dados { get; set; } = new List<Dados>();

            public void AdicionarAluno()
            {
                Console.WriteLine("Digite o nome do aluno a ser adicionado: ");
                var aluno = new Dados { Nome = Console.ReadLine() };
                Console.WriteLine("Digite a idade do aluno: ");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o curso do aluno: ");
                aluno.Curso = Console.ReadLine();

                Dados.Add(aluno);
                Console.WriteLine("Aluno adicionado com sucesso!");
            }

            public void ListarAlunos()
            {
                Console.WriteLine("Lista de Alunos:");
                foreach (var aluno in Dados)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}");
            }
            }

            public void RemoverAluno()
            {
                Console.WriteLine("Digite o nome do aluno a ser removido: ");
                string nome = Console.ReadLine();
                var alunoRemover = Dados.FirstOrDefault(d => d.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                if (alunoRemover != null)
                {
                    Dados.Remove(alunoRemover);
                    Console.WriteLine("Aluno removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }

            public void AtualizarAluno()
            {
                Console.WriteLine("Digite o nome do aluno que deseja editar: ");
                string nome = Console.ReadLine();
                var aluno = Dados.FirstOrDefault(d => d.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                if (aluno != null)
                {
                    Console.WriteLine("Digite o novo nome do aluno: ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite a nova idade do aluno: ");
                    aluno.Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o novo curso do aluno: ");
                    aluno.Curso = Console.ReadLine();

                    Console.WriteLine("Aluno atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }

            public void BuscarAluno()
            {
                Console.WriteLine("Digite o nome do aluno que deseja buscar: ");
                string nome = Console.ReadLine();
                var aluno = Dados.FirstOrDefault(d => d.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
                if (aluno != null)
                {
                    Console.WriteLine("Aluno encontrado.");
                    Console.WriteLine($"Nome do aluno: {aluno.Nome}, Idade: {aluno.Idade}, Curso: {aluno.Curso}");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
        }
    }

