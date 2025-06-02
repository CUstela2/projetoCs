using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace _02._06
{
    public class Aluno
    {
        public void AdicionarAluno()
        {
            Console.WriteLine("Digite o nome do aluno a ser adicionado: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o curso do aluno: ");
            string curso = Console.ReadLine();

            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"
                    INSERT INTO Alunos (Nome, Idade, Curso)
                    VALUES (@nome, @idade, @curso);
                ";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@idade", idade);
                comando.Parameters.AddWithValue("@curso", curso);
                comando.ExecuteNonQuery();
            }

            Console.WriteLine("Aluno adicionado com sucesso!");
        }

        public void ListarAlunos()
        {
            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = "SELECT * FROM Alunos";
                using (var leitor = comando.ExecuteReader())
                {
                    Console.WriteLine("Lista de Alunos:");
                    while (leitor.Read())
                    {
                        int id = leitor.GetInt32(0);
                        string nome = leitor.GetString(1);
                        int idade = leitor.GetInt32(2);
                        string curso = leitor.GetString(3);

                        Console.WriteLine($" Nome: {nome}, Idade: {idade}, Curso: {curso}, ID: {id}");
                    }
                }
            }
        }

        public void RemoverAluno()
        {
            Console.WriteLine("Digite o ID do aluno a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = "DELETE FROM Alunos WHERE Id = @id";
                comando.Parameters.AddWithValue("@id", id);
                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    Console.WriteLine("Aluno removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
        }

        public void AtualizarAluno()
        {
            Console.WriteLine("Digite o ID do aluno que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o novo nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a nova idade do aluno: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo curso do aluno: ");
            string curso = Console.ReadLine();

            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"
                    UPDATE Alunos
                    SET Nome = @nome, Idade = @idade, Curso = @curso
                    WHERE Id = @id
                ";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@idade", idade);
                comando.Parameters.AddWithValue("@curso", curso);
                comando.Parameters.AddWithValue("@id", id);
                int resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    Console.WriteLine("Aluno atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado.");
                }
            }
        }

        public void BuscarAluno()
        {
            Console.WriteLine("Digite o ID do aluno que deseja buscar: ");
            int id = int.Parse(Console.ReadLine());

            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = "SELECT * FROM Alunos WHERE Id = @id";
                comando.Parameters.AddWithValue("@id", id);
                using (var leitor = comando.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        string nome = leitor.GetString(1);
                        int idade = leitor.GetInt32(2);
                        string curso = leitor.GetString(3);

                        Console.WriteLine("Aluno encontrado:");
                        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Curso: {curso}");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado.");
                    }
                }
            }
        }
    }
}
