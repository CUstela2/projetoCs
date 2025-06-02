using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02._06
{
    public class Funcionario
    {
        public double Salario { get; set; }
        public string Nome { get; set; }
        public double Imposto { get; set; }
        public double SalarioLiquido()
        {
            return Salario - Imposto;

        }
        public void AumentarSalario(double por100)
        {
            Salario += Salario * por100 / 100;
        }
        public override string ToString()
        {
            return $"nome: {Nome}, salario: {Salario:F2}, imposto: {Imposto:F2}, salario liquido: {SalarioLiquido():F2}";
        }
        public  string Atualizados()
        {
            return $"nome: {Nome}, salario Liquido: {SalarioLiquido():F2}";
        }
    }
}