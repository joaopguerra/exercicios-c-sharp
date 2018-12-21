using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_Salarios {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("EMPRESA XXXXX");
            Console.WriteLine("--------------");

            Console.WriteLine("CADASTRO DE FUNCIONÁRIOS");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.Write("Quantos funcionários quer cadastrar: ");
            int qte = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= qte; i++)
            {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("Matrícula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: R$");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                lista.Add(new Funcionario(matricula, nome, salario));
            }

            Console.Write("Deseja aumentar algum salário? [S/N]: ");
            string resp = Console.ReadLine();
            Console.WriteLine();

            if (resp == "s" || resp == "S")
            {
                Console.Write("Digite a matrícula de quem deseja aumentar o salário: ");
                int mat_aumento = int.Parse(Console.ReadLine());

                Funcionario aumento = lista.Find(x => x.Matricula == mat_aumento);
                if (aumento != null)
                {
                    Console.Write("Qual a porcentagem do aumento: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    aumento.Aumento(porcentagem);
                }

                else
                {
                    Console.WriteLine("Funcionário não existe! ");
                }
            }

            if (resp == "n" || resp == "N")
            {
                Console.WriteLine();
                Console.WriteLine("Quadro de funcionários:");
                foreach (Funcionario obj in lista)
                {
                    Console.WriteLine(obj);
                }
            }

        }
    }
}
