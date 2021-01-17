using System;
using System.Collections.Generic;
using System.Text;
using POO.Classes_e_Objetos;
using static POO.Classes_e_Objetos.ClassesObjetos;

namespace POO.Classes_e_Objetos
{
    public class MetodosBancos
    {
        //Para criar o método precisaria ser público para mostrar na tela de program.
        public void CadastrarCliente()
        {
            //Antes de mostrar as infor
            //Antes precisava criar uma linha em branco para pular a linha, após a opção escolhida
            Console.WriteLine();
            //Criando um título para a tela
            Console.WriteLine("****Cadastro de Clientes****");
            //Criando uma linha em branco para pular uma linha para digitar os nomes do cliente
            Console.WriteLine();
            //Insira o nome do cliente
            Console.WriteLine("Insira o seu nome: ");
            //Após o usuário digitar o nome a variável declarada acima nome do cliente, irá receber o que foi escrito na linha e efetuar a leitura.
            var nomeDoCliente = Console.ReadLine();
            //Insira o número da agência
            Console.WriteLine("Insira o seu documento: ");
            //Lendo o nome da agencia
            var documento = Console.ReadLine();
            //Insira o número do celular
            Console.WriteLine("Insira o número do celular: ");
            //Lendo o número do celular
            var celular = Console.ReadLine();
            //Insira a sua idade
            Console.WriteLine("Insira a sua idade: ");
            //Lendo a idade
            var idade = Console.ReadLine();
            //Console.ReadKey - Testes
            Console.ReadKey();

            //Depois irá acrescentar o método Cliente que irá receber a informação escrita pelo Console.ReadLine
            ClienteBanco clienteBanco = new ClienteBanco
            {
                NomeDoCliente = nomeDoCliente,
                Documento = documento,
                Celular = celular,
                Idade = Convert.ToInt32(idade)
            };

            Console.WriteLine();
            Console.WriteLine("****Informações do cliente****");
            //Mostrando as informações
            Console.WriteLine($"Nome do cliente: {nomeDoCliente}" + "\n" +
                $"Documento: {documento}" + "\n" +
                $"Celular: {celular}" + "\n" +
                $"Idade: {idade}");
            Console.WriteLine();
            //Após isso o cadastro foi efetuado com sucesso
            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.ReadKey();
        }

        //Método para puxar o usuário digitar o nome do cliente e mostrar as informações para efetuar as operações bancárias
        public void ExecutarOperacoesBancarias()
        {
            //Linha em branco
            Console.WriteLine();
            //Titulo do banco
            Console.WriteLine("****Operações Bancárias****");
            Console.WriteLine();
            //Digite o nome do cliente
            Console.WriteLine("Insira o nome do cliente: ");
            //Declarado a variável nomeCliente que irá receber o nome e fazer a leitura da linha
            var nomeDoCliente = Console.ReadLine();
            //Insira um valor para depositar
            Console.WriteLine("Insira o valor: ");
            //Após ter inserido o valor, a linha será lido e em seguido convertido.
            var valor = Console.ReadLine();
            //Após feito isso, o mesmo será convertido para double.
            var valorConvertido = Convert.ToDouble(valor);

            //Instanciando o método Conta Poupança
            var contaPoupanca = new ContaPoupanca()
            {
                //Acrescetando os valores desta classe
                NomeTitular = "Milton",
                Agencia = 0822,
                Conta = 107322,
                Saldo = 1200
            };

            //Chama o método Depositar (com o valorConvertido
            contaPoupanca.Depositar(valorConvertido);

            //Chama o método para Sacar
            //contaPoupanca.Sacar(valorConvertido);

            //Quando é chamado o método Sacar

            //Informações após feito o depósito
            Console.WriteLine();
            Console.WriteLine($"O {contaPoupanca.NomeTitular} " + $"da agencia: {contaPoupanca.Agencia}" + "-" + $"{contaPoupanca.Conta}" + "\n" +
                $"fez um depósito e está com o saldo de: {Convert.ToDouble(contaPoupanca.Saldo)} " + "reais");

            //Achei necessário colocar antes ReadKey()
            Console.ReadKey();
        }
    }

    //Nova classe para fazer as outras operações da conta
    public class ContaPoupanca
    {
        //Declaramos as variáveis
        public string NomeTitular;
        public int Agencia;
        public int Conta;
        public double Saldo;

        //Valor Double para sacar
        public double Depositar(double valorDeposito)
        {
            //Saldo += valor do deposito
            Saldo += valorDeposito;
            //Retorna o saldo
            return Saldo;
        }

        //Sacar
        public double Sacar(double valorSaque)
        {
            //Se valorSaque for maior que o Saldo aparecerá a mensagem que não dá para sacar.
            if(valorSaque > Saldo)
            {
                Console.WriteLine($"Não foi possível realizar o saque, pois o seu saldo é de: {Saldo}!");
            }
            else
            {
                //Primeiro vamos subtrair os valores
                Saldo -= valorSaque;

                Console.WriteLine();
    
                Console.WriteLine($"O {NomeTitular} " + $"da agencia: {Agencia}" + "-" + $"{Conta}" + "\n" +
                    $"fez um saque e está com o saldo de: {Saldo} " + "reais");
            }
            //Retorna o saldo
            return Saldo;
        }
    }

}
