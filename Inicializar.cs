using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace _02._06
{
    public class Inicializar
    {
        public void AdicionarAlunosIniciais()
        {
            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = "SELECT COUNT(*) FROM Alunos";
                long count = (long)comando.ExecuteScalar();

                if (count == 0)
                {
                    comando.CommandText = @"
                INSERT INTO Alunos (Nome, Idade, Curso) VALUES
                ('Viniciu', 17, 'DevSistemas'),
                ('Leonardo', 18, 'DevSistemas'),
                ('Sara', 18, 'DevSistemas');
            ";
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void CriarTabelaSeNaoExistir()
        {
            using (var conexao = new SQLiteConnection("Data Source=banco.db"))
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Alunos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Idade INTEGER,
                        Curso TEXT
                    );
                ";
                comando.ExecuteNonQuery();
            }
        }
    }
}