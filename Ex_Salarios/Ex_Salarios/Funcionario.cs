using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_Salarios {
    class Funcionario {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int matricula, string nome, double salario) {
            Matricula = matricula;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento (double porcentagem) {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString() {
            return Matricula + ", " + Nome + ", R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
