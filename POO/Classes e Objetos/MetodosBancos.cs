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
        
    }
}
