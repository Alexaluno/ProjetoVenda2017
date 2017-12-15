using Util.Entidades.Clientes.Repositorio;
using Util.Entidades.Clientes;
using Util.Entidades.Produtos.Repositorio;
using Util.Entidades.Produtos;
using Util.Entidades.Usuarios;
using Util.Entidades.Usuarios.Repositorio;
using Util.Entidades.Vendas.Repositorio;
using Util.Entidades.Vendas;
using System;

namespace Console.App
{
    class Program
    {
        public static void Main()
        {

         

                var cliente1 = new Cliente("Alex1", "991-795-900-20", "rua llll 1");
                var cliente2 = new Cliente("Alex2", "992-795-900-20", "rua llll 2");
                var cliente3 = new Cliente("Alex3", "993-795-900-20", "rua llll 3");
                var cliente4 = new Cliente("Alex4", "994-795-900-20", "rua llll 4");

                var clienteRepositorio = new ClienteRepositorio();
                    clienteRepositorio.Clientes.Add(cliente1);
                    clienteRepositorio.Clientes.Add(cliente2);
                    clienteRepositorio.Clientes.Add(cliente3);
                    clienteRepositorio.Clientes.Add(cliente4);


                var produto1 = new Produto("Ceva",10);
                var produto2 = new Produto("chocolate", 10);
                var produto3 = new Produto("arroz", 10);
                var produto4 = new Produto("babana", 10);

                var produtoRepositorio = new ProdutoRepositorio();
                    produtoRepositorio.Produtos.Add(produto1);
                    produtoRepositorio.Produtos.Add(produto1);
                    produtoRepositorio.Produtos.Add(produto1);
                    produtoRepositorio.Produtos.Add(produto1);

            var retorno = produtoRepositorio.Produtos;

                var usuario = new Usuario("Alex",true);
                var usuarioRepositorio = new UsuarioRepositorio();
                    usuarioRepositorio.Usuarios.Add(usuario);


       
           
                var venda = new Venda("001", usuario, cliente1, retorno, 100, 10);
                var vendasRepositorio = new VendaRepositorio();
                    vendasRepositorio.Vendas.Add(venda);

                var rertonoVenda = vendasRepositorio.Vendas;

                foreach (var item in rertonoVenda)
                {
                    System.Console.WriteLine("------------>> pedido <<--------------------");
                    System.Console.WriteLine(item.Id);
                    System.Console.WriteLine(item.Pedido);

                    System.Console.WriteLine("------------>> Usuario <<--------------------");
                    System.Console.WriteLine(item.Usuario.Id);
                    System.Console.WriteLine(item.Usuario.Nome);

                    System.Console.WriteLine("------------>> Cliente <<--------------------");
                    System.Console.WriteLine(item.Cliente.Id);
                    System.Console.WriteLine(item.Cliente.Nome);
                    System.Console.WriteLine(item.Cliente.Cpf);
                    System.Console.WriteLine(item.Cliente.Endereco);

                    System.Console.WriteLine("------------>> pRoduto <<--------------------");
                    foreach (var prod in item.Produtos)
                        {
                            System.Console.WriteLine(prod.Id);
                            System.Console.WriteLine(prod.Descricao);
                            System.Console.WriteLine(prod.Valor);
                    }
            }

            System.Console.Read();

        }
    }
}
