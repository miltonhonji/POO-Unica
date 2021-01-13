namespace POO.Classes_e_Objetos
{
    public class Conta
    {
        public int Agencia { get; set; }
        public string Banco { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
