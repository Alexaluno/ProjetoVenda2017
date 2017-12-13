
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.Entidades.Clientes.Repositorio;
using Util.Entidades.Clientes;
using Util.Entidades.Produtos.Repositorio;
using Util.Entidades.Produtos;
using Util.Entidades.Usuarios;
using Util.Entidades.Usuarios.Repositorio;
using Util.Entidades.Vendas.Repositorio;
using Util.Entidades.Vendas;

namespace Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var cliente = new Cliente();
                ClienteRepositorio.Clientes.Add(cliente);

            } while (true);


            do
            {
                var produto = new Produto();
                ProdutoRepositorio.Produtos.Add(produto);

            } while (true);

            do
            {
                var usuario = new Usuario();
                UsuarioRepositorio.Usuarios.Add(usuario);

            } while (true);


            do
            {
                var venda = new Venda();
                VendaRepositorio.Vendas.Add(venda);

            } while (true);
          
            
        }
    }
}
