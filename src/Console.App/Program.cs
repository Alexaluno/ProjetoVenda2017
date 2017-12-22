using Util.Entidades.Clientes.Repositorio;
using Util.Entidades.Clientes;
using Util.Entidades.Produtos.Repositorio;
using Util.Entidades.Produtos;
using Util.Entidades.Usuarios;
using Util.Entidades.Usuarios.Repositorio;
using Util.Entidades.Vendas.Repositorio;
using Util.Entidades.Vendas;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static void Main()
        {
            //Codigo Usuario
            var usuario1 = new Usuario("Rodrigo", true);
            var usuario2 = new Usuario("Alex", false); 
            var usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Usuarios.Add(usuario1);
            usuarioRepositorio.Usuarios.Add(usuario2);

            var retornoUsuarioRepositorio = usuarioRepositorio.Usuarios;

            foreach (var item in retornoUsuarioRepositorio)
            {
                Console.WriteLine("Nome :" + item.Nome + " | " + "Administrador: " + item.Administrador);
            }
            Console.ReadLine();

            //limpa a tela
            Console.Clear();

            //Codigo Cliente
            var cliente1 = new Cliente("Juliana", "33333333333", "Taquara");
            var cliente2 = new Cliente("Daniela", "22222222222", "Taquara");
            var clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.Clientes.Add(cliente1);
            clienteRepositorio.Clientes.Add(cliente2);

            var retornoClienteRepositorio = clienteRepositorio.Clientes;

            foreach (var item in retornoClienteRepositorio)
            {
                Console.WriteLine("Nome: " + item.Nome + " | " + "CPF: " + item.Cpf + " | " + "Cidade: " + item.Endereco);
            }
            Console.ReadLine();

            //limpa a tela
            Console.Clear();

            //Codigo Produto
            var produto1 = new Produto("Cerveja", Convert.ToDecimal(2.49));
            var produto2 = new Produto("Refri", Convert.ToDecimal(1.19));
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Produtos.Add(produto1);
            produtoRepositorio.Produtos.Add(produto2);

            var retornoProdutoRepositorio = produtoRepositorio.Produtos;

            foreach (var item in retornoProdutoRepositorio)
            {
                Console.WriteLine("Produto: " + item.Descricao + " | " + "Valor: R$" + item.Valor);
            }
            Console.ReadLine();

            //Codigo Venda
            foreach (var user in retornoUsuarioRepositorio)
            {
                foreach (var client in retornoClienteRepositorio)
                {
                    var venda = new Venda("001", user, client, retornoProdutoRepositorio, 200, 20);
                    foreach (var prod in retornoProdutoRepositorio)
                    {
                        Console.WriteLine("Num.Ped: " + venda.Pedido + " | " + "Usuario: " + venda.Usuario.Nome + " | " + "Cliente: " + venda.Cliente.Nome + " | " + "Produto(s): " + prod.Descricao + " | " + "Valor Total: R$" + venda.ValorTotal + " | " + "Quantidade Total: " + venda.QuantidadeTotal);
                        Console.WriteLine();
                    }
                    
                }
            }
            Console.ReadLine();

        }
    }
}
