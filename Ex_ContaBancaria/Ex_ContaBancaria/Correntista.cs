using System;
using System.Globalization;

namespace Ex_ContaBancaria {
    class Correntista {       
        public string Titular { get; set; }
        public int Conta { get; private set; }
        public string DepInicial;
        public double SaldoInicial { get; set; }
        public double SaldoFinal;

        public Correntista() {
        }

        public Correntista (int conta, string titular, double saldoinicial) {
            Conta = conta;
            Titular = titular;
            SaldoInicial = saldoinicial;
            SaldoFinal = saldoinicial;
        }

        public void ValorParaDeposito (double valorparadeposito) {
            SaldoFinal = SaldoInicial + valorparadeposito;
        }
        
        public void ValorParaSaque (double valorparasaque) {
            SaldoFinal = SaldoFinal - valorparasaque - 5.0;
        }

        public override string ToString() {
            return ("Conta " + Conta 
                + ", Titular: " + Titular
                + ", Saldo: $" + SaldoFinal.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
