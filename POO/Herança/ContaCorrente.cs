using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public class Conta
    {
        public int Agencia { get; set; }

        public int NumeroConta { get; set; }

        public double Saldo { get; set; }

        public string Banco { get; set; }

        public TipoConta TipoConta { get; set; }

    }

    public class ContaCorrente : Conta
    {

        public int CodigoBanco { get; set; }
    }

    public class ContaPoupanca : Conta
    {

        public DateTime DePoupar { get; set; } 
    }

    public class ContaInvestimento : Conta
    {
        public string TipoInvestidor { get; set; }

        public string TipoInvestimento { get; set; }

    }

    public enum TipoConta
    {
        ContaCorrente = 1,
        ContaPoupanca = 2,
        ContaInvestimento = 3
    }
}
