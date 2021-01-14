using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Classes_e_Objetos
{
    public class ClassesObjetos
    {
        //Criando uma nova classe chamada ContaBancaria
        public class ContaBancaria
        {
            //Propriedades para a conta bancaria
            //Nome do banco
            public string NomeBanco { get; set; }
            //Agência
            public string Agencia { get; set; }
            //Número da Conta
            public string NumeroConta { get; set; }
            //Saldo do cliente
            public double Saldo { get; set; }
            //Telefone
            public string Telefone { get; set; }
        }

        //Criando um método para o cliente
        public class ClienteBanco
        {
            //Propriedades para o cliente
            //Nome do cliente
            public string NomeDoCliente { get; set; }
            //Documento
            public string Documento { get; set; }
            //Telefone
            public string Celular { get; set; }
            //Idade
            public int Idade { get; set; }
        }

        //Primeiro Método para puxar as informações da Conta Bancária e do cliente
        //Retornar em void
        public void InformacoesContaBancariaCliente()
        {
            //Instanciando a classe Conta
            ContaBancaria contaBancaria = new ContaBancaria
            {
                //Preenchendo as informações da conta bancaria
                NomeBanco = "Bradesco",
                Agencia = "1105-5",
                NumeroConta = "00000-111",
                Saldo = 100.00,
                Telefone = "992354-3333"
            };

            //Instânciando a classe ClienteBanco
            ClienteBanco clienteBanco = new ClienteBanco
            {
                NomeDoCliente = "Milton",
                Documento = "45498999903",
                Celular = "995498-0000",
                Idade = 34
            };

            //Após digitar o número 0, aqui é colocado uma linha em branco
            Console.WriteLine();
            //Título informações do cliente
            Console.WriteLine("**** Informações do cliente *****");
            //Escrevendo as informações do clienteBanco
            Console.WriteLine($"O cliente: {clienteBanco.NomeDoCliente} " + $"com o documento: {clienteBanco.Documento} " + "\n" + 
                $"Com o número do celular: { clienteBanco.Celular} " + $"está com a idade de:  {clienteBanco.Idade} " + "anos.");
            //Console.ReadKey() no fim das informações do cliente.;
            Console.ReadKey();
            //Uma linha em branca para separar as informações do banco.
            Console.WriteLine();
            //Informações da contaBancaria
            Console.WriteLine($"Este cliente é do banco: {contaBancaria.NomeBanco} " + $"da agência: { contaBancaria.Agencia} {contaBancaria.NumeroConta} " + "\n" +
                $"está com o saldo: {contaBancaria.Saldo} reais.");
            Console.Write($"Em caso haja erros no deposito ligue para: {contaBancaria.Telefone}.");
            //Console.ReadKey no fim das informações da conta bancaria
            Console.ReadKey();
        }


    }
}
