using System;
using System.Collections.Generic;
using System.Text;

namespace API_Juntos.Core.Entidades
{
    public class Pedido
    {
        public Pedido(DateTime dataPedido, int idCliente, List<ProdutosDoPedido> produtosDoPedido)
        {
            DataPedido = dataPedido;            
            IdCliente = idCliente;
            ProdutosDoPedido = produtosDoPedido;
        }

        protected Pedido() { }

        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<ProdutosDoPedido> ProdutosDoPedido { get; set; }

        
        
    }
}
