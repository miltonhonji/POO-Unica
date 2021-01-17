using System;
using POO.Classes_e_Objetos;

namespace POO
{
    public class Program
    {
        static void Main()
        {
            //Aqui iremos mencionar o titulo
            Console.WriteLine("****Insira uma opção:****");
            //Insira uma opção
            Console.WriteLine();
            //Selecionando classe e objetos
            Console.WriteLine("0 - Classe e Objetos");
            //Escolhendo a opção Cadastrar Opção Cadastrar Clientes
            Console.WriteLine("1 - Metodos Bancos");
            //Escolhendo a opção Operações Bancárias
            Console.WriteLine("2 - Operações bancárias");

            //Conforme visto na aula iremos declarar a variável para usar no swicth/case
            var opcao = Console.ReadKey();

            //Aqui iremos pegar a variavél opcao.keychar (Quando houver um determinado ele irá chamar determinado método.
            switch (opcao.KeyChar)
            {
                case '0':
                    //Chamando a classe "ClassesObjetos" e o método InformacoesContaBancariaCliente utilizando o 'new'
                    new ClassesObjetos().InformacoesContaBancariaCliente();
                    break;

                case '1':
                    //Chamando o classe "MetodosBanco" e o método CadastrarCliente
                    new MetodosBancos().CadastrarCliente();
                    break;

                case '2':
                    //Chamando a classe "MetodosBancos" e o método OperacoesBancarias
                    new MetodosBancos().ExecutarOperacoesBancarias();
                    break;
            }
        }
    }
}


//Exemplo
/*Conta conta = new Conta
{
    Banco = "Banco XPTO",
    NumeroConta = 8792,
    Saldo = 100
};

Cliente cliente = new Cliente
{
    Nome = "Jéssica",
    Email = "teste@teste.com",
    Idade = 30,
    Telefone = "000000"
};

Console.WriteLine("Dados do cliente");
Console.WriteLine(".........................");
Console.WriteLine($"Nome {cliente.Nome}" + "\n");
Console.WriteLine($"Email {cliente.Email}" + "\n");
Console.WriteLine($"Idade {cliente.Idade}" + "\n");
Console.WriteLine($"Idade {cliente.Telefone}" + "\n");

Console.WriteLine("Dados da Conta");
Console.WriteLine(".........................");
Console.WriteLine($"Banco {conta.Banco}" + "\n");
Console.WriteLine($"Número da Conta {conta.NumeroConta}" + "\n");
Console.WriteLine($"Saldo {conta.Saldo}" + "\n");
Console.ReadKey();*/
