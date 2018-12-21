using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_ContaBancaria {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            string depinicial = Console.ReadLine();
            
            if (depinicial == "s" || depinicial == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Correntista a = new Correntista(conta, titular, saldoinicial);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Conta " + conta + ", Titular: " + titular 
                    + ", Saldo inicial: $ " + saldoinicial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.Write("Entre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                a.ValorParaDeposito(deposito);
                Console.WriteLine("Dados atualizados da conta: ");
                Console.WriteLine(a);
                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                a.ValorParaSaque(saque);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados da conta: ");
                Console.WriteLine(a);
                Console.WriteLine();

            }

            if (depinicial == "n" || depinicial == "N")
            {
                double saldoinicial = 0;
                Correntista a = new Correntista(conta, titular, saldoinicial);

                Console.WriteLine();
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Conta " + conta + ", Titular: " + titular
                    + ", Saldo inicial: $ " + saldoinicial.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine();
                Console.Write("Entre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                a.ValorParaDeposito(deposito);
                Console.WriteLine("Dados atualizados da conta: ");
                Console.WriteLine(a);
                Console.WriteLine();
                Console.Write("Entre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                a.ValorParaSaque(saque);
                Console.WriteLine();
                Console.WriteLine("Dados atualizados da conta: ");
                Console.WriteLine(a);
                Console.WriteLine();
            }            
        }

    }
}

